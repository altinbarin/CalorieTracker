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
    public class YemekDAL : EfEntityRepositoryBase<Yemek, KaloriHesaplamaDbContext>, IYemekDAL
    {    

        public List<Yemek> GetAllWhere(Expression<Func<Yemek, bool>> expression)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Set<Yemek>().Where(expression).ToList();
            }
        }

        public Yemek GetById(int id)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Yemekler.Where(x => x.YemekId == id).FirstOrDefault();

            }
        }

        public List<string> YemeklerIsimlerListesi()
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Yemekler.Select(x => x.Isim).ToList();
            }
        }

        public void ResimGuncelle(int yemekId, byte[] resimBytes)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                var yemek = context.Yemekler.FirstOrDefault(x => x.YemekId == yemekId);
                if (yemek != null)
                {
                    yemek.YemekResmi = resimBytes;
                    context.SaveChanges();
                }
            }
        }

    

        public int YemekIsmineGoreYemekId(string yemekAdi)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Yemekler.Where(x => x.Isim == yemekAdi).Select(x => x.YemekId).FirstOrDefault();
            }
        }
    }
}