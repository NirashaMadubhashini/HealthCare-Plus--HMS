using HealthCare_Plus__HMS.Admin;
using HealthCare_Plus__HMS.Doctor;
using HealthCare_Plus__HMS.Staff;
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

namespace HealthCare_Plus__HMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        public static string Role;
        private void iconPictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            roleCb.SelectedIndex = 0;
            unameTb.Text = "";
            passTb.Text = "";

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(unameTb.Text) || string.IsNullOrEmpty(passTb.Text) || roleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                Con.Open();

                string query = "SELECT userRole FROM UserTbl WHERE userName=@userName AND userPassword=@userPassword";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@userName", unameTb.Text);
                cmd.Parameters.AddWithValue("@userPassword", passTb.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string dbUserRole = reader["userRole"].ToString();
                    if (dbUserRole == roleCb.SelectedItem.ToString())
                    {
                        // Correct Role and Credentials
                        switch (dbUserRole)
                        {
                            case "Admin":
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                                this.Hide();
                                break;
                            case "Doctor":
                                DoctorDashboard doctorDashboard = new DoctorDashboard();
                                doctorDashboard.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Invalid Role selected.");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Role mismatch. Please select the correct role.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials. Please try again.");
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

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
