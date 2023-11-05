using Kalori.Service.Concrete;
using Kalori_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KaloriTakip_WFAUI
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        KaloriHesaplamaDbContext context;
        KullaniciService kullaniciService = new KullaniciService();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            using (context = new KaloriHesaplamaDbContext())
            {

                var aktifKullanici = kullaniciService.MaileGoreKullaniciListesiGetir(txtKullaniciAdi.Text);

                var kullanici = kullaniciService.MaileGoreKullaniciGetir(txtKullaniciAdi.Text);

                if (aktifKullanici[0].Mail == txtKullaniciAdi.Text && aktifKullanici[0].Sifre == txtParola.Text)
                {

                    if (cmbHatirla.Checked == true)
                    {
                        kullanici.SifremiHatirla = true;
                        context.SaveChanges();
                    }
                    else
                    {
                        kullanici.SifremiHatirla = false;
                        context.SaveChanges();
                    }
                    MessageBox.Show("Giriş başarılı!", "Hoşgeldiniz", MessageBoxButtons.OK);

                    if (aktifKullanici[0].KullanıcıTipi)
                    {
                        AdminSayfasi adminFormu = new AdminSayfasi(aktifKullanici);
                        adminFormu.ShowDialog();
                    }
                    else
                    {
                        KullaniciGirisi kullaniciFormu = new KullaniciGirisi(aktifKullanici);
                        kullaniciFormu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtParola.Clear();
                }
            }

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            KaydolmaEkrani kaydolmaEkrani = new KaydolmaEkrani();
            kaydolmaEkrani.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifreSifirlamaFormu = new SifremiUnuttum();
            sifreSifirlamaFormu.ShowDialog();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            var kullaniciAdlari = kullaniciService.KullaniciIsimleriGetir();

            var sifremiHatirla = kullaniciService.GetAllWhere(x => x.Mail == txtKullaniciAdi.Text).Select(x => x.SifremiHatirla).FirstOrDefault();

            foreach (var item in kullaniciAdlari)
            {

                if (item.Contains(txtKullaniciAdi.Text))
                {
                    if (sifremiHatirla == true)
                    {
                        txtParola.Text = kullaniciService.GetAllWhere(x => x.Mail == txtKullaniciAdi.Text).Select(x => x.Sifre).FirstOrDefault();
                        cmbHatirla.Checked = true;
                    }
                }
            }
        }
    }
}
