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
    public partial class KategoriEkleSil : Form
    {
        KaloriHesaplamaDbContext context;
        public KategoriEkleSil()
        {
            InitializeComponent();
        }
        KategoriService kategoriService = new KategoriService();
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori() { Isim = txtKategoriIsmi.Text };

            kategoriService.Create(kategori);

            MessageBox.Show("Kategori Eklendi");

            cmbKategoriSilmeKategoriler.DataSource = kategoriService.KategoriIsimlerListesi();
            txtKategoriIsmi.Clear();

        }

        private void btnKategoriSilme_Click(object sender, EventArgs e)
        {

            kategoriService.Delete(kategoriService
                .GetById(kategoriService
                .KategoriIsmineGoreKategoriId(cmbKategoriSilmeKategoriler.SelectedItem.ToString())));
            MessageBox.Show("İlgili Kategori Silindi");

            cmbKategoriSilmeKategoriler.DataSource = kategoriService.KategoriIsimlerListesi();

        }

        private void KategoriEkleSil_Load(object sender, EventArgs e)
        {
            cmbKategoriSilmeKategoriler.DataSource = kategoriService.KategoriIsimlerListesi();
        }
    }
}
