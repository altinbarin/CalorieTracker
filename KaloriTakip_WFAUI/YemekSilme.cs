using Kalori.Service.Concrete;

using KALORI.DATA.Entities;
using Kalori_DAL.Context;
using Kalori_DAL.ilk;
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
    public partial class YemekSilme : Form
    {
        KaloriHesaplamaDbContext context;
        public YemekSilme()
        {
            InitializeComponent();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
                                      
            YemekService yemekService = new YemekService();
            yemekService.Delete(yemekService.GetById(yemekService.YemekIsmineGoreYemekId(cmbYemeklerYemekSilme.SelectedItem.ToString())));
                         
            MessageBox.Show("Yemek silme başarılı");

            cmbYemeklerYemekSilme.DataSource = yemekService.YemeklerIsimlerListesi();

        }

        private void YemekSilme_Load(object sender, EventArgs e)
        {
            YemekService yemekService = new YemekService();

            cmbYemeklerYemekSilme.DataSource = yemekService.YemeklerIsimlerListesi();           
        }
    }
}
