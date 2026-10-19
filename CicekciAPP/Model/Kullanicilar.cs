using System;
using System.Collections.Generic;
using System.Text;

namespace CicekciAPP.Model
{
    public class Kullanicilar
    {  
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; } // "Admin" veya "Kullanıcı"


    }
}
