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

    public class KategoriDAL

    {
        public void Create(Kategori entity)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Kategori entity)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public Kategori GetById(int id)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Kategoriler.Where(x => x.KategoriId == id).FirstOrDefault();

            }
        }

        public List<string> KategoriIsimlerListesi()
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Kategoriler.Select(x => x.Isim).ToList();
            }
        }

        public int KategoriIsmineGoreKategoriId(string kategoriAdi)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Kategoriler.Where(x => x.Isim == kategoriAdi).Select(x => x.KategoriId).FirstOrDefault();
            }
        }

    }


}