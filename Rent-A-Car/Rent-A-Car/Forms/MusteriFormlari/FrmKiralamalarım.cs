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

namespace Rent_A_Car.Forms.MusteriFormlari
{
    public partial class FrmKiralamalarım : Form
    {
        public FrmKiralamalarım()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public int musteriID;
        private void Listele()
        {
            DataTable dt = new DataTable();
            string query = "SELECT k.KiralamaID, k.BaslangicTarihi, k.BitisTarihi, k.ToplamUcret, k.IadeEdildiMi, a.Marka, a.Model, a.Plaka, a.Kilometre, m.AdSoyad, m.TCKimlikNo, s.SubeAdi FROM Tbl_Kiralamalar k JOIN Tbl_Araclar a ON k.AracID = a.AracID JOIN Tbl_Musteriler m ON k.MusteriID = m.MusteriID JOIN Tbl_Subeler s ON k.SubeID = s.SubeID WHERE m.MusteriID = @p1";
            SqlCommand command = new SqlCommand(query, connection.Baglanti());
            command.Parameters.AddWithValue("@p1", musteriID);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmKiralamalarım_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
