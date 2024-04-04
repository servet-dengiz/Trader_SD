using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trader
{
    public partial class FonAl : Form
    {
        public FonAl()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbAd.Text != "" && txbAdet.Text != "" && txbFiyat.Text != "" && txbTarih.Text != "")
                {
                    Fon f = new Fon();
                    f.FonAd = txbAd.Text;
                    f.Fiyat = decimal.Parse(txbFiyat.Text);
                    f.Adet = int.Parse(txbAdet.Text);
                    f.AlmaTarih = txbTarih.DateTime;
                    f.Toplam = decimal.Parse(txbFiyat.Text) * int.Parse(txbAdet.Text);
                    veriler.Fon.Add(f);
                    veriler.SaveChanges();
                    XtraMessageBox.Show("Fon alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("boş kutucuk bırakmayın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FonAl_Load(object sender, EventArgs e)
        {

        }
    }
}
