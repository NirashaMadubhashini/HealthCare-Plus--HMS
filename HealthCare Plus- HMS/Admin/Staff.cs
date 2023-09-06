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

namespace HealthCare_Plus__HMS.Admin
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            DisplayRec();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;
        private void DisplayRec()
        {
            Con.Open();
            string Query = "Select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            StaffDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void Clear()
        {
            RNameTb.Text = "";
            RAddressTb.Text = "";
            RPhoneTb.Text = "";
            RPassword.Text = "";
            Key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RAddressTb.Text == "" || RPhoneTb.Text == "" || RPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StaffTbl(StaffName, StaffAdd, StaffPhone, StaffPass)values(@SN, @SA, @SP, @SPA)", Con);
                    cmd.Parameters.AddWithValue("@SN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@SA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SPA", RPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Member Added");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RAddressTb.Text == "" || RPhoneTb.Text == "" || RPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update StaffTbl set StaffName=@SN,StaffAdd=@SA,StaffPhone=@SP,StaffPass=@SPA where StaffId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@SA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SPA", RPassword.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Member Updated");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Staff Member");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from StaffTbl where StaffId = @SKey", Con); // Fixed typo and added '='
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Member Deleted");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = StaffDGV.Rows[e.RowIndex];

                RNameTb.Text = row.Cells["StaffName"].Value?.ToString() ?? ""; // Using column name for clarity
                RAddressTb.Text = row.Cells["StaffAdd"].Value?.ToString() ?? "";
                RPhoneTb.Text = row.Cells["StaffPhone"].Value?.ToString() ?? "";
                RPassword.Text = row.Cells["StaffPass"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(RNameTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["StaffId"].Value?.ToString() ?? "0");  // Use StaffId or appropriate unique key field
                }
            }
        }
    }
}
