namespace Rent_A_Car.Forms.YoneticiFormlari
{
    partial class FrmMusteriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriIslemleri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKullaniciAdi = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.TxtKullAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxxtDogum = new System.Windows.Forms.MaskedTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtTC = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi)).BeginInit();
            this.TxtKullaniciAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1464, 837);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(131, 177);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(204, 20);
            this.TxtMail.TabIndex = 22;
            // 
            // TxtID
            // 
            this.TxtID.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtID.Location = new System.Drawing.Point(131, 101);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(204, 20);
            this.TxtID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(72, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Müşteri ID:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(139, 541);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(91, 39);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(236, 541);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(91, 39);
            this.BtnListele.TabIndex = 17;
            this.BtnListele.Text = "Listele";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(236, 496);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(91, 39);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(139, 496);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(91, 39);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(103, 180);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mail:";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(131, 138);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(204, 20);
            this.TxtAdSoyad.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ad Soyad:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Controls.Add(this.groupControl2);
            this.TxtKullaniciAdi.Controls.Add(this.TxxtDogum);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl6);
            this.TxtKullaniciAdi.Controls.Add(this.TxtTelefon);
            this.TxtKullaniciAdi.Controls.Add(this.TxtTC);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl5);
            this.TxtKullaniciAdi.Controls.Add(this.TxtAdres);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl3);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl4);
            this.TxtKullaniciAdi.Controls.Add(this.TxtMail);
            this.TxtKullaniciAdi.Controls.Add(this.TxtID);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl7);
            this.TxtKullaniciAdi.Controls.Add(this.BtnGuncelle);
            this.TxtKullaniciAdi.Controls.Add(this.BtnListele);
            this.TxtKullaniciAdi.Controls.Add(this.BtnSil);
            this.TxtKullaniciAdi.Controls.Add(this.BtnKaydet);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl2);
            this.TxtKullaniciAdi.Controls.Add(this.TxtAdSoyad);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl1);
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(1470, 0);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(441, 837);
            this.TxtKullaniciAdi.TabIndex = 9;
            this.TxtKullaniciAdi.Text = "Hesap İşlemleri";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.TxtSifre);
            this.groupControl2.Controls.Add(this.TxtKullAdi);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Location = new System.Drawing.Point(131, 377);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(204, 100);
            this.groupControl2.TabIndex = 37;
            this.groupControl2.Text = "GİRİŞ BİLGİLERİ";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(65, 69);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(134, 20);
            this.TxtSifre.TabIndex = 34;
            // 
            // TxtKullAdi
            // 
            this.TxtKullAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtKullAdi.Location = new System.Drawing.Point(65, 32);
            this.TxtKullAdi.Name = "TxtKullAdi";
            this.TxtKullAdi.Size = new System.Drawing.Size(134, 20);
            this.TxtKullAdi.TabIndex = 36;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(33, 72);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 33;
            this.labelControl9.Text = "Şifre:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 13);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "Kullnıcı Adı:";
            // 
            // TxxtDogum
            // 
            this.TxxtDogum.Location = new System.Drawing.Point(131, 289);
            this.TxxtDogum.Mask = "00/00/0000";
            this.TxxtDogum.Name = "TxxtDogum";
            this.TxxtDogum.Size = new System.Drawing.Size(204, 21);
            this.TxxtDogum.TabIndex = 32;
            this.TxxtDogum.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(59, 292);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Doğum Tarihi:";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(131, 215);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(204, 21);
            this.TxtTelefon.TabIndex = 30;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(131, 332);
            this.TxtTC.Mask = "00000000000";
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(204, 21);
            this.TxtTC.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(108, 335);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(17, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "TC:";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(131, 254);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(204, 20);
            this.TxtAdres.TabIndex = 26;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(93, 257);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Adres:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(85, 218);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Telefon:";
            // 
            // FrmMusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1910, 836);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMusteriIslemleri";
            this.Text = "FrmMusteriIslemleri";
            this.Load += new System.EventHandler(this.FrmMusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi)).EndInit();
            this.TxtKullaniciAdi.ResumeLayout(false);
            this.TxtKullaniciAdi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl TxtKullaniciAdi;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.MaskedTextBox TxtTC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox TxxtDogum;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.TextEdit TxtKullAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}