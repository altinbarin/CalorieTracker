using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KALORI.DATA.Abstract;

namespace KALORI.DATA.Entities
{
    public class Ogun:BaseKalori
    {
        public int OgunId { get; set; }
        public string Isim { get; set; }

        public ICollection<KullaniciOgun> KullaniciOgunleri { get; set; }

        public Ogun()
        {
            KullaniciOgunleri = new HashSet<KullaniciOgun>();
        }
    }
}
