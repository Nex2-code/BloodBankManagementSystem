using BloodBankManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BloodBankManagementSystem.DAL
{
    class donorDAL
    {
        static string myconn = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        #region select data frm data base
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconn);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_donors";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region insert data base into user
        public bool Insert(donorBLL d)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);
            try
            {
                string sql = "INSERT INTO tbl_donors(first_name,email,gender,last_name,blood_group,contact,address,added_date,image_name,added_by) values (@first_name,@email,@gender,@last_name,@blood_group,@contact,@address,@added_date,@image_name,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                conn.Open();

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return isSuccess;
        }
        #endregion
        #region update data base
        public bool Update(donorBLL d)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);
            try
            {
                string sql = "UPDATE tbl_donors SET first_name=@first_name,email=@email,last_name=@last_name,blood_group=@blood_group,gender=@gender,contact=@contact,address=@address,added_date=@added_date,image_name=@image_name,added_by=@added_by WHERE donor_id=@donor_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Delete data 
        public bool Delete( donorBLL d)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);
            try
            {
                string sql = "DELETE FROM tbl_donors WHERE donor_id=@donor_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("donor_id", d.donor_id);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region search
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconn);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_donors WHERE donor_id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "%' OR blood_group LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region donor count
        public string donorcount(string blood_group)
        {
            SqlConnection conn = new SqlConnection(myconn);
            string donor = "0";
            try
            {
                string sql = "SELECT * FROM tbl_donors WHERE blood_group = '" + blood_group + "'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                donor = dt.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return donor;

        }
        #endregion
    }
}
