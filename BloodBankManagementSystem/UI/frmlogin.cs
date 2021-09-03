using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedInUser;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            l.username = textBox1.Text;
            l.password = textBox2.Text;
            bool isSuccess = dal.logincheck(l);
            if(isSuccess == true)
            {
                loggedInUser = l.username;
                MessageBox.Show("Login Successful");
                frmHome home = new frmHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }
    }
}
