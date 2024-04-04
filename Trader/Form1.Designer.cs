namespace Trader
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSifre = new DevExpress.XtraEditors.TextEdit();
            this.txbKullanici = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydol = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txbSifre
            // 
            this.txbSifre.Location = new System.Drawing.Point(223, 353);
            this.txbSifre.Margin = new System.Windows.Forms.Padding(5);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbSifre.Properties.Appearance.Options.UseFont = true;
            this.txbSifre.Size = new System.Drawing.Size(187, 30);
            this.txbSifre.TabIndex = 2;
            // 
            // txbKullanici
            // 
            this.txbKullanici.Location = new System.Drawing.Point(223, 303);
            this.txbKullanici.Margin = new System.Windows.Forms.Padding(5);
            this.txbKullanici.Name = "txbKullanici";
            this.txbKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbKullanici.Properties.Appearance.Options.UseFont = true;
            this.txbKullanici.Size = new System.Drawing.Size(187, 30);
            this.txbKullanici.TabIndex = 1;
            // 
            // btnKaydol
            // 
            this.btnKaydol.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydol.Appearance.Options.UseFont = true;
            this.btnKaydol.ImageOptions.Image = global::Trader.Properties.Resources.kaydolButton;
            this.btnKaydol.Location = new System.Drawing.Point(417, 484);
            this.btnKaydol.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(125, 41);
            this.btnKaydol.TabIndex = 4;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.ImageOptions.Image = global::Trader.Properties.Resources.girisButton;
            this.btnGiris.Location = new System.Drawing.Point(223, 421);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(187, 53);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giris";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit1.EditValue = global::Trader.Properties.Resources.cikis;
            this.pictureEdit1.Location = new System.Drawing.Point(541, 14);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(60, 60);
            this.pictureEdit1.TabIndex = 5;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trader.Properties.Resources.giris;
            this.ClientSize = new System.Drawing.Size(615, 828);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.txbKullanici);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txbSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txbSifre;
        private DevExpress.XtraEditors.TextEdit txbKullanici;
        private DevExpress.XtraEditors.SimpleButton btnKaydol;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
    }
}

