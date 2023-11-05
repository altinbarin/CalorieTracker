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
    public class OgunYemekDAL
    {


        public void Create(OgunYemek entity)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }


        public void Delete(OgunYemek entity)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<OgunYemek> GetAll()
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Set<OgunYemek>().ToList();
            }
        }

        public List<OgunYemek> GetAllWhere(Expression<Func<OgunYemek, bool>> expression)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.Set<OgunYemek>().Where(expression).ToList();
            }
        }

        public OgunYemek GetById(int id)
        {
            using (KaloriHesaplamaDbContext context = new KaloriHesaplamaDbContext())
            {
                return context.OgunYemekleri.Where(x => x.IslemId == id).FirstOrDefault();
            }
        }
    }
}