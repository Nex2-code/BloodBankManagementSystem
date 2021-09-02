
namespace BloodBankManagementSystem.UI
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
            this.components = new System.ComponentModel.Container();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblmanage = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.btnimage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.txtboxcontact = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.lblprofilepic = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnltop.Controls.Add(this.pictureBox1);
            this.pnltop.Controls.Add(this.lblmanage);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1163, 54);
            this.pnltop.TabIndex = 0;
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
            // lblmanage
            // 
            this.lblmanage.AutoSize = true;
            this.lblmanage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmanage.Location = new System.Drawing.Point(418, 9);
            this.lblmanage.Name = "lblmanage";
            this.lblmanage.Size = new System.Drawing.Size(197, 38);
            this.lblmanage.TabIndex = 0;
            this.lblmanage.Text = "Manage User ";
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbox.Location = new System.Drawing.Point(142, 91);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(184, 153);
            this.pbox.TabIndex = 1;
            this.pbox.TabStop = false;
            // 
            // btnimage
            // 
            this.btnimage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnimage.Location = new System.Drawing.Point(332, 214);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(128, 30);
            this.btnimage.TabIndex = 2;
            this.btnimage.Text = "Select Image";
            this.btnimage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfullname.Location = new System.Drawing.Point(29, 328);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(80, 20);
            this.lblfullname.TabIndex = 4;
            this.lblfullname.Text = "Full Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblid.Location = new System.Drawing.Point(53, 271);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(25, 20);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(130, 268);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(420, 27);
            this.txtid.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblemail.Location = new System.Drawing.Point(29, 379);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 20);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(130, 376);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(420, 27);
            this.txtboxemail.TabIndex = 7;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusername.Location = new System.Drawing.Point(29, 427);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(80, 20);
            this.lblusername.TabIndex = 10;
            this.lblusername.Text = "Username";
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(130, 424);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(420, 27);
            this.txtboxusername.TabIndex = 9;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpassword.Location = new System.Drawing.Point(29, 473);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(76, 20);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(130, 470);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(420, 27);
            this.txtpassword.TabIndex = 11;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcontact.Location = new System.Drawing.Point(29, 524);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(63, 20);
            this.lblcontact.TabIndex = 14;
            this.lblcontact.Text = "Contact";
            // 
            // txtboxcontact
            // 
            this.txtboxcontact.Location = new System.Drawing.Point(130, 521);
            this.txtboxcontact.Name = "txtboxcontact";
            this.txtboxcontact.Size = new System.Drawing.Size(420, 27);
            this.txtboxcontact.TabIndex = 13;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbladdress.Location = new System.Drawing.Point(29, 577);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(66, 20);
            this.lbladdress.TabIndex = 16;
            this.lbladdress.Text = "Address";
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(130, 574);
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(420, 134);
            this.txtadress.TabIndex = 15;
            // 
            // lblprofilepic
            // 
            this.lblprofilepic.AutoSize = true;
            this.lblprofilepic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblprofilepic.Location = new System.Drawing.Point(16, 91);
            this.lblprofilepic.Name = "lblprofilepic";
            this.lblprofilepic.Size = new System.Drawing.Size(108, 20);
            this.lblprofilepic.TabIndex = 17;
            this.lblprofilepic.Text = "Profile Picture";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(650, 111);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(491, 27);
            this.tbsearch.TabIndex = 20;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsearch.Location = new System.Drawing.Point(575, 111);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(69, 25);
            this.lblsearch.TabIndex = 19;
            this.lblsearch.Text = "Search";
            // 
            // dgvuser
            // 
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(575, 179);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowHeadersWidth = 51;
            this.dgvuser.RowTemplate.Height = 29;
            this.dgvuser.Size = new System.Drawing.Size(566, 529);
            this.dgvuser.TabIndex = 21;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(16, 723);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 40);
            this.btnadd.TabIndex = 22;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Silver;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclear.Location = new System.Drawing.Point(421, 723);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 40);
            this.btnclear.TabIndex = 23;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Tomato;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.Location = new System.Drawing.Point(286, 723);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 40);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(151, 723);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 40);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 788);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lblprofilepic);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.txtboxcontact);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblmanage;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.TextBox txtboxcontact;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.Label lblprofilepic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}