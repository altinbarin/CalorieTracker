
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

    public class KategoriDAL : EfEntityRepositoryBase<Kategori, KaloriHesaplamaDbContext>, IKategoriDAL
    {
     
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