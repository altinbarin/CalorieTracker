using KALORI.DATA.Entities;
using Kalori_DAL.Context;
using Kalori_DAL.ilk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalori.Service.Concrete
{
    public class OgunService
    {
        OgunDAL ogunDAL = new OgunDAL();
        public Ogun GetById(int id)
        {
            return ogunDAL.GetById(id);
        }

        public int OgunIsmineGoreOgunId(string ogunAdi)
        {
            return ogunDAL.OgunIsmineGoreOgunId(ogunAdi);
        }
        public List<string> OgunIsimlerListesi()
        {
            OgunDAL ogunDAL = new OgunDAL();
            return ogunDAL.OgunIsimlerListesi();
        }
    }
}