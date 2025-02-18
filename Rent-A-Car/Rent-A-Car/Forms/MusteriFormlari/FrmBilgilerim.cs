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
    public partial class FrmBilgilerim : Form
    {
        public FrmBilgilerim()
        {
            InitializeComponent();
        }
        public int musteriID;

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            MERNIS_Validator mernisValidator = new MERNIS_Validator();
            if (!mernisValidator.TCKimlikNoDogrula(TxtTC.Text))
            {
                MessageBox.Show("Kimlik bilgileriniz hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = "UPDATE Tbl_Musteriler SET AdSoyad=@p1, Eposta=@p2, Telefon=@p3, Adres=@p4, DogumTarihi=@p5, TCKimlikNo=@p6 WHERE MusteriID=@p7";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());

                command.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                command.Parameters.AddWithValue("@p2", TxtMail.Text);
                command.Parameters.AddWithValue("@p3", TxtTelefon.Text);
                command.Parameters.AddWithValue("@p4", TxtAdres.Text);
                command.Parameters.AddWithValue("@p5", Convert.ToDateTime(TxxtDogum.Text));
                command.Parameters.AddWithValue("@p6", TxtTC.Text);
                command.Parameters.AddWithValue("@p7", TxtID.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Bilgileriniz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
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
        Connection connection = new Connection();
        private void Listele()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Musteriler WHERE MusteriID = @p1", connection.Baglanti());
            command.Parameters.AddWithValue("@p1", musteriID);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmBilgilerim_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["MusteriID"].ToString();
            TxtAdSoyad.Text = dr["AdSoyad"].ToString();
            TxtMail.Text = dr["Eposta"].ToString();
            TxtTelefon.Text = dr["Telefon"].ToString();
            TxtAdres.Text = dr["Adres"].ToString();
            TxxtDogum.Text = dr["DogumTarihi"].ToString();
            TxtTC.Text = dr["TCKimlikNo"].ToString();
        }
    }
}
