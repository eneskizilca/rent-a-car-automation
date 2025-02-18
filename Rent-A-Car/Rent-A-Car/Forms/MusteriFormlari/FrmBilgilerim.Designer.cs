namespace Rent_A_Car.Forms.MusteriFormlari
{
    partial class FrmBilgilerim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgilerim));
            this.TxxtDogum = new System.Windows.Forms.MaskedTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtTC = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.TxtKullaniciAdi = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi)).BeginInit();
            this.TxtKullaniciAdi.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnGuncelle.Location = new System.Drawing.Point(184, 390);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(91, 39);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
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
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1464, 837);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // TxtKullaniciAdi
            // 
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
            this.TxtKullaniciAdi.Controls.Add(this.labelControl2);
            this.TxtKullaniciAdi.Controls.Add(this.TxtAdSoyad);
            this.TxtKullaniciAdi.Controls.Add(this.labelControl1);
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(1470, 0);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(441, 837);
            this.TxtKullaniciAdi.TabIndex = 11;
            this.TxtKullaniciAdi.Text = "Müsteri İşlemleri";
            // 
            // FrmBilgilerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 836);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBilgilerim";
            this.Text = "FrmBilgilerim";
            this.Load += new System.EventHandler(this.FrmBilgilerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi)).EndInit();
            this.TxtKullaniciAdi.ResumeLayout(false);
            this.TxtKullaniciAdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox TxxtDogum;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.MaskedTextBox TxtTC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl TxtKullaniciAdi;
    }
}