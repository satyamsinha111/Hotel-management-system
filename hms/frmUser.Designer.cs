namespace hms
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnArrangeroom = new System.Windows.Forms.Button();
            this.btncheckin = new System.Windows.Forms.Button();
            this.btncheckout = new System.Windows.Forms.Button();
            this.btnBookroom = new System.Windows.Forms.Button();
            this.btnGenInvoice = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.usDashboard1 = new hms.usDashboard();
            this.ucCheckin1 = new hms.ucCheckin();
            this.ucCheckout1 = new hms.ucCheckout();
            this.ucArrangeroom1 = new hms.ucArrangeroom();
            this.ucBookroom1 = new hms.ucBookroom();
            this.ucInvoice1 = new hms.ucInvoice();
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 108);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(510, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reception panel";
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
            this.panel2.Controls.Add(this.btnGenInvoice);
            this.panel2.Controls.Add(this.btnBookroom);
            this.panel2.Controls.Add(this.btncheckout);
            this.panel2.Controls.Add(this.btncheckin);
            this.panel2.Controls.Add(this.btnArrangeroom);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 440);
            this.panel2.TabIndex = 2;
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
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnArrangeroom
            // 
            this.btnArrangeroom.BackColor = System.Drawing.Color.DarkRed;
            this.btnArrangeroom.FlatAppearance.BorderSize = 0;
            this.btnArrangeroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrangeroom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangeroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArrangeroom.Location = new System.Drawing.Point(14, 180);
            this.btnArrangeroom.Name = "btnArrangeroom";
            this.btnArrangeroom.Size = new System.Drawing.Size(188, 40);
            this.btnArrangeroom.TabIndex = 1;
            this.btnArrangeroom.Text = "Arrange rooms";
            this.btnArrangeroom.UseVisualStyleBackColor = false;
            this.btnArrangeroom.Click += new System.EventHandler(this.btnArrangeroom_Click);
            // 
            // btncheckin
            // 
            this.btncheckin.BackColor = System.Drawing.Color.DarkRed;
            this.btncheckin.FlatAppearance.BorderSize = 0;
            this.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncheckin.Location = new System.Drawing.Point(15, 96);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(188, 40);
            this.btncheckin.TabIndex = 2;
            this.btncheckin.Text = "Checkin";
            this.btncheckin.UseVisualStyleBackColor = false;
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.BackColor = System.Drawing.Color.DarkRed;
            this.btncheckout.FlatAppearance.BorderSize = 0;
            this.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncheckout.Location = new System.Drawing.Point(15, 138);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(188, 40);
            this.btncheckout.TabIndex = 3;
            this.btncheckout.Text = "Checkout";
            this.btncheckout.UseVisualStyleBackColor = false;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // btnBookroom
            // 
            this.btnBookroom.BackColor = System.Drawing.Color.DarkRed;
            this.btnBookroom.FlatAppearance.BorderSize = 0;
            this.btnBookroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookroom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookroom.Location = new System.Drawing.Point(15, 222);
            this.btnBookroom.Name = "btnBookroom";
            this.btnBookroom.Size = new System.Drawing.Size(188, 40);
            this.btnBookroom.TabIndex = 4;
            this.btnBookroom.Text = "Room booking";
            this.btnBookroom.UseVisualStyleBackColor = false;
            this.btnBookroom.Click += new System.EventHandler(this.btnBookroom_Click);
            // 
            // btnGenInvoice
            // 
            this.btnGenInvoice.BackColor = System.Drawing.Color.DarkRed;
            this.btnGenInvoice.FlatAppearance.BorderSize = 0;
            this.btnGenInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenInvoice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenInvoice.Location = new System.Drawing.Point(15, 264);
            this.btnGenInvoice.Name = "btnGenInvoice";
            this.btnGenInvoice.Size = new System.Drawing.Size(188, 40);
            this.btnGenInvoice.TabIndex = 5;
            this.btnGenInvoice.Text = "Generate invoice";
            this.btnGenInvoice.UseVisualStyleBackColor = false;
            this.btnGenInvoice.Click += new System.EventHandler(this.btnGenInvoice_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(15, 306);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // usDashboard1
            // 
            this.usDashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usDashboard1.BackColor = System.Drawing.Color.DarkRed;
            this.usDashboard1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usDashboard1.Location = new System.Drawing.Point(223, 109);
            this.usDashboard1.Name = "usDashboard1";
            this.usDashboard1.Size = new System.Drawing.Size(860, 437);
            this.usDashboard1.TabIndex = 8;
            // 
            // ucCheckin1
            // 
            this.ucCheckin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCheckin1.BackColor = System.Drawing.Color.DarkRed;
            this.ucCheckin1.Location = new System.Drawing.Point(222, 108);
            this.ucCheckin1.Name = "ucCheckin1";
            this.ucCheckin1.Size = new System.Drawing.Size(860, 437);
            this.ucCheckin1.TabIndex = 7;
            // 
            // ucCheckout1
            // 
            this.ucCheckout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCheckout1.BackColor = System.Drawing.Color.DarkRed;
            this.ucCheckout1.Location = new System.Drawing.Point(222, 109);
            this.ucCheckout1.Name = "ucCheckout1";
            this.ucCheckout1.Size = new System.Drawing.Size(860, 437);
            this.ucCheckout1.TabIndex = 6;
            // 
            // ucArrangeroom1
            // 
            this.ucArrangeroom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucArrangeroom1.BackColor = System.Drawing.Color.DarkRed;
            this.ucArrangeroom1.Location = new System.Drawing.Point(222, 109);
            this.ucArrangeroom1.Name = "ucArrangeroom1";
            this.ucArrangeroom1.Size = new System.Drawing.Size(860, 437);
            this.ucArrangeroom1.TabIndex = 5;
            // 
            // ucBookroom1
            // 
            this.ucBookroom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBookroom1.BackColor = System.Drawing.Color.DarkRed;
            this.ucBookroom1.Location = new System.Drawing.Point(222, 109);
            this.ucBookroom1.Name = "ucBookroom1";
            this.ucBookroom1.Size = new System.Drawing.Size(860, 437);
            this.ucBookroom1.TabIndex = 4;
            // 
            // ucInvoice1
            // 
            this.ucInvoice1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInvoice1.BackColor = System.Drawing.Color.DarkRed;
            this.ucInvoice1.Location = new System.Drawing.Point(222, 109);
            this.ucInvoice1.Name = "ucInvoice1";
            this.ucInvoice1.Size = new System.Drawing.Size(860, 437);
            this.ucInvoice1.TabIndex = 3;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1079, 547);
            this.Controls.Add(this.usDashboard1);
            this.Controls.Add(this.ucCheckin1);
            this.Controls.Add(this.ucCheckout1);
            this.Controls.Add(this.ucArrangeroom1);
            this.Controls.Add(this.ucBookroom1);
            this.Controls.Add(this.ucInvoice1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUser";
            this.Text = "Reception";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncheckin;
        private System.Windows.Forms.Button btnArrangeroom;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBookroom;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Button btnGenInvoice;
        private System.Windows.Forms.Button btnLogout;
        private ucInvoice ucInvoice1;
        private ucBookroom ucBookroom1;
        private ucArrangeroom ucArrangeroom1;
        private ucCheckout ucCheckout1;
        private ucCheckin ucCheckin1;
        private usDashboard usDashboard1;
    }
}