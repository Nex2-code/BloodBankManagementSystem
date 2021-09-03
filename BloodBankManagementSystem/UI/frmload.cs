using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmload : Form
    {
        public frmload()
        {
            InitializeComponent();
        }
        int move = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 24;
            panel2.Width += 10;
            move += 10;
            if(move == 700)
            {
                timer1.Stop();
                this.Hide();

                frmlogin login = new frmlogin();
                login.Show();
            }
        }

        private void frmload_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
