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
    public class YemekConfig : IEntityTypeConfiguration<Yemek>
    {
        public void Configure(EntityTypeBuilder<Yemek> builder)
        {
            builder.HasKey(x => x.YemekId);

            builder.HasOne(x => x.Kategori)
                .WithMany(x => x.Yemekler)
                .HasForeignKey(x => x.KategoriId);
            
        }
    }
}
