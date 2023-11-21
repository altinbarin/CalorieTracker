using Kalori_DAL.ilk;
using System.Linq.Expressions;
using KALORI.DATA.Entities;
using Kalori.Service.Abstract;

namespace Kalori.Service.Concrete
{
    public class YemekService:IYemekService
    {
        private readonly YemekDAL _yemekDAL;

        public YemekService()
        {
            _yemekDAL = new YemekDAL();
        }

        public void Create(Yemek yemek)
        {
            _yemekDAL.Create(yemek);
        }

        public void Delete(Yemek yemek)
        {
            _yemekDAL.Delete(yemek);
        }

        public List<Yemek> GetAllWhere(Expression<Func<Yemek, bool>> expression)
        {
            return _yemekDAL.GetAllWhere(expression);
        }

        public Yemek GetById(int id)
        {
            return _yemekDAL.GetById(id);
        }

        public void ResimGuncelle(int yemekId, byte[] resim)
        {
            Yemek yemek = _yemekDAL.GetById(yemekId);
            if (yemek != null)
            {
                yemek.YemekResmi = resim;
                _yemekDAL.Update(yemek);
            }
            else
            {
                throw new InvalidOperationException("Geçersiz yemek ID'si");
            }
        }

        public void ResimGuncelle(Yemek yemek, byte[] resim)
        {
            yemek.YemekResmi = resim;
            _yemekDAL.Update(yemek);
        }
        public void Update(Yemek yemek)
        {
            _yemekDAL.Update(yemek);

        }

        public int YemekIsmineGoreYemekId(string yemekAdi)
        {
            return _yemekDAL.YemekIsmineGoreYemekId(yemekAdi);
        }

        public List<string> YemeklerIsimlerListesi()
        {
            return _yemekDAL.YemeklerIsimlerListesi();
        }
    }
}