using KALORI.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALORI.DATA.Configuration
{
    public class OgunYemekConfig : IEntityTypeConfiguration<OgunYemek>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OgunYemek> builder)
        {
            builder.ToTable("Ogun-Yemek Tablosu");

            builder.HasKey(x => new {x.IslemId,x.YemekId});

                        
            builder.HasOne(x => x.Yemek)
                .WithMany(x => x.OgunYemekleri)
                .HasForeignKey(x => x.YemekId);
        }
    }
}
