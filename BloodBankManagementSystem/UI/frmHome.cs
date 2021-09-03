using BloodBankManagementSystem.DAL;
using BloodBankManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
            donorDAL dal = new donorDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            allDonorCount();
            DataTable dt = new DataTable();
            gdv.DataSource = dt;
            labuserlogname.Text = frmlogin.loggedInUser;
        }
        public void allDonorCount()
        {
            lblcountOpve.Text = dal.donorcount("O+");
            lblcountOnve.Text = dal.donorcount("O-");
            lblcountApve.Text = dal.donorcount("A+");
            lblcountAnve.Text = dal.donorcount("A-");
            lblcountBpve.Text = dal.donorcount("B+");
            lblcountBnve.Text = dal.donorcount("B-");
            lblcountABpve.Text = dal.donorcount("AB+");
            lblcountABnve.Text = dal.donorcount("AB-");
        }

        private void lblfooter_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void donersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoners donor = new frmDoners();
            donor.Show();
        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            allDonorCount();
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = tbsearch.Text;
            if(keyword != "")
            {
                DataTable dt = dal.Search(keyword);
                gdv.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                gdv.DataSource = dt;
            }
        }
    }
}
