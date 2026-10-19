using System;
using System.Collections.Generic;
using System.Text;

namespace CicekciAPP.Model
{
    public class Urunler
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int StokAdedi { get; set; }
        public string Aciklama { get; set; } = string.Empty;
        public bool Durum { get; set; } = true;
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;


        public virtual Kategoriler Kategoriler { get; set; }
    }
}
