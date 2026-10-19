using System;
using System.Collections.Generic;
using System.Text;

namespace CicekciAPP.Model
{
    public class Kategoriler
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; } = string.Empty;
    }
}
