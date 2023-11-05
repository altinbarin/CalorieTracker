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
    public class KategoriService
    {
        public void Create(Kategori entity)
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            kategoriDAL.Create(entity);
        }

        public void Delete(Kategori kategori)
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            kategoriDAL.Delete(kategori);
        }


        public Kategori GetById(int id)
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            return kategoriDAL.GetById(id);
        }

        public int KategoriIsmineGoreKategoriId(string kategoriAdi)
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            return kategoriDAL.KategoriIsmineGoreKategoriId(kategoriAdi);
        }

        public List<string> KategoriIsimlerListesi()
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            return kategoriDAL.KategoriIsimlerListesi();
        }

    }
}