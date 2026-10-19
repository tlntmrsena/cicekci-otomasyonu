using System;
using System.Collections.Generic;
using System.Text;

namespace CicekciAPP.Model
{
    public class Musteriler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Notlar { get; set; } = string.Empty;
        public DateTime KayitTarihi { get; set; } = DateTime.Now;



    }
}
