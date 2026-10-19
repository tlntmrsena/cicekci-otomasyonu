using CicekciAPP.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CicekciAPP.Forms
{
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        private int _seciliUrunId = 0;
        private void frmUrun_Load(object sender, EventArgs e)
        {
            KategoriComboboxlariniDoldur();
            UrunListesiniYukle();
        }
        public async Task UrunListesiniYukle(int? kategoriId = null, string aramaMetni = "")
        {
            using var db = new AppDbContext();
            var sorgu = db.Urunler.Include(u => u.Kategoriler).AsNoTracking();
            if (kategoriId.HasValue && kategoriId > 0)
                sorgu = sorgu.Where(u => u.Kategoriler.Id == kategoriId.Value);

            if (!string.IsNullOrWhiteSpace(aramaMetni))
                sorgu = sorgu.Where(u => u.UrunAdi.Contains(aramaMetni));

            var liste = await sorgu.Select(u => new
            {
                u.Id,
                u.UrunAdi,
                Kategori = u.Kategoriler.KategoriAdi,
                u.Fiyat,
                u.StokAdedi,
                DurumMetni = u.Durum ? "✅ Aktif" : "❌ Pasif",
                u.Durum,
                u.EklenmeTarihi
            }).ToListAsync();

            dgvUrunler.DataSource = liste;

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (Convert.ToInt32(row.Cells["StokAdedi"].Value) < 5)
                row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                row.DefaultCellStyle.ForeColor = Color.DarkRed;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var seciliKategori = await db.Kategoriler.FindAsync((int)cmbKategori.SelectedValue);
            if (_seciliUrunId == 0) // Yeni Ürün
            {
                var yeniUrun = new Urunler
                {
                    UrunAdi = txtUrunAdi.Text,
                    Fiyat = numFiyat.Value,
                    StokAdedi = (int)numStok.Value,
                    Kategoriler = await db.Kategoriler.FindAsync((int)cmbKategori.SelectedValue),
                    Aciklama = txtAciklama.Text,
                    Durum = chkDurum.Checked,
                    EklenmeTarihi = DateTime.Now
                };
                db.Urunler.Add(yeniUrun);
            }
            else // Güncelleme
            {
                var guncelUrun = await db.Urunler.FindAsync(_seciliUrunId);
                if (guncelUrun != null)
                {
                    guncelUrun.UrunAdi = txtUrunAdi.Text;
                    guncelUrun.Fiyat = numFiyat.Value;
                    guncelUrun.StokAdedi = (int)numStok.Value;
                    guncelUrun.Kategoriler = seciliKategori;
                    guncelUrun.Aciklama = txtAciklama.Text;
                    guncelUrun.Durum = chkDurum.Checked;
                }
            }

            await db.SaveChangesAsync();
            pnlUrunIslem.Visible = false;
            await UrunListesiniYukle();
            MessageBox.Show("Ürün başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _seciliUrunId = Convert.ToInt32(dgvUrunler.Rows[e.RowIndex].Cells["Id"].Value);
            txtUrunAdi.Text = dgvUrunler.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();
            numFiyat.Value = Convert.ToDecimal(dgvUrunler.Rows[e.RowIndex].Cells["Fiyat"].Value);
            numStok.Value = Convert.ToDecimal(dgvUrunler.Rows[e.RowIndex].Cells["StokAdedi"].Value);
            chkDurum.Checked = Convert.ToBoolean(dgvUrunler.Rows[e.RowIndex].Cells["Durum"].Value);
            pnlUrunIslem.Visible = true;

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            pnlUrunIslem.Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            pnlUrunIslem.Visible = false;
        }
        private void FormuTemizle()
        {
            txtUrunAdi.Clear(); txtAciklama.Clear(); numFiyat.Value = 0; numStok.Value = 0; chkDurum.Checked = false; cmbKategori.SelectedIndex = -1;
        }

        private async void txtArama_TextChanged(object sender, EventArgs e)
        {
            await UrunListesiniYukle(null, txtArama.Text);
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0) return;

            int id = (int)dgvUrunler.SelectedRows[0].Cells["Id"].Value;
            var onay = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                using var db = new AppDbContext();
                var urun = await db.Urunler.FindAsync(id);
                if (urun != null)
                {
                    db.Urunler.Remove(urun);
                    pnlUrunIslem.Visible = false;
                    await db.SaveChangesAsync();
                    await UrunListesiniYukle();
 
                }
            }

        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var seciliKategori = await db.Kategoriler.FindAsync((int)cmbKategori.SelectedValue);
            if (_seciliUrunId == 0) // Yeni Ürün
            {
                var yeniUrun = new Urunler
                {
                    UrunAdi = txtUrunAdi.Text,
                    Fiyat = numFiyat.Value,
                    StokAdedi = (int)numStok.Value,
                    Kategoriler = await db.Kategoriler.FindAsync((int)cmbKategori.SelectedValue),
                    Aciklama = txtAciklama.Text,
                    Durum = chkDurum.Checked,
                    EklenmeTarihi = DateTime.Now
                };
                db.Urunler.Add(yeniUrun);
            }
            else // Güncelleme
            {
                var guncelUrun = await db.Urunler.FindAsync(_seciliUrunId);
                if (guncelUrun != null)
                {
                    guncelUrun.UrunAdi = txtUrunAdi.Text;
                    guncelUrun.Fiyat = numFiyat.Value;
                    guncelUrun.StokAdedi = (int)numStok.Value;
                    guncelUrun.Kategoriler = seciliKategori;
                    guncelUrun.Aciklama = txtAciklama.Text;
                    guncelUrun.Durum = chkDurum.Checked;
                }
            }

            await db.SaveChangesAsync();
            pnlUrunIslem.Visible = false;
            await UrunListesiniYukle();
            MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private async void KategoriComboboxlariniDoldur()
        {
            using var db = new AppDbContext();
            var kategoriler = await db.Kategoriler.AsNoTracking().ToListAsync();
            var filtreListesi = kategoriler.ToList();
            filtreListesi.Insert(0, new Kategoriler { Id = 0, KategoriAdi = "Tüm Kategoriler" });
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "Id";
            cmbKategori.DataSource = kategoriler;
            cmbFiltre.DisplayMember = "KategoriAdi";
            cmbFiltre.ValueMember = "Id";
            cmbFiltre.DataSource = filtreListesi;
        }

        private async void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltre.SelectedValue == null) return;

            int seciliKategoriId = (int)cmbFiltre.SelectedValue;
            await UrunListesiniYukle(seciliKategoriId == 0 ? null : (int?)seciliKategoriId, txtArama.Text);
        }
    }
}
