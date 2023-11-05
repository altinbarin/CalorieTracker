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
    public partial class OgunEkle : Form
    {
        OgunService ogunService = new OgunService();
        YemekService yemekService = new YemekService();
        KullaniciService kullaniciService = new KullaniciService();
        KullaniciOgunService kullaniciOgunService = new KullaniciOgunService();
        List<Kullanici> kullanici;
        KaloriHesaplamaDbContext context;
        List<OgunYemek> ogunYemekler = new List<OgunYemek>();
        public OgunEkle(List<Kullanici> aktifKullanici)
        {
            InitializeComponent();
            kullanici = aktifKullanici;
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {


            var ogun = ogunService.GetById(ogunService.OgunIsmineGoreOgunId(cmbOgun.SelectedItem.ToString()));

            var ogunTarih = kullaniciOgunService.GetAllWhere(x => x.Tarih.Value.DayOfYear == dateTimePicker1.Value.DayOfYear && x.OgunId == ogun.OgunId).FirstOrDefault();

            var ogunId = ogunService.OgunIsmineGoreOgunId(cmbOgun.SelectedItem.ToString());

            var yemek = yemekService.GetById(yemekService.YemekIsmineGoreYemekId(cmbYemek.SelectedItem.ToString()));

            #region Guncelleme

            if (ogunTarih is not null)
            {
                MessageBox.Show($"Girdiğiniz tarihte {cmbOgun.SelectedItem} öğünü bulunmaktadır. Değişiklik yapmak için lütfen güncelleme sayfasına gidiniz", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion


            #region Yeni OgunEkleme

            else if (ogunTarih is null)
            {
                try
                {
                    if (ogunYemekler.Count > 0)
                    {
                        var kullanici1 = kullaniciService.MaileGoreKullaniciGetir(kullanici[0].Mail);
                        var yeniKullaniciOgun = new KullaniciOgun()
                        {
                            KullaniciMail = kullanici1.Mail,
                            OgunId = ogunId,
                            Tarih = dateTimePicker1.Value,

                        };
                        var yeniOgunYemek = new List<OgunYemek>();
                        foreach (var item in ogunYemekler)
                        {
                            yeniOgunYemek.Add(item);
                        }

                        yeniKullaniciOgun.OgunYemek = yeniOgunYemek;
                        kullaniciOgunService.Create(yeniKullaniciOgun);

                    }

                    else
                    {
                        var kullanici1 = kullaniciService.MaileGoreKullaniciGetir(kullanici[0].Mail);
                        var yeniKullaniciOgun = new KullaniciOgun()
                        {
                            KullaniciMail = kullanici1.Mail,
                            OgunId = ogunId,
                            Tarih = dateTimePicker1.Value,
                        };

                        var yeniOgunYemek = new List<OgunYemek>()
                                     { new OgunYemek() { YemekId = yemek.YemekId, Porsiyon = nmrPorsiyon.Value ,Kalori=yemek.Kalori  } };

                        yeniKullaniciOgun.OgunYemek = yeniOgunYemek;
                        kullaniciOgunService.Create(yeniKullaniciOgun);

                    }
                    MessageBox.Show("Kayıt başarılı");
                }
                catch (Exception)
                {
                    MessageBox.Show("Aynı yemekten iki kez ekleyemezsiniz. Bunun yerine porsiyonu arttırmayı deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            ogunYemekler = new List<OgunYemek>();
            lstUrunler.Items.Clear();
            Kontrol();
            #endregion

        }
        private void btnArti_Click(object sender, EventArgs e)
        {

            var selectedYemek = yemekService.GetById(yemekService.YemekIsmineGoreYemekId(cmbYemek.SelectedItem.ToString()));

            if (selectedYemek != null)
            {
                int porsiyon = (int)nmrPorsiyon.Value;
                int toplamKalori = selectedYemek.Kalori * porsiyon;
                var yeniOgunYemek = new OgunYemek() { YemekId = selectedYemek.YemekId, Porsiyon = nmrPorsiyon.Value, Kalori = selectedYemek.Kalori };
                ogunYemekler.Add(yeniOgunYemek);


                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = selectedYemek.Isim;
                viewItem.SubItems.Add(selectedYemek.Kalori.ToString());
                viewItem.SubItems.Add(yeniOgunYemek.Porsiyon.ToString());
                viewItem.SubItems.Add((yeniOgunYemek.Porsiyon * selectedYemek.Kalori).ToString());

                lstUrunler.Items.Add(viewItem);
            }

            Kontrol();
        }

        private void Kontrol()
        {
            if (lstUrunler.Items.Count > 0)
            {
                cmbOgun.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                cmbOgun.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            string selectedOgunIsim = "";
            ListViewItem selected = lstUrunler.SelectedItems[0];
            if (lstUrunler.SelectedItems.Count > 0)
            {
                selectedOgunIsim = selected.SubItems[0].Text;

            }
            var selectedYemek = yemekService.YemekIsmineGoreYemekId(selectedOgunIsim.ToString());
            OgunYemek selectedItem2 = new OgunYemek();
            int selectedItem3;
            foreach (var item in ogunYemekler)
            {
                if (item.YemekId == selectedYemek)
                {
                    selectedItem2 = item;
                }
            }
            ogunYemekler.Remove(selectedItem2);
            lstUrunler.Items.Remove(selected);

            Kontrol();
        }
        private void cmbYemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (context = new KaloriHesaplamaDbContext())
            {
                var yemekFotografi = context.Yemekler.Where(x => x.Isim == cmbYemek.SelectedItem.ToString()).Select(x => x.YemekResmi).FirstOrDefault();
                pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(yemekFotografi));
            }

        }

        private void OgunEkle_Load(object sender, EventArgs e)
        {
            lstUrunler.FullRowSelect = true;
            lstUrunler.View = View.Details;
            lstUrunler.Columns.Add("Yemek İsmi", 100);
            lstUrunler.Columns.Add("Kalori", 70);
            lstUrunler.Columns.Add("Porsiyon", 70);
            lstUrunler.Columns.Add("Toplam Kalori", 100);
            using (context = new KaloriHesaplamaDbContext())
            {
                //bilgileri güncelleyebilelim
                cmbOgun.DataSource = ogunService.OgunIsimlerListesi();
                cmbYemek.DataSource = yemekService.YemeklerIsimlerListesi();
            }
        }
    }
}
