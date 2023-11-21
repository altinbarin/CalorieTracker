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
    public class KategoriService:IKategoriService
    {
        KategoriDAL kategoriDAL = new KategoriDAL();

        public void Create(Kategori entity)
        {
            kategoriDAL.Create(entity);
        }

        public void Delete(Kategori kategori)
        {
            kategoriDAL.Delete(kategori);
        }


        public Kategori GetById(int id)
        {
            return kategoriDAL.GetById(id);
        }

        public int KategoriIsmineGoreKategoriId(string kategoriAdi)
        {
            return kategoriDAL.KategoriIsmineGoreKategoriId(kategoriAdi);
        }

        public List<string> KategoriIsimlerListesi()
        {
            return kategoriDAL.KategoriIsimlerListesi();
        }

    }
}