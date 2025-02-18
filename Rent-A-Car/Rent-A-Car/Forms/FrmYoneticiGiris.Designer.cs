namespace Rent_A_Car.Forms
{
    partial class FrmYoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiGiris));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.TxtParola = new DevExpress.XtraEditors.TextEdit();
            this.BtnParolaGizle = new DevExpress.XtraEditors.PictureEdit();
            this.BtnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnParolaGizle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 299);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Kullanıcı Adı:";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(139, 22);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(145, 145);
            this.pictureEdit3.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(84, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(255, 39);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "KızılCar Rent A Car";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(98, 335);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Parola:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(139, 296);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(145, 20);
            this.TxtKullaniciAdi.TabIndex = 13;
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(139, 332);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Properties.PasswordChar = '*';
            this.TxtParola.Size = new System.Drawing.Size(145, 20);
            this.TxtParola.TabIndex = 14;
            // 
            // BtnParolaGizle
            // 
            this.BtnParolaGizle.EditValue = ((object)(resources.GetObject("BtnParolaGizle.EditValue")));
            this.BtnParolaGizle.Location = new System.Drawing.Point(290, 332);
            this.BtnParolaGizle.Name = "BtnParolaGizle";
            this.BtnParolaGizle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.BtnParolaGizle.Properties.Appearance.Options.UseBackColor = true;
            this.BtnParolaGizle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnParolaGizle.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.BtnParolaGizle.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.BtnParolaGizle.Size = new System.Drawing.Size(25, 20);
            this.BtnParolaGizle.TabIndex = 15;
            this.BtnParolaGizle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnParolaGizle_MouseDown);
            this.BtnParolaGizle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnParolaGizle_MouseUp);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Appearance.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.Appearance.Options.UseFont = true;
            this.BtnGirisYap.Location = new System.Drawing.Point(160, 396);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(101, 32);
            this.BtnGirisYap.TabIndex = 16;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGeri.ImageOptions.Image")));
            this.BtnGeri.Location = new System.Drawing.Point(375, 428);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(39, 37);
            this.BtnGeri.TabIndex = 17;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(138, 227);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(150, 23);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Yönetici Giriş Paneli";
            // 
            // FrmYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 477);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.BtnParolaGizle);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmYoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYoneticiGiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmYoneticiGiris_FormClosed);
            this.Load += new System.EventHandler(this.FrmYoneticiGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnParolaGizle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit TxtParola;
        private DevExpress.XtraEditors.PictureEdit BtnParolaGizle;
        private DevExpress.XtraEditors.SimpleButton BtnGirisYap;
        private DevExpress.XtraEditors.SimpleButton BtnGeri;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}