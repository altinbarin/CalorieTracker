using Kalori.Service.Abstract;
using KALORI.DATA.Entities;
using Kalori_DAL.Context;
using Kalori_DAL.ilk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kalori.Service.Concrete
{
    public class KullaniciOgunService:IKullaniciOgunService
    {
        KullaniciOgunDAL kullaniciOgunDAL = new KullaniciOgunDAL();

        public KullaniciOgun GetKullaniciOgunWithOgunYemekleri(int kullaniciOgunId)
        {
            return kullaniciOgunDAL.GetKullaniciOgunWithOgunYemekleri(kullaniciOgunId);

        }
        public void Create(KullaniciOgun kullaniciOgun)
        {
            kullaniciOgunDAL.Create(kullaniciOgun);
        }

        public List<KullaniciOgun> GetAll()
        {
            return kullaniciOgunDAL.GetAll();
        }

        public List<KullaniciOgun> GetAllWhere(Expression<Func<KullaniciOgun, bool>> expression)
        {
            return kullaniciOgunDAL.GetAllWhere(expression);
        }


        public void Update(KullaniciOgun kullaniciOgun)
        {
            kullaniciOgunDAL.Update(kullaniciOgun);
        }
        
    }
}