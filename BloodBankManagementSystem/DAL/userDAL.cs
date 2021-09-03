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
    class userDAL
    {
        static string myconn = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        #region select data frm data base
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconn);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_users";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
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
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);
            try
            {
                string sql = "INSERT INTO tbl_users(username,email,password,full_name,contact,address,added_date,image_name) values (@username,@email,@password,@full_name,@contact,@address,@added_date,@image_name)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name",u.image_name);
                conn.Open();

                int row = cmd.ExecuteNonQuery();
                if(row>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
             }
            catch(Exception ex)
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
        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);
            try
            {
                string sql = "UPDATE tbl_users SET username=@username,email=@email,password=@password,full_name=@full_name,contact=@contact,address=@address,added_date=@added_date,image_name=@image_name WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if(row>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
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
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);
            try
            {
                string sql = "DELETE FROM tbl_users WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("user_id", u.user_id);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if(row>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
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
    }
}
