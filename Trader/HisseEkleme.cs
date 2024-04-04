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
    public partial class HisseEkleme : Form
    {
        public HisseEkleme()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        void yukle()
        {
            var kategori = (from x in veriler.Kategori
                            select new
                            {
                                x.KategoriAd,
                                x.KategoriId
                            }).ToList();


            lookUpEdit1.Properties.DataSource = kategori;
        }

        private void HisseEkleme_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lookUpEdit1.Text != null)
            {
                var silinecek = veriler.Kategori.Find(lookUpEdit1.EditValue);
                veriler.Kategori.Remove(silinecek);
                veriler.SaveChanges();
                XtraMessageBox.Show("kategori silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
                yukle();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.KategoriAd = txbAd.Text;
            veriler.Kategori.Add(k);
            veriler.SaveChanges();
            XtraMessageBox.Show("kategori eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
            yukle();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
