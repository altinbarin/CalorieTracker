using Kalori_DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KALORI.DATA.Entities;
using Kalori_DAL.ilk;
using Kalori.Service.Concrete;

namespace KaloriTakip_WFAUI
{
    public partial class SifremiUnuttum : Form
    {
        KullaniciService kullaniciService = new KullaniciService(); 
        KaloriHesaplamaDbContext context;
        Random rnd = new Random();
        string aktivasyonKodu;

        public SifremiUnuttum()
        {
            InitializeComponent();

        }
        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            txtYeniSifre.Enabled = false;
            txtYeniSifreOnay.Enabled = false;
            btnYeniSifreKaydet.Enabled = false;
            txtOnayKodu.Enabled = false;
            btnOnayla.Enabled = false;
        }
        private void btnSifirlamaKodu_Click(object sender, EventArgs e)
        {           
                if (kullaniciService.MaileGoreKullaniciGetir(txtKullaniciAdi.Text) != null)
                {

                    aktivasyonKodu = rnd.Next(100000, 999999).ToString();

                    MailMessage mesaj = new MailMessage();
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new NetworkCredential("fohmkaloritakip@gmail.com", "znyj ajxp mjyl vvyh");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    mesaj.From = new MailAddress("fohmkaloritakip@gmail.com");
                    mesaj.Subject = "Sıfırlama Kodu";
                    mesaj.Body = "Sıfırlama kodunuz: " + aktivasyonKodu;
                    mesaj.To.Add(txtKullaniciAdi.Text);
                    client.Send(mesaj);


                    btnSifirlamaKodu.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtOnayKodu.Enabled = true;
                    btnOnayla.Enabled = true;
                    btnSifirlamaKodu.Text = "Sıfırlama Kodu Gönderildi";
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }           
        }

        private void btnYeniSifreKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text == txtYeniSifreOnay.Text)
            {
                kullaniciService.MaileGoreKullaniciGetir(txtKullaniciAdi.Text).Sifre = txtYeniSifre.Text;
                kullaniciService.Update(kullaniciService.MaileGoreKullaniciGetir(txtKullaniciAdi.Text));
                MessageBox.Show("Şifreniz başarılı şekilde güncellenmiştir");
                    this.Close();              
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen şifrenizi tekrar kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            if (txtOnayKodu.Text == aktivasyonKodu)
            {
                txtYeniSifre.Enabled = true;
                txtYeniSifreOnay.Enabled = true;
                btnYeniSifreKaydet.Enabled = true;
                btnOnayla.Enabled = false;
                txtOnayKodu.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hatalı aktivasyon kodu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOnayKodu.Clear();
            }
        }
        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {


            if (IsLetterOnly(txtYeniSifre.Text) || IsDigitsOnly(txtYeniSifre.Text) || txtYeniSifre.Text.Length <= 6)
            {
                lblZorluk.BackColor = Color.Red;
                lblZorluk.Text = "Düşük";
                btnYeniSifreKaydet.Enabled = false;
            }
            else if (txtYeniSifre.Text.Length == 7)
            {
                lblZorluk.BackColor = Color.Yellow;

                lblZorluk.Text = "Orta";
                btnYeniSifreKaydet.Enabled = true;
            }
            else if (txtYeniSifre.Text.Length > 7)
            {
                lblZorluk.BackColor = Color.Green;

                lblZorluk.Text = "Yüksek";
                btnYeniSifreKaydet.Enabled = true;
            }

        }

        /// <summary>
        /// Sadece metin oluşup olmadığını kontrol eden metod
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static bool IsLetterOnly(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// Sadece sayilardan oluşup olmadığını kontrol eden metod
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static bool IsDigitsOnly(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
