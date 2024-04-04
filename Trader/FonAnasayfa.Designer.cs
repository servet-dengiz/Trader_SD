namespace Trader
{
    partial class FonAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.btnGecmis = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnFonSat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFonAl = new DevExpress.XtraEditors.SimpleButton();
            this.btnPortfoy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(249, 35);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 39);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "FONLAR";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::Trader.Properties.Resources.fonAltGif;
            this.pictureEdit2.Location = new System.Drawing.Point(13, 596);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(590, 220);
            this.pictureEdit2.TabIndex = 37;
            // 
            // btnGecmis
            // 
            this.btnGecmis.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmis.Appearance.Options.UseFont = true;
            this.btnGecmis.ImageOptions.Image = global::Trader.Properties.Resources.fonGecmisButtonum;
            this.btnGecmis.Location = new System.Drawing.Point(135, 486);
            this.btnGecmis.Margin = new System.Windows.Forms.Padding(5);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(345, 70);
            this.btnGecmis.TabIndex = 21;
            this.btnGecmis.Text = "Geçmiş";
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit1.EditValue = global::Trader.Properties.Resources.geriDonS1;
            this.pictureEdit1.Location = new System.Drawing.Point(541, 14);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(60, 60);
            this.pictureEdit1.TabIndex = 19;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // btnFonSat
            // 
            this.btnFonSat.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFonSat.Appearance.Options.UseFont = true;
            this.btnFonSat.ImageOptions.Image = global::Trader.Properties.Resources.fonSilButtonum;
            this.btnFonSat.Location = new System.Drawing.Point(135, 366);
            this.btnFonSat.Margin = new System.Windows.Forms.Padding(5);
            this.btnFonSat.Name = "btnFonSat";
            this.btnFonSat.Size = new System.Drawing.Size(345, 70);
            this.btnFonSat.TabIndex = 17;
            this.btnFonSat.Text = "Fon Sat";
            this.btnFonSat.Click += new System.EventHandler(this.btnFonSat_Click);
            // 
            // btnFonAl
            // 
            this.btnFonAl.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFonAl.Appearance.Options.UseFont = true;
            this.btnFonAl.ImageOptions.Image = global::Trader.Properties.Resources.fonEkleButtonum;
            this.btnFonAl.Location = new System.Drawing.Point(135, 246);
            this.btnFonAl.Margin = new System.Windows.Forms.Padding(5);
            this.btnFonAl.Name = "btnFonAl";
            this.btnFonAl.Size = new System.Drawing.Size(345, 70);
            this.btnFonAl.TabIndex = 16;
            this.btnFonAl.Text = "Fon Al";
            this.btnFonAl.Click += new System.EventHandler(this.btnFonAl_Click);
            // 
            // btnPortfoy
            // 
            this.btnPortfoy.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPortfoy.Appearance.Options.UseFont = true;
            this.btnPortfoy.ImageOptions.Image = global::Trader.Properties.Resources.portfoyButton1;
            this.btnPortfoy.Location = new System.Drawing.Point(135, 126);
            this.btnPortfoy.Margin = new System.Windows.Forms.Padding(5);
            this.btnPortfoy.Name = "btnPortfoy";
            this.btnPortfoy.Size = new System.Drawing.Size(345, 70);
            this.btnPortfoy.TabIndex = 15;
            this.btnPortfoy.Text = "Pörtföyüm";
            this.btnPortfoy.Click += new System.EventHandler(this.btnPortfoy_Click);
            // 
            // FonAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(615, 828);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnFonSat);
            this.Controls.Add(this.btnFonAl);
            this.Controls.Add(this.btnPortfoy);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FonAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FonAnasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGecmis;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnFonSat;
        private DevExpress.XtraEditors.SimpleButton btnFonAl;
        private DevExpress.XtraEditors.SimpleButton btnPortfoy;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}