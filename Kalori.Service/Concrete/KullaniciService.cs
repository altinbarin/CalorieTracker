using KALORI.DATA.Entities;
using Kalori_DAL.ilk;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kalori.Service.Concrete
{
    public class KullaniciService
    {


        public void Update(Kullanici kullanici)
        {
            KullaniciDAL kullaniciDAL = new KullaniciDAL();
            kullaniciDAL.Update(kullanici);
        }


        public Kullanici MaileGoreKullaniciGetir(string Mail)
        {
            KullaniciDAL kullaniciDAL = new KullaniciDAL();
            return kullaniciDAL.MaileGoreKullaniciGetir(Mail);
        }

        public void Create(Kullanici kullanici)
        {
            KullaniciDAL kullaniciDAL = new KullaniciDAL();
            kullaniciDAL.Create(kullanici);
        }

        public List<string> KullaniciIsimleriGetir()
        {
            KullaniciDAL kullaniciDAL = new KullaniciDAL();
            return kullaniciDAL.KullaniciIsimleriGetir();
        }

        public List<Kullanici> GetAllWhere(Expression<Func<Kullanici, bool>> expression)
        {
            KullaniciDAL kullaniciDAL = new KullaniciDAL();
            return kullaniciDAL.GetAllWhere(expression);
        }

        public List<Kullanici> MaileGoreKullaniciListesiGetir(string text)
        {
            KullaniciDAL kullaniciDAL = new KullaniciDAL();
            return kullaniciDAL.MaileGoreKullaniciListesiGetir(text);
        }
    }
}