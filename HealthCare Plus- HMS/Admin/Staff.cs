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
using System.Xml.Linq;

namespace HealthCare_Plus__HMS.Admin
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            loadTbl();
            staffDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(StaffDGV_DataBindingComplete);

        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        int Key = 0;

        private void loadTbl()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True"))
                {
                    Con.Open();
                    string Query = "Select user_id, userName, userPassword, userRole, userEmail, userContact, userDateCreated, userLastLogin from UserTbl";
                    using (SqlDataAdapter sda = new SqlDataAdapter(Query, Con))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                        var ds = new DataSet();
                        sda.Fill(ds);
                        staffDGV.DataSource = ds.Tables[0];

                        // Change the column names
                        staffDGV.Columns["user_id"].HeaderText = "User ID";
                        staffDGV.Columns["userName"].HeaderText = "User Name";
                        staffDGV.Columns["userPassword"].HeaderText = "Password";
                        staffDGV.Columns["userRole"].HeaderText = "Role";
                        staffDGV.Columns["userEmail"].HeaderText = "Email";
                        staffDGV.Columns["userContact"].HeaderText = "Contact";
                        staffDGV.Columns["userDateCreated"].HeaderText = "Date Created";
                        staffDGV.Columns["userLastLogin"].HeaderText = "Last Login";

                        staffDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }



        private void Clear()
        {
            nameTb.Text = "";
            contactTb.Text = "";
            passwordTb.Text = "";
            emailTb.Text = "";
            roleCb.Text = "";
            Key = 0;
        }
        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTb.Text) ||
               string.IsNullOrWhiteSpace(contactTb.Text) ||
               string.IsNullOrWhiteSpace(passwordTb.Text) ||
               string.IsNullOrWhiteSpace(emailTb.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            // Email validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailTb.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid Email Address");
                return;
            }


            // Contact number validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(contactTb.Text, @"^[0-9\-\+\s]+$"))
            {
                MessageBox.Show("Invalid Contact Number");
                return;
            }


            // Password validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(passwordTb.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, and one number.");
                return;
            }


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl(userName,userPassword, userRole, userEmail, userContact,userLastLogin) VALUES(@SN, @SPA, @SR, @SE, @SP,@SL)", Con);
                cmd.Parameters.AddWithValue("@SN",nameTb.Text);
                cmd.Parameters.AddWithValue("@SPA",passwordTb.Text); // This should ideally be hashed and salted
/*                cmd.Parameters.AddWithValue("@SR", roleCb.SelectedItem.ToString());
*/                cmd.Parameters.AddWithValue("@SR", roleCb.Text);
                cmd.Parameters.AddWithValue("@SE", emailTb.Text);
                cmd.Parameters.AddWithValue("@SP", contactTb.Text);
                cmd.Parameters.AddWithValue("@SL", DateTime.Now); // Set userLastLogin to current date and time
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Member Added");
                loadTbl();
                Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Check if the essential fields are filled
            if (string.IsNullOrWhiteSpace(nameTb.Text) ||
                string.IsNullOrWhiteSpace(contactTb.Text) ||
                string.IsNullOrWhiteSpace(passwordTb.Text) ||
                string.IsNullOrWhiteSpace(emailTb.Text)) // Added email validation
            {
                MessageBox.Show("Missing Information");
                return;
            }
            // Email validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailTb.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid Email Address");
                return;
            }


            // Contact number validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(contactTb.Text, @"^[0-9\-\+\s]+$"))
            {
                MessageBox.Show("Invalid Contact Number");
                return;
            }


            // Password validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(passwordTb.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, and one number.");
                return;
            }

            try
            {
                // Open database connection
                Con.Open();

                // Prepare SQL command to update the details of the selected user
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET userName=@SN, userContact=@SP, userPassword=@SPA, userEmail=@SE, userRole=@SR, userLastLogin=@SL  WHERE user_id=@SKey", Con);
                cmd.Parameters.AddWithValue("@SN", nameTb.Text);
                cmd.Parameters.AddWithValue("@SP", contactTb.Text);
                cmd.Parameters.AddWithValue("@SPA", passwordTb.Text);
                cmd.Parameters.AddWithValue("@SE", emailTb.Text);
               /* cmd.Parameters.AddWithValue("@SR", roleCb.SelectedItem.ToString());*/
                cmd.Parameters.AddWithValue("@SR", roleCb.Text);
                cmd.Parameters.AddWithValue("@SL", DateTime.Now); // Update userLastLogin to current date and time
                cmd.Parameters.AddWithValue("@SKey", Key);

                // Execute the SQL command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Member Updated");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                // Close database connection, refresh the table view and clear the input fields
                Con.Close();
                loadTbl();
                Clear();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if a staff member is selected
            if (Key == 0)
            {
                MessageBox.Show("Select the Staff Member");
                return;
            }

            try
            {
                // Open database connection
                Con.Open();

                // Prepare SQL command to delete the selected user
                SqlCommand cmd = new SqlCommand("DELETE FROM UserTbl WHERE user_id = @SKey", Con);
                cmd.Parameters.AddWithValue("@SKey", Key);

                // Execute the SQL command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Member Deleted");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                // Close database connection, refresh the table view and clear the input fields
                Con.Close();
                loadTbl();
                Clear();
            }
        }
        private void StaffDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in staffDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  // Exit if the row index is not valid

            DataGridViewRow row = staffDGV.Rows[e.RowIndex];

            // Safely retrieve cell values using a helper function
            nameTb.Text = GetCellValue(row, "userName");
            contactTb.Text = GetCellValue(row, "userContact");
            passwordTb.Text = GetCellValue(row, "userPassword");
            emailTb.Text = GetCellValue(row, "userEmail");
            roleCb.Text = GetCellValue(row, "userRole");

            // Use the helper function to convert the StaffId (or user_id) to an integer
            Key = ConvertToInt(GetCellValue(row, "user_id"));
        }

        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName]?.Value?.ToString() ?? "";
        }

        // Helper function to safely convert strings to integers
        private int ConvertToInt(string value)
        {
            int.TryParse(value, out int result);
            return result;
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            roleCb.Items.Add("Doctor");
            roleCb.Items.Add("Admin");
            roleCb.Items.Add("Nurse");
            roleCb.Items.Add("Receptionist");
        }

        private void roleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
