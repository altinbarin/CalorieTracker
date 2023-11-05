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

namespace KaloriTakip_WFAUI
{
    public partial class BilgilerimiGuncelle : Form
    {
        List<Kullanici> Kullanici;
        KaloriHesaplamaDbContext context;
        KullaniciService kullaniciService=new KullaniciService();
        public BilgilerimiGuncelle(List<Kullanici> kullanici)
        {
            InitializeComponent();
            Kullanici = kullanici;
        }

        private void Guncelle(object sender, EventArgs e)
        {
            using (context = new KaloriHesaplamaDbContext())
            {
                if (txtAd.Text != null && txtSoyad.Text != null)
                {
              
                    var kullanici = kullaniciService.MaileGoreKullaniciGetir(Kullanici[0].Mail);
                    kullanici.Boy = Convert.ToInt32(nmrBoy.Value);
                    kullanici.Kilo = Convert.ToInt32(nmrKilo.Value);
                    kullanici.Soyisim = txtSoyad.Text;
                    kullanici.Isim = txtAd.Text;

                    kullaniciService.Update(kullanici);
                    MessageBox.Show("Uygulamayı tekrar başlattığınızda bilgileriniz güncellenecektir", "Başarılı");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Boş değer bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BilgilerimiGuncelle_Load(object sender, EventArgs e)
        {
            nmrBoy.Value = Kullanici[0].Boy;
            nmrKilo.Value = Kullanici[0].Kilo;
            txtAd.Text = Kullanici[0].Isim;
            txtSoyad.Text = Kullanici[0].Soyisim;
        }

    }
}
