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
    public partial class FrmAracListesiVeArama : Form
    {
        public FrmAracListesiVeArama()
        {
            InitializeComponent();
            cmbAracAra.TextChanged += cmbAracAra_TextChanged;
        }
        Connection connection = new Connection();
        private void Listele()
        {
            string query = "SELECT A.AracID, A.Marka, A.Model, A.Plaka, A.GunlukUcret, A.Kilometre, A.BakimKilometreLimiti, A.MusaitMi, A.OlusturmaTarihi, S.SinifAdi FROM Tbl_Araclar AS A JOIN Tbl_AracSiniflari AS S ON A.AracSinifID = S.AracSinifID";
            SqlDataAdapter da = new SqlDataAdapter(query, connection.Baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        public void ComboBoxDoldur()
        {
            try
            {
                string query = "SELECT Marka FROM Tbl_Araclar";
                SqlCommand cmd = new SqlCommand(query, connection.Baglanti());
                SqlDataReader dr = cmd.ExecuteReader();

                // ComboBox AutoComplete ayarları
                AutoCompleteStringCollection araclar = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    string markaAdi = dr["Marka"].ToString();
                    cmbAracAra.Items.Add(markaAdi);
                    araclar.Add(markaAdi); // Otomatik tamamlama için ekleme
                }

                dr.Close();

                cmbAracAra.AutoCompleteCustomSource = araclar;
                cmbAracAra.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbAracAra.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Baglanti().Close();
            }
        }
        public void Filtrele(string arama)
        {
            try
            {
                string query = "SELECT A.AracID, A.Marka, A.Model, A.Plaka, A.GunlukUcret, A.Kilometre, A.BakimKilometreLimiti, A.MusaitMi, A.OlusturmaTarihi, S.SinifAdi FROM Tbl_Araclar AS A JOIN Tbl_AracSiniflari AS S ON A.AracSinifID = S.AracSinifID WHERE A.Marka LIKE @p1";
                SqlDataAdapter da = new SqlDataAdapter(query, connection.Baglanti());
                da.SelectCommand.Parameters.AddWithValue("@p1", arama + "%"); // Başlayan kelimeler için filtre
                DataSet ds = new DataSet();
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAracAra_TextChanged(object sender, EventArgs e)
        {
            Filtrele(cmbAracAra.Text);
        }

        private void FrmAracListesiVeArama_Load(object sender, EventArgs e)
        {
            ComboBoxDoldur();
            Filtrele(cmbAracAra.Text);
        }
    }
}
