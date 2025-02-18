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
    public partial class FrmYoneticiIstatistikChart : Form
    {
        public FrmYoneticiIstatistikChart()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void LblEnFazlaUrunuOlanMarka_Click(object sender, EventArgs e)
        {

        }
        private void VerileriGetir()
        {
            string query1 = "SELECT COUNT(*) FROM Tbl_Araclar";
            SqlCommand command1 = new SqlCommand(query1, connection.Baglanti());
            int kayitSayisi1 = (int)command1.ExecuteScalar();
            LblToplamAracSayisi.Text = kayitSayisi1.ToString();

            string query2 = "SELECT TOP 1 Marka FROM Tbl_Araclar GROUP BY Marka ORDER BY COUNT(*) DESC";
            SqlCommand command2 = new SqlCommand(query2, connection.Baglanti());
            string kayit2 = (string)command2.ExecuteScalar();
            LblEnFazlaUrunuOlanMarka.Text = kayit2.ToString();

            string query3 = "SELECT TOP 1 Marka FROM Tbl_Araclar ORDER BY GunlukUcret DESC";
            SqlCommand command3 = new SqlCommand(query3, connection.Baglanti());
            string kayit3 = (string)command3.ExecuteScalar();
            LblEnYuksekFiyatliMarka.Text = kayit3.ToString();

            string query4 = "SELECT COUNT(DISTINCT Marka) FROM Tbl_Araclar";
            SqlCommand command4 = new SqlCommand(query4, connection.Baglanti());
            int kayitSayisi4 = (int)command4.ExecuteScalar();
            LblToplamMarkaSayisi.Text = kayitSayisi4.ToString();

            string query = "SELECT Tbl_Araclar.Marka, Tbl_Araclar.Model, Tbl_AracSiniflari.SinifAdi " +
               "FROM Tbl_Araclar " +
               "INNER JOIN Tbl_AracSiniflari ON Tbl_Araclar.AracSinifID = Tbl_AracSiniflari.AracSinifID";


            SqlCommand command = new SqlCommand(query, connection.Baglanti()); 

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Grid'e veriyi bağla
            gridControl1.DataSource = dataTable;

            // chart 1
            string query6 = "SELECT Marka, COUNT(*) AS AracSayisi FROM Tbl_Araclar GROUP BY Marka";


            SqlCommand command6 = new SqlCommand(query6, connection.Baglanti());
            SqlDataReader dr1 = command6.ExecuteReader(); // Verileri oku

            // Pasta grafiğe veri ekle
            while (dr1.Read())
            {
                string marka = dr1["Marka"].ToString();              // Marka adı
                int aracSayisi = Convert.ToInt32(dr1["AracSayisi"]); // Araç sayısı

                // Grafiğe veri ekle

                chartControl1.Series["Markalar"].Points.AddPoint(marka, aracSayisi);
            }
            dr1.Close();
            // Etiketleri göster
            chartControl1.Series["Markalar"].Label.TextPattern = "{A}: {V} araç"; // Marka ve Araç Sayısı
            chartControl1.Series["Markalar"].Label.Font = new Font("Arial", 10); // Etiket fontu ayarı
            chartControl1.Series["Markalar"].Label.Visible = true; // Etiketleri göster

            // Tooltip ayarları

            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True; // Legend görünürlüğü



            // chart 2
            string query5 = "SELECT Tbl_AracSiniflari.SinifAdi, COUNT(Tbl_Araclar.AracID) AS AracSayisi " +
                "FROM Tbl_AracSiniflari " +
                "LEFT JOIN Tbl_Araclar ON Tbl_AracSiniflari.AracSinifID = Tbl_Araclar.AracSinifID " +
                "GROUP BY Tbl_AracSiniflari.SinifAdi";


            SqlCommand command5 = new SqlCommand(query5, connection.Baglanti());
            SqlDataReader dr2 = command5.ExecuteReader();

            while (dr2.Read())
            {
                // Grafik verisini doldur
                string sinifAdi = dr2["SinifAdi"].ToString();
                int aracSayisi = Convert.ToInt32(dr2["AracSayisi"]);

                // Chart kontrolüne veri ekle
                chartControl2.Series["Kategoriler"].Points.AddPoint(sinifAdi, aracSayisi);
            }
            dr2.Close();
        }
        private void FrmYoneticiIstatistikChart_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
    }
}
