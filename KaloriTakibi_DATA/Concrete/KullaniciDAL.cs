using KALORI.DATA.Abstract;
using KALORI.DATA.Entities;
using Kalori_DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kalori_DAL.ilk
{
    public class KullaniciDAL
    {
        public void Create(Kullanici kullanici)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Add(kullanici);
                context.SaveChanges();
            }
        }

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

        public void Update(Kullanici kullanici)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Update(kullanici);
                context.SaveChanges();
            }
        }
    }


}