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
    public partial class AdminYemekEkle : Form
    {
        KaloriHesaplamaDbContext context;
            Yemek yeniYemek;
            YemekService yemekService = new YemekService();
            KategoriService kategoriService = new KategoriService();
        public AdminYemekEkle()
        {
            InitializeComponent();
        }

        private byte[] yeniResimBytes;
        private void btnYeniYemekEkle_Click(object sender, EventArgs e)
        {

            if (txtIsim.Text == "" || pbYeniYemekResmi.Image is null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < yemekService.YemeklerIsimlerListesi().Count; i++)
                {
                            if (txtIsim.Text == yemekService.YemeklerIsimlerListesi()[i])
                            {
                                MessageBox.Show("Seçtiğiniz yemek mevcuttur. Lütfen başka yemek ekleyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {                                                                                             
                                yeniYemek = new Yemek()
                                {
                                    Isim = txtIsim.Text.Trim(),
                                    Kalori = (int)nmrKalori.Value,
                                    KategoriId = kategoriService.KategoriIsmineGoreKategoriId(cmbKategoriler.Text),
                                    YemekResmi = yeniResimBytes
                                };

                                yemekService.Create(yeniYemek);
                               
                                MessageBox.Show("Yemek ekleme başarılı");

                                //clear metodu olabilir
                                txtIsim.Text = "";
                                nmrKalori.Value = 1;
                                cmbKategoriler.SelectedIndex = 0;

                               return;
                            }
                }
            }                        
        }

        private void AdminYemekEkle_Load(object sender, EventArgs e)
        {           
            cmbKategoriler.DataSource = kategoriService.KategoriIsimlerListesi();
        }

        private void btnYeniYemekResimSec_Click(object sender, EventArgs e)
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

                    pbYeniYemekResmi.Image = resim;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        yeniResimBytes = ms.ToArray();
                    }
                }
            
        }
    }
}
