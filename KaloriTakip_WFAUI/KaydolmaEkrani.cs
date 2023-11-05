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
using System.Net;
using System.Net.Mail;
using Kalori.Service.Concrete;

namespace KaloriTakip_WFAUI
{
    public partial class KaydolmaEkrani : Form
    {
        KaloriHesaplamaDbContext context;
        KullaniciService kullaniciService = new KullaniciService();
        public KaydolmaEkrani()
        {
            InitializeComponent();
        }

        private void KaydolmaEkrani_Load(object sender, EventArgs e)
        {
            btnKaydol.Enabled = false;
            btnAktivasyonOnayla.Enabled = false;

            rdbKadin.Checked = true;
            nmrBoy.Minimum = 100;
            nmrKilo.Minimum = 30;

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAktivasyon.Text == aktivasyonKodu && txtIsim.Text.Trim() != "" && txtSoyisim.Text.Trim() != "" && txtEmail.Text.Trim() != "")
                {
                    
                        Kullanici kullanici = new Kullanici()
                        {
                            Mail = txtEmail.Text.Trim(),       
                            Isim = txtIsim.Text.Trim(),
                            Soyisim = txtSoyisim.Text.Trim(),
                            Sifre = txtSifre.Text,              
                            DogumTarihi = dtpDogumTarihi.Value,
                            Boy = Convert.ToInt32(nmrBoy.Value),
                            Kilo = Convert.ToInt32(nmrKilo.Value),
                            Cinsiyet = rdbErkek.Checked ? "Erkek" : "Kadın",
                        };

                        kullaniciService.Create(kullanici);
                        MessageBox.Show("Kayıt başarılı!");
                        this.Close();

                }
                else
                {
                    MessageBox.Show("Aktivasyon kodu hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz işlem!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (IsLetterOnly(txtSifre.Text) || IsDigitsOnly(txtSifre.Text) || txtSifre.Text.Length <= 6)
            {
                lblZorluk.BackColor = Color.Red;
                lblZorluk.Text = "Düşük";
                btnKaydol.Enabled = false;
            }
            else if (txtSifre.Text.Length == 7)
            {
                lblZorluk.BackColor = Color.Yellow;

                lblZorluk.Text = "Orta";
                btnKaydol.Enabled = true;
                btnAktivasyonOnayla.Enabled = true;
            }
            else if (txtSifre.Text.Length > 7)
            {
                lblZorluk.BackColor = Color.Green;

                lblZorluk.Text = "Yüksek";
                btnKaydol.Enabled = true;
                btnAktivasyonOnayla.Enabled = true;
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


        Random rnd = new Random();
        string aktivasyonKodu;
        private void btnAktivasyonOnayla_Click(object sender, EventArgs e)
        {
            aktivasyonKodu = rnd.Next(100000, 999999).ToString();

            MailMessage mesaj = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("fohmkaloritakip@gmail.com", "znyj ajxp mjyl vvyh");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            mesaj.From = new MailAddress("fohmkaloritakip@gmail.com");
            mesaj.Subject = "Aktivasyon Kodu";
            mesaj.Body = "Aktivasyon kodunuz: " + aktivasyonKodu;
            mesaj.To.Add(txtEmail.Text);
            client.Send(mesaj);


            btnAktivasyonOnayla.Enabled = false;
            btnAktivasyonOnayla.Text = "Aktivasyon Kodu Gönderildi";

        }

    }
}
