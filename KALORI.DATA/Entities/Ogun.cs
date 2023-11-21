using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data_Access.Entities;

namespace KALORI.DATA.Entities
{
    public class Ogun : IEntity
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
