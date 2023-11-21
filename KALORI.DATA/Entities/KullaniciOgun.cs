using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data_Access.Entities;

namespace KALORI.DATA.Entities
{
    public class KullaniciOgun : IEntity
    {
        public int IslemId { get; set; }
        public DateTime? Tarih { get; set; }
        public string KullaniciMail { get; set; }
        public Kullanici Kullanici { get; set; }

        public int OgunId { get; set; }
        public Ogun Ogun { get; set; }
        public ICollection<OgunYemek> OgunYemek { get; set; }
    }
}
