using CicekciAPP.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
namespace CicekciAPP.Forms
{
    public partial class frmSatis : Form
    {
        private List<SepetItem> _sepet = new List<SepetItem>();
        public frmSatis()
        {
            InitializeComponent();
        }
        string placeholder = "Müşteri Seçiniz...";
        private async void frmSatis_Load(object sender, EventArgs e)
        {
            await MusterileriDoldur();
            await UrunleriGetir();
            cmbMusteri.Text = placeholder;
            cmbMusteri.ForeColor = Color.Gray;
        }
        private async Task MusterileriDoldur()
        {
            using var db = new AppDbContext();
            var musteriler = await db.Musteriler
                .AsNoTracking()
                .Select(m => new
                {
                    Id = m.Id,
                    AdSoyad = m.Ad + " " + m.Soyad,
                })
                .ToListAsync();
            // Peşin müşteri kaydını ekle ve doğrudan listeyi DataSource olarak ata.
            musteriler.Insert(0, new { Id = 0, AdSoyad = "Peşin Müşteri (Kayıtsız)" });
            cmbMusteri.DataSource = musteriler;
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "Id";
        }
        private async Task UrunleriGetir(string arama = "")
        {
            using var db = new AppDbContext();
            var sorgu = db.Urunler.Where(u => u.Durum == true && u.StokAdedi > 0).AsNoTracking();
            if (!string.IsNullOrWhiteSpace(arama))
            {
                sorgu = sorgu.Where(u => u.UrunAdi.Contains(arama));
            }
            var urunler = await sorgu.Select(u => new
            {
                u.Id,
                u.UrunAdi,
                u.Fiyat,
                u.StokAdedi
            }).ToListAsync();
            dgvUrunler.DataSource = urunler;
        }
        private void cmbMusteri_Enter(object sender, EventArgs e)
        {
            if (cmbMusteri.Text == placeholder)
            {
                cmbMusteri.Text = "";
                cmbMusteri.ForeColor = Color.Black;
            }
        }

        private void cmbMusteri_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbMusteri.Text))
            {
                cmbMusteri.Text = placeholder;
                cmbMusteri.ForeColor = Color.Gray;
            }
        }
       

        private async void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            await UrunleriGetir(txtUrunAra.Text);
        }

        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dynamic secilenUrun = dgvUrunler.Rows[e.RowIndex].DataBoundItem;
            int urunId = secilenUrun.Id;
            int stok = secilenUrun.StokAdedi;
            var sepettekiUrun = _sepet.FirstOrDefault(s => s.UrunId == urunId);
            if (sepettekiUrun != null)
            {
                if (sepettekiUrun.Adet >= stok)
                {
                    MessageBox.Show("Stokta bu üründen daha fazla yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sepettekiUrun.Adet++;
            }
            else
            {
                _sepet.Add(new SepetItem
                {
                    UrunId = urunId,
                    UrunAdi = secilenUrun.UrunAdi,
                    BirimFiyat = secilenUrun.Fiyat,
                    Adet = 1
                });
            }
            SepetArayuzunuGuncelle();
        }
        private void SepetArayuzunuGuncelle()
        {
            dgvSepet.DataSource = null;
            dgvSepet.DataSource = _sepet;
            if (dgvSepet.Columns["UrunId"] != null) dgvSepet.Columns["UrunId"].Visible = false;
            decimal toplam = _sepet.Sum(s => s.ToplamFiyat);
            lblToplamTutar.Text = $"{toplam:C2}";

        }

        private async void btnSatisiTamamla_Click(object sender, EventArgs e)
        {
            if (_sepet==null || _sepet.Count == 0)
            {
                MessageBox.Show("Sepet boş, satış yapılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var db = new AppDbContext();
            using var transaction = await db.Database.BeginTransactionAsync();

            try
            {
                int musteriId = (int)cmbMusteri.SelectedValue;

                var yeniSatis = new Satislar
                {
                   ToplamTutar=_sepet.Sum(s => s.ToplamFiyat),
                    SatisTarihi = DateTime.Now,
                    Aciklama="Uygulama üzerinden satış gerçekleşti.",
                    Musteri = musteriId == 0 ? null : await db.Musteriler.FindAsync(musteriId)
                };
                db.Satislar.Add(yeniSatis);
                await db.SaveChangesAsync();

                foreach (var item in _sepet) 
                {
                    var satilanUrun = await db.Urunler.FindAsync(item.UrunId);
                    if (satilanUrun != null)
                    {
                        satilanUrun.StokAdedi -= item.Adet;
                        if (satilanUrun.StokAdedi <= 0) satilanUrun.Durum = false;
                    }
                    var detay= new SatisDetaylari
                    {
                        SatisId= yeniSatis.Id,
                        UrunId=item.UrunId,
                        Adet=item.Adet,
                        BirimFiyat=item.BirimFiyat,
                        ToplamFiyat=item.ToplamFiyat
                    };
                    db.SatisDetaylari.Add(detay);

                    
                }

                await db.SaveChangesAsync();
                await transaction.CommitAsync();
                MessageBox.Show("Satış başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _sepet.Clear();
                SepetArayuzunuGuncelle();
                await UrunleriGetir(txtUrunAra.Text);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                string hataMesaji = "Satış işlemi sırasında bir hata oluştu:\n" + ex.Message;
                if (ex.InnerException != null)
                {
                    hataMesaji += "\n\nVERİTABANI DETAYI:\n" + ex.InnerException.Message;
                }

                MessageBox.Show(hataMesaji, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class SepetItem
        {
            public int UrunId { get; set; }
            public string UrunAdi { get; set; }
            public decimal BirimFiyat { get; set; }
            public int Adet { get; set; }
            public decimal ToplamFiyat => BirimFiyat * Adet;
        }
    }
}
