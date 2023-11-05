using KALORI.DATA.Abstract;
using KALORI.DATA.Entities;
using Kalori_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kalori_DAL.ilk
{
    public class KullaniciOgunDAL
    {
        public KullaniciOgun GetKullaniciOgunWithOgunYemekleri(int kullaniciOgunId)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                var kullaniciOgun = context.KullaniciOgunleri
                 .Include(ko => ko.OgunYemek)
                 .FirstOrDefault(ko => ko.IslemId == kullaniciOgunId);

                return kullaniciOgun;
            }

        }

        public void Create(KullaniciOgun kullaniciOgun)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Add(kullaniciOgun);
                context.SaveChanges();
            }
        }

        public List<KullaniciOgun> GetAll()
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Set<KullaniciOgun>().ToList();
            }
        }

        public List<KullaniciOgun> GetAllWhere(Expression<Func<KullaniciOgun, bool>> expression)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Set<KullaniciOgun>().Where(expression).ToList();
            }
        }

        public void Update(KullaniciOgun entity)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}