using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus__HMS.Staff
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPat();
            patientsDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(PatientsDGV_DataBindingComplete);

            patientsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientsDGV.MultiSelect = false;
            patientsDGV.ReadOnly = true;

        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        int Key = 0;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (ActiveControl == patFirstNameTb)
                {
                    patLastNameTb.Focus();
                }
                else if (ActiveControl == patLastNameTb)
                {
                    patPhoneTb.Focus();
                }
                else if (ActiveControl == patPhoneTb)
                {
                    patAddressTb.Focus();
                }
                else if (ActiveControl == patAddressTb)
                {
                    patMedHistoryTb.Focus();
                }
                return true; // Indicate that you've handled this key
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private bool ValidateInputs()
        {
            // Validation for PatientFirstName and PatientLastName
            Regex namePattern = new Regex(@"^[A-Za-z\s]+$");

            if (!namePattern.IsMatch(patFirstNameTb.Text))
            {
                MessageBox.Show("First name can only contain A-Z letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!namePattern.IsMatch(patLastNameTb.Text))
            {
                MessageBox.Show("Last name can only contain A-Z letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validation for PatientContact
            Regex phonePattern = new Regex(@"^\d{10}$");

            if (!phonePattern.IsMatch(patPhoneTb.Text))
            {
                MessageBox.Show("Contact should only contain 10 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validation for PatientAddress
            if (!namePattern.IsMatch(patAddressTb.Text))
            {
                MessageBox.Show("Address can only contain A-Z letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void DisplayPat()
        {
            Con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            patientsDGV.DataSource = ds.Tables[0];
            patientsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            patientsDGV.AutoResizeColumns();  // Resize columns to fit content
            patientsDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            Con.Close();
        }

        private void Clear()
        {
            patFirstNameTb.Text = "";
            patLastNameTb.Text = "";
            patDOBCb.Text = "";
            patGenCb.SelectedIndex = -1;
            patPhoneTb.Text = "";
            patAddressTb.Text = "";
            patMedHistoryTb.Text = "";
            Key = 0;
        }
        private void PatNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            if (patFirstNameTb.Text == "" || patLastNameTb.Text == "" || patDOBCb.Text == "" || patGenCb.SelectedIndex == -1 || patPhoneTb.Text == ""  || patAddressTb.Text == "" || patMedHistoryTb.Text == "")

            {
                MessageBox.Show("Missing Essential Information. Please fill in all the fields."); // Error message for missing information
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatientFirstName,PatientLastName,PatientDOB,PatientGender,PatientContact,PatientAddress,PatientMedicalHistory,PatientRegisteredDate )values(@PFN,@PLN,@PDOB,@PG,@PP,@PA,@PMH,@PRD)", Con);
                    cmd.Parameters.AddWithValue("@PFN", patFirstNameTb.Text);
                    cmd.Parameters.AddWithValue("@PLN", patLastNameTb.Text);
                    cmd.Parameters.AddWithValue("@PDOB", patDOBCb.Value.Date);
                    cmd.Parameters.AddWithValue("@PG", patGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", patPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PA",patAddressTb.Text);
                    cmd.Parameters.AddWithValue("@PMH", patMedHistoryTb.Text);
                    cmd.Parameters.AddWithValue("@PRD", DateTime.Now); // Set userLastLogin to current date and time
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An Error Occurred: " + Ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            if (patFirstNameTb.Text == "" || patLastNameTb.Text == "" || patDOBCb.Text == "" || patGenCb.SelectedIndex == -1 || patPhoneTb.Text == "" || patAddressTb.Text == "" || patMedHistoryTb.Text == "")
            {
                MessageBox.Show("Missing Essential Information. Please fill in all the fields."); // Error message for missing information
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTbl  set PatientFirstName=@PFN,PatientLastName=@PLN,PatientDOB=@PDOB,PatientGender=@PG,PatientContact=@PP,PatientAddress=@PA,PatientMedicalHistory=@PMH,PatientRegisteredDate=@PRD  where patient_id=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PFN", patFirstNameTb.Text);
                    cmd.Parameters.AddWithValue("@PLN", patLastNameTb.Text);
                    cmd.Parameters.AddWithValue("@PDOB", patDOBCb.Value.Date);
                    cmd.Parameters.AddWithValue("@PG", patGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", patPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PA", patAddressTb.Text);
                    cmd.Parameters.AddWithValue("@PMH", patMedHistoryTb.Text);
                    cmd.Parameters.AddWithValue("@PRD", DateTime.Now); // Set userLastLogin to current date and time
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An Error Occurred: " + Ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("No Patient Selected. Please select a patient to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl  where patient_id= @PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PatientsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in patientsDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = patientsDGV.Rows[e.RowIndex];

                patFirstNameTb.Text = row.Cells["PatientFirstName"].Value?.ToString() ?? "";
                patLastNameTb.Text = row.Cells["PatientLastName"].Value?.ToString() ?? "";
                patGenCb.SelectedItem = row.Cells["PatientGender"].Value?.ToString() ?? "";
                patPhoneTb.Text = row.Cells["PatientContact"].Value?.ToString() ?? "";
                patAddressTb.Text = row.Cells["PatientAddress"].Value?.ToString() ?? "";
                patMedHistoryTb.Text = row.Cells["PatientMedicalHistory"].Value?.ToString() ?? "";
                // Use the DateTimePicker's Value property to set its value
                if (DateTime.TryParse(row.Cells["PatientDOB"].Value?.ToString(), out DateTime result))
                {
                    patDOBCb.Value = result;
                }

                if (string.IsNullOrEmpty(patFirstNameTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["patient_id"].Value?.ToString() ?? "0");
                }
            }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM PatientTbl WHERE PatientFirstName LIKE @search OR PatientLastName LIKE @search";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@search", "%" + searchTb.Text + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            patientsDGV.DataSource = dt;
            Con.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
