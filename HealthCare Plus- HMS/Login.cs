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

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Role;
        private void iconPictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Resetlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoleCb.SelectedIndex = 0;
            UnameTb.Text = "";
            PassTb.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select Your Position");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }
                else if (UnameTb.Text == "Admin" && PassTb.Text == "123")
                {
                    Role = "Admin";
                    AdminDashboard obj = new AdminDashboard();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Admin UserName and Password");
                }
            }
            else if (RoleCb.SelectedIndex == 1)
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Doctor Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from DoctorTbl where DocName= '" + UnameTb.Text + " ' and  DocPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doctor";
                        DoctorDashboard obj = new DoctorDashboard();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found");
                    }
                    Con.Close();
                }
            }
            else
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Staff Member Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from StaffTbl where StaffName= '" + UnameTb.Text + " ' and  StaffPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Staff";
                        StaffDashboard obj = new StaffDashboard();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Staff Member Not Found");
                    }
                    Con.Close();
                }
            }
        }
    }
}
