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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCare_Plus__HMS.Doctor
{
    public partial class PatientRecords : Form
    {
        private string _userName;
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public PatientRecords(string userName)
        {
            InitializeComponent();
            // Improve DataGridView initial settings
            patRecordsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patRecordsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patRecordsDGV.MultiSelect = false;
            patRecordsDGV.ReadOnly = true;

            _userName = userName;
            LoadPatientIds();
            LoadAllPatientDetails();
        }

        private void LoadPatientIds()
        {
            try
            {
                Con.Open();

                string query = @"SELECT DISTINCT p.patient_id
                        FROM PatientTbl p
                        INNER JOIN AppointmentTbl a ON p.patient_id = a.patient_id
                        INNER JOIN UserTbl u ON a.doctor_id = u.user_id
                        WHERE u.userName = @userName";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@userName", _userName);

                SqlDataReader reader = cmd.ExecuteReader();

                patIdCb.Items.Clear(); // clear existing items
                while (reader.Read())
                {
                    patIdCb.Items.Add(reader["patient_id"].ToString());
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
        private void patIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patIdCb.SelectedIndex != -1) // Make sure something is selected
            {
                LoadPatientDetails(patIdCb.SelectedItem.ToString());
            }
        }

        private void LoadPatientDetails(string patientId)
        {
            try
            {
                Con.Open();

                string query = @"SELECT PatientFirstName, PatientLastName, PatientContact, PatientMedicalHistory
                                FROM PatientTbl
                                WHERE patient_id = @patientId";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@patientId", patientId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    patFullNameTb.Text = $"{reader["PatientFirstName"]} {reader["PatientLastName"]}";
                    patContactTb.Text = reader["PatientContact"].ToString();
                    patMedicineTb.Text = reader["PatientMedicalHistory"].ToString();
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

        private void LoadAllPatientDetails()
        {
            try
            {
                Con.Open();

                string query = @"
            SELECT DISTINCT p.patient_id AS 'Patient ID', p.PatientFirstName AS 'First Name', 
                           p.PatientLastName AS 'Last Name', p.PatientContact AS 'Contact', 
                           p.PatientMedicalHistory AS 'Medical History'
            FROM PatientTbl p
            INNER JOIN AppointmentTbl a ON p.patient_id = a.patient_id
            INNER JOIN UserTbl u ON a.doctor_id = u.user_id
            WHERE u.userName = @userName";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@userName", _userName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                patRecordsDGV.DataSource = dt;

                // Improve DataGridView appearance
                patRecordsDGV.AutoResizeColumns();  // Resize columns to fit content
                patRecordsDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;  // Set alternating row colors
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



        private void patNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void patContactTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void patMedicineTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void patRecordsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
  
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (patIdCb.SelectedIndex != -1) // Ensure a patient is selected.
            {
                UpdatePatientDetails(patIdCb.SelectedItem.ToString());
                LoadAllPatientDetails(); // Refresh the table
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }

        private void UpdatePatientDetails(string patientId)
        {
            try
            {
                Con.Open();

                // Splitting the full name into first and last names.
                string[] names = patFullNameTb.Text.Split(' ');
                string firstName = names[0];
                string lastName = names.Length > 1 ? names[1] : "";  // Handling case if only first name is present.

                string query = @"UPDATE PatientTbl
                                 SET PatientFirstName = @firstName, PatientLastName = @lastName, PatientContact = @contact, PatientMedicalHistory = @medicalHistory
                                 WHERE patient_id = @patientId";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@contact", patContactTb.Text);
                cmd.Parameters.AddWithValue("@medicalHistory", patMedicineTb.Text);
                cmd.Parameters.AddWithValue("@patientId", patientId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient details updated successfully!");
                }
                else
                {
                    MessageBox.Show("Error updating patient details.");
                }

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

        private void searchTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
