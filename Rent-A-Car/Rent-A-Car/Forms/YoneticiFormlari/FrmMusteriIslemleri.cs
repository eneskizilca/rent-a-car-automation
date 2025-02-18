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
    public partial class FrmMusteriIslemleri : Form
    {
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }

        private void FrmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }
        Connection connection = new Connection();
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteriler", connection.Baglanti());
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtID.Text))
            {
                MessageBox.Show("Lütfen müşteri seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = "DELETE FROM Tbl_Musteriler WHERE MusteriID=@p1";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", TxtID.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Musteri başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            MERNIS_Validator mernisValidator = new MERNIS_Validator();
            if (!mernisValidator.TCKimlikNoDogrula(TxtTC.Text))
            {
                MessageBox.Show("Kimlik bilgileriniz hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                // İlk sorgu
                string query1 = "INSERT INTO Tbl_Musteriler (AdSoyad, Eposta,Telefon, Adres, DogumTarihi, TCKimlikNo) VALUES (@q1, @q2, @q3, @q4, @q5, @q6)";
                SqlCommand command1 = new SqlCommand(query1, connection.Baglanti());
                command1.Parameters.AddWithValue("@q1", TxtAdSoyad.Text);
                command1.Parameters.AddWithValue("@q2", TxtMail.Text);
                command1.Parameters.AddWithValue("@q3", TxtTelefon.Text);
                command1.Parameters.AddWithValue("@q4", TxtAdres.Text);
                command1.Parameters.AddWithValue("@q5", Convert.ToDateTime(TxxtDogum.Text));
                command1.Parameters.AddWithValue("@q6", TxtTC.Text);
                command1.ExecuteNonQuery();

                // İkinci sorgu
                string query2 = "INSERT INTO Tbl_MusteriSifre (KullaniciAdi, Parola) VALUES (@p1, @p2)";
                SqlCommand command2 = new SqlCommand(query2, connection.Baglanti());
                command2.Parameters.AddWithValue("@p1", TxtKullAdi.Text);
                command2.Parameters.AddWithValue("@p2", TxtSifre.Text);
                command2.ExecuteNonQuery();

                // Tüm işlemler başarılı
                MessageBox.Show("Müşteri başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Temizlik işlemleri
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                connection.Baglanti().Close();
            }
        }

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

                MessageBox.Show("Müşteri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
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

        private void BtnListele_Click(object sender, EventArgs e)
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
