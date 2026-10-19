using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CicekciAPP.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            OzetBilgileriYukle();
        }

        public void OzetBilgileriYukle()
        {
            using (var db = new AppDbContext())
            {
                var bugun = DateTime.Today;
                var sonYediGun = bugun.AddDays(-7);

                // --- 1. GRAFİK: SATIŞ TRENDİ (Line Chart) ---
                // EF Core 10'da Date özelliği SQL tarafına doğrudan çevrilebilir
                Hazirla(chartSatisTrendi, "Satislar", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line);
                var satisVerileri = db.Satislar
                    .Where(s => s.SatisTarihi >= sonYediGun)
                    .GroupBy(s => s.SatisTarihi.Date) // Modern EF Core bunu anlar
                    .Select(g => new { Tarih = g.Key, Toplam = g.Sum(s => s.ToplamTutar) })
                    .OrderBy(x => x.Tarih).ToList();

                foreach (var v in satisVerileri)
                    chartSatisTrendi.Series["Satislar"].Points.AddXY(v.Tarih.ToShortDateString(), v.Toplam);

                // --- 2. GRAFİK: KATEGORİ DAĞILIMI (Pie Chart) ---
                Hazirla(chartKategoriDagilimi, "Kategoriler", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie);
                var kategoriVerileri = db.SatisDetaylari
                    .Include(sd => sd.Urunler)
                    .ThenInclude(u => u.Kategoriler)
                    .GroupBy(sd => sd.Urunler.Kategoriler.KategoriAdi)
                    .Select(g => new { Isim = g.Key ?? "Genel", Adet = g.Sum(sd => sd.Adet) }).ToList();

                foreach (var k in kategoriVerileri)
                    chartKategoriDagilimi.Series["Kategoriler"].Points.AddXY(k.Isim, k.Adet);

                // --- 3. GRAFİK: KRİTİK STOK (Column Chart) ---
                // Dokümandaki: "5 adet altı -> kırmızı uyarı" kuralı
                Hazirla(chartKritikStok, "Stok", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column);
                var kritikUrunler = db.Urunler
                    .Where(u => u.StokAdedi < 5)
                    .Select(u => new { u.UrunAdi, u.StokAdedi }).ToList();

                foreach (var urun in kritikUrunler)
                {
                    int pIdx = chartKritikStok.Series["Stok"].Points.AddXY(urun.UrunAdi, urun.StokAdedi);
                    chartKritikStok.Series["Stok"].Points[pIdx].Color = Color.Red;
                }

                // --- 4. GRAFİK: EN ÇOK SATANLAR (Bar Chart) ---
                Hazirla(chartEnCokSatanlar, "Urunler", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar);
                var enCokSatanlar = db.SatisDetaylari
                    .GroupBy(sd => sd.Urunler.UrunAdi)
                    .Select(g => new { Urun = g.Key, Miktar = g.Sum(sd => sd.Adet) })
                    .OrderByDescending(x => x.Miktar).Take(5).ToList();

                foreach (var e in enCokSatanlar)
                    chartEnCokSatanlar.Series["Urunler"].Points.AddXY(e.Urun, e.Miktar);
            }
        }

        private void Hazirla(System.Windows.Forms.DataVisualization.Charting.Chart chart, string seriAdi, System.Windows.Forms.DataVisualization.Charting.SeriesChartType tip)
        {
            chart.Series.Clear();
            var seri = chart.Series.Add(seriAdi);
            seri.ChartType = tip;
            // Minimal görünüm
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
        }
    }
}
