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

namespace Rent_A_Car.Forms
{
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        public static FrmMusteriPaneli frm;
        public int musteriID;
        private void FrmMusteriGiris_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(213, 189, 175);
            TxtKullaniciAdi.Text = "musterideneme";
            TxtParola.Text = "1406993";
        }

        private void FrmMusteriGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            StartForm frm = new StartForm();
            frm.Show();
            this.Hide();
        }

        private void LblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            Forms.FrmSifremiUnuttum frm = new Forms.FrmSifremiUnuttum();
            frm.Show();
        }

        public void BtnGirisYap_Click(object sender, EventArgs e)
        {
            string Username = TxtKullaniciAdi.Text;
            string Password = TxtParola.Text;
            
            try
            {
                // SQL komutunu oluştur
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tbl_MusteriSifre WHERE KullaniciAdi=@username AND Parola=@password", conn.Baglanti());
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);

                // Sorguyu çalıştır ve sonuçları al
                int result = (int)cmd.ExecuteScalar(); // COUNT(*) değeri dönecek

                // Sonuç kontrolü (0 ise kullanıcı adı veya şifre yanlış)
                if (result > 0)
                {
                    //ID yi müsteri panel için degiskene ata
                    SqlCommand cmd2 = new SqlCommand("SELECT MusteriID FROM Tbl_MusteriSifre WHERE KullaniciAdi = @username", conn.Baglanti());
                    cmd2.Parameters.AddWithValue("@username", Username);
                    musteriID = Convert.ToInt32(cmd2.ExecuteScalar());
                    // Ana sayfaya geçiş
                    frm = new FrmMusteriPaneli();
                    frm.musteriID = musteriID;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Baglanti().Close();
            }
        }
        public int GetCustomerID()
        {
            int customerId = -1; // Varsayılan olarak geçersiz bir değer.

            try
            {
                // SQL sorgusunu oluşturuyoruz.
                SqlCommand cmd = new SqlCommand(
                    "SELECT MusteriID FROM Tbl_MusteriSifre WHERE KullaniciAdi = @username AND Parola = @password",
                    conn.Baglanti());

                // Parametreleri ekliyoruz.
                cmd.Parameters.AddWithValue("@username", TxtKullaniciAdi.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TxtParola.Text.Trim());
                
                // Sorguyu çalıştırıp sonucu alıyoruz.
                object result = cmd.ExecuteScalar();

                // Sonuç geçerli ise int'e çeviriyoruz.
                if (result != null)
                {
                    customerId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz.
                conn.Baglanti().Close();
            }

            return customerId;
        }

    }
}
