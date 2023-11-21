using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data_Access.Entities;

namespace KALORI.DATA.Entities
{
    public class Yemek : IEntity
    {
        public int YemekId { get; set; }
        public string Isim { get; set; }
        public int Kalori { get; set; }
       
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        //public string? PhotoPath { get; set; }
        public byte[]? YemekResmi { get; set; }

        public ICollection<OgunYemek> OgunYemekleri { get; set; }

        public Yemek()
        {
            OgunYemekleri = new HashSet<OgunYemek>();
        }
    }
}
