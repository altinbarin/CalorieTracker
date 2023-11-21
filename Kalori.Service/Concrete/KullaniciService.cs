using Kalori.Service.Abstract;
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
    public class KullaniciService:IKullaniciService
    {

        KullaniciDAL kullaniciDAL = new KullaniciDAL();

        public void Update(Kullanici kullanici)
        {
            kullaniciDAL.Update(kullanici);
        }


        public Kullanici MaileGoreKullaniciGetir(string Mail)
        {
            return kullaniciDAL.MaileGoreKullaniciGetir(Mail);
        }

        public void Create(Kullanici kullanici)
        {
            kullaniciDAL.Create(kullanici);
        }

        public List<string> KullaniciIsimleriGetir()
        {
            return kullaniciDAL.KullaniciIsimleriGetir();
        }

        public List<Kullanici> GetAllWhere(Expression<Func<Kullanici, bool>> expression)
        {
            return kullaniciDAL.GetAllWhere(expression);
        }

        public List<Kullanici> MaileGoreKullaniciListesiGetir(string text)
        {
            return kullaniciDAL.MaileGoreKullaniciListesiGetir(text);
        }
    }
}