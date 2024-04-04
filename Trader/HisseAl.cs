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
    public partial class HisseAl : Form
    {
        public HisseAl()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();
        private void HisseAl_Load(object sender, EventArgs e)
        {

            var kategori = (from x in veriler.Kategori
                            select new
                            {
                                x.KategoriAd,
                                x.KategoriId
                            }).ToList();


            lookUpEdit1.Properties.DataSource = kategori;
        }

        private void txbAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (lookUpEdit1.Text != "" && txbAdet.Text != "" && txbFiyat.Text != "" && dateEdit1.Text != "")
                {
                    Hisse h = new Hisse();
                    h.HisseAd = lookUpEdit1.Text;
                    h.Fiyat = decimal.Parse(txbFiyat.Text);
                    h.Adet = int.Parse(txbAdet.Text);
                    h.AlmaTarihi = dateEdit1.DateTime;
                    h.Toplam = decimal.Parse(txbFiyat.Text) * int.Parse(txbAdet.Text);
                    h.Kategori  =int.Parse( lookUpEdit1.EditValue.ToString() );
                    veriler.Hisse.Add(h);
                    veriler.SaveChanges();
                    XtraMessageBox.Show("hisse alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    XtraMessageBox.Show("boş kutucuk bırakmayın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
