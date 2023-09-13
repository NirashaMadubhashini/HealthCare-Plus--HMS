using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus__HMS.Doctor
{
    public partial class Profile : Form
    {
        private string _userName;
        private string _userPassword;

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public Profile(string userName, string userPassword)
        {
            InitializeComponent();
            _userName = userName;
            _userPassword = userPassword;
            LoadDoctorDetails();
        }

        private void LoadDoctorDetails()
        {
            try
            {
                Con.Open();

                // Construct the SQL query
                string query = @"SELECT u.user_id, u.userName, u.userContact, u.userEmail, 
                            dp.doctorSpecialization, dp.doctorQualifications,dp.roomNumber
                    FROM UserTbl u
                    INNER JOIN DoctorTbl dp ON u.user_id = dp.doctor_id
                    WHERE u.userName =@userName AND u.userPassword =@userPassword";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@userName", _userName);
                cmd.Parameters.AddWithValue("@userPassword", _userPassword); // Consider hashing the password

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    docIdTb.Text = reader["user_id"].ToString();
                    docNameTb.Text = reader["userName"].ToString();
                    docPhoneTb.Text = reader["userContact"].ToString();
                    docEmailTb.Text = reader["userEmail"].ToString();
                    docSpecTb.Text = reader["doctorSpecialization"].ToString();
                    docRoomTb.Text = reader["roomNumber"].ToString();
                    experienceTb.Text = reader["doctorQualifications"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }





        private void docNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docEmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docSpecTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docRoomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void experienceTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
