using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.Forms.YoneticiFormlari
{
    public partial class FrmKiralamaHareketleri : Form
    {
        public FrmKiralamaHareketleri()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void Listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT k.KiralamaID, k.BaslangicTarihi, k.BitisTarihi, k.ToplamUcret, k.IadeEdildiMi, a.Marka, a.Model, a.Plaka, a.Kilometre, m.AdSoyad, m.TCKimlikNo, s.SubeAdi FROM Tbl_Kiralamalar k JOIN Tbl_Araclar a ON k.AracID = a.AracID JOIN Tbl_Musteriler m ON k.MusteriID = m.MusteriID JOIN Tbl_Subeler s ON k.SubeID = s.SubeID"
            , connection.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void ApplyRowStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            gridView.RowStyle += (sender, e) =>
            {
                // GridView'i al
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                // Sadece veri satırlarını kontrol et
                if (e.RowHandle >= 0)
                {
                    // "IadeEdildiMi" sütunundaki değeri kontrol et
                    var cellValue = view.GetRowCellValue(e.RowHandle, "IadeEdildiMi");

                    // Eğer değer false (veya 0) ise satır rengini değiştir
                    if (cellValue is bool isReturned && isReturned == false)
                    {
                        e.Appearance.BackColor = Color.Red; // Arka plan rengi kırmızı
                        e.Appearance.ForeColor = Color.White; // Yazı rengini beyaz yap
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.White; // Varsayılan renk (isteğe bağlı)
                        e.Appearance.ForeColor = Color.Black; // Varsayılan yazı rengi
                    }
                }
            };
        }


        private void FrmKiralamaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
            ApplyRowStyle(gridView1);
        }
        
    }
}
