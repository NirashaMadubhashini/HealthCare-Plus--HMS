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
            InitializeRoleComboBox(); // Call the method to initialize role combobox items
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        public static string Role;

        // Method to initialize the role combobox items
        private void InitializeRoleComboBox()
        {
            roleCb.Items.Add("Admin");
            roleCb.Items.Add("Doctor");
            roleCb.Items.Add("Staff Member"); // Add staff member role here
            // You can add more roles as per your requirements
        }

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
            roleCb.SelectedIndex = -1; // Set this to -1 to clear the selection
            unameTb.Text = "";
            passTb.Text = "";
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unameTb.Text) || string.IsNullOrEmpty(passTb.Text) || roleCb.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required. Please complete each field before proceeding.");
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
                        switch (dbUserRole)
                        {
                            case "Admin":
                                AdminDashboard adminDashboard = new AdminDashboard();
                                MessageBox.Show("Login successful. Welcome, Admin!");
                                adminDashboard.Show();
                                this.Hide();
                                break;
                            case "Doctor":
                                DoctorDashboard doctorDashboard = new DoctorDashboard();
                                MessageBox.Show("Login successful. Welcome, Doctor!");
                                doctorDashboard.Show();
                                this.Hide();
                                break;
                            case "Staff Member": // Fixed the staff member case
                                StaffDashboard staffDashboard = new StaffDashboard(); // Assuming the class name is StaffDashboard
                                MessageBox.Show("Login successful. Welcome, Staff Member!");
                                staffDashboard.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("The role you selected is not recognized. Please select a valid role.");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected role does not match the credentials provided. Please select the correct role.");
                    }
                }
                else
                {
                    MessageBox.Show("The username or password entered is incorrect. Please try again.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while attempting to log in. Please try again later.");
            }
            finally
            {
                Con.Close();
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlLogin_Paint_1(object sender, PaintEventArgs e)
        {
        }
    }
}
