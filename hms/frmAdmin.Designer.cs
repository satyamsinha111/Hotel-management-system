namespace hms
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnIssues = new System.Windows.Forms.Button();
            this.btntotalBooking = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.usDashboard1 = new hms.usDashboard();
            this.uctotalBooking1 = new hms.uctotalBooking();
            this.ucIssues1 = new hms.ucIssues();
            this.ucRooms1 = new hms.ucRooms();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 108);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(510, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin panel";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(370, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel management system";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnRooms);
            this.panel2.Controls.Add(this.btnIssues);
            this.panel2.Controls.Add(this.btntotalBooking);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 440);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(15, 222);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.DarkRed;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRooms.Location = new System.Drawing.Point(15, 180);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(188, 40);
            this.btnRooms.TabIndex = 4;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnIssues
            // 
            this.btnIssues.BackColor = System.Drawing.Color.DarkRed;
            this.btnIssues.FlatAppearance.BorderSize = 0;
            this.btnIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssues.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssues.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIssues.Location = new System.Drawing.Point(15, 138);
            this.btnIssues.Name = "btnIssues";
            this.btnIssues.Size = new System.Drawing.Size(188, 40);
            this.btnIssues.TabIndex = 3;
            this.btnIssues.Text = "Issues reported";
            this.btnIssues.UseVisualStyleBackColor = false;
            this.btnIssues.Click += new System.EventHandler(this.btnIssues_Click);
            // 
            // btntotalBooking
            // 
            this.btntotalBooking.BackColor = System.Drawing.Color.DarkRed;
            this.btntotalBooking.FlatAppearance.BorderSize = 0;
            this.btntotalBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntotalBooking.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotalBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntotalBooking.Location = new System.Drawing.Point(15, 96);
            this.btntotalBooking.Name = "btntotalBooking";
            this.btntotalBooking.Size = new System.Drawing.Size(188, 40);
            this.btntotalBooking.TabIndex = 2;
            this.btntotalBooking.Text = "Total bookings";
            this.btntotalBooking.UseVisualStyleBackColor = false;
            this.btntotalBooking.Click += new System.EventHandler(this.btntotalBooking_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkRed;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Location = new System.Drawing.Point(14, 54);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(188, 40);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // usDashboard1
            // 
            this.usDashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usDashboard1.BackColor = System.Drawing.Color.DarkRed;
            this.usDashboard1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usDashboard1.Location = new System.Drawing.Point(222, 109);
            this.usDashboard1.Name = "usDashboard1";
            this.usDashboard1.Size = new System.Drawing.Size(860, 437);
            this.usDashboard1.TabIndex = 5;
            // 
            // uctotalBooking1
            // 
            this.uctotalBooking1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uctotalBooking1.BackColor = System.Drawing.Color.DarkRed;
            this.uctotalBooking1.Location = new System.Drawing.Point(222, 109);
            this.uctotalBooking1.Name = "uctotalBooking1";
            this.uctotalBooking1.Size = new System.Drawing.Size(860, 437);
            this.uctotalBooking1.TabIndex = 4;
            // 
            // ucIssues1
            // 
            this.ucIssues1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucIssues1.BackColor = System.Drawing.Color.DarkRed;
            this.ucIssues1.Location = new System.Drawing.Point(222, 109);
            this.ucIssues1.Name = "ucIssues1";
            this.ucIssues1.Size = new System.Drawing.Size(860, 437);
            this.ucIssues1.TabIndex = 3;
            // 
            // ucRooms1
            // 
            this.ucRooms1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRooms1.BackColor = System.Drawing.Color.DarkRed;
            this.ucRooms1.Location = new System.Drawing.Point(222, 109);
            this.ucRooms1.Name = "ucRooms1";
            this.ucRooms1.Size = new System.Drawing.Size(860, 437);
            this.ucRooms1.TabIndex = 2;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1079, 547);
            this.Controls.Add(this.usDashboard1);
            this.Controls.Add(this.uctotalBooking1);
            this.Controls.Add(this.ucIssues1);
            this.Controls.Add(this.ucRooms1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.Text = "Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnIssues;
        private System.Windows.Forms.Button btntotalBooking;
        private System.Windows.Forms.Button btnLogout;
        private ucRooms ucRooms1;
        private ucIssues ucIssues1;
        private uctotalBooking uctotalBooking1;
        private usDashboard usDashboard1;
    }
}