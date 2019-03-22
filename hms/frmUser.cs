using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hms
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        frmLogin log;
        private void frmUser_Load(object sender, EventArgs e)
        {
            usDashboard1.Show();
            ucArrangeroom1.Hide();
            ucBookroom1.Hide();
            ucCheckin1.Hide();
            ucCheckout1.Hide();
            ucInvoice1.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            usDashboard1.Show();
            ucArrangeroom1.Hide();
            ucBookroom1.Hide();
            ucCheckin1.Hide();
            ucCheckout1.Hide();
            ucInvoice1.Hide();
        }

        private void btncheckin_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucArrangeroom1.Hide();
            ucBookroom1.Hide();
            ucCheckin1.Show();
            ucCheckout1.Hide();
            ucInvoice1.Hide();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucArrangeroom1.Hide();
            ucBookroom1.Hide();
            ucCheckin1.Hide();
            ucCheckout1.Show();
            ucInvoice1.Hide();
        }

        private void btnArrangeroom_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucArrangeroom1.Show();
            ucBookroom1.Hide();
            ucCheckin1.Hide();
            ucCheckout1.Hide();
            ucInvoice1.Hide();
        }

        private void btnBookroom_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucArrangeroom1.Hide();
            ucBookroom1.Show();
            ucCheckin1.Hide();
            ucCheckout1.Hide();
            ucInvoice1.Hide();
        }

        private void btnGenInvoice_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucArrangeroom1.Hide();
            ucBookroom1.Hide();
            ucCheckin1.Hide();
            ucCheckout1.Hide();
            ucInvoice1.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            log = new frmLogin();
            log.Show();
        }
    }
}
