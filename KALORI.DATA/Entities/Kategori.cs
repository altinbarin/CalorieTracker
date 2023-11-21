using Core.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALORI.DATA.Entities
{
    public class Kategori:IEntity
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
