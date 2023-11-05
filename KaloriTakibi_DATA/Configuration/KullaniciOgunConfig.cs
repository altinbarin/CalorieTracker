using KALORI.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALORI.DATA.Configuration
{
    public class KullaniciOgunConfig : IEntityTypeConfiguration<KullaniciOgun>
    {
        public void Configure(EntityTypeBuilder<KullaniciOgun> builder)
        {
            builder.ToTable("İslemler");

            builder.HasKey(x => x.IslemId);

            builder.HasOne(x => x.Kullanici)
                .WithMany(x => x.KullaniciOgunleri)
                .HasForeignKey(x => x.KullaniciMail);

            builder.HasOne(x => x.Ogun)
                .WithMany(x => x.KullaniciOgunleri)
                .HasForeignKey(x => x.OgunId);

            builder.HasMany(x => x.OgunYemek)
                .WithOne(x => x.KullaniciOgun);
                

        }
    }
}
