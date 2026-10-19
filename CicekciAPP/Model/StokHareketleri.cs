using System;
using System.Collections.Generic;
using System.Text;

namespace CicekciAPP.Model
{
    public class StokHareketleri
    {
        public int Id { get; set; }
        public string IslemTuru { get; set; } // "Giriş" veya "Çıkış"
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public string Aciklama { get; set; } = string.Empty;
        public Urunler Urun { get; set; }
    }
}
