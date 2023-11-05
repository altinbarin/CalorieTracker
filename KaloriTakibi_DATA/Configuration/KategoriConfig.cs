using KALORI.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALORI.DATA.Configuration
{
    public class KategoriConfig : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(x => x.KategoriId);


        }
    }
}
