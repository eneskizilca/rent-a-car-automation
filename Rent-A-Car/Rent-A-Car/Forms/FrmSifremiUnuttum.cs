using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rent_A_Car.Forms
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }
        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(213, 189, 175);
        }
        private void WhatappMesajiYolla(string kullaniciAdi)
        {
            if (kullaniciAdi != "")
            {
                object telefonNo = GetTelefonNo(kullaniciAdi);

                if (telefonNo != null)
                {
                    string telefon = telefonNo.ToString();
                    string yeniParola = UpdatePassword(kullaniciAdi);
                    string mesaj = $"KızılCar için yeni şifreniz: {yeniParola}";
                    System.Diagnostics.Process.Start($"https://api.whatsapp.com/send?phone=" + telefon + "&text=" + mesaj);
                }
                else
                {
                    Console.WriteLine("Kullanıcı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adi giriniz!");
            }
        }
        private void MailYolla(string kullaniciAdi)
        {
            if (kullaniciAdi != "")
            {
                object mailAddres = GetMail(kullaniciAdi);
                MailYollamaIslemi(mailAddres.ToString(), kullaniciAdi);
            }
            else
            {
                MessageBox.Show("Kullanıcı adi giriniz!");
            }

        }
        private object GetTelefonNo(string kullaniciAdi)
        {
            Connection conn = new Connection();
            string sorgu = @"
                SELECT m.Telefon
                FROM Tbl_MusteriParola mp
                INNER JOIN Tbl_Musteriler m ON mp.MusteriID = m.MusteriID
                WHERE mp.KullaniciAdi = @KullaniciAdi;";
            SqlCommand command = new SqlCommand(sorgu, conn.Baglanti());
            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

            object telefonNo = command.ExecuteScalar(); // Tek bir değer dönecek.
            return telefonNo;
        }
        private void MailYollamaIslemi(string mailAddres, string kullaniciAdi)
        {
            try
            {
                // Gönderenin bilgileri
                string senderEmail = "235541116@firat.edu.tr";
                string senderPassword = "dyjj ysyc rpgy kftu";

                // Alıcının e-posta adresi
                string recipientEmail = mailAddres;
                //sifre üret
                string yeniParola = UpdatePassword(kullaniciAdi);
                // E-posta ayarları
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = "KızılCar Şifre Değiştirme";
                mail.Body = "KızılCar için yeni şifreniz: " + yeniParola;
                mail.IsBodyHtml = false; // Eğer HTML formatında göndermek istiyorsanız true yapabilirsiniz.

                // SMTP ayarları
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true; // Gmail için SSL gereklidir.
                smtp.Send(mail);

                MessageBox.Show("E-posta başarıyla gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-posta gönderilirken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private object GetMail(string kullaniciAdi)
        {
            Connection conn = new Connection();
            string sorgu = @"
                SELECT m.Eposta
                FROM Tbl_MusteriParola mp
                INNER JOIN Tbl_Musteriler m ON mp.MusteriID = m.MusteriID
                WHERE mp.KullaniciAdi = @KullaniciAdi;";
            SqlCommand command = new SqlCommand(sorgu, conn.Baglanti());
            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

            object mail = command.ExecuteScalar(); // Tek bir değer dönecek.
            return mail;
        }
        public static string UpdatePassword(string kullaniciAdi)
        {
            Connection conn = new Connection();
            // 7 haneli rastgele sayı üret
            Random random = new Random();
            string yeniParola = random.Next(1000000, 10000000).ToString(); // 7 haneli sayı üret

            // SQL sorgusu
            string query = "UPDATE Tbl_MusteriParola SET Parola = @YeniParola WHERE KullaniciAdi = @KullaniciAdi";

            SqlCommand command = new SqlCommand(query, conn.Baglanti());
            // Parametreleri ekle
            command.Parameters.AddWithValue("@YeniParola", yeniParola);
            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

            // Sorguyu çalıştır
            command.ExecuteNonQuery();
            return yeniParola;
        }

        private void BtnWhatsapp_Click(object sender, EventArgs e)
        {
            WhatappMesajiYolla(TxtKullaniciAdi.Text);
        }

        private void BtnMail_Click(object sender, EventArgs e)
        {
            MailYolla(TxtKullaniciAdi.Text);
        }
    }
}
