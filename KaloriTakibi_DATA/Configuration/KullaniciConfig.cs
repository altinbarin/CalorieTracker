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
    public class KullaniciConfig : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.Mail);
            builder.Property(x => x.Cinsiyet).IsRequired();
            builder.Property(x => x.Isim).IsRequired();
            builder.Property(x => x.Soyisim).IsRequired();
            builder.Property(x => x.Yas).IsRequired();
            builder.Property(x => x.Boy).IsRequired();
            builder.Property(x => x.Sifre).IsRequired();
            builder.Property(x => x.DogumTarihi).IsRequired();

        }
    }
}
