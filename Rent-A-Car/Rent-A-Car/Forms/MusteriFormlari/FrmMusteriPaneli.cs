using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class FrmMusteriPaneli : Form
    {
        public FrmMusteriPaneli()
        {
            InitializeComponent();
        }
        public int musteriID;

        private void BtnHizliKirala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.MusteriFormlari.FrmHizliKirala frm = new Forms.MusteriFormlari.FrmHizliKirala();
            frm.musteriID = musteriID;
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMusteriPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMusteriPaneli_Load(object sender, EventArgs e)
        {

        }

        private void BtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void BtnMailKutusu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/1/#inbox");
        }

        private void BtnTümAraçlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.MusteriFormlari.FrmTumAraclar frm = new Forms.MusteriFormlari.FrmTumAraclar();
            frm.MdiParent = this;
            frm.Show();
        }

        public void BtnAracAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAracAra frm = new FrmAracAra();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.notion.com/product/calendar");
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void BtnDovizKurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmKurlar fr = new Forms.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/");
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void BtnBizeUlasin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.MusteriFormlari.FrmBizeUlasin frm = new Forms.MusteriFormlari.FrmBizeUlasin();
            frm.Show();
        }

        private void BtnHesapBilgilerim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.MusteriFormlari.FrmBilgilerim frm = new Forms.MusteriFormlari.FrmBilgilerim();
            frm.musteriID = musteriID;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.MusteriFormlari.FrmKiralamalarım frm = new Forms.MusteriFormlari.FrmKiralamalarım();
            frm.musteriID = musteriID;
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnSubeIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.MusteriFormlari.FrmTumSubeler frm = new Forms.MusteriFormlari.FrmTumSubeler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
