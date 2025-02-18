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
    public partial class FrmAracTeslimAlma : Form
    {
        public FrmAracTeslimAlma()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        int seciliKiralamaID;
        int seciliKilometreDegeri;
        string seciliAracPlaka;
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT k.KiralamaID, k.BaslangicTarihi, k.BitisTarihi, k.ToplamUcret, k.IadeEdildiMi, a.Marka, a.Model, a.Plaka, a.Kilometre, m.AdSoyad, m.TCKimlikNo, s.SubeAdi FROM Tbl_Kiralamalar k JOIN Tbl_Araclar a ON k.AracID = a.AracID JOIN Tbl_Musteriler m ON k.MusteriID = m.MusteriID JOIN Tbl_Subeler s ON k.SubeID = s.SubeID WHERE k.IadeEdildiMi = 0"
            , connection.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmAracTeslimAlma_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnTeslimAl_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "UPDATE Tbl_Araclar SET Kilometre = @p1 WHERE Plaka=@p2";
                SqlCommand command1 = new SqlCommand(query1, connection.Baglanti());

                DataRow dr1 = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                seciliKilometreDegeri = Convert.ToInt32(dr1["Kilometre"]);
                seciliAracPlaka = dr1["Plaka"].ToString();

                command1.Parameters.AddWithValue("@p1", seciliKilometreDegeri);
                command1.Parameters.AddWithValue("@p2", seciliAracPlaka);
                command1.ExecuteNonQuery();

                string query2 = "UPDATE Tbl_Kiralamalar SET IadeEdildiMi=1 WHERE KiralamaID=@p1";
                SqlCommand command2 = new SqlCommand(query2, connection.Baglanti());

                DataRow dr2 = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                seciliKiralamaID = Convert.ToInt32(dr2["KiralamaID"]);

                command2.Parameters.AddWithValue("@p1", seciliKiralamaID);
                command2.ExecuteNonQuery();

                connection.Baglanti().Close();

                MessageBox.Show("Araç teslim alındı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
