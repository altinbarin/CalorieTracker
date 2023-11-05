
using Kalori.Service.Concrete;
using KALORI.DATA.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KaloriTakip_WFAUI
{
    public partial class Raporlar : Form
    {
        KaloriHesaplamaDbContext context;
        KullaniciOgunService kullaniciOgunService;
        YemekService yemekService;
        OgunService ogunService;
        OgunYemekService ogunYemekService;
        private static List<Kullanici> Kullanici;
        public Raporlar(List<Kullanici> kullanici)
        {
            InitializeComponent();
            Kullanici = kullanici;
            context = new KaloriHesaplamaDbContext();
            kullaniciOgunService = new KullaniciOgunService();
            ogunService = new OgunService();
            ogunYemekService = new OgunYemekService();
            yemekService = new YemekService();
        }

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {

                lstRaporlar.Items.Clear();

                var gunlukRapor = kullaniciOgunService.GetAllWhere(x => x.Kullanici.Mail == Kullanici[0].Mail && x.Tarih.Value.Date == dateTimePicker1.Value.Date).OrderBy(x => x.OgunId)
                    .ToList();

                foreach (var item in gunlukRapor)
                {
                    ListViewItem lvi = new ListViewItem();
                    var ogun = ogunService.GetById(item.OgunId);
                    var yemekler = ogunYemekService.GetAllWhere(x => x.KullaniciOgun.OgunId == item.OgunId && x.IslemId == item.IslemId).ToList();
                    int toplamKalori = 0;
                    foreach (var yemek in yemekler)
                    {
                        toplamKalori += yemek.Kalori * (int)yemek.Porsiyon;
                    }

                    lvi.Text = ($"{ogun.Isim}");                    //Metot yapılacak
                    lvi.SubItems.Add($"{toplamKalori}");
                    lvi.SubItems.Add($"{item.Tarih}");
                    lstRaporlar.Items.Add(lvi);
                }
            
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            lstRaporlar.FullRowSelect = true;
            lstRaporlar.View = View.Details;
            lstRaporlar.Columns.Add("Öğün İsmi", 100);
            lstRaporlar.Columns.Add("Toplam Kalori", 100);
            lstRaporlar.Columns.Add("Tarih", 150);

            //yemekler gözükecek

            lstYemekler.FullRowSelect = true;
            lstYemekler.View = View.Details;
            lstYemekler.Columns.Add("Yemek İsmi", 150);
            lstYemekler.Columns.Add("Kalori", 70);
            lstYemekler.Columns.Add("Porsiyon", 70);

        }

        private void lstRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstYemekler.Items.Clear();
            string selectedOgunIsim = "";

            if (lstRaporlar.SelectedItems.Count > 0)
            {
                ListViewItem selected = lstRaporlar.SelectedItems[0];
                selectedOgunIsim = selected.Text;
                var selected1 = selected.SubItems[2].Text;

                DateTime selectedday1;

               
                    var haftalikRapor = kullaniciOgunService.GetAllWhere(x => x.Kullanici.Mail == Kullanici[0].Mail && x.Tarih.Value.DayOfYear == StringToDate(selected1).DayOfYear && x.Ogun.Isim == selectedOgunIsim).FirstOrDefault();
                      
                    var yemekler = ogunYemekService.GetAllWhere(x => x.KullaniciOgun.OgunId == haftalikRapor.OgunId && x.IslemId == haftalikRapor.IslemId);

                    foreach (var yemek in yemekler)
                    {
                        var yemek1 = yemekService.GetById(yemek.YemekId);

                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = ($"{yemek1.Isim}");
                        lvi.SubItems.Add(yemek.Kalori.ToString());
                        lvi.SubItems.Add(yemek.Porsiyon.ToString()); ;
                        lstYemekler.Items.Add(lvi);
                    }                
            }
        }

        private void btnHaftalikRapor_Click_1(object sender, EventArgs e)
        {
            lstRaporlar.Items.Clear();
           
                DateTime baslangicTarihi = dateTimePicker1.Value.Date.AddDays(-(int)dateTimePicker1.Value.DayOfWeek);
                DateTime bitisTarihi = baslangicTarihi.AddDays(6);

                var haftalikRapor = kullaniciOgunService.GetAllWhere(x => x.Kullanici.Mail == Kullanici[0].Mail && x.Tarih.Value.Date >= baslangicTarihi && x.Tarih.Value.Date <= bitisTarihi).OrderBy(x => x.Tarih)
                    .ToList();

                foreach (var item in haftalikRapor)
                {

                    ListViewItem lvi = new ListViewItem();

                    var ogun = ogunService.GetById(item.OgunId);
                    var yemekler = ogunYemekService.GetAllWhere(x => x.KullaniciOgun.OgunId == item.OgunId && x.IslemId == item.IslemId).ToList();
                    int toplamKalori = 0;
                    foreach (var yemek in yemekler)
                    {                    
                        toplamKalori += yemek.Kalori * (int)yemek.Porsiyon;
                    }

                    lvi.Text = ($"{ogun.Isim}");//Metot yapılacak
                    lvi.SubItems.Add($"{toplamKalori}");
                    lvi.SubItems.Add($"{item.Tarih}");
                    lstRaporlar.Items.Add(lvi);

                }          
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            lstRaporlar.Items.Clear();
            DateTime baslangicTarihi = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            DateTime bitisTarihi = baslangicTarihi.AddMonths(1).AddDays(-1);


            
               var aylikRapor = kullaniciOgunService.GetAllWhere(x => x.Kullanici.Mail == Kullanici[0].Mail && x.Tarih.Value.Date >= baslangicTarihi && x.Tarih.Value.Date <= bitisTarihi).OrderBy(x => x.Tarih)
                    .ToList();

                foreach (var item in aylikRapor)
                {
                    ListViewItem lvi = new ListViewItem();

                    var ogun = ogunService.GetById(item.OgunId);
                    var yemekler = ogunYemekService.GetAllWhere(x => x.KullaniciOgun.OgunId == item.OgunId && x.IslemId == item.IslemId).ToList();
                    int toplamKalori = 0;
                    foreach (var yemek in yemekler)
                    {
                        toplamKalori += yemek.Kalori * (int)yemek.Porsiyon;
                    }

                    lvi.Text = ($"{ogun.Isim}");//Metot yapılacak
                    lvi.SubItems.Add($"{toplamKalori}");
                    lvi.SubItems.Add($"{item.Tarih}");
                    lstRaporlar.Items.Add(lvi);

                }           
        }
        public static DateTime StringToDate(string theDateInStringFormat)
        {
            DateTime result;
            if (DateTime.TryParse(theDateInStringFormat, out result))
            {
                return result;
            }

            return new DateTime();
        }
    }
}
