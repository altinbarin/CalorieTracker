using FontAwesome.Sharp;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KaloriTakip_WFAUI
{
    public partial class KullaniciGirisi : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        KaloriHesaplamaDbContext context;
        OgunService ogunService = new OgunService();
        YemekService yemekService = new YemekService(); 
        KullaniciService kullaniciService = new KullaniciService();
        private static List<Kullanici> kullanici;
        public KullaniciGirisi(List<Kullanici> aktifKullanici)
        {
            InitializeComponent();
            kullanici = aktifKullanici;
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            
                //bilgileri güncelleyebilelim
                cmbOgun.DataSource = ogunService.OgunIsimlerListesi();
                cmbYemek.DataSource = yemekService.YemeklerIsimlerListesi();
                btnanasayfa.Enabled = false;

                lstBilgiler.FullRowSelect = true;
                lstBilgiler.View = View.Details;
                lstBilgiler.Columns.Add("Mail", 300);
                lstBilgiler.Columns.Add("Isim", 120);
                lstBilgiler.Columns.Add("Soyisim", 150);
                lstBilgiler.Columns.Add("Kilo", 70);
                lstBilgiler.Columns.Add("Boy", 70);
                lstBilgiler.Columns.Add("Cinsiyet", 120);

                var kullanici1 = kullaniciService.MaileGoreKullaniciGetir(kullanici[0].Mail);

                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = kullanici1.Mail;
                viewItem.SubItems.Add(kullanici1.Isim);
                viewItem.SubItems.Add(kullanici1.Soyisim);
                viewItem.SubItems.Add(kullanici1.Kilo.ToString() + " kg");
                viewItem.SubItems.Add(kullanici1.Boy.ToString() + " cm");
                viewItem.SubItems.Add(kullanici1.Cinsiyet.ToString());

                lstBilgiler.Items.Add(viewItem);


                lstUrunler.FullRowSelect = true;
                lstUrunler.View = View.Details;
                lstUrunler.Columns.Add("Yemek İsmi", 100);
                lstUrunler.Columns.Add("Kalori", 70);
                lstUrunler.Columns.Add("Porsiyon", 70);
                lstUrunler.Columns.Add("Toplam Kalori", 100);


           leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panel1.Controls.Add(leftBorderBtn);
        }
        private void Activate(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(172, 126, 241);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnOgunEkle1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OgunEkle(kullanici));
            btnanasayfa.Enabled = true;
        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GuncelleForm(kullanici));
            btnanasayfa.Enabled = true;
        }

        private void btnKullaniciRaporlari_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Raporlar(kullanici));
            btnanasayfa.Enabled = true;
        }



        private void Reset()    
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void btnBilgilerimiGuncelle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BilgilerimiGuncelle(kullanici));
            btnanasayfa.Enabled = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
