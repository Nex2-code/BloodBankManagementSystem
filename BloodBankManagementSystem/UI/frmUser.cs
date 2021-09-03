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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        string imageName = "no-image.png";
        string rowheaderimage;
        string sourcePath = "";
        string destinationpath = "";
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

            if(imageName != "no-image.png")
            {
                File.Copy(sourcePath, destinationpath);
            }
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
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
            string imagepath = path + "\\images\\no-image.png";
            pbox.Image = new Bitmap(imagepath);
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

            if (imageName != "no-image.png")
            {
                File.Copy(sourcePath, destinationpath);
            }

            bool success = dal.Update(u);
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
            imageName = dgvuser.Rows[RowIndex].Cells[8].Value.ToString();

            rowheaderimage = imageName;


            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
            if(imageName != "no-image.jpg")
            {
                string imagepath = path + "\\images\\" + imageName;
                pbox.Image = new Bitmap(imagepath);
            }
            else
            {
                string imagepath = path + "\\images\\no-image.png";
                pbox.Image = new Bitmap(imagepath);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtboxid.Text); 
            if(rowheaderimage != "no-image.png")
            {
                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
                string imagepath = path + "\\images\\" + rowheaderimage;

                clear();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                
                File.Delete(imagepath);
            }

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

        private void btnimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File (*.jpg;*.jpeg;,*.png)|*.jpg;*.jpeg;,*.png;";
            if(open.ShowDialog()==DialogResult.OK)
            {
                if(open.CheckFileExists)
                {
                    pbox.Image = new Bitmap(open.FileName);
                    string ext = Path.GetExtension(open.FileName);
                    Random ran = new Random();
                    int RandInt = ran.Next(0, 1000);
                    imageName = "Blood_management_user_" + RandInt + ext;
                    sourcePath = open.FileName;
                    string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);
                    destinationpath = path + "\\images\\" + imageName;                       
                }
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = tbusersearch.Text;
            if(keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvuser.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvuser.DataSource = dt;
            }
        }
    }
}
