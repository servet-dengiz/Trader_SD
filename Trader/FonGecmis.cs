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
    public partial class FonGecmis : Form
    {
        public FonGecmis()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();
        void listele()
        {
            var fonlar = veriler.FonSonuc.ToList();
            gridControl1.DataSource = fonlar;
        }

        private void FonGecmis_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                txbAd.Text = gridView1.GetFocusedRowCellValue("SatilanFon").ToString();
                
                fonId.Text= gridView1.GetFocusedRowCellValue("SatilanFonId").ToString();
            }
            catch (Exception)
            {


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var x = int.Parse(fonId.Text);
                var silinecek = veriler.FonSonuc.Find(x);
                veriler.FonSonuc.Remove(silinecek);
                veriler.SaveChanges();
                listele();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Fon Seciniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
