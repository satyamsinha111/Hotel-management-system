namespace hms
{
    partial class ucCheckin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.dgvCheckins = new System.Windows.Forms.DataGridView();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.pnlWarningWindow = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDispose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbtnAll = new System.Windows.Forms.RadioButton();
            this.rdBtnMobile = new System.Windows.Forms.RadioButton();
            this.rdBtnName = new System.Windows.Forms.RadioButton();
            this.rdBtnId = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdte = new System.Windows.Forms.Button();
            this.pnlEditwindow = new System.Windows.Forms.Panel();
            this.btncDelete = new System.Windows.Forms.Button();
            this.btncUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btneditclose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcName = new System.Windows.Forms.TextBox();
            this.txtcMobile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcCount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcPin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcBid = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCState = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ucUpdateNotification1 = new hms.ucUpdateNotification();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckins)).BeginInit();
            this.pnlWarningWindow.SuspendLayout();
            this.pnlTitlebar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlEditwindow.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.IndianRed;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(19, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 19);
            this.txtName.TabIndex = 3;
            this.txtName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(245, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(244, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "City";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcount.Location = new System.Drawing.Point(24, 194);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(58, 19);
            this.lblcount.TabIndex = 12;
            this.lblcount.Text = "Country";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPin.Location = new System.Drawing.Point(245, 193);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(58, 19);
            this.lblPin.TabIndex = 14;
            this.lblPin.Text = "Pincode";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(244, 249);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 19);
            this.label.TabIndex = 16;
            this.label.Text = "Booking Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(22, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "State";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.IndianRed;
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMobile.Location = new System.Drawing.Point(243, 105);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(191, 19);
            this.txtMobile.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.IndianRed;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(19, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 19);
            this.txtEmail.TabIndex = 20;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.IndianRed;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCity.Location = new System.Drawing.Point(243, 164);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(191, 19);
            this.txtCity.TabIndex = 21;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.IndianRed;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCountry.Location = new System.Drawing.Point(19, 216);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(191, 19);
            this.txtCountry.TabIndex = 22;
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.IndianRed;
            this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPin.Location = new System.Drawing.Point(243, 216);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(191, 19);
            this.txtPin.TabIndex = 23;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.IndianRed;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.SystemColors.Window;
            this.txtState.Location = new System.Drawing.Point(19, 271);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(191, 19);
            this.txtState.TabIndex = 24;
            // 
            // txtBooking
            // 
            this.txtBooking.BackColor = System.Drawing.Color.IndianRed;
            this.txtBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBooking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooking.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBooking.Location = new System.Drawing.Point(243, 271);
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(191, 19);
            this.txtBooking.TabIndex = 25;
            // 
            // dgvCheckins
            // 
            this.dgvCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheckins.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvCheckins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckins.Location = new System.Drawing.Point(457, 223);
            this.dgvCheckins.Name = "dgvCheckins";
            this.dgvCheckins.Size = new System.Drawing.Size(383, 155);
            this.dgvCheckins.TabIndex = 26;
            this.dgvCheckins.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCheckins_RowHeaderMouseClick);
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.IndianRed;
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckin.Location = new System.Drawing.Point(344, 320);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(90, 31);
            this.btnCheckin.TabIndex = 27;
            this.btnCheckin.Text = "Check in";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Snow;
            this.lblError.Location = new System.Drawing.Point(170, 376);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(117, 23);
            this.lblError.TabIndex = 28;
            this.lblError.Text = "No bookings";
            this.lblError.Visible = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.Snow;
            this.lblSuccess.Location = new System.Drawing.Point(122, 376);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(208, 23);
            this.lblSuccess.TabIndex = 29;
            this.lblSuccess.Text = "Checked in successfully";
            this.lblSuccess.Visible = false;
            // 
            // pnlWarningWindow
            // 
            this.pnlWarningWindow.Controls.Add(this.btnClose);
            this.pnlWarningWindow.Controls.Add(this.btnBook);
            this.pnlWarningWindow.Controls.Add(this.label7);
            this.pnlWarningWindow.Controls.Add(this.label6);
            this.pnlWarningWindow.Controls.Add(this.pnlTitlebar);
            this.pnlWarningWindow.Controls.Add(this.btnDispose);
            this.pnlWarningWindow.Location = new System.Drawing.Point(188, 150);
            this.pnlWarningWindow.Name = "pnlWarningWindow";
            this.pnlWarningWindow.Size = new System.Drawing.Size(446, 159);
            this.pnlWarningWindow.TabIndex = 30;
            this.pnlWarningWindow.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(321, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 31);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close window";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.IndianRed;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBook.Location = new System.Drawing.Point(183, 116);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(107, 31);
            this.btnBook.TabIndex = 28;
            this.btnBook.Text = "Book room";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(179, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "OOPS!!!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(102, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "No booking registered on this id";
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.White;
            this.pnlTitlebar.Controls.Add(this.label8);
            this.pnlTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Size = new System.Drawing.Size(415, 23);
            this.pnlTitlebar.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Warning";
            // 
            // btnDispose
            // 
            this.btnDispose.BackColor = System.Drawing.Color.IndianRed;
            this.btnDispose.FlatAppearance.BorderSize = 0;
            this.btnDispose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispose.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDispose.Location = new System.Drawing.Point(415, 0);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(30, 23);
            this.btnDispose.TabIndex = 0;
            this.btnDispose.Text = "X";
            this.btnDispose.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(457, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 123);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.rdbtnAll);
            this.panel2.Controls.Add(this.rdBtnMobile);
            this.panel2.Controls.Add(this.rdBtnName);
            this.panel2.Controls.Add(this.rdBtnId);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(14, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 96);
            this.panel2.TabIndex = 30;
            // 
            // rdbtnAll
            // 
            this.rdbtnAll.AutoSize = true;
            this.rdbtnAll.Location = new System.Drawing.Point(266, 14);
            this.rdbtnAll.Name = "rdbtnAll";
            this.rdbtnAll.Size = new System.Drawing.Size(44, 23);
            this.rdbtnAll.TabIndex = 33;
            this.rdbtnAll.TabStop = true;
            this.rdbtnAll.Text = "All";
            this.rdbtnAll.UseVisualStyleBackColor = true;
            this.rdbtnAll.CheckedChanged += new System.EventHandler(this.rdbtnAll_CheckedChanged);
            // 
            // rdBtnMobile
            // 
            this.rdBtnMobile.AutoSize = true;
            this.rdBtnMobile.Location = new System.Drawing.Point(184, 14);
            this.rdBtnMobile.Name = "rdBtnMobile";
            this.rdBtnMobile.Size = new System.Drawing.Size(70, 23);
            this.rdBtnMobile.TabIndex = 32;
            this.rdBtnMobile.TabStop = true;
            this.rdBtnMobile.Text = "Mobile";
            this.rdBtnMobile.UseVisualStyleBackColor = true;
            // 
            // rdBtnName
            // 
            this.rdBtnName.AutoSize = true;
            this.rdBtnName.Location = new System.Drawing.Point(99, 14);
            this.rdBtnName.Name = "rdBtnName";
            this.rdBtnName.Size = new System.Drawing.Size(64, 23);
            this.rdBtnName.TabIndex = 31;
            this.rdBtnName.TabStop = true;
            this.rdBtnName.Text = "Name";
            this.rdBtnName.UseVisualStyleBackColor = true;
            // 
            // rdBtnId
            // 
            this.rdBtnId.AutoSize = true;
            this.rdBtnId.Location = new System.Drawing.Point(24, 14);
            this.rdBtnId.Name = "rdBtnId";
            this.rdBtnId.Size = new System.Drawing.Size(40, 23);
            this.rdBtnId.TabIndex = 30;
            this.rdBtnId.TabStop = true;
            this.rdBtnId.Text = "Id";
            this.rdBtnId.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(229, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.IndianRed;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 28);
            this.txtSearch.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(26, 322);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 31);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdte
            // 
            this.btnUpdte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdte.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdte.FlatAppearance.BorderSize = 0;
            this.btnUpdte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdte.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdte.Location = new System.Drawing.Point(750, 384);
            this.btnUpdte.Name = "btnUpdte";
            this.btnUpdte.Size = new System.Drawing.Size(90, 31);
            this.btnUpdte.TabIndex = 33;
            this.btnUpdte.Text = "Update";
            this.btnUpdte.UseVisualStyleBackColor = false;
            this.btnUpdte.Click += new System.EventHandler(this.btnUpdte_Click);
            // 
            // pnlEditwindow
            // 
            this.pnlEditwindow.Controls.Add(this.txtcBid);
            this.pnlEditwindow.Controls.Add(this.label17);
            this.pnlEditwindow.Controls.Add(this.txtCState);
            this.pnlEditwindow.Controls.Add(this.label18);
            this.pnlEditwindow.Controls.Add(this.txtcPin);
            this.pnlEditwindow.Controls.Add(this.label16);
            this.pnlEditwindow.Controls.Add(this.txtcCount);
            this.pnlEditwindow.Controls.Add(this.label15);
            this.pnlEditwindow.Controls.Add(this.txtcCity);
            this.pnlEditwindow.Controls.Add(this.label14);
            this.pnlEditwindow.Controls.Add(this.txtcEmail);
            this.pnlEditwindow.Controls.Add(this.label13);
            this.pnlEditwindow.Controls.Add(this.txtcMobile);
            this.pnlEditwindow.Controls.Add(this.label10);
            this.pnlEditwindow.Controls.Add(this.txtcName);
            this.pnlEditwindow.Controls.Add(this.label11);
            this.pnlEditwindow.Controls.Add(this.btncDelete);
            this.pnlEditwindow.Controls.Add(this.btncUpdate);
            this.pnlEditwindow.Controls.Add(this.panel4);
            this.pnlEditwindow.Controls.Add(this.btneditclose);
            this.pnlEditwindow.Location = new System.Drawing.Point(316, 82);
            this.pnlEditwindow.Name = "pnlEditwindow";
            this.pnlEditwindow.Size = new System.Drawing.Size(446, 241);
            this.pnlEditwindow.TabIndex = 34;
            this.pnlEditwindow.Visible = false;
            // 
            // btncDelete
            // 
            this.btncDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btncDelete.FlatAppearance.BorderSize = 0;
            this.btncDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncDelete.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncDelete.Location = new System.Drawing.Point(323, 207);
            this.btncDelete.Name = "btncDelete";
            this.btncDelete.Size = new System.Drawing.Size(110, 31);
            this.btncDelete.TabIndex = 29;
            this.btncDelete.Text = "Delete";
            this.btncDelete.UseVisualStyleBackColor = false;
            this.btncDelete.Click += new System.EventHandler(this.btncDelete_Click);
            // 
            // btncUpdate
            // 
            this.btncUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btncUpdate.FlatAppearance.BorderSize = 0;
            this.btncUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncUpdate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncUpdate.Location = new System.Drawing.Point(206, 207);
            this.btncUpdate.Name = "btncUpdate";
            this.btncUpdate.Size = new System.Drawing.Size(107, 31);
            this.btncUpdate.TabIndex = 28;
            this.btncUpdate.Text = "Update";
            this.btncUpdate.UseVisualStyleBackColor = false;
            this.btncUpdate.Click += new System.EventHandler(this.btncUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 23);
            this.panel4.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Edit details";
            // 
            // btneditclose
            // 
            this.btneditclose.BackColor = System.Drawing.Color.IndianRed;
            this.btneditclose.FlatAppearance.BorderSize = 0;
            this.btneditclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditclose.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneditclose.Location = new System.Drawing.Point(415, 0);
            this.btneditclose.Name = "btneditclose";
            this.btneditclose.Size = new System.Drawing.Size(30, 23);
            this.btneditclose.TabIndex = 0;
            this.btneditclose.Text = "X";
            this.btneditclose.UseVisualStyleBackColor = false;
            this.btneditclose.Click += new System.EventHandler(this.btneditclose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(15, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Name";
            // 
            // txtcName
            // 
            this.txtcName.BackColor = System.Drawing.Color.IndianRed;
            this.txtcName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcName.Location = new System.Drawing.Point(13, 55);
            this.txtcName.Name = "txtcName";
            this.txtcName.Size = new System.Drawing.Size(122, 19);
            this.txtcName.TabIndex = 33;
            // 
            // txtcMobile
            // 
            this.txtcMobile.BackColor = System.Drawing.Color.IndianRed;
            this.txtcMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcMobile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcMobile.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcMobile.Location = new System.Drawing.Point(147, 55);
            this.txtcMobile.Name = "txtcMobile";
            this.txtcMobile.Size = new System.Drawing.Size(122, 19);
            this.txtcMobile.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(149, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mobile";
            // 
            // txtcEmail
            // 
            this.txtcEmail.BackColor = System.Drawing.Color.IndianRed;
            this.txtcEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcEmail.Location = new System.Drawing.Point(285, 55);
            this.txtcEmail.Name = "txtcEmail";
            this.txtcEmail.Size = new System.Drawing.Size(122, 19);
            this.txtcEmail.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(287, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 36;
            this.label13.Text = "E-Mail";
            // 
            // txtcCity
            // 
            this.txtcCity.BackColor = System.Drawing.Color.IndianRed;
            this.txtcCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcCity.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcCity.Location = new System.Drawing.Point(13, 102);
            this.txtcCity.Name = "txtcCity";
            this.txtcCity.Size = new System.Drawing.Size(122, 19);
            this.txtcCity.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(15, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "City";
            // 
            // txtcCount
            // 
            this.txtcCount.BackColor = System.Drawing.Color.IndianRed;
            this.txtcCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcCount.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcCount.Location = new System.Drawing.Point(149, 102);
            this.txtcCount.Name = "txtcCount";
            this.txtcCount.Size = new System.Drawing.Size(122, 19);
            this.txtcCount.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(151, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "Country";
            // 
            // txtcPin
            // 
            this.txtcPin.BackColor = System.Drawing.Color.IndianRed;
            this.txtcPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcPin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcPin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcPin.Location = new System.Drawing.Point(285, 105);
            this.txtcPin.Name = "txtcPin";
            this.txtcPin.Size = new System.Drawing.Size(122, 19);
            this.txtcPin.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(287, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 19);
            this.label16.TabIndex = 42;
            this.label16.Text = "Pin-code";
            // 
            // txtcBid
            // 
            this.txtcBid.BackColor = System.Drawing.Color.IndianRed;
            this.txtcBid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcBid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcBid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcBid.Location = new System.Drawing.Point(149, 144);
            this.txtcBid.Name = "txtcBid";
            this.txtcBid.Size = new System.Drawing.Size(122, 19);
            this.txtcBid.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(151, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 19);
            this.label17.TabIndex = 46;
            this.label17.Text = "Booking Id";
            // 
            // txtCState
            // 
            this.txtCState.BackColor = System.Drawing.Color.IndianRed;
            this.txtCState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCState.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCState.Location = new System.Drawing.Point(13, 145);
            this.txtCState.Name = "txtCState";
            this.txtCState.Size = new System.Drawing.Size(122, 19);
            this.txtCState.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(15, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 19);
            this.label18.TabIndex = 44;
            this.label18.Text = "State";
            // 
            // ucUpdateNotification1
            // 
            this.ucUpdateNotification1.BackColor = System.Drawing.Color.DarkRed;
            this.ucUpdateNotification1.Location = new System.Drawing.Point(302, 95);
            this.ucUpdateNotification1.Name = "ucUpdateNotification1";
            this.ucUpdateNotification1.Size = new System.Drawing.Size(203, 140);
            this.ucUpdateNotification1.TabIndex = 35;
            // 
            // ucCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.ucUpdateNotification1);
            this.Controls.Add(this.pnlEditwindow);
            this.Controls.Add(this.btnUpdte);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlWarningWindow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.dgvCheckins);
            this.Controls.Add(this.txtBooking);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Name = "ucCheckin";
            this.Size = new System.Drawing.Size(860, 437);
            this.Load += new System.EventHandler(this.ucCheckin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckins)).EndInit();
            this.pnlWarningWindow.ResumeLayout(false);
            this.pnlWarningWindow.PerformLayout();
            this.pnlTitlebar.ResumeLayout(false);
            this.pnlTitlebar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlEditwindow.ResumeLayout(false);
            this.pnlEditwindow.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.DataGridView dgvCheckins;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Panel pnlWarningWindow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlTitlebar;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBtnMobile;
        private System.Windows.Forms.RadioButton rdBtnName;
        private System.Windows.Forms.RadioButton rdBtnId;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdbtnAll;
        private System.Windows.Forms.Button btnUpdte;
        private System.Windows.Forms.Panel pnlEditwindow;
        private System.Windows.Forms.Button btncDelete;
        private System.Windows.Forms.Button btncUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btneditclose;
        private System.Windows.Forms.TextBox txtcBid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCState;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtcPin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcMobile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcName;
        private System.Windows.Forms.Label label11;
        private ucUpdateNotification ucUpdateNotification1;
    }
}
