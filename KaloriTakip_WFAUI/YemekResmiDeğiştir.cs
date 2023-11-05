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
    public partial class YemekResmiDeğiştir : Form
    {
        KaloriHesaplamaDbContext context;
        YemekService yemekService = new YemekService();
        public YemekResmiDeğiştir()
        {
            InitializeComponent();
            using (context = new KaloriHesaplamaDbContext())
            {
                cmbYemekler.DataSource = yemekService.YemeklerIsimlerListesi();

            }
        }

        private byte[] resimBytes;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (context = new KaloriHesaplamaDbContext())
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string resimYolu = openFileDialog1.FileName;

                    // Seçilen resmi bir Image nesnesine yükle
                    Image resim = Image.FromFile(resimYolu);

                    pictureBox1.Image = resim;


                    using (MemoryStream ms = new MemoryStream())
                    {
                        resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        resimBytes = ms.ToArray();
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                yemekService.ResimGuncelle(yemekService.GetById(yemekService.YemekIsmineGoreYemekId(cmbYemekler.Text)), resimBytes);
                
                MessageBox.Show("Ekleme başarılı");
                         
        }

        private void cmbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYemekler.SelectedItem != null)
            {
                using (context = new KaloriHesaplamaDbContext())
                {
                    var yemekFotografi = context.Yemekler
                        .Where(x => x.Isim == cmbYemekler.SelectedItem.ToString())
                        .Select(x => x.YemekResmi)
                        .FirstOrDefault();

                    if (yemekFotografi != null)
                    {
                        pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(yemekFotografi));
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir değer seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
    }
}
