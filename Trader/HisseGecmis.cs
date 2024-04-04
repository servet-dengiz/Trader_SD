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
    public partial class HisseGecmis : Form
    {
        public HisseGecmis()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();

        void listele()
        {
            var hisseler = veriler.HisseSonuc.ToList();
            gridControl1.DataSource = hisseler;
        }

        private void HisseGecmis_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txbAd.Text = gridView1.GetFocusedRowCellValue("SatilanHisseAdi").ToString();
            tbxId.Text = gridView1.GetFocusedRowCellValue("SatilanHisseId").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {


                var x = int.Parse(tbxId.Text);
                var silinecek = veriler.HisseSonuc.Find(x);
                veriler.HisseSonuc.Remove(silinecek);
                veriler.SaveChanges();
                listele();


            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hisse Seciniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
