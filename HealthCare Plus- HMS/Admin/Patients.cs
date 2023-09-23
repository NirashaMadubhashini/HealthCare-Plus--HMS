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
using System.Windows.Input;
using System.Text.RegularExpressions;


namespace HealthCare_Plus__HMS.Admin
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPatients();
            patDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(patDGV_DataBindingComplete);

            patDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patDGV.MultiSelect = false;
            patDGV.ReadOnly = true;


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

        private void DisplayPatients()
        {
            Con.Open();
            string Query = "Select * from PatientTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            // Improve DataGridView appearance
            patDGV.AutoResizeColumns();  // Resize columns to fit content
            patDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            patDGV.DataSource = ds.Tables[0];
            patDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void PatNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(patFirstNameTb.Text) ||
        string.IsNullOrWhiteSpace(patLastNameTb.Text) ||
        string.IsNullOrWhiteSpace(patDOBCb.Text) ||
        patGenCb.SelectedIndex == -1 ||
        string.IsNullOrWhiteSpace(patPhoneTb.Text) ||
        string.IsNullOrWhiteSpace(patAddressTb.Text) ||
        string.IsNullOrWhiteSpace(patMedHistoryTb.Text))
            {
                MessageBox.Show("Please complete all fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
                    cmd.Parameters.AddWithValue("@PA", patAddressTb.Text);
                    cmd.Parameters.AddWithValue("@PMH", patMedHistoryTb.Text);
                    cmd.Parameters.AddWithValue("@PRD", DateTime.Now); // Set userLastLogin to current date and time
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient has been successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayPatients();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occurred while adding the patient: " + Ex.Message);
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
                MessageBox.Show("Please complete all fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

                    MessageBox.Show("Patient details have been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayPatients();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occurred while updating the patient details: " + Ex.Message);
                }
            }
        }

        private void patDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in patDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void patDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = patDGV.Rows[e.RowIndex];

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
            patDGV.DataSource = dt;


            Con.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select the patient you want to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl  where patient_id= @PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient has been successfully deleted from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayPatients();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occurred while deleting the patient: " + Ex.Message);
                }
            }
            }

        private void patGenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
