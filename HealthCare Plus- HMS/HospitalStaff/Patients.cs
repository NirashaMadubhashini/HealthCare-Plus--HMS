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

namespace HealthCare_Plus__HMS.Staff
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPat();
            patientsDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(PatientsDGV_DataBindingComplete);

        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        int Key = 0;
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
            if (patFirstNameTb.Text == "" || patLastNameTb.Text == "" || patDOBCb.Text == "" || patGenCb.SelectedIndex == -1 || patPhoneTb.Text == ""  || patAddressTb.Text == "" || patMedHistoryTb.Text == "")

            {
                MessageBox.Show("Missing Information");
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
                    MessageBox.Show("Patient Added");
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (patFirstNameTb.Text == "" || patLastNameTb.Text == "" || patDOBCb.Text == "" || patGenCb.SelectedIndex == -1 || patPhoneTb.Text == "" || patAddressTb.Text == "" || patMedHistoryTb.Text == "")
            {
                MessageBox.Show("Missing Information");
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
                    MessageBox.Show("Patient Updated");
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl  where patient_id= @PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted");
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
    }
}
