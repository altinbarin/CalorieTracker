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
using FontAwesome.Sharp;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Kalori.Service.Concrete;

namespace KaloriTakip_WFAUI
{
    public partial class AdminSayfasi : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private static List<Kullanici> kullanici;
        KaloriHesaplamaDbContext context;
        YemekService yemekService = new YemekService();
        KategoriService kategoriService = new KategoriService();
        public AdminSayfasi(List<Kullanici> aktifKullanici)
        {
            InitializeComponent();
            kullanici = aktifKullanici;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panel1.Controls.Add(leftBorderBtn);
        }

        //Methods
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
                //LeftBorder button
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

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {

            button1.Enabled = false;

        }

        private void YemekEkleme_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminYemekEkle());
            button1.Enabled = true;
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

        private void YemekResim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new YemekResmiDeğiştir());
            button1.Enabled = true;
        }

        private void YemekSil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new YemekSilme());
            button1.Enabled = true;
        }

        private void KategoriEkleSil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KategoriEkleSil());
            button1.Enabled = true;
        }

        private void Raporlar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminRaporlar());
            button1.Enabled = true;
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
