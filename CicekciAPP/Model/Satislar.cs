using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CicekciAPP.Model
{
    public class Satislar
    {
        public int Id { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime SatisTarihi { get; set; } = DateTime.Now;
        public string Aciklama { get; set; } = string.Empty;
        public Musteriler Musteri { get; set; }
    }
}
