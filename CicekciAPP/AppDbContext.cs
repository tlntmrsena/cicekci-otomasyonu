using CicekciAPP.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CicekciAPP
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<Satislar> Satislar { get; set; }
        public DbSet<SatisDetaylari> SatisDetaylari { get; set; }
        public DbSet<StokHareketleri> StokHareketleri { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=SENA\SQLEXPRESS;Database=CicekciDB;Trusted_Connection=True;TrustServerCertificate=True;");

            }

        }
    }
}
