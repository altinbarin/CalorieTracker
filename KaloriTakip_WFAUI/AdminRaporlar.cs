using Kalori.Service.Concrete;
using Kalori_DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakip_WFAUI
{
    public partial class AdminRaporlar : Form
    {
        KaloriHesaplamaDbContext context;
        KategoriService kategoriService = new KategoriService();
        KullaniciOgunService kullaniciOgunService = new KullaniciOgunService();
        KullaniciService kullaniciService = new KullaniciService();
        OgunService ogunService = new OgunService();
        OgunYemekService ogunYemekService = new OgunYemekService();
        YemekService yemekService = new YemekService();
        public AdminRaporlar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kullanıcı Öğünleri ve Öğün Yemekleri tabloları birleştiriliyor. Kullanıcı öğünleri tablosundan öğünId ve isim, öğün yemekleri tablosundan yemekId ve isim alınıyor. Kullanıcı öğünlerini öğünId'ye göre gruplayıp, öğün yemeklerini yemekId'ye göre gruplayıp, en çok yenen yemeği buluyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOguneGoreYemek_Click(object sender, EventArgs e)
        {
              listBox1.Items.Clear();
              

                var groupedQuery = kullaniciOgunService.GetAll().Join(ogunYemekService.GetAll(), ko => ko.IslemId, oy => oy.IslemId, (ko, oy) => new { ko.OgunId, oy.YemekId });

                var groupedAndCounted = groupedQuery
                    .GroupBy(x => x.OgunId)
                    .Select(group => new
                    {
                        OgunId = group.Key,
                        EnCokYenilenYemekId = group
                            .GroupBy(x => x.YemekId)
                            .OrderByDescending(x => x.Count())
                            .First()
                            .Key
                    });

                foreach (var item in groupedAndCounted)
                {
                    using (var innerContext = new KaloriHesaplamaDbContext())
                    {
                        var ogunIsmi = innerContext.Ogunler.Where(x => x.OgunId == item.OgunId).Select(x => x.Isim).FirstOrDefault();       //m1
                        var yemekIsmi = innerContext.Yemekler.Where(x => x.YemekId == item.EnCokYenilenYemekId).Select(x => x.Isim).FirstOrDefault();
                        listBox1.Items.Add($"{ogunIsmi} - En Çok Yenilen Yemek: {yemekIsmi}\n");
                    }
                }
            
        }


        /// <summary>
        /// Kullanıcı Öğünleri ve Öğün Yemekleri tabloları birleştiriliyor. Kullanıcı öğünleri tablosundan öğünId ve isim, öğün yemekleri tablosundan yemekId ve isim alınıyor. Kullanıcı öğünlerini öğünId'ye göre gruplayıp, öğün yemeklerini yemekId'ye göre gruplayıp, öğünlere göre yemeklerin adetlerini görüyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHangiYemekHangiOgun_Click(object sender, EventArgs e)
        {
            
          
                listBox1.Items.Clear();
               
                var groupedQuery1 = kullaniciOgunService.GetAll().Join(ogunYemekService.GetAll(), ko => ko.IslemId, oy => oy.IslemId, (ko, oy) => new { ko.OgunId, oy.YemekId });

                var groupedAndCounted2 = groupedQuery1
                    .GroupBy(x => new { x.OgunId, x.YemekId })
                    .Select(group => new
                    {
                        OgunId = group.Key.OgunId,
                        YemekId = group.Key.YemekId,
                        Adet = group.Count()
                    });

                foreach (var item in groupedAndCounted2)
                {
                    using (var innerContext = new KaloriHesaplamaDbContext())
                    {
                        var yemekIsmi = innerContext.Yemekler.Where(x => x.YemekId == item.YemekId).Select(x => x.Isim).FirstOrDefault();  //m1
                          var ogunIsmi = innerContext.Ogunler.Where(x => x.OgunId == item.OgunId).Select(x => x.Isim).FirstOrDefault();
                        listBox1.Items.Add($"{yemekIsmi} - {ogunIsmi} - {item.Adet} adet\n");
                    }
                }
            
        }

       
        /// <summary>
        /// En çok yenen yemek bulunuyor. Yemekler tablosundan yemekId ve isim alınıyor. Kullanıcı öğünleri ve öğün yemekleri tabloları birleştiriliyor. Kullanıcı öğünlerini öğünId'ye göre gruplayıp, öğün yemeklerini yemekId'ye göre gruplayıp, en çok yenen yemeği buluyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnCokHangiYemek_Click(object sender, EventArgs e)
        {
            
                var groupedQuery3 = kullaniciOgunService.GetAll().Join(ogunYemekService.GetAll(), ko => ko.IslemId, oy => oy.IslemId, (ko, oy) => new { ko.OgunId, oy.YemekId });

                var groupedAndCounted3 = groupedQuery3
                    .GroupBy(x => x.YemekId)
                    .Select(group => new
                    {
                        YemekId = group.Key,
                        ToplamAdet = group.Count()
                        
                    })
                    .OrderByDescending(item => item.ToplamAdet)
                    .FirstOrDefault(); 

           
                var enCokYenenYemekIsmi = yemekService.GetById(groupedAndCounted3.YemekId);
            var genelYemek = yemekService.GetById(enCokYenenYemekIsmi.YemekId);


                label1.Text = $"En çok yenilen Yemek: {genelYemek.Isim}, Toplam Adet: {groupedAndCounted3.ToplamAdet}";
            
        }
    }
}
