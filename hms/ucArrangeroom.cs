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
    public partial class ucArrangeroom : UserControl
    {
        public ucArrangeroom()
        {
            InitializeComponent();
        }
        private void ucArrangeroom_VisibleChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/Rooms.xml");
            try
            {
                dgvRoom.DataSource = ds.Tables[0];
                
            }
            catch
            {
                dgvRoom.DataSource = null;
                
            }
        }
         private void btnAdd_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("database/Rooms.xml");
            XmlNode root = doc.SelectSingleNode("totalRooms");
            XmlNode chNode = doc.CreateElement("Room");
            XmlNode id = doc.CreateElement("Id");
            id.InnerText = Properties.Settings.Default.RoomId.ToString();
            chNode.AppendChild(id);
            XmlNode roomCapacity = doc.CreateElement("Room_Capacity");
            roomCapacity.InnerText = cbRoomcapacity.Text;
            chNode.AppendChild(roomCapacity);
            XmlNode prcePerDay = doc.CreateElement("Price_Per_Day");
            prcePerDay.InnerText = txtPrcPrdy.Text;
            chNode.AppendChild(prcePerDay);
            XmlNode advance = doc.CreateElement("Advance");
            advance.InnerText = cbRoomAdvance.Text;
            chNode.AppendChild(advance);
            XmlNode prcePerPpl = doc.CreateElement("Price_per_people");
            prcePerPpl.InnerText = txtPrcePRppl.Text;
            chNode.AppendChild(prcePerPpl);
            XmlNode availbility = doc.CreateElement("Availability");
            availbility.InnerText = cbRoomAvibty.Text;
            chNode.AppendChild(availbility);
            XmlNode emi = doc.CreateElement("Emi_Eligibility");
            emi.InnerText = cbEmieligilibility.Text;
            chNode.AppendChild(emi);
            XmlNode ac = doc.CreateElement("AC");
            if (rdBtnAcYes.Checked == true)
            {
                ac.InnerText = "Yes";
            }
            else
            {
                ac.InnerText = "No";

            }
            chNode.AppendChild(ac);
            XmlNode wifi = doc.CreateElement("WiFi");
            
            if (rdBtnWifiyes.Checked == true)
            {
                wifi.InnerText = "Yes";
            }
            else
            {
                wifi.InnerText = "No";
            }
            chNode.AppendChild(wifi);
            root.AppendChild(chNode);
            Properties.Settings.Default.RoomId += 1;
            Properties.Settings.Default.Save();
            doc.Save("database/Rooms.xml");
            DataSet ds = new DataSet();
            ds.ReadXml("database/Rooms.xml");
            try
            {
                dgvRoom.DataSource = ds.Tables[0];
                MessageBox.Show("Room added successfully");
            }
            catch
            {
                dgvRoom.DataSource = null;
                MessageBox.Show("Empty database");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/Rooms.xml");
            if (rdBtnId.Checked == true)
            {
                try
                {
                    ds.Tables[0].DefaultView.RowFilter = "Id ='" + txtSearchrst.Text + "'";
                    dgvRoom.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Please enter something");
                }
            }
            else if (rdBtnPrice.Checked == true)
            {
                try
                {
                    ds.Tables[0].DefaultView.RowFilter = "Price_Per_Day ='" + txtSearchrst.Text + "'";
                    dgvRoom.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Please enter something");
                }
            }
            else if (rdBtnCap.Checked == true)
            {
                try
                {
                    ds.Tables[0].DefaultView.RowFilter = "Room_Capacity ='" + cbCapSearch.Text + "'";
                    dgvRoom.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Please enter something");
                }
            }
            else
            {
                MessageBox.Show("Atfirst check any button");
            }
        }

        private void rdBtnCap_CheckedChanged(object sender, EventArgs e)
        {
            cbCapSearch.Visible = true;
            txtSearchrst.Visible = false;
        }

        private void rdBtnPrice_CheckedChanged(object sender, EventArgs e)
        {
            cbCapSearch.Visible = false;
            txtSearchrst.Visible = true;
        }

        private void rdBtnId_CheckedChanged(object sender, EventArgs e)
        {
            cbCapSearch.Visible = false;
            txtSearchrst.Visible = true;
        }

        private void rdbtnall_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("database/Rooms.xml");
            try
            {
                dgvRoom.DataSource = ds.Tables[0];

            }
            catch
            {
                dgvRoom.DataSource = null;
            }
        }

        
    }
 }

