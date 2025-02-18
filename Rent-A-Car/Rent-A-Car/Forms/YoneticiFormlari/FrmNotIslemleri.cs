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
    public partial class FrmNotIslemleri : Form
    {
        public FrmNotIslemleri()
        {
            InitializeComponent();
        }

        private void FrmNotIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }
        Connection connection = new Connection();
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Notlar", connection.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            // İç içe kontrolleri gezmek için yardımcı metot
            void KontrolleriTemizle(Control parent)
            {
                foreach (Control ctrl in parent.Controls)
                {
                    // Eğer kontrol TextEdit ise (DevExpress)
                    if (ctrl is DevExpress.XtraEditors.TextEdit)
                    {
                        (ctrl as DevExpress.XtraEditors.TextEdit).Text = string.Empty;
                    }
                    // Eğer kontrol RichTextBox ise (Standart .NET kontrolü)
                    else if (ctrl is RichTextBox)
                    {
                        (ctrl as RichTextBox).Clear();
                    }
                    // Eğer kontrol MaskedTextBox ise (Standart .NET kontrolü)
                    else if (ctrl is MaskedTextBox)
                    {
                        (ctrl as MaskedTextBox).Text = string.Empty;
                    }

                    // Eğer kontrolün alt kontrolleri varsa, onları da temizle
                    if (ctrl.HasChildren)
                    {
                        KontrolleriTemizle(ctrl);
                    }
                }
            }

            // Ana formun kontrollerini temizleme işlemi başlat
            KontrolleriTemizle(this);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Tbl_Notlar (Konu, Icerik) VALUES (@q1, @q2)";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());

                command.Parameters.AddWithValue("@q1", TxtKonu.Text);
                command.Parameters.AddWithValue("@q2", TxtIcerik.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Not başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Tbl_Notlar WHERE NotID=@p1";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();
                MessageBox.Show("Not başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Tbl_Notlar SET Konu=@p1, Icerik=@p2 WHERE NotID=@p3";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());

                command.Parameters.AddWithValue("@p1", TxtKonu.Text);
                command.Parameters.AddWithValue("@p2", TxtIcerik.Text);
                command.Parameters.AddWithValue("@p3", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Not başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["NotID"].ToString();
            TxtKonu.Text = dr["Konu"].ToString();
            TxtIcerik.Text = dr["Icerik"].ToString();
        }
    }
}
