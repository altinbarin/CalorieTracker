using Kalori.Service.Abstract;
using KALORI.DATA.Entities;
using Kalori_DAL.ilk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kalori.Service.Concrete
{
    public class OgunYemekService:IOgunYemekService
    {
        OgunYemekDAL ogunYemekDAL = new OgunYemekDAL();
        public void Create(OgunYemek ogunYemek)
        {
            ogunYemekDAL.Create(ogunYemek);
        }

        public void Delete(OgunYemek ogunYemek)
        {
            ogunYemekDAL.Delete(ogunYemek);
        }

        public List<OgunYemek> GetAllWhere(Expression<Func<OgunYemek, bool>> expression)
        {
            return ogunYemekDAL.GetAllWhere(expression);
        }

        public OgunYemek GetById(int id)
        {
            return ogunYemekDAL.GetById(id);
        }
        public List<OgunYemek> GetAll()
        {
            return ogunYemekDAL.GetAll();
        }


    }
}