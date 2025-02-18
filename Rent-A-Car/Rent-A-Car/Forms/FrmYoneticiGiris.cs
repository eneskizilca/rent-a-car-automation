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
    public partial class FrmYoneticiGiris : Form
    {
        public FrmYoneticiGiris()
        {
            InitializeComponent();
        }

        private void FrmYoneticiGiris_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(213, 189, 175);
            TxtKullaniciAdi.Text = "eneskizilcar";
            TxtParola.Text = "18.Nisan.2004";
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            string Username = TxtKullaniciAdi.Text;
            string Password = TxtParola.Text;
            Connection conn = new Connection();
            try
            {
                // SQL komutunu oluştur
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tbl_AdminSifre WHERE KullaniciAdi=@username AND Parola=@password", conn.Baglanti());
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);

                // Sorguyu çalıştır ve sonuçları al
                int result = (int)cmd.ExecuteScalar(); // COUNT(*) değeri dönecek

                // Sonuç kontrolü (0 ise kullanıcı adı veya şifre yanlış)
                if (result > 0)
                {
                    // Ana sayfaya geçiş
                    Forms.FrmYoneticiPaneli frm = new Forms.FrmYoneticiPaneli();
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

        private void BtnParolaGizle_MouseUp(object sender, MouseEventArgs e)
        {
            TxtParola.Properties.PasswordChar = '*';
        }

        private void BtnParolaGizle_MouseDown(object sender, MouseEventArgs e)
        {
            TxtParola.Properties.PasswordChar = '\0';
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            StartForm frm = new StartForm();
            frm.Show();
            this.Hide();
        }

        private void FrmYoneticiGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
