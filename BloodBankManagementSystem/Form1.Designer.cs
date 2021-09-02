
namespace BloodBankManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.lbldev = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOpve = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.lbldonorsOpve = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOnve = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnve = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApve = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBnve = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBpve = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblABnve = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblABpve = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.gdv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlfooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.donersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.userToolStripMenuItem.Text = "Users";
            // 
            // donersToolStripMenuItem
            // 
            this.donersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.donersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donersToolStripMenuItem.Name = "donersToolStripMenuItem";
            this.donersToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.donersToolStripMenuItem.Text = "Doners";
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlfooter.Controls.Add(this.lblname);
            this.pnlfooter.Controls.Add(this.lbldev);
            this.pnlfooter.Controls.Add(this.lblfooter);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 757);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1233, 46);
            this.pnlfooter.TabIndex = 1;
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblfooter.ForeColor = System.Drawing.Color.Red;
            this.lblfooter.Location = new System.Drawing.Point(183, 6);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(288, 31);
            this.lblfooter.TabIndex = 0;
            this.lblfooter.Text = "Blood Bank Management";
            this.lblfooter.Click += new System.EventHandler(this.lblfooter_Click);
            // 
            // lbldev
            // 
            this.lbldev.AutoSize = true;
            this.lbldev.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbldev.ForeColor = System.Drawing.Color.Black;
            this.lbldev.Location = new System.Drawing.Point(477, 6);
            this.lbldev.Name = "lbldev";
            this.lbldev.Size = new System.Drawing.Size(162, 31);
            this.lbldev.TabIndex = 1;
            this.lbldev.Text = "Developed by:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblname.ForeColor = System.Drawing.Color.Green;
            this.lblname.Location = new System.Drawing.Point(645, 6);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(135, 31);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Adarsh Negi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lbldonorsOpve);
            this.panel1.Controls.Add(this.lblcount);
            this.panel1.Controls.Add(this.lblOpve);
            this.panel1.Location = new System.Drawing.Point(27, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 125);
            this.panel1.TabIndex = 2;
            // 
            // lblOpve
            // 
            this.lblOpve.AutoSize = true;
            this.lblOpve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpve.ForeColor = System.Drawing.Color.Red;
            this.lblOpve.Location = new System.Drawing.Point(16, 19);
            this.lblOpve.Name = "lblOpve";
            this.lblOpve.Size = new System.Drawing.Size(122, 81);
            this.lblOpve.TabIndex = 0;
            this.lblOpve.Text = "O+";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcount.ForeColor = System.Drawing.Color.Green;
            this.lblcount.Location = new System.Drawing.Point(144, 19);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(82, 50);
            this.lblcount.TabIndex = 1;
            this.lblcount.Text = "100";
            // 
            // lbldonorsOpve
            // 
            this.lbldonorsOpve.AutoSize = true;
            this.lbldonorsOpve.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldonorsOpve.Location = new System.Drawing.Point(156, 77);
            this.lbldonorsOpve.Name = "lbldonorsOpve";
            this.lbldonorsOpve.Size = new System.Drawing.Size(67, 23);
            this.lbldonorsOpve.TabIndex = 2;
            this.lbldonorsOpve.Text = "Donors";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblOnve);
            this.panel2.Location = new System.Drawing.Point(307, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 125);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "100";
            // 
            // lblOnve
            // 
            this.lblOnve.AutoSize = true;
            this.lblOnve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnve.ForeColor = System.Drawing.Color.Red;
            this.lblOnve.Location = new System.Drawing.Point(16, 19);
            this.lblOnve.Name = "lblOnve";
            this.lblOnve.Size = new System.Drawing.Size(104, 81);
            this.lblOnve.TabIndex = 0;
            this.lblOnve.Text = "O-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblAnve);
            this.panel3.Location = new System.Drawing.Point(307, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 125);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Donors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(144, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "100";
            // 
            // lblAnve
            // 
            this.lblAnve.AutoSize = true;
            this.lblAnve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnve.ForeColor = System.Drawing.Color.Red;
            this.lblAnve.Location = new System.Drawing.Point(16, 19);
            this.lblAnve.Name = "lblAnve";
            this.lblAnve.Size = new System.Drawing.Size(101, 81);
            this.lblAnve.TabIndex = 0;
            this.lblAnve.Text = "A-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lblApve);
            this.panel4.Location = new System.Drawing.Point(27, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 125);
            this.panel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(156, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Donors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(144, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 50);
            this.label8.TabIndex = 1;
            this.label8.Text = "100";
            // 
            // lblApve
            // 
            this.lblApve.AutoSize = true;
            this.lblApve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApve.ForeColor = System.Drawing.Color.Red;
            this.lblApve.Location = new System.Drawing.Point(16, 19);
            this.lblApve.Name = "lblApve";
            this.lblApve.Size = new System.Drawing.Size(119, 81);
            this.lblApve.TabIndex = 0;
            this.lblApve.Text = "A+";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lblBnve);
            this.panel5.Location = new System.Drawing.Point(307, 379);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 125);
            this.panel5.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(156, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Donors";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(144, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 50);
            this.label11.TabIndex = 1;
            this.label11.Text = "100";
            // 
            // lblBnve
            // 
            this.lblBnve.AutoSize = true;
            this.lblBnve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBnve.ForeColor = System.Drawing.Color.Red;
            this.lblBnve.Location = new System.Drawing.Point(16, 19);
            this.lblBnve.Name = "lblBnve";
            this.lblBnve.Size = new System.Drawing.Size(97, 81);
            this.lblBnve.TabIndex = 0;
            this.lblBnve.Text = "B-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.lblBpve);
            this.panel6.Location = new System.Drawing.Point(27, 379);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 125);
            this.panel6.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(156, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "Donors";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(144, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 50);
            this.label14.TabIndex = 1;
            this.label14.Text = "100";
            // 
            // lblBpve
            // 
            this.lblBpve.AutoSize = true;
            this.lblBpve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBpve.ForeColor = System.Drawing.Color.Red;
            this.lblBpve.Location = new System.Drawing.Point(16, 19);
            this.lblBpve.Name = "lblBpve";
            this.lblBpve.Size = new System.Drawing.Size(115, 81);
            this.lblBpve.TabIndex = 0;
            this.lblBpve.Text = "B+";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.lblABnve);
            this.panel7.Location = new System.Drawing.Point(307, 547);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 125);
            this.panel7.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(156, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Donors";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(144, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 50);
            this.label17.TabIndex = 1;
            this.label17.Text = "100";
            // 
            // lblABnve
            // 
            this.lblABnve.AutoSize = true;
            this.lblABnve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblABnve.ForeColor = System.Drawing.Color.Red;
            this.lblABnve.Location = new System.Drawing.Point(16, 19);
            this.lblABnve.Name = "lblABnve";
            this.lblABnve.Size = new System.Drawing.Size(139, 81);
            this.lblABnve.TabIndex = 0;
            this.lblABnve.Text = "AB-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.lblABpve);
            this.panel8.Location = new System.Drawing.Point(27, 547);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 125);
            this.panel8.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(156, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 23);
            this.label19.TabIndex = 2;
            this.label19.Text = "Donors";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Green;
            this.label20.Location = new System.Drawing.Point(144, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 50);
            this.label20.TabIndex = 1;
            this.label20.Text = "100";
            // 
            // lblABpve
            // 
            this.lblABpve.AutoSize = true;
            this.lblABpve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblABpve.ForeColor = System.Drawing.Color.Red;
            this.lblABpve.Location = new System.Drawing.Point(16, 19);
            this.lblABpve.Name = "lblABpve";
            this.lblABpve.Size = new System.Drawing.Size(157, 81);
            this.lblABpve.TabIndex = 0;
            this.lblABpve.Text = "AB+";
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsearch.Location = new System.Drawing.Point(631, 67);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(69, 25);
            this.lblsearch.TabIndex = 10;
            this.lblsearch.Text = "Search";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(706, 67);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(491, 27);
            this.tbsearch.TabIndex = 11;
            // 
            // gdv
            // 
            this.gdv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv.Location = new System.Drawing.Point(616, 128);
            this.gdv.Name = "gdv";
            this.gdv.RowHeadersWidth = 51;
            this.gdv.RowTemplate.Height = 29;
            this.gdv.Size = new System.Drawing.Size(581, 554);
            this.gdv.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 803);
            this.Controls.Add(this.gdv);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlfooter.ResumeLayout(false);
            this.pnlfooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donersToolStripMenuItem;
        private System.Windows.Forms.Panel pnlfooter;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldev;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldonorsOpve;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblOpve;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOnve;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnve;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApve;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBnve;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBpve;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblABnve;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblABpve;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.DataGridView gdv;
    }
}

