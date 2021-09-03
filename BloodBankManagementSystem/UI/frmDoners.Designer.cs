
using System;

namespace BloodBankManagementSystem.UI
{
    partial class frmDoners
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
            this.components = new System.ComponentModel.Container();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvdonor = new System.Windows.Forms.DataGridView();
            this.tbdonorsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btndelete = new System.Windows.Forms.Button();
            this.lblprofilepic = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtboxdonoradress = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.txtboxdonorcontact = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtboxdonorlastname = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtboxdonoremail = new System.Windows.Forms.TextBox();
            this.lbldonorid = new System.Windows.Forms.Label();
            this.txtboxdonorid = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtboxdonorfirstname = new System.Windows.Forms.TextBox();
            this.btnimage = new System.Windows.Forms.Button();
            this.pboxdonor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblmanagedoner = new System.Windows.Forms.Label();
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblbloodgroup = new System.Windows.Forms.Label();
            this.lstboxdonorgender = new System.Windows.Forms.ComboBox();
            this.lstboxdonorbloodgroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(151, 776);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 40);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Silver;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclear.Location = new System.Drawing.Point(421, 776);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 40);
            this.btnclear.TabIndex = 48;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(16, 776);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 40);
            this.btnadd.TabIndex = 47;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvdonor
            // 
            this.dgvdonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdonor.Location = new System.Drawing.Point(587, 195);
            this.dgvdonor.Name = "dgvdonor";
            this.dgvdonor.RowHeadersWidth = 51;
            this.dgvdonor.RowTemplate.Height = 29;
            this.dgvdonor.Size = new System.Drawing.Size(566, 529);
            this.dgvdonor.TabIndex = 46;
            this.dgvdonor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdonor_RowHeaderMouseClick);
            // 
            // tbdonorsearch
            // 
            this.tbdonorsearch.Location = new System.Drawing.Point(650, 127);
            this.tbdonorsearch.Name = "tbdonorsearch";
            this.tbdonorsearch.Size = new System.Drawing.Size(491, 27);
            this.tbdonorsearch.TabIndex = 45;
            this.tbdonorsearch.TextChanged += new System.EventHandler(this.tbdonorsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsearch.Location = new System.Drawing.Point(575, 127);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(69, 25);
            this.lblsearch.TabIndex = 44;
            this.lblsearch.Text = "Search";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Tomato;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.Location = new System.Drawing.Point(286, 776);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 40);
            this.btndelete.TabIndex = 49;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblprofilepic
            // 
            this.lblprofilepic.AutoSize = true;
            this.lblprofilepic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblprofilepic.Location = new System.Drawing.Point(16, 107);
            this.lblprofilepic.Name = "lblprofilepic";
            this.lblprofilepic.Size = new System.Drawing.Size(108, 20);
            this.lblprofilepic.TabIndex = 43;
            this.lblprofilepic.Text = "Profile Picture";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbladdress.Location = new System.Drawing.Point(29, 630);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(66, 20);
            this.lbladdress.TabIndex = 42;
            this.lbladdress.Text = "Address";
            // 
            // txtboxdonoradress
            // 
            this.txtboxdonoradress.Location = new System.Drawing.Point(142, 627);
            this.txtboxdonoradress.Multiline = true;
            this.txtboxdonoradress.Name = "txtboxdonoradress";
            this.txtboxdonoradress.Size = new System.Drawing.Size(420, 134);
            this.txtboxdonoradress.TabIndex = 41;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcontact.Location = new System.Drawing.Point(29, 577);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(63, 20);
            this.lblcontact.TabIndex = 40;
            this.lblcontact.Text = "Contact";
            // 
            // txtboxdonorcontact
            // 
            this.txtboxdonorcontact.Location = new System.Drawing.Point(142, 574);
            this.txtboxdonorcontact.Name = "txtboxdonorcontact";
            this.txtboxdonorcontact.Size = new System.Drawing.Size(420, 27);
            this.txtboxdonorcontact.TabIndex = 39;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbllastname.Location = new System.Drawing.Point(29, 391);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(84, 20);
            this.lbllastname.TabIndex = 38;
            this.lbllastname.Text = "Last Name";
            // 
            // txtboxdonorlastname
            // 
            this.txtboxdonorlastname.Location = new System.Drawing.Point(142, 388);
            this.txtboxdonorlastname.Name = "txtboxdonorlastname";
            this.txtboxdonorlastname.Size = new System.Drawing.Size(420, 27);
            this.txtboxdonorlastname.TabIndex = 37;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblgender.Location = new System.Drawing.Point(29, 437);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(60, 20);
            this.lblgender.TabIndex = 36;
            this.lblgender.Text = "Gender";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblemail.Location = new System.Drawing.Point(29, 535);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 20);
            this.lblemail.TabIndex = 34;
            this.lblemail.Text = "Email";
            // 
            // txtboxdonoremail
            // 
            this.txtboxdonoremail.Location = new System.Drawing.Point(142, 532);
            this.txtboxdonoremail.Name = "txtboxdonoremail";
            this.txtboxdonoremail.Size = new System.Drawing.Size(420, 27);
            this.txtboxdonoremail.TabIndex = 33;
            // 
            // lbldonorid
            // 
            this.lbldonorid.AutoSize = true;
            this.lbldonorid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldonorid.Location = new System.Drawing.Point(29, 287);
            this.lbldonorid.Name = "lbldonorid";
            this.lbldonorid.Size = new System.Drawing.Size(73, 20);
            this.lbldonorid.TabIndex = 32;
            this.lbldonorid.Text = "Donor ID";
            this.lbldonorid.Click += new System.EventHandler(this.lbldonorid_Click);
            // 
            // txtboxdonorid
            // 
            this.txtboxdonorid.Location = new System.Drawing.Point(142, 284);
            this.txtboxdonorid.Name = "txtboxdonorid";
            this.txtboxdonorid.ReadOnly = true;
            this.txtboxdonorid.Size = new System.Drawing.Size(420, 27);
            this.txtboxdonorid.TabIndex = 31;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfirstname.Location = new System.Drawing.Point(29, 344);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 20);
            this.lblfirstname.TabIndex = 30;
            this.lblfirstname.Text = "First Name";
            // 
            // txtboxdonorfirstname
            // 
            this.txtboxdonorfirstname.Location = new System.Drawing.Point(142, 341);
            this.txtboxdonorfirstname.Name = "txtboxdonorfirstname";
            this.txtboxdonorfirstname.Size = new System.Drawing.Size(420, 27);
            this.txtboxdonorfirstname.TabIndex = 29;
            // 
            // btnimage
            // 
            this.btnimage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnimage.Location = new System.Drawing.Point(344, 230);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(128, 30);
            this.btnimage.TabIndex = 28;
            this.btnimage.Text = "Select Image";
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // pboxdonor
            // 
            this.pboxdonor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pboxdonor.Location = new System.Drawing.Point(151, 107);
            this.pboxdonor.Name = "pboxdonor";
            this.pboxdonor.Size = new System.Drawing.Size(184, 153);
            this.pboxdonor.TabIndex = 27;
            this.pboxdonor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = global::BloodBankManagementSystem.Properties.Resources.icons8_close_window_96;
            this.pictureBox1.Location = new System.Drawing.Point(1126, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblmanagedoner
            // 
            this.lblmanagedoner.AutoSize = true;
            this.lblmanagedoner.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmanagedoner.Location = new System.Drawing.Point(418, 9);
            this.lblmanagedoner.Name = "lblmanagedoner";
            this.lblmanagedoner.Size = new System.Drawing.Size(226, 38);
            this.lblmanagedoner.TabIndex = 0;
            this.lblmanagedoner.Text = "Manage Donors";
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnltop.Controls.Add(this.pictureBox1);
            this.pnltop.Controls.Add(this.lblmanagedoner);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1183, 54);
            this.pnltop.TabIndex = 26;
            // 
            // lblbloodgroup
            // 
            this.lblbloodgroup.AutoSize = true;
            this.lblbloodgroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbloodgroup.Location = new System.Drawing.Point(29, 482);
            this.lblbloodgroup.Name = "lblbloodgroup";
            this.lblbloodgroup.Size = new System.Drawing.Size(98, 20);
            this.lblbloodgroup.TabIndex = 52;
            this.lblbloodgroup.Text = "Blood Group";
            // 
            // lstboxdonorgender
            // 
            this.lstboxdonorgender.FormattingEnabled = true;
            this.lstboxdonorgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.lstboxdonorgender.Location = new System.Drawing.Point(142, 429);
            this.lstboxdonorgender.Name = "lstboxdonorgender";
            this.lstboxdonorgender.Size = new System.Drawing.Size(420, 28);
            this.lstboxdonorgender.TabIndex = 55;
            // 
            // lstboxdonorbloodgroup
            // 
            this.lstboxdonorbloodgroup.FormattingEnabled = true;
            this.lstboxdonorbloodgroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.lstboxdonorbloodgroup.Location = new System.Drawing.Point(142, 479);
            this.lstboxdonorbloodgroup.Name = "lstboxdonorbloodgroup";
            this.lstboxdonorbloodgroup.Size = new System.Drawing.Size(420, 28);
            this.lstboxdonorbloodgroup.TabIndex = 56;
            // 
            // frmDoners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 831);
            this.Controls.Add(this.lstboxdonorbloodgroup);
            this.Controls.Add(this.lstboxdonorgender);
            this.Controls.Add(this.lblbloodgroup);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvdonor);
            this.Controls.Add(this.tbdonorsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lblprofilepic);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtboxdonoradress);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.txtboxdonorcontact);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtboxdonorlastname);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtboxdonoremail);
            this.Controls.Add(this.lbldonorid);
            this.Controls.Add(this.txtboxdonorid);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.txtboxdonorfirstname);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.pboxdonor);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doners";
            this.Load += new System.EventHandler(this.frmDoners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvdonor;
        private System.Windows.Forms.TextBox tbdonorsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblprofilepic;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtboxdonoradress;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.TextBox txtboxdonorcontact;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtboxdonorlastname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtboxdonoremail;
        private System.Windows.Forms.Label lbldonorid;
        private System.Windows.Forms.TextBox txtboxdonorid;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtboxdonorfirstname;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.PictureBox pboxdonor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblmanagedoner;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblbloodgroup;
        private System.Windows.Forms.ComboBox lstboxdonorgender;
        private System.Windows.Forms.ComboBox lstboxdonorbloodgroup;
    }
}