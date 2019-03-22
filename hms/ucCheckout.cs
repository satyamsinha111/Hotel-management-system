using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hms
{
    public partial class ucCheckout : UserControl
    {
        public ucCheckout()
        {
            InitializeComponent();
        }
         private void ucCheckout_VisibleChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/checkins.xml");
            try
            {
                dgvCheckout.DataSource = ds.Tables[0];
            }
            catch
            {
                
            }
        }
          private void btnCheckout_Click(object sender, EventArgs e)
        {
            var id = dgvCheckout.SelectedRows[0].Cells[0].Value;
            XmlDocument doc = new XmlDocument();
            doc.Load("database/checkins.xml");
            XmlNodeList list = doc.SelectNodes("totalCheckins/Checkin");
            foreach (XmlNode node in list)
            {
                try
                {
                    if (node["Id"].InnerText == id.ToString())
                    {
                        node.ParentNode.RemoveChild(node);
                        pnlsuccessWindow.Show();
                        
                    }
                }
                catch
                {
                    continue;
                }

            }
            doc.Save("database/checkins.xml");
            DataSet ds = new DataSet();
            ds.ReadXml("database/checkins.xml");
            try
            {
                dgvCheckout.DataSource = ds.Tables[0];
                
            }
            catch
            {
                dgvCheckout.DataSource = null;
                MessageBox.Show("Empty database");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/checkins.xml");
            if (rdbtnName.Checked == true)
            {
                try
                {
                    ds.Tables[0].DefaultView.RowFilter = "Name ='" + txtSearch.Text + "'";
                    dgvCheckout.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("null search done");
                }
            }
            else if (rdBtnMobile.Checked == true)
            {
                try
                {
                    ds.Tables[0].DefaultView.RowFilter = "Mobile ='" + txtSearch.Text + "'";
                    dgvCheckout.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("null search done");
                }

            }
            else if (rdBtnId.Checked == true)
            {
                try
                {
                    ds.Tables[0].DefaultView.RowFilter = "Id ='" + txtSearch.Text + "'";
                    dgvCheckout.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("null search done");
                }
            }
            else
            {
                MessageBox.Show("No filters checked");
            }


        }

        private void rdBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/checkins.xml");
            try
            {
                dgvCheckout.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("No data in database");

            }
        }

        private void btnFailClose_Click(object sender, EventArgs e)
        {
            pnlFailwindow.Hide();
        }

        private void btnSucClose_Click(object sender, EventArgs e)
        {
            pnlsuccessWindow.Hide();
        }

        private void btnFailOk_Click(object sender, EventArgs e)
        {
            pnlFailwindow.Hide();
        }

        private void btnSucOK_Click(object sender, EventArgs e)
        {
            pnlsuccessWindow.Hide();
        }
    }
 }

