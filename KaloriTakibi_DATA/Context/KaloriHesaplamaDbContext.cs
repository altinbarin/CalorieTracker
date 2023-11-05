using KALORI.DATA.Configuration;
using KALORI.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalori_DAL.Context
{
    public class KaloriHesaplamaDbContext: DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciOgun> KullaniciOgunleri { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<OgunYemek> OgunYemekleri { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PE0VBS8;Database=KaloriTakip;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new KategoriConfig());
            //modelBuilder.ApplyConfiguration(new KullaniciConfig());
            //modelBuilder.ApplyConfiguration(new KullaniciOgunConfig());
            //modelBuilder.ApplyConfiguration(new OgunConfig());
            //modelBuilder.ApplyConfiguration(new OgunYemekConfig());
            //modelBuilder.ApplyConfiguration(new YemekConfig());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KaloriHesaplamaDbContext).Assembly);
        }

    }
}
