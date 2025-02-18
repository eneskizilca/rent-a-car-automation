using GeoCoordinatePortable;
using System;
using System.Device;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace Rent_A_Car.Forms.MusteriFormlari
{
    public partial class FrmHizliKirala : Form
    {
        public FrmHizliKirala()
        {
            InitializeComponent();
            LoadSubeler();
        }
        public int musteriID;
        public int subeID;
        public string subeAdi;
        public DateTime baslangicTarihi;
        public DateTime bitisTarihi;
        public int kiraGunSayisi;
        public int indirimYuzdesi = 0;

        Connection connection = new Connection();

        private void LblIndirimKodu_Click(object sender, EventArgs e)
        {
            IndirimKoduGizleGoster();
        }
        private void IndirimKoduGizleGoster()
        {
            if (TxtIndırımKodu.Visible == true)
                TxtIndırımKodu.Visible = false;
            else
                TxtIndırımKodu.Visible = true;

            if (BtnIndırımSorgula.Visible == true)
                BtnIndırımSorgula.Visible = false;
            else
                BtnIndırımSorgula.Visible = true;
        }

        private async void simpleButton1_ClickAsync(object sender, EventArgs e)
        {
            
            string location = await GetLocationAsync2();
            MessageBox.Show(location, "Your Location");
        }
        private async Task<string> GetLocationAsync2()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://ip-api.com/json/");
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var locationData = JsonConvert.DeserializeObject<LocationResponse>(json);

                    return $"Latitude: {locationData.Lat}, Longitude: {locationData.Lon}, City: {locationData.City}";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        private async Task<string> GetLocationAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://ip-api.com/json/");
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var locationData = JsonConvert.DeserializeObject<LocationResponse>(json);

                    return $"Latitude: {locationData.Lat}, Longitude: {locationData.Lon}, City: {locationData.City}";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public class LocationResponse
        {
            public string City { get; set; }
            public double Lat { get; set; }
            public double Lon { get; set; }
        }


        public void BtnKirala_Click(object sender, EventArgs e)
        {
            try
            {
                // Teslim alma tarih ve saatini al
                DateTime teslimAlma = dateAlisTarih.DateTime.Date + timeAlisSaati.TimeSpan;

                // İade tarih ve saatini al
                DateTime iade = dateIadeTarih.DateTime.Date + timeIadeSaati.TimeSpan;

                // Tarihler arasındaki farkı hesapla
                TimeSpan fark = iade - teslimAlma;

                if (fark.TotalDays <= 0)
                {
                    MessageBox.Show("Geçersiz bir tarih aralığı seçtiniz.");
                    return;
                }

                // Gün sayısını al ve label'a yazdır
                int kiraGunSayisi = (int)Math.Ceiling(fark.TotalDays);

                // "Bir günlüğüne kirala" gibi mesaj oluştur
                string mesaj = $"{kiraGunSayisi} Günlüğüne kiralamayı onaylıyor musunuz?";

                // Mesajı MessageBox ile göster
                DialogResult sonuc = MessageBox.Show(mesaj, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    // Kullanıcı "Evet" dediğinde başka bir ekrana geçme işlemi

                    FrmAracAra frm = new FrmAracAra();
                    frm.subeID = Convert.ToInt32(lkpAlisSubeler.EditValue);
                    frm.subeAdi = lkpAlisSubeler.Text;
                    frm.baslangicTarihi = teslimAlma;
                    frm.bitisTarihi = iade;
                    frm.kiraGunSayisi = kiraGunSayisi;
                    frm.indirim = indirimYuzdesi;
                    frm.musteriID = musteriID;
                    
                    frm.MdiParent = FrmMusteriGiris.frm;
                    frm.Show(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private async void BtnAlisSubeKonum_ClickAsync(object sender, EventArgs e)
        {
            // Bilgisayarın mevcut konumunu al
            var currentLocation = await GetCurrentLocationAsync();

            // Karşılaştırılacak koordinatlar (örnek olarak belirliyoruz)
            var location1 = new Coordinate { Latitude = 38.670893, Longitude = 39.188987 }; // Şube 1 (Elazığ Merkez)
            var location2 = new Coordinate { Latitude = 38.600113, Longitude = 39.267880 };  // (Elazığ Havalimanı)

            // Mesafeleri hesapla
            double distanceToLocation1 = CalculateDistance(currentLocation, location1);
            double distanceToLocation2 = CalculateDistance(currentLocation, location2);

            // Daha yakın olanı belirle
            string closerLocation = distanceToLocation1 < distanceToLocation2
                ? "Şube 1 (Elazığ Merkez)"
                : "Şube 2 (Elazığ Havalimanı)";

            // Sonucu göster
            MessageBox.Show($"En yakın şube: {closerLocation}");
        }

        private async Task<Coordinate> GetCurrentLocationAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://ip-api.com/json/");
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var locationData = JsonConvert.DeserializeObject<LocationResponse>(json);

                    return new Coordinate
                    {
                        Latitude = locationData.Lat,
                        Longitude = locationData.Lon
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
                return null;
            }
        }


        private double CalculateDistance(Coordinate coord1, Coordinate coord2)
        {
            const double EarthRadiusKm = 6371; // Dünya'nın yarıçapı (km)
            double lat1 = DegreesToRadians(coord1.Latitude);
            double lon1 = DegreesToRadians(coord1.Longitude);
            double lat2 = DegreesToRadians(coord2.Latitude);
            double lon2 = DegreesToRadians(coord2.Longitude);

            double dLat = lat2 - lat1;
            double dLon = lon2 - lon1;

            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Pow(Math.Sin(dLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return EarthRadiusKm * c;
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private void FrmHizliKirala_Load(object sender, EventArgs e)
        {

        }
        private void LoadSubeler()
        {
            string query = "SELECT SubeID, SubeAdi FROM Tbl_Subeler";

            try
            {
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // LookUpEdit kontrolüne veriyi bağla
                lkpAlisSubeler.Properties.DataSource = dataTable;
                lkpAlisSubeler.Properties.DisplayMember = "SubeAdi"; // Görünen kolon
                lkpAlisSubeler.Properties.ValueMember = "SubeID";   // Seçildiğinde alınan değer
                

                // LookUpEdit kontrolüne veriyi bağla
                lkpIadeSubeler.Properties.DataSource = dataTable;
                lkpIadeSubeler.Properties.DisplayMember = "SubeAdi"; // Görünen kolon
                lkpIadeSubeler.Properties.ValueMember = "SubeID";   // Seçildiğinde alınan değer
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIndırımSorgula_Click(object sender, EventArgs e)
        {
            string kuponKodu = TxtIndırımKodu.Text; // TextEdit'e girilen kupon kodu
            string query = "SELECT IndirimMiktari FROM Tbl_KuponKodlari WHERE Kod = @Kod"; // Kupon kodu sorgusu

            try
            {
                SqlCommand command = new SqlCommand(query, connection.Baglanti());
                command.Parameters.AddWithValue("@Kod", kuponKodu);

                object result = command.ExecuteScalar(); // Sorguyu çalıştır

                if (result != null)
                {
                    indirimYuzdesi = Convert.ToInt32(result);
                    MessageBox.Show($"%{indirimYuzdesi} indirim kazandınız!", "Kupon Geçerli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kupon kodu geçerli değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void simpleButton2_ClickAsync(object sender, EventArgs e)
        {
            string location = await GetLocationAsync2();
            MessageBox.Show(location, "Your Location");
        }
    }

    public class Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    //public class LocationResponse
    //{
    //    public double Lat { get; set; }
    //    public double Lon { get; set; }
    //}
    public class LocationResponse
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}

