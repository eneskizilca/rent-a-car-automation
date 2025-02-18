using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.Forms.MusteriFormlari
{
    public partial class FrmBizeUlasin : Form
    {
        public FrmBizeUlasin()
        {
            InitializeComponent();
        }
        MailGonderici mailGonderici = new MailGonderici();
        private void BtnMailGonder_Click(object sender, EventArgs e)
        {
            mailGonderici.MailYollamaIslemiBizeUlasin(TxtIcerik.Text);
        }
    }
}
