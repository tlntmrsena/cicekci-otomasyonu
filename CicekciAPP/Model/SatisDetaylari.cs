using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CicekciAPP.Model
{
    public class SatisDetaylari
    {
        public int Id { get; set; }
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamFiyat { get; set; }


        [ForeignKey("UrunId")]
        public virtual Urunler Urunler { get; set; }
        [ForeignKey("SatisId")]
        public virtual Satislar Satislar { get; set; }
    }
}
