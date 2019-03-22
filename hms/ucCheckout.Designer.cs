namespace hms
{
    partial class ucCheckout
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
            this.dgvCheckout = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnId = new System.Windows.Forms.RadioButton();
            this.rdbtnName = new System.Windows.Forms.RadioButton();
            this.rdBtnMobile = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSucClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSucOK = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFailClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFailOk = new System.Windows.Forms.Button();
            this.btnFailHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 63);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Out";
            // 
            // dgvCheckout
            // 
            this.dgvCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheckout.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckout.Location = new System.Drawing.Point(459, 86);
            this.dgvCheckout.Name = "dgvCheckout";
            this.dgvCheckout.RowHeadersVisible = false;
            this.dgvCheckout.Size = new System.Drawing.Size(377, 319);
            this.dgvCheckout.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.rdBtnMobile);
            this.groupBox1.Controls.Add(this.rdbtnName);
            this.groupBox1.Controls.Add(this.rdBtnId);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // rdBtnId
            // 
            this.rdBtnId.AutoSize = true;
            this.rdBtnId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnId.Location = new System.Drawing.Point(18, 31);
            this.rdBtnId.Name = "rdBtnId";
            this.rdBtnId.Size = new System.Drawing.Size(40, 23);
            this.rdBtnId.TabIndex = 0;
            this.rdBtnId.TabStop = true;
            this.rdBtnId.Text = "Id";
            this.rdBtnId.UseVisualStyleBackColor = true;
            // 
            // rdbtnName
            // 
            this.rdbtnName.AutoSize = true;
            this.rdbtnName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnName.Location = new System.Drawing.Point(142, 31);
            this.rdbtnName.Name = "rdbtnName";
            this.rdbtnName.Size = new System.Drawing.Size(64, 23);
            this.rdbtnName.TabIndex = 1;
            this.rdbtnName.TabStop = true;
            this.rdbtnName.Text = "Name";
            this.rdbtnName.UseVisualStyleBackColor = true;
            // 
            // rdBtnMobile
            // 
            this.rdBtnMobile.AutoSize = true;
            this.rdBtnMobile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMobile.Location = new System.Drawing.Point(262, 31);
            this.rdBtnMobile.Name = "rdBtnMobile";
            this.rdBtnMobile.Size = new System.Drawing.Size(70, 23);
            this.rdBtnMobile.TabIndex = 2;
            this.rdBtnMobile.TabStop = true;
            this.rdBtnMobile.Text = "Mobile";
            this.rdBtnMobile.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.IndianRed;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Location = new System.Drawing.Point(23, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 28);
            this.txtSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(214, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.IndianRed;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckout.Location = new System.Drawing.Point(294, 262);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(107, 31);
            this.btnCheckout.TabIndex = 29;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSucOK);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSucClose);
            this.panel2.Location = new System.Drawing.Point(407, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 130);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 22);
            this.panel3.TabIndex = 0;
            // 
            // btnSucClose
            // 
            this.btnSucClose.BackColor = System.Drawing.Color.Red;
            this.btnSucClose.FlatAppearance.BorderSize = 0;
            this.btnSucClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucClose.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSucClose.Location = new System.Drawing.Point(246, -1);
            this.btnSucClose.Name = "btnSucClose";
            this.btnSucClose.Size = new System.Drawing.Size(27, 23);
            this.btnSucClose.TabIndex = 1;
            this.btnSucClose.Text = "X";
            this.btnSucClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Success";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(60, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Checked out successfully";
            // 
            // btnSucOK
            // 
            this.btnSucOK.BackColor = System.Drawing.Color.IndianRed;
            this.btnSucOK.FlatAppearance.BorderSize = 0;
            this.btnSucOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucOK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSucOK.Location = new System.Drawing.Point(108, 89);
            this.btnSucOK.Name = "btnSucOK";
            this.btnSucOK.Size = new System.Drawing.Size(55, 31);
            this.btnSucOK.TabIndex = 30;
            this.btnSucOK.Text = "OK";
            this.btnSucOK.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFailHelp);
            this.panel4.Controls.Add(this.btnFailOk);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnFailClose);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(407, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 130);
            this.panel4.TabIndex = 31;
            this.panel4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(60, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Something went wrong";
            // 
            // btnFailClose
            // 
            this.btnFailClose.BackColor = System.Drawing.Color.Red;
            this.btnFailClose.FlatAppearance.BorderSize = 0;
            this.btnFailClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailClose.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFailClose.Location = new System.Drawing.Point(246, -1);
            this.btnFailClose.Name = "btnFailClose";
            this.btnFailClose.Size = new System.Drawing.Size(27, 23);
            this.btnFailClose.TabIndex = 1;
            this.btnFailClose.Text = "X";
            this.btnFailClose.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 22);
            this.panel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Failed";
            // 
            // btnFailOk
            // 
            this.btnFailOk.BackColor = System.Drawing.Color.IndianRed;
            this.btnFailOk.FlatAppearance.BorderSize = 0;
            this.btnFailOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailOk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFailOk.Location = new System.Drawing.Point(64, 89);
            this.btnFailOk.Name = "btnFailOk";
            this.btnFailOk.Size = new System.Drawing.Size(74, 31);
            this.btnFailOk.TabIndex = 30;
            this.btnFailOk.Text = "OK";
            this.btnFailOk.UseVisualStyleBackColor = false;
            // 
            // btnFailHelp
            // 
            this.btnFailHelp.BackColor = System.Drawing.Color.IndianRed;
            this.btnFailHelp.FlatAppearance.BorderSize = 0;
            this.btnFailHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailHelp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFailHelp.Location = new System.Drawing.Point(146, 89);
            this.btnFailHelp.Name = "btnFailHelp";
            this.btnFailHelp.Size = new System.Drawing.Size(74, 31);
            this.btnFailHelp.TabIndex = 31;
            this.btnFailHelp.Text = "Help";
            this.btnFailHelp.UseVisualStyleBackColor = false;
            // 
            // ucCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCheckout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckout);
            this.Name = "ucCheckout";
            this.Size = new System.Drawing.Size(860, 437);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCheckout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnMobile;
        private System.Windows.Forms.RadioButton rdbtnName;
        private System.Windows.Forms.RadioButton rdBtnId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSucClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSucOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFailHelp;
        private System.Windows.Forms.Button btnFailOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFailClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
    }
}
