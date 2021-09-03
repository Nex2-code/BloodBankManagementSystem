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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        string imageName = "no-image.jpg";

        private void frmUser_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvuser.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            u.full_name = txtboxfullname.Text;
            u.email = txtboxemail.Text;
            u.username = txtboxusername.Text;
            u.password = txtpassword.Text;
            u.contact = txtboxcontact.Text;
            u.address = txtboxadress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;
            bool success = dal.Insert(u);
            if(success == true)
            {
                MessageBox.Show("User Added Successfully");
                DataTable dt = dal.Select();
                dgvuser.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Fail to add");
            }
        }
        public void clear()
        {
            txtboxfullname.Text = "";
            txtboxemail.Text = "";
            txtboxusername.Text = "";
            txtpassword.Text = "";
            txtboxcontact.Text = "";
            txtboxadress.Text = "";
            txtboxid.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtboxid.Text);
            u.full_name = txtboxfullname.Text;
            u.email = txtboxemail.Text;
            u.username = txtboxusername.Text;
            u.password = txtpassword.Text;
            u.contact = txtboxcontact.Text;
            u.address = txtboxadress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;
            bool success = dal.Update(u);
            if(success == true)
            {
                MessageBox.Show("Successfully Updated");
                DataTable dt = dal.Select();
                dgvuser.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Fail to Update");
            }

        }

        private void dgvuser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtboxid.Text = dgvuser.Rows[RowIndex].Cells[0].Value.ToString();
            txtboxusername.Text = dgvuser.Rows[RowIndex].Cells[1].Value.ToString();
            txtboxemail.Text = dgvuser.Rows[RowIndex].Cells[2].Value.ToString();
            txtpassword.Text = dgvuser.Rows[RowIndex].Cells[3].Value.ToString();
            txtboxfullname.Text = dgvuser.Rows[RowIndex].Cells[4].Value.ToString();        
            txtboxcontact.Text = dgvuser.Rows[RowIndex].Cells[5].Value.ToString();
            txtboxadress.Text = dgvuser.Rows[RowIndex].Cells[6].Value.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtboxid.Text); 
            bool success = dal.Delete(u);
            if(success == true)
            {
                MessageBox.Show("Delete Successfully");
                DataTable dt = dal.Select();
                dgvuser.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to Update");
            }
        }
    }
}
