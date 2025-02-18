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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        private void FrmRehber_Load(object sender, EventArgs e)
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
    }
}
