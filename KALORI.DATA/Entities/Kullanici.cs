using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KALORI.DATA.Abstract;

namespace KALORI.DATA.Entities
{
    public class Kullanici:BaseKalori
    {
        public Kullanici()
        {
            KullaniciOgunleri = new HashSet<KullaniciOgun>();
        }

        public int Yas
        {
            get
            {
                    int yas = DateTime.Now.Year - DogumTarihi.Value.Year;
                    return yas;
            }
            set {; }
        }
        public string Mail { get; set; }
        public string Soyisim { get; set; }
        public string Isim { get; set; }
        public string Sifre { get; set; }
        
        public DateTime?  DogumTarihi { get; set; }

        public int  Boy { get; set; }
        public int  Kilo { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime? KayıtTarihi { get; set; } = DateTime.Now;
        public bool KullanıcıTipi { get; set; }=false;

        public bool? SifremiHatirla { get; set; }

        public ICollection<KullaniciOgun> KullaniciOgunleri { get; set; }

      
        

    }
}
