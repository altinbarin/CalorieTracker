using Core.Data_Access.EntityFramework;
using KALORI.DATA.Entities;
using Kalori_DAL.Abstract;
using Kalori_DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kalori_DAL.ilk
{
    public class KullaniciDAL : EfEntityRepositoryBase<Kullanici, KaloriHesaplamaDbContext>, IKullaniciDAL
    {
       

        public List<Kullanici> GetAllWhere(Expression<Func<Kullanici, bool>> expression)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Set<Kullanici>().Where(expression).ToList();
            }
        }

        public List<string> KullaniciIsimleriGetir()
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Kullanicilar.Select(x => x.Mail).ToList();
            }
        }

        public Kullanici MaileGoreKullaniciGetir(string Mail)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Kullanicilar.Where(x => x.Mail == Mail).FirstOrDefault();
            }
        }

        public List<Kullanici> MaileGoreKullaniciListesiGetir(string text)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Kullanicilar.Where(x => x.Mail == text).ToList();
            }
        }

     
    }


}