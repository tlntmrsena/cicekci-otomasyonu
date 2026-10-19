using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CicekciAPP.Model;
namespace CicekciAPP.Forms
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }
        private int _seciliMusteriId = 0;
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            ListeYenile();
            MusterileriGetirAsync();
        }
        public async Task<List<object>> MusterileriGetirAsync(string filtre = "")
        {
            using var db = new AppDbContext();

            var sorgu = db.Musteriler.AsNoTracking();

            // Arama kutusu doluysa filtrele
            if (!string.IsNullOrWhiteSpace(filtre))
            {
                sorgu = sorgu.Where(m => m.Ad.Contains(filtre) ||
                                         m.Soyad.Contains(filtre) ||
                                         m.Telefon.Contains(filtre));
            }

            // Tamamen senin sınıflarındaki property isimleriyle:
            var liste = await sorgu.Select(m => new
            {
                m.Id,
                m.Ad,
                m.Soyad,
                m.Telefon,

                // Satislar tablosundaki 'Musteri' nesnesi üzerinden eşleştirme
                ToplamAlisveris = db.Satislar
                                    .Where(s => s.Musteri.Id == m.Id)
                                    .Sum(s => (decimal?)s.ToplamTutar) ?? 0,

                SonAlisveris = db.Satislar
                                 .Where(s => s.Musteri.Id == m.Id)
                                 .OrderByDescending(s => s.SatisTarihi)
                                 .Select(s => s.SatisTarihi)
                                 .FirstOrDefault(),
                m.Notlar
            }).ToListAsync();

            return liste.Cast<object>().ToList();
        }
        private async void MusteriListesiniYukle()
        {
            frmMusteri manager = new frmMusteri();
            var musteriler = await manager.MusterileriGetirAsync(txtArama.Text);
            // dgvMusteriler senin DataGridView'inin adı
            dgvMusteriler.DataSource = null;
            dgvMusteriler.DataSource = musteriler;


        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            _seciliMusteriId = 0;
            FormuTemizle();
            pnlMusteriIslem.Visible = true;
            ListeYenile();
            txtAd.Focus();
        }

        private async void ListeYenile()
        {
            var manager = new frmMusteri();
            // txtArama'daki metni gönderiyoruz, böylece dinamik filtreleme yapılıyor
            var veriler = await manager.MusterileriGetirAsync(txtArama.Text);

            dgvMusteriler.DataSource = null;
            dgvMusteriler.DataSource = veriler;
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            MusteriListesiniYukle();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            pnlMusteriIslem.Visible = false;
        }
        private void FormuTemizle()
        {
            txtAd.Clear(); txtSoyad.Clear(); txtTelefon.Clear(); txtNotlar.Clear();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var musteri = new Musteriler
            {
                Id = _seciliMusteriId,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Notlar = txtNotlar.Text,
                KayitTarihi = DateTime.Now // Yeni kayıtsa şimdiki tarih, EF Core güncellemede bunu ezmeyecektir (Gerekirse kontrollü yapılabilir)
            };

            await KaydetVeyaGuncelleAsync(musteri);

            pnlMusteriIslem.Visible = false; // Paneli kapat
            ListeYenile(); // Grid'i otomatik tazele
            MessageBox.Show("İşlem başarıyla tamamlandı.","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public async Task KaydetVeyaGuncelleAsync(Musteriler musteriler)
        {
            using var db = new AppDbContext();

            if (musteriler.Id == 0)
                db.Musteriler.Add(musteriler); // Yeni kayıt
            else
                db.Musteriler.Update(musteriler); // Mevcut kayıt güncelleme

            await db.SaveChangesAsync();
        }

        public async Task SilAsync(int id)
        {
            using var db = new AppDbContext();
            var m = await db.Musteriler.FindAsync(id);
            if (m != null)
            {
                db.Musteriler.Remove(m);
                await db.SaveChangesAsync();
            }
        }

        private void dgvMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _seciliMusteriId = (int)dgvMusteriler.Rows[e.RowIndex].Cells["Id"].Value;
            txtAd.Text = dgvMusteriler.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
            txtSoyad.Text = dgvMusteriler.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
            txtTelefon.Text = dgvMusteriler.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
            txtNotlar.Text = dgvMusteriler.Rows[e.RowIndex].Cells["Notlar"].Value.ToString();

            pnlMusteriIslem.Visible = true; // Paneli bilgilerle birlikte aç
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count == 0) return;

            int id = (int)dgvMusteriler.SelectedRows[0].Cells["Id"].Value;
            var onay = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                await SilAsync(id);
                ListeYenile();
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            var musteri = new Musteriler
            {
                Id = _seciliMusteriId,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Notlar = txtNotlar.Text,
                KayitTarihi = DateTime.Now // Yeni kayıtsa şimdiki tarih, EF Core güncellemede bunu ezmeyecektir (Gerekirse kontrollü yapılabilir)
            };

            await KaydetVeyaGuncelleAsync(musteri);

            pnlMusteriIslem.Visible = false; // Paneli kapat
            ListeYenile(); // Grid'i otomatik tazele
            MessageBox.Show("Müşteri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
