using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace hms
{
    public partial class ucCheckin : UserControl
    {
        public ucCheckin()
        {
            InitializeComponent();
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("database/traffic.xml");
            XmlNode root = doc.SelectSingleNode("totalTraffic");
            XmlNode childnode = doc.CreateElement("traffic");
            XmlNode id = doc.CreateElement("Id");
            id.InnerText = Properties.Settings.Default.trafficId.ToString();
            childnode.AppendChild(id);
            XmlNode name = doc.CreateElement("Name");
            name.InnerText = txtName.Text;
            childnode.AppendChild(name);
            XmlNode mobile = doc.CreateElement("Mobile");
            mobile.InnerText = txtMobile.Text;
            childnode.AppendChild(mobile);
            XmlNode email = doc.CreateElement("E-Mail");
            email.InnerText = txtEmail.Text;
            childnode.AppendChild(email);
            XmlNode city = doc.CreateElement("City");
            city.InnerText = txtCity.Text;
            childnode.AppendChild(city);
            XmlNode country = doc.CreateElement("Country");
            country.InnerText = txtCountry.Text;
            childnode.AppendChild(country);
            XmlNode pin = doc.CreateElement("Pin-Code");
            pin.InnerText = txtPin.Text;
            childnode.AppendChild(pin);
            XmlNode state = doc.CreateElement("State");
            state.InnerText = txtState.Text;
            childnode.AppendChild(state);
            XmlNode bId = doc.CreateElement("BookingId");
            bId.InnerText = txtBooking.Text;
            childnode.AppendChild(bId);
            root.AppendChild(childnode);
            doc.Save("database/traffic.xml");
            Properties.Settings.Default.trafficId += 1;
            Properties.Settings.Default.Save();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("database/checkins.xml");
            XmlNode newRoot = xdoc.SelectSingleNode("totalCheckins");
            XmlNode chNode = xdoc.CreateElement("Checkin");
            XmlNode Id = xdoc.CreateElement("Id");
            Id.InnerText = Properties.Settings.Default.checkinId.ToString();
            chNode.AppendChild(Id);
            XmlNode nme = xdoc.CreateElement("Name");
            nme.InnerText = txtName.Text;
            chNode.AppendChild(nme);
            XmlNode mble = xdoc.CreateElement("Mobile");
            mble.InnerText = txtMobile.Text;
            chNode.AppendChild(mble);
            XmlNode inTime = xdoc.CreateElement("InTime");
            inTime.InnerText = DateTime.Now.ToString("HH:mm tt");
            chNode.AppendChild(inTime);
            XmlNode outTime = xdoc.CreateElement("OutTime");
            outTime.InnerText = "Not yet";
            chNode.AppendChild(outTime);
            newRoot.AppendChild(chNode);
            xdoc.Save("database/checkins.xml");
            Properties.Settings.Default.checkinId += 1;
            Properties.Settings.Default.Save();
            DataSet ds = new DataSet();
            ds.ReadXml("database/traffic.xml");
            try
            {
                dgvCheckins.DataSource = ds.Tables[0];
                MessageBox.Show("checked in successfully");
                lblSuccess.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkinId = 0;
            Properties.Settings.Default.trafficId = 0;
            Properties.Settings.Default.Save();
            MessageBox.Show("Reset done successfully");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/traffic.xml");
            if (rdBtnId.Checked == true)
            {
                try
                {
                    ds.Tables[0].DefaultView.RowFilter = "Id ='" + txtSearch.Text + "'";
                    dgvCheckins.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("No data in database");
                }
                
            }
            else if (rdBtnMobile.Checked == true)
            {
                ds.Tables[0].DefaultView.RowFilter = "Mobile ='" + txtSearch.Text + "'";
                dgvCheckins.DataSource = ds.Tables[0];

            }
            else if (rdBtnName.Checked == true)
            {
                ds.Tables[0].DefaultView.RowFilter = "Name ='" + txtSearch.Text + "'";
                dgvCheckins.DataSource = ds.Tables[0];
            }

        }

        private void rdbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/traffic.xml");
            dgvCheckins.DataSource = ds.Tables[0];
        }

        private void btnUpdte_Click(object sender, EventArgs e)
        {
          /*  try
            {
                var id = dgvCheckins.SelectedRows[0].Cells[0].Value;
                var name = dgvCheckins.SelectedRows[0].Cells[1].Value;
                var mobile = dgvCheckins.SelectedRows[0].Cells[2].Value;
                var email = dgvCheckins.SelectedRows[0].Cells[4].Value;
                var city = dgvCheckins.SelectedRows[0].Cells[4].Value;
                var count = dgvCheckins.SelectedRows[0].Cells[4].Value;
                var pin = dgvCheckins.SelectedRows[0].Cells[4].Value;
                var state = dgvCheckins.SelectedRows[0].Cells[4].Value;
                var bId = dgvCheckins.SelectedRows[0].Cells[4].Value;

                XDocument xmlDoc = XDocument.Load("database/traffic.xml");
                var items = xmlDoc.Descendants("traffic");
                foreach (var item in items)
                {
                    if (item.Element("Id").Value == id.ToString())
                    {
                        item.SetElementValue("Id", id.ToString());
                        item.SetElementValue("Name", name.ToString());
                        item.SetElementValue("Mobile", mobile.ToString());
                        item.SetElementValue("E-Mail", email.ToString());
                        item.SetElementValue("City", city.ToString());
                        item.SetElementValue("Country", count.ToString());
                        item.SetElementValue("Pin-Code", pin.ToString());
                        item.SetElementValue("State", state.ToString());
                        item.SetElementValue("BookingId", bId.ToString());
                    }
                    else
                    {
                        continue;
                    }
                }
                xmlDoc.Save("database/traffic.xml");
                DataSet ds = new DataSet();
                ds.ReadXml("database/traffic.xml");
                try
                {
                    dgvCheckins.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch
            {
                MessageBox.Show("Error occured");
            }*/
        }

        private void txtName_MouseDown(object sender, MouseEventArgs e)
        {
            lblSuccess.Hide();
        }

        private void dgvCheckins_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                pnlEditwindow.Visible = true;
                var name = dgvCheckins.SelectedRows[0].Cells[1].Value;
                var mobile = dgvCheckins.SelectedRows[0].Cells[2].Value;
                var email = dgvCheckins.SelectedRows[0].Cells[3].Value;
                var city = dgvCheckins.SelectedRows[0].Cells[4].Value;
                var count = dgvCheckins.SelectedRows[0].Cells[5].Value;
                var pin = dgvCheckins.SelectedRows[0].Cells[6].Value;
                var state = dgvCheckins.SelectedRows[0].Cells[7].Value;
                var bId = dgvCheckins.SelectedRows[0].Cells[8].Value;
                txtcName.Text = name.ToString();
                txtcMobile.Text = mobile.ToString();
                txtcEmail.Text = email.ToString();
                txtcCity.Text = city.ToString();
                txtcCount.Text = count.ToString();
                txtcPin.Text = pin.ToString();
                txtCState.Text = state.ToString();
                txtcBid.Text = bId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btneditclose_Click(object sender, EventArgs e)
        {
            pnlEditwindow.Hide();
        }

        private void btncUpdate_Click(object sender, EventArgs e)
        {
            var id = dgvCheckins.SelectedRows[0].Cells[0].Value;
            XDocument xmlDoc = XDocument.Load("database/traffic.xml");
            var items = xmlDoc.Descendants("traffic");
            foreach (var item in items)
            {
                if (item.Element("Id").Value == id.ToString())
                {

                    item.SetElementValue("Name", txtcName.Text);
                    item.SetElementValue("Mobile", txtcMobile.Text);
                    item.SetElementValue("E-Mail", txtcEmail.Text);
                    item.SetElementValue("City", txtcCity.Text);
                    item.SetElementValue("Country", txtcCount.Text);
                    item.SetElementValue("Pin-Code", txtcPin.Text);
                    item.SetElementValue("State", txtCState.Text);
                    item.SetElementValue("BookingId", txtcBid.Text);
                }
                else
                {
                    continue;
                }
            }
            xmlDoc.Save("database/traffic.xml");
            pnlEditwindow.Hide();
            DataSet ds = new DataSet();
            ds.ReadXml("database/traffic.xml");
            try
            {
                dgvCheckins.DataSource = ds.Tables[0];
                ucUpdateNotification1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btncDelete_Click(object sender, EventArgs e)
        {
            var id = dgvCheckins.SelectedRows[0].Cells[0].Value;
            XmlDocument doc = new XmlDocument();
            doc.Load("database/traffic.xml");
            XmlNodeList list = doc.SelectNodes("totalTraffic/traffic");
            foreach (XmlNode node in list)
            {
                try
                {
                    if (node["Id"].InnerText == id.ToString())
                    {
                        node.ParentNode.RemoveChild(node);
                    }
                }
                catch
                {
                    continue;
                }
            }
            doc.Save("database/traffic.xml");
            pnlEditwindow.Hide();
            DataSet ds = new DataSet();
            ds.ReadXml("database/traffic.xml");
            try
            {
                dgvCheckins.DataSource = ds.Tables[0];
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                dgvCheckins.Rows.Remove(dgvCheckins.SelectedRows[0]);
                MessageBox.Show(ex.Message);
            }
        }

        private void ucCheckin_Load(object sender, EventArgs e)
        {
            ucUpdateNotification1.Hide();
        }
        

        
    }
}
