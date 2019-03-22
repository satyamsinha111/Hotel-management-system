using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace hms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Authentication auth;
        frmAdmin admin;
        frmUser user;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            auth = new Authentication(txtUser.Text, txtPass.Text);
            admin = new frmAdmin();
            user = new frmUser();
            var Identity=auth.checkPass;
            if (Identity == "Admin")
            {

                this.Hide();
                admin = new frmAdmin();
                admin.Show();
            }
            else if (Identity == "User")
            {
                
                this.Hide();
                user = new frmUser();
                user.Show();
            }
            else
            {
                lblError.Show();
            }


        }

        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {
            lblError.Hide();
        }

        private void txtPass_MouseDown(object sender, MouseEventArgs e)
        {
            lblError.Hide();
        }


    }
}
