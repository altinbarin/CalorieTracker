using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KALORI.DATA.Abstract;

namespace KALORI.DATA.Entities
{
    public class KullaniciOgun:BaseKalori
    {
        public int IslemId { get; set; }
        public string KullaniciMail { get; set; }
        public int OgunId { get; set; }
        public DateTime? Tarih { get; set; }

        public Kullanici Kullanici { get; set; }
        public Ogun Ogun { get; set; }
        public ICollection<OgunYemek> OgunYemek { get; set; }
    }
}
