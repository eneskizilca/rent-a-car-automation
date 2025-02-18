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
    public partial class FrmAracSinifIslemleri : Form
    {
        public FrmAracSinifIslemleri()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_AracSiniflari", connection.Baglanti());
            da.Fill(dt);
            gridAracSiniflari.DataSource = dt;
        }

        private void AracSinifListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan değer
            string sinifAdi = TxtAd.Text.Trim();

            if (string.IsNullOrEmpty(sinifAdi))
            {
                MessageBox.Show("Lütfen sınıf adı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                string query1 = "SELECT COUNT(*) FROM Tbl_AracSiniflari WHERE SinifAdi = @p1";
                SqlCommand command = new SqlCommand(query1, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", sinifAdi);
                int kayitSayisi = (int)command.ExecuteScalar();
                if(kayitSayisi > 0)
                {
                    MessageBox.Show("Kaydedilemedi. Bu değer mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtAd.Text = "";
                    return;
                }


                string query2 = "INSERT INTO Tbl_AracSiniflari (SinifAdi) VALUES (@q1)";
                SqlCommand command2 = new SqlCommand(query2, connection.Baglanti());

                command2.Parameters.AddWithValue("@q1", sinifAdi);
                command2.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Sınıf başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                TxtAd.Text = "";
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
                string query = "DELETE FROM Tbl_AracSiniflari WHERE AracSinifID=@p1";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();
                MessageBox.Show("Sınıf başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "UPDATE Tbl_AracSiniflari SET SinifAdi=@p1 WHERE AracSinifID=@p2";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());

                command.Parameters.AddWithValue("@p1", TxtAd.Text);
                command.Parameters.AddWithValue("@p2", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Sınıf başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TxtID.Text = dr["AracSinifID"].ToString();
            TxtAd.Text = dr["SinifAdi"].ToString();
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Tbl_AracSiniflari SET SinifAdi=@p1 WHERE AracSinifID=@p2";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());

                command.Parameters.AddWithValue("@p1", TxtAd.Text);
                command.Parameters.AddWithValue("@p2", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Sınıf başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
