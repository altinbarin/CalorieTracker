using KALORI.DATA.Abstract;
using KALORI.DATA.Entities;
using Kalori_DAL.Context;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kalori_DAL.ilk
{
    public class OgunDAL
    {

        public List<Ogun> GetAllWhere(Expression<Func<Ogun, bool>> expression)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Set<Ogun>().Where(expression).ToList();
            }
        }

        public Ogun GetById(int id)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Ogunler.Where(x => x.OgunId == id).FirstOrDefault();
            }
        }

        public int OgunIsmineGoreOgunId(string ogunAdi)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Ogunler.Where(x => x.Isim == ogunAdi).Select(x => x.OgunId).FirstOrDefault();
            }
        }

        public List<string> OgunIsimlerListesi()
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Ogunler.Select(x => x.Isim).ToList();
            }
        }
    }
}