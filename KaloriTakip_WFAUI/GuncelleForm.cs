using Kalori.Service.Concrete;
using KALORI.DATA.Entities;
using Kalori_DAL.Context;
using Microsoft.EntityFrameworkCore;
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

    public partial class GuncelleForm : Form
    {
        KaloriHesaplamaDbContext context;
        KullaniciOgunService kullaniciOgunService = new KullaniciOgunService();
        OgunService ogunService = new OgunService();
        OgunYemekService ogunYemekService = new OgunYemekService();
        YemekService yemekService = new YemekService();
        public List<Kullanici> kullanici2 { get; set; }
        public GuncelleForm(List<Kullanici> kullanicis)
        {
            InitializeComponent();
            kullanici2 = kullanicis;
        }

        private void btnTarihGetir_Click(object sender, EventArgs e)
        {
            lstOgunler.Items.Clear();
            lstOgunDetaylari.Items.Clear();

            var ogunTarih = kullaniciOgunService.GetAllWhere(x => x.Tarih.Value.DayOfYear == dateTimePicker1.Value.DayOfYear && x.Kullanici == kullanici2[0]);

            foreach (var item in ogunTarih)
            {
                var ogun = ogunService.GetById(item.OgunId);
                lstOgunler.Items.Add(ogun.Isim);
            }
        }

        private void lstOgunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOgunDetaylari.Items.Clear();

            var IslemId = kullaniciOgunService.GetAllWhere(x => x.Tarih.Value.DayOfYear == dateTimePicker1.Value.DayOfYear && x.Kullanici == kullanici2[0] && x.Ogun.Isim == lstOgunler.SelectedItem as string).FirstOrDefault().IslemId;

            var ogunYemekleri = ogunYemekService.GetAllWhere(x => x.IslemId == IslemId).ToList();

            foreach (var yemek in ogunYemekleri)
            {
                var yemekIsmi = yemekService.GetById(yemek.YemekId).Isim;

                ListViewItem lvi = new ListViewItem();
                lvi.Text = yemekIsmi;
                lvi.SubItems.Add(yemek.Porsiyon.ToString());
                lvi.SubItems.Add(yemek.Kalori.ToString());
                lvi.SubItems.Add($"Toplam Kalori: {yemek.Kalori * yemek.Porsiyon}");
                lstOgunDetaylari.Items.Add(lvi);
            }
        }


        private void GuncelleForm_Load(object sender, EventArgs e)
        {
            cbYemekIsmi.DataSource = yemekService.YemeklerIsimlerListesi();

            lstOgunDetaylari.FullRowSelect = true;
            lstOgunDetaylari.View = View.Details;
            lstOgunDetaylari.Columns.Add("Yemek İsmi", 150);
            lstOgunDetaylari.Columns.Add("Porsiyon", 90);
            lstOgunDetaylari.Columns.Add("Kalori", 70);
            lstOgunDetaylari.Columns.Add("Toplam Kalori", 200);

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {

            var ogunTarih = kullaniciOgunService.GetAllWhere(x => x.Tarih.Value.DayOfYear == dateTimePicker1.Value.Date.DayOfYear && x.Kullanici.Mail == kullanici2[0].Mail && x.Ogun.Isim == lstOgunler.SelectedItem as string).FirstOrDefault();

            var yemekler = yemekService.GetAllWhere(x => x.Isim == cbYemekIsmi.SelectedItem.ToString()).FirstOrDefault();
            var kullaniciOgunWithOgunYemek = kullaniciOgunService.GetKullaniciOgunWithOgunYemekleri(ogunTarih.IslemId);
            var yeniOgunYemek = new OgunYemek() { YemekId = yemekler.YemekId, Porsiyon = nmrPorsiyon.Value, Kalori = yemekler.Kalori };

            kullaniciOgunWithOgunYemek.OgunYemek.Add(yeniOgunYemek);
            kullaniciOgunService.Update(kullaniciOgunWithOgunYemek);

            lstOgunDetaylari.Items.Clear();

            var IslemId = kullaniciOgunService.GetAllWhere(x => x.Tarih.Value.DayOfYear == dateTimePicker1.Value.DayOfYear && x.Kullanici == kullanici2[0] && x.Ogun.Isim == lstOgunler.SelectedItem as string).FirstOrDefault().IslemId;

            var ogunYemekleri = ogunYemekService.GetAllWhere(x => x.IslemId == IslemId).ToList();

            foreach (var yemek in ogunYemekleri)
            {
                var yemekIsmi = yemekService.GetById(yemek.YemekId).Isim;

                ListViewItem lvi = new ListViewItem();
                lvi.Text = yemekIsmi;
                lvi.SubItems.Add(yemek.Porsiyon.ToString());
                lvi.SubItems.Add(yemek.Kalori.ToString());
                lvi.SubItems.Add($"Toplam Kalori: {yemek.Kalori * yemek.Porsiyon}");
                lstOgunDetaylari.Items.Add(lvi);
            }


        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {

            var ogunTarih = kullaniciOgunService.GetAllWhere(x => x.Tarih.Value.DayOfYear == dateTimePicker1.Value.DayOfYear && x.Kullanici == kullanici2[0] && x.Ogun.Isim == lstOgunler.SelectedItem as string).FirstOrDefault();

            ListViewItem selected = lstOgunDetaylari.SelectedItems[0];
            string selectedOgunIsim = selected.Text;

            var guncellenecekYemek = ogunYemekService.GetAllWhere(x => x.IslemId == ogunTarih.IslemId && x.Yemek.Isim == selectedOgunIsim).FirstOrDefault();

            ogunYemekService.Delete(guncellenecekYemek);

            lstOgunDetaylari.Items.Clear();

            var islemId = kullaniciOgunService.GetAllWhere(x => x.Tarih.Value.DayOfYear == dateTimePicker1.Value.DayOfYear && x.Kullanici == kullanici2[0] && x.Ogun.Isim == lstOgunler.SelectedItem as string).FirstOrDefault().IslemId;

            var ogunYemekleri = ogunYemekService.GetAllWhere(x => x.IslemId == islemId).ToList();

            foreach (var yemek in ogunYemekleri)
            {
                var yemekIsmi = yemekService.GetById(yemek.YemekId).Isim;

                ListViewItem lvi = new ListViewItem();
                lvi.Text = yemekIsmi;
                lvi.SubItems.Add(yemek.Porsiyon.ToString());
                lvi.SubItems.Add(yemek.Kalori.ToString());
                lvi.SubItems.Add($"Toplam Kalori: {yemek.Kalori * yemek.Porsiyon}");
                lstOgunDetaylari.Items.Add(lvi);
            }


        }
    }
}
