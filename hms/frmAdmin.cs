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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        frmLogin log;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            usDashboard1.Show();
            ucIssues1.Hide();
            ucRooms1.Hide();
            uctotalBooking1.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            usDashboard1.Show();
            ucIssues1.Hide();
            ucRooms1.Hide();
            uctotalBooking1.Hide();
        }

        private void btntotalBooking_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucIssues1.Hide();
            ucRooms1.Hide();
            uctotalBooking1.Show();


        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucIssues1.Show();
            ucRooms1.Hide();
            uctotalBooking1.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            usDashboard1.Hide();
            ucIssues1.Hide();
            ucRooms1.Show();
            uctotalBooking1.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            log = new frmLogin();
            log.Show();

        }
    }
}
