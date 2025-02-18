namespace Rent_A_Car
{
    partial class FrmAracAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracAra));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbAracAra = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblKiraGunSayisi = new System.Windows.Forms.Label();
            this.LblIadeTarihi = new System.Windows.Forms.Label();
            this.LblAlisTarihi = new System.Windows.Forms.Label();
            this.LblSube = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblMarka = new System.Windows.Forms.Label();
            this.LblToplamUcret = new System.Windows.Forms.Label();
            this.BtnOdemeyiTamamla = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.cmbAracAra);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1910, 836);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // cmbAracAra
            // 
            this.cmbAracAra.FormattingEnabled = true;
            this.cmbAracAra.Location = new System.Drawing.Point(783, 122);
            this.cmbAracAra.Name = "cmbAracAra";
            this.cmbAracAra.Size = new System.Drawing.Size(376, 21);
            this.cmbAracAra.TabIndex = 2;
            this.cmbAracAra.SelectedIndexChanged += new System.EventHandler(this.cmbAracAra_SelectedIndexChanged);
            this.cmbAracAra.TextChanged += new System.EventHandler(this.cmbAracAra_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(730, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(484, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = " Aramak İstediğiniz Aracın Markasını Giriniz ";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.LblKiraGunSayisi);
            this.panel1.Controls.Add(this.LblIadeTarihi);
            this.panel1.Controls.Add(this.LblAlisTarihi);
            this.panel1.Controls.Add(this.LblSube);
            this.panel1.Controls.Add(this.LblModel);
            this.panel1.Controls.Add(this.LblMarka);
            this.panel1.Controls.Add(this.LblToplamUcret);
            this.panel1.Controls.Add(this.BtnOdemeyiTamamla);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1537, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 617);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LblKiraGunSayisi
            // 
            this.LblKiraGunSayisi.AutoSize = true;
            this.LblKiraGunSayisi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKiraGunSayisi.ForeColor = System.Drawing.Color.White;
            this.LblKiraGunSayisi.Location = new System.Drawing.Point(69, 486);
            this.LblKiraGunSayisi.Name = "LblKiraGunSayisi";
            this.LblKiraGunSayisi.Size = new System.Drawing.Size(34, 25);
            this.LblKiraGunSayisi.TabIndex = 17;
            this.LblKiraGunSayisi.Text = "18";
            this.LblKiraGunSayisi.Click += new System.EventHandler(this.LblKiraGunSayisi_Click);
            // 
            // LblIadeTarihi
            // 
            this.LblIadeTarihi.AutoSize = true;
            this.LblIadeTarihi.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIadeTarihi.ForeColor = System.Drawing.Color.White;
            this.LblIadeTarihi.Location = new System.Drawing.Point(101, 399);
            this.LblIadeTarihi.Name = "LblIadeTarihi";
            this.LblIadeTarihi.Size = new System.Drawing.Size(126, 26);
            this.LblIadeTarihi.TabIndex = 16;
            this.LblIadeTarihi.Text = "15/10/2025";
            this.LblIadeTarihi.Click += new System.EventHandler(this.LblIadeTarihi_Click);
            // 
            // LblAlisTarihi
            // 
            this.LblAlisTarihi.AutoSize = true;
            this.LblAlisTarihi.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAlisTarihi.ForeColor = System.Drawing.Color.White;
            this.LblAlisTarihi.Location = new System.Drawing.Point(101, 313);
            this.LblAlisTarihi.Name = "LblAlisTarihi";
            this.LblAlisTarihi.Size = new System.Drawing.Size(126, 26);
            this.LblAlisTarihi.TabIndex = 15;
            this.LblAlisTarihi.Text = "12/10/2025";
            this.LblAlisTarihi.Click += new System.EventHandler(this.LblAlisTarihi_Click);
            // 
            // LblSube
            // 
            this.LblSube.AutoSize = true;
            this.LblSube.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSube.ForeColor = System.Drawing.Color.White;
            this.LblSube.Location = new System.Drawing.Point(101, 230);
            this.LblSube.Name = "LblSube";
            this.LblSube.Size = new System.Drawing.Size(199, 26);
            this.LblSube.TabIndex = 14;
            this.LblSube.Text = "Elazığ Merkez Şube";
            this.LblSube.Click += new System.EventHandler(this.LblSube_Click);
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblModel.ForeColor = System.Drawing.Color.White;
            this.LblModel.Location = new System.Drawing.Point(101, 148);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(58, 26);
            this.LblModel.TabIndex = 13;
            this.LblModel.Text = "Egea";
            this.LblModel.Click += new System.EventHandler(this.LblModel_Click);
            // 
            // LblMarka
            // 
            this.LblMarka.AutoSize = true;
            this.LblMarka.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMarka.ForeColor = System.Drawing.Color.White;
            this.LblMarka.Location = new System.Drawing.Point(101, 68);
            this.LblMarka.Name = "LblMarka";
            this.LblMarka.Size = new System.Drawing.Size(55, 26);
            this.LblMarka.TabIndex = 12;
            this.LblMarka.Text = "FIAT";
            this.LblMarka.Click += new System.EventHandler(this.LblMarka_Click);
            // 
            // LblToplamUcret
            // 
            this.LblToplamUcret.AutoSize = true;
            this.LblToplamUcret.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamUcret.ForeColor = System.Drawing.Color.White;
            this.LblToplamUcret.Location = new System.Drawing.Point(158, 514);
            this.LblToplamUcret.Name = "LblToplamUcret";
            this.LblToplamUcret.Size = new System.Drawing.Size(69, 19);
            this.LblToplamUcret.TabIndex = 11;
            this.LblToplamUcret.Text = "12999,99";
            this.LblToplamUcret.Click += new System.EventHandler(this.LblToplamUcret_Click);
            // 
            // BtnOdemeyiTamamla
            // 
            this.BtnOdemeyiTamamla.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdemeyiTamamla.Appearance.Options.UseFont = true;
            this.BtnOdemeyiTamamla.Location = new System.Drawing.Point(108, 555);
            this.BtnOdemeyiTamamla.Name = "BtnOdemeyiTamamla";
            this.BtnOdemeyiTamamla.Size = new System.Drawing.Size(155, 39);
            this.BtnOdemeyiTamamla.TabIndex = 10;
            this.BtnOdemeyiTamamla.Text = "Ödemeyi Tamamla";
            this.BtnOdemeyiTamamla.Click += new System.EventHandler(this.BtnOdemeyiTamamla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(99, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Günlük Toplam Ücret";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 45);
            this.label6.TabIndex = 8;
            this.label6.Text = "İade Tarihi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alış Tarihi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şube";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "₺";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1531, 620);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FrmAracAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 836);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAracAra";
            this.Text = "FrmAracAra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAracAra_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cmbAracAra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblIadeTarihi;
        private System.Windows.Forms.Label LblAlisTarihi;
        private System.Windows.Forms.Label LblSube;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblMarka;
        private System.Windows.Forms.Label LblToplamUcret;
        private DevExpress.XtraEditors.SimpleButton BtnOdemeyiTamamla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblKiraGunSayisi;
    }
}