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
    public partial class FrmAracIslemleri : Form
    {
        public FrmAracIslemleri()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Araclar", connection.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void ComboboxDoldur()
        {
            string query = "SELECT AracSinifID, SinifAdi FROM Tbl_AracSiniflari";


            SqlDataAdapter da = new SqlDataAdapter(query, connection.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ComboBox'a veri bağlama
            cmbSinif.DataSource = dt;
            cmbSinif.DisplayMember = "SinifAdi";  // Kullanıcıya gösterilecek değer
            cmbSinif.ValueMember = "AracSinifID"; // Seçildiğinde alınacak değer
            cmbSinif.SelectedIndex = -1;          // Varsayılan olarak hiçbir şey seçili değil

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
                string query1 = "SELECT COUNT(*) FROM Tbl_Araclar WHERE Plaka = @p1";
                SqlCommand command = new SqlCommand(query1, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                int kayitSayisi = (int)command.ExecuteScalar();
                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Kaydedilemedi. Bu plakaya sahip araç mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPlaka.Text = "";
                    return;
                }

                string query2 = "INSERT INTO Tbl_Araclar (Marka, Model, Plaka, GunlukUcret, Kilometre, BakimKilometreLimiti, AracSinifID) VALUES (@q1, @q2, @q3, @q4, @q5, @q6, @q7)";
                SqlCommand command2 = new SqlCommand(query2, connection.Baglanti());

                command2.Parameters.AddWithValue("@q1", TxtMarka.Text);
                command2.Parameters.AddWithValue("@q2", TxtModel.Text);
                command2.Parameters.AddWithValue("@q3", TxtPlaka.Text);
                command2.Parameters.AddWithValue("@q4", Decimal.Parse(TxtGunlukUcret.Text));
                command2.Parameters.AddWithValue("@q5", Convert.ToInt32(TxtKilometre.Text));
                command2.Parameters.AddWithValue("@q6", Convert.ToInt32(TxtBakimKilometreLimiti.Text));
                int secilenSinifID = Convert.ToInt32(cmbSinif.SelectedValue);
                command2.Parameters.AddWithValue("@q7", secilenSinifID);
                command2.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Araç başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAracIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            ComboboxDoldur();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Tbl_Araclar WHERE AracID=@p1";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();
                MessageBox.Show("Araç başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            {   //Marka, Model, Plaka, GunlukUcret, Kilometre, BakimKilometreLimiti, AracSinifID
                string query = "UPDATE Tbl_Araclar SET Marka=@p1, Model=@p2, Plaka=@p3, GunlukUcret=@p4, Kilometre=@p5, BakimKilometreLimiti=@p6, AracSinifID=@p7 WHERE AracID=@p8";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());

                command.Parameters.AddWithValue("@p1", TxtMarka.Text);
                command.Parameters.AddWithValue("@p2", TxtModel.Text);
                command.Parameters.AddWithValue("@p3", TxtPlaka.Text); 
                command.Parameters.AddWithValue("@p4", Decimal.Parse(TxtGunlukUcret.Text));
                command.Parameters.AddWithValue("@p5", Convert.ToInt32(TxtKilometre.Text));
                command.Parameters.AddWithValue("@p6", Convert.ToInt32(TxtBakimKilometreLimiti.Text));
                int secilenSinifID = Convert.ToInt32(cmbSinif.SelectedValue);
                command.Parameters.AddWithValue("@p7", secilenSinifID);
                command.Parameters.AddWithValue("@p8", TxtID.Text);
                command.ExecuteNonQuery();
                connection.Baglanti().Close();

                MessageBox.Show("Araç başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TxtID.Text = dr["AracID"].ToString();
            TxtMarka.Text = dr["Marka"].ToString();
            TxtModel.Text = dr["Model"].ToString();
            TxtPlaka.Text = dr["Plaka"].ToString();
            TxtGunlukUcret.Text = dr["GunlukUcret"].ToString();
            TxtKilometre.Text = dr["Kilometre"].ToString();
            TxtBakimKilometreLimiti.Text = dr["BakimKilometreLimiti"].ToString();
            cmbSinif.SelectedValue = (int)dr["AracSinifID"];
        }
    }
}
