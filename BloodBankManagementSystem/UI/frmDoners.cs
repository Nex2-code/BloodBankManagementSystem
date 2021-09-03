using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmDoners : Form
    {
        public frmDoners()
        {
            InitializeComponent();
        }
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        userDAL udal = new userDAL();
        string imageName = "no-image.png";
        string rowheaderimage;
        string sourcePath = "";
        string destinationpath = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbldonorid_Click(object sender, EventArgs e)
        {

        }

        private void lstboxdonorgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            d.first_name = txtboxdonorfirstname.Text;
            d.email = txtboxdonoremail.Text;
            d.gender = lstboxdonorgender.Text;
            d.last_name = txtboxdonorlastname.Text;
            d.blood_group = lstboxdonorbloodgroup.Text;
            d.contact = txtboxdonorcontact.Text;
            d.address = txtboxdonoradress.Text;
            d.added_date = DateTime.Now;
            d.image_name = imageName;

            if(imageName != "no-image.png")
            {
                File.Copy(sourcePath, destinationpath);
            }

            string loggedInUser = frmlogin.loggedInUser;
            userBLL user = udal.GetIDFromUsername(loggedInUser);
            d.added_by = user.user_id;
            bool success = dal.Insert(d);
            if (success == true)
            {
                MessageBox.Show("User Added Successfully");
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Fail to add");
            }
        }
        public void clear()
        {
            txtboxdonorfirstname.Text = "";
            txtboxdonoremail.Text = "";
            lstboxdonorgender.Text = "";
            lstboxdonorbloodgroup.Text = "";
            txtboxdonorlastname.Text = "";
            txtboxdonoradress.Text = "";
            txtboxdonorcontact.Text = "";
            txtboxdonorid.Text = "";
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
            string imagepath = path + "\\images\\no-image.png";
            pboxdonor.Image = new Bitmap(imagepath);
        }
        private void frmDoners_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvdonor.DataSource = dt;
        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File (*.jpg;*.jpeg;,*.png)|*.jpg;*.jpeg;,*.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    pboxdonor.Image = new Bitmap(open.FileName);
                    string ext = Path.GetExtension(open.FileName);
                    Random ran = new Random();
                    int RandInt = ran.Next(0, 1000);
                    imageName = "Blood_management_donor_" + RandInt + ext;
                    sourcePath = open.FileName;
                    string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
                    destinationpath = path + "\\images\\" + imageName;
                    
                }
            }
        }

        private void tbdonorsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = tbdonorsearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvdonor.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtboxdonorid.Text);
            if (rowheaderimage != "no-image.png")
            {
                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
                string imagepath = path + "\\images\\" + rowheaderimage;

                clear();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Delete(imagepath);
            }
            bool success = dal.Delete(d);
            if (success == true)
            {
                MessageBox.Show("Delete Successfully");
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to Update");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtboxdonorid.Text);
            d.first_name = txtboxdonorfirstname.Text;
            d.last_name = txtboxdonorlastname.Text;
            d.gender = lstboxdonorgender.Text;
            d.blood_group = lstboxdonorbloodgroup.Text;
            d.email = txtboxdonoremail.Text;
            d.contact = txtboxdonorcontact.Text;
            d.address = txtboxdonoradress.Text;
            d.added_date = DateTime.Now;
            d.image_name = imageName;
            string loggedInUser = frmlogin.loggedInUser;
            userBLL user = udal.GetIDFromUsername(loggedInUser);
            d.added_by = user.user_id;

            if (imageName != "no-image.png")
            {
                File.Copy(sourcePath, destinationpath);
            }

            bool success = dal.Update(d);

            if (rowheaderimage != "no-image.png")
            {
                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
                string imagepath = path + "\\images\\" + rowheaderimage;

                clear();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Delete(imagepath);
            }

            if (success == true)
            {
                MessageBox.Show("Successfully Updated");
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Fail to Update");
            }
        }

        private void dgvdonor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtboxdonorid.Text = dgvdonor.Rows[RowIndex].Cells[0].Value.ToString();
            txtboxdonorfirstname.Text = dgvdonor.Rows[RowIndex].Cells[1].Value.ToString();
            txtboxdonorlastname.Text = dgvdonor.Rows[RowIndex].Cells[2].Value.ToString();
            txtboxdonorcontact.Text = dgvdonor.Rows[RowIndex].Cells[3].Value.ToString();
            txtboxdonoremail.Text = dgvdonor.Rows[RowIndex].Cells[4].Value.ToString();
            lstboxdonorgender.Text = dgvdonor.Rows[RowIndex].Cells[5].Value.ToString();
            txtboxdonoradress.Text = dgvdonor.Rows[RowIndex].Cells[6].Value.ToString();
            lstboxdonorbloodgroup.Text = dgvdonor.Rows[RowIndex].Cells[7].Value.ToString();
            imageName = dgvdonor.Rows[RowIndex].Cells[9].Value.ToString();
            rowheaderimage = imageName;


            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
            if (imageName != "no-image.jpg")
            {
                string imagepath = path + "\\images\\" + imageName;
                pboxdonor.Image = new Bitmap(imagepath);
            }
            else
            {
                string imagepath = path + "\\images\\no-image.png";
                pboxdonor.Image = new Bitmap(imagepath);
            }
        }
    }
}
