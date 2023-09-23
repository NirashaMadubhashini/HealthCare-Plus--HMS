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
using System.Text.RegularExpressions;


namespace HealthCare_Plus__HMS.Admin
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            loadTbl();
            staffDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(StaffDGV_DataBindingComplete);

            staffDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDGV.MultiSelect = false;
            staffDGV.ReadOnly = true;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        int Key = 0;

        private bool IsValidUserName(string userName)
        {
            // Match only A-Z and a-z letters
            return Regex.IsMatch(userName, "^[A-Za-z]+$");
        }

        private bool IsValidUserContact(string userContact)
        {
            // Match only numbers and should be 10 digits
            return Regex.IsMatch(userContact, @"^\d{10}$");
        }

        private bool IsValidUserPassword(string userPassword)
        {
            // Adjusted the regex pattern to accept underscores along with A-Z, a-z letters, and 0-9 numbers
            return Regex.IsMatch(userPassword, "^[A-Za-z0-9_]+$");
        }

        private bool IsValidUserEmail(string userEmail)
        {
            // Adjusted the regex pattern for the updated requirement
            return Regex.IsMatch(userEmail, @"^[a-z0-9]+@healthcare\.com$");
        }


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

                        staffDGV.AutoResizeColumns();  // Resize columns to fit content
                        staffDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

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
                MessageBox.Show("An error occurred while loading the table. Error details: " + Ex.Message);
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
            if (!IsValidUserName(nameTb.Text))
            {
                MessageBox.Show("Invalid User Name! It should contain only letters A-z.");
                return;
            }

            if (!IsValidUserContact(contactTb.Text))
            {
                MessageBox.Show("Invalid Contact! It should contain exactly 10 numbers.");
                return;
            }

            if (!IsValidUserPassword(passwordTb.Text))
            {
                MessageBox.Show("Invalid Password! It should contain only A-z letters, hyphen and 0-9 numbers.");
                return;
            }

            if (!IsValidUserEmail(emailTb.Text))
            {
                MessageBox.Show("Invalid Email! It should be in the format: username@healthcare.com");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTb.Text) ||
               string.IsNullOrWhiteSpace(contactTb.Text) ||
               string.IsNullOrWhiteSpace(passwordTb.Text) ||
               string.IsNullOrWhiteSpace(emailTb.Text))
            {
                MessageBox.Show("Missing Information");
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

                MessageBox.Show("Staff member has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTbl();
                Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred. Error details: " + Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidUserName(nameTb.Text))
            {
                MessageBox.Show("Invalid User Name! It should contain only letters A-z.");
                return;
            }

            if (!IsValidUserContact(contactTb.Text))
            {
                MessageBox.Show("Invalid Contact! It should contain exactly 10 numbers.");
                return;
            }

            if (!IsValidUserPassword(passwordTb.Text))
            {
                MessageBox.Show("Invalid Password! It should contain only A-z letters, hyphen and 0-9 numbers.");
                return;
            }

            if (!IsValidUserEmail(emailTb.Text))
            {
                MessageBox.Show("Invalid Email! It should be in the format: username@healthcare.com");
                return;
            }
            // Check if the essential fields are filled
            if (string.IsNullOrWhiteSpace(nameTb.Text) ||
                string.IsNullOrWhiteSpace(contactTb.Text) ||
                string.IsNullOrWhiteSpace(passwordTb.Text) ||
                string.IsNullOrWhiteSpace(emailTb.Text)) // Added email validation
            {
                MessageBox.Show("Missing Information");
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
                MessageBox.Show("Staff member details have been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred. Error details: " + Ex.Message);
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
                MessageBox.Show("Staff member has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred. Error details: " + Ex.Message);
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

        private int ConvertToInt(string value)
        {
            int.TryParse(value, out int result);
            return result;
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            roleCb.Items.Add("Doctor");
            roleCb.Items.Add("Admin");
            roleCb.Items.Add("Staff Member");
        }

        private void roleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM UserTbl WHERE userName LIKE @search";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@search", "%" + searchTb.Text + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            staffDGV.DataSource = dt;
            Con.Close();
        }
    }
}
