using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(213, 189, 175);
        }


        private void BtnYoneticiGiris_MouseClick(object sender, MouseEventArgs e)
        {
            Forms.FrmYoneticiGiris frm = new Forms.FrmYoneticiGiris();
            this.Hide();
            frm.Show();
        }

        private void BtnMusteriGiris_MouseClick(object sender, MouseEventArgs e)
        {
            Forms.FrmMusteriGiris frm = new Forms.FrmMusteriGiris();
            this.Hide();
            frm.Show();
        }
    }
}
