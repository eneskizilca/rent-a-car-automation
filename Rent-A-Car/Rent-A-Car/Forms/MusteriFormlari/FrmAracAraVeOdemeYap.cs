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

namespace Rent_A_Car
{
    public partial class FrmAracAra : Form
    {
        public int aracID;
        public int musteriID;
        public int subeID;
        public string subeAdi;
        public DateTime baslangicTarihi;
        public DateTime bitisTarihi;
        public int kiraGunSayisi;
        public int indirim;
        decimal toplamUcret;

        public FrmAracAra()
        {
            InitializeComponent();
            cmbAracAra.TextChanged += cmbAracAra_TextChanged;
        }

        Connection connection = new Connection();
        private void cmbAracArama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Listele()
        {
            string query = "SELECT A.AracID, A.Marka, A.Model, A.Plaka, A.GunlukUcret, A.Kilometre, A.BakimKilometreLimiti, A.MusaitMi, A.OlusturmaTarihi, S.SinifAdi FROM Tbl_Araclar AS A JOIN Tbl_AracSiniflari AS S ON A.AracSinifID = S.AracSinifID WHERE A.MusaitMi = 1";
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
                string query = "SELECT A.AracID, A.Marka, A.Model, A.Plaka, A.GunlukUcret, A.Kilometre, A.BakimKilometreLimiti, A.MusaitMi, A.OlusturmaTarihi, S.SinifAdi FROM Tbl_Araclar AS A JOIN Tbl_AracSiniflari AS S ON A.AracSinifID = S.AracSinifID WHERE A.MusaitMi = 1 AND A.Marka LIKE @p1";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAracAra_TextChanged(object sender, EventArgs e)
        {
            Filtrele(cmbAracAra.Text);
        }

        private void FrmAracAra_Load(object sender, EventArgs e)
        {
            ComboBoxDoldur();
            Filtrele(cmbAracAra.Text);
            LblSube.Text = subeAdi;
        }

        private void BtnOdemeyiTamamla_Click(object sender, EventArgs e)
        {
            KiralamaIslemiEkle();
            AracMusaitlikAyarla();
            ParayiKasayaAktar();
            Listele();
        }
        private void AracMusaitlikAyarla()
        {
            string query = @"
                    UPDATE Tbl_Araclar SET MusaitMi = 0 WHERE AracID =@p1 ";

            SqlCommand command = new SqlCommand(query, connection.Baglanti());
            command.Parameters.AddWithValue("@p1", aracID);
            command.ExecuteNonQuery();
        }
        private void KiralamaIslemiEkle()
        {
            // Gerekli değişkenlerden gelen değerler
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            aracID = Convert.ToInt32(dr["AracID"]);
            
            try
            {
                // SQL komutunu oluştur
                string query = @"
                    INSERT INTO Tbl_Kiralamalar (AracID, MusteriID, SubeID, BaslangicTarihi, BitisTarihi, ToplamUcret, IadeEdildiMi)
                    VALUES (@AracID, @MusteriID, @SubeID, @BaslangicTarihi, @BitisTarihi, @ToplamUcret, @IadeEdildiMi)";

                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@AracID", aracID);
                command.Parameters.AddWithValue("@MusteriID", musteriID);
                command.Parameters.AddWithValue("@SubeID", subeID);
                command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                command.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
                command.Parameters.AddWithValue("@ToplamUcret", toplamUcret);
                command.Parameters.AddWithValue("@IadeEdildiMi", false);

                // Komutu çalıştır
                int rowsAffected = command.ExecuteNonQuery();

                // Sonuç hakkında bilgi ver
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ödemeniz alındı. Kiralama işlemi başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Kiralama işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }
        private void ParayiKasayaAktar()
        {
            
            Connection connection = new Connection();
            try
            {
                // SQL komutunu oluştur
                string query = "UPDATE Tbl_Kasa SET KasadakiPara = KasadakiPara+@p1";
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@p1", toplamUcret);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata durumunda
                MessageBox.Show("Kasaya eklenirken bir  hata oluştu: " + ex.Message);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            LblMarka.Text = dr["Marka"].ToString();
            LblModel.Text = dr["Model"].ToString();
            LblSube.Text = subeAdi;
            LblAlisTarihi.Text = baslangicTarihi.ToString();
            LblIadeTarihi.Text = bitisTarihi.ToString();
            LblKiraGunSayisi.Text = kiraGunSayisi.ToString();
            toplamUcret = (Convert.ToDecimal(dr["GunlukUcret"]) * kiraGunSayisi * (100 - indirim) / 100);
            LblToplamUcret.Text = toplamUcret.ToString();
        }

        private void cmbAracAra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblKiraGunSayisi_Click(object sender, EventArgs e)
        {

        }

        private void LblIadeTarihi_Click(object sender, EventArgs e)
        {

        }

        private void LblAlisTarihi_Click(object sender, EventArgs e)
        {

        }

        private void LblSube_Click(object sender, EventArgs e)
        {

        }

        private void LblModel_Click(object sender, EventArgs e)
        {

        }

        private void LblMarka_Click(object sender, EventArgs e)
        {

        }

        private void LblToplamUcret_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
