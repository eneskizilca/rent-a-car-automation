using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.Forms
{
    public partial class FrmYoneticiPaneli : Form
    {
        public FrmYoneticiPaneli()
        {
            InitializeComponent();
        }

        private void BtnAracSinifListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmAracSinifIslemleri frm = new Forms.YoneticiFormlari.FrmAracSinifIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void FrmYoneticiPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSubeIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmSubeIslemleri frm = new Forms.YoneticiFormlari.FrmSubeIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKuponKodIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmKuponKodIslemleri frm = new Forms.YoneticiFormlari.FrmKuponKodIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnMailKutusu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/1/#inbox");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnDovizKurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmKurlar fr = new Forms.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmMusteriIslemleri frm = new Forms.YoneticiFormlari.FrmMusteriIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmRehber frm = new Forms.YoneticiFormlari.FrmRehber();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnMailGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmMailGonder frm = new Forms.YoneticiFormlari.FrmMailGonder();
            frm.Show();
        }

        private void BtnMesajYolla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmMesajGonder frm = new Forms.YoneticiFormlari.FrmMesajGonder();
            frm.Show();
        }

        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmNotIslemleri frm = new Forms.YoneticiFormlari.FrmNotIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/");
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void BtnAracTeslimAlma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmAracTeslimAlma frm = new Forms.YoneticiFormlari.FrmAracTeslimAlma();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKiralamaHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmKiralamaHareketleri frm = new Forms.YoneticiFormlari.FrmKiralamaHareketleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnFaturaOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmRaporSihirbazi frm = new Forms.YoneticiFormlari.FrmRaporSihirbazi();
            frm.Show();
        }

        private void BtnGenelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmYoneticiIstatistikChart frm = new Forms.YoneticiFormlari.FrmYoneticiIstatistikChart();
            frm.MdiParent = this;
            frm.Show();
        }
        
        private void BtnAracListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmAracListesiVeArama frm = new Forms.YoneticiFormlari.FrmAracListesiVeArama();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKartIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYoneticiIstatistikKart frm = new FrmYoneticiIstatistikKart();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnAracIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.YoneticiFormlari.FrmAracIslemleri frm = new Forms.YoneticiFormlari.FrmAracIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
