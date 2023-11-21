using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data_Access.Entities;

namespace KALORI.DATA.Entities
{
    public class OgunYemek : IEntity
    {
        public int IslemId { get; set; }
        public int YemekId { get; set; }
        public int Kalori { get; set; }

        public Yemek Yemek { get; set; }

        public KullaniciOgun KullaniciOgun { get; set; }
        public decimal Porsiyon { get; set; }
    }
}
