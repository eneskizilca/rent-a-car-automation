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
    public partial class FrmSubeIslemleri : Form
    {
        public FrmSubeIslemleri()
        {
            InitializeComponent();
        }

        Connection connection = new Connection();
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Subeler", connection.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmSubeIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text))
            {
                MessageBox.Show("Lütfen şube adı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query1 = "SELECT COUNT(*) FROM Tbl_Subeler WHERE SubeAdi = @p1";
                SqlCommand command = new SqlCommand(query1, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", TxtAd.Text);
                int kayitSayisi = (int)command.ExecuteScalar();
                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Kaydedilemedi. Bu değer mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtAd.Text = "";
                    return;
                }

                string query2 = "INSERT INTO Tbl_Subeler (SubeAdi, Enlem, Boylam, Sehir) VALUES (@q1, @q2, @q3, @q4)";
                SqlCommand command2 = new SqlCommand(query2, connection.Baglanti());

                command2.Parameters.AddWithValue("@q1", TxtAd.Text);
                command2.Parameters.AddWithValue("@q2", Decimal.Parse(TxtEnlem.Text));
                command2.Parameters.AddWithValue("@q3", Decimal.Parse(TxtBoylam.Text));
                command2.Parameters.AddWithValue("@q4", TxtSehir.Text);
                command2.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Şube başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "DELETE FROM Tbl_Subeler WHERE SubeID=@p1";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();
                MessageBox.Show("Şube başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "UPDATE Tbl_Subeler SET SubeAdi=@p1, Enlem=@p2, Boylam=@p3, Sehir=@p4 WHERE SubeID=@p5";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());

                command.Parameters.AddWithValue("@p1", TxtAd.Text);
                command.Parameters.AddWithValue("@p2", decimal.Parse(TxtEnlem.Text));
                command.Parameters.AddWithValue("@p3", decimal.Parse(TxtBoylam.Text));
                command.Parameters.AddWithValue("@p4", TxtSehir.Text);
                command.Parameters.AddWithValue("@p5", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Şube başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TxtID.Text = dr["SubeID"].ToString();
            TxtAd.Text = dr["SubeAdi"].ToString();
            TxtEnlem.Text = dr["Enlem"].ToString();
            TxtBoylam.Text = dr["Boylam"].ToString();
            TxtSehir.Text = dr["Sehir"].ToString();
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
