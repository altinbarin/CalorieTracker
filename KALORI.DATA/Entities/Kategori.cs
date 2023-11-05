using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KALORI.DATA.Abstract;

namespace KALORI.DATA.Entities
{
    public class Kategori:BaseKalori
    {
        public int KategoriId { get; set; }
        public string Isim { get; set; }

        public ICollection<Yemek> Yemekler { get; set; }

        public Kategori()
        {
            Yemekler = new HashSet<Yemek>();
        }
    }
}
