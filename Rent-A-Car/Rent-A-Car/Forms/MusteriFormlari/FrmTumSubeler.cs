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

namespace Rent_A_Car.Forms.MusteriFormlari
{
    public partial class FrmTumSubeler : Form
    {
        public FrmTumSubeler()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void FrmTumSubeler_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
        private void VeriGetir()
        {
            string query1 = "SELECT COUNT(*) FROM Tbl_Kiralamalar";
            SqlCommand command = new SqlCommand(query1, connection.Baglanti());
            int kayitSayisi = (int)command.ExecuteScalar();
            LblKiralamaDeger.Text = "Bugüne kadar " + kayitSayisi + " kişi bizimle güvenle ve sorunsuz kirlama işlemi gerçekleştirdi.";
        }
    }
}
