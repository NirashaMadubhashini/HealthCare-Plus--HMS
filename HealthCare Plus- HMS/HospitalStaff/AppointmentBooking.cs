using FontAwesome.Sharp;
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
    public partial class AppointmentBooking : Form
    {
        private int selectedAppointmentId = -1;
        private Dictionary<string, string> patientNameToIdMap = new Dictionary<string, string>();
        private Dictionary<string, (string doctorSpecialization, string roomNumber)> DoctorNameToDetailsMap = new Dictionary<string, (string doctorSpecialization, string roomNumber)>();
        public AppointmentBooking()
        {
            InitializeComponent();
            LoadPatientNames();
            LoadDoctorNames();
            LoadAppointmentsIntoDataGridView();
            appoinmenysLoadDGV.CellClick += AppoinmenysLoadDGV_CellClick;

        }


        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void ClearFields()
        {
            // Clear all the text boxes, combo boxes, etc. to their default states
            patNameCb.SelectedItem = null;
            docNameCb.SelectedItem = null;
            appoinmentNoteTb.Text = string.Empty;
            patContactTb.Text = string.Empty;
            specializationTb.Text = string.Empty;
            docRoomNumTb.Text = string.Empty;
            statusCb.SelectedItem = null;

            // Reset date picker to current date
            appointmentDateDTP.Value = DateTime.Now;

            // Clear the selected appointment ID
            selectedAppointmentId = -1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void appoinmenysLoadDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadPatientNames()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT PatientContact, PatientFirstName FROM PatientTbl", Con);
                SqlDataReader reader = cmd.ExecuteReader();

                patNameCb.Items.Clear();
                while (reader.Read())
                {
                    string patientName = reader["PatientFirstName"].ToString();
                    string patientId = reader["PatientContact"].ToString();

                    patNameCb.Items.Add(patientName);

                    // Store the patient ID with the corresponding name in the dictionary
                    patientNameToIdMap[patientName] = patientId;
                }
                reader.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error while loading patient names", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }

        }

        private void LoadDoctorNames()
        {
            docNameCb.Items.Clear();

            try
            {
                Con.Open();
                // Modify your SQL query to also fetch the specialization and room number
                // by joining UserTbl and DoctorTbl
                SqlCommand cmd = new SqlCommand("SELECT U.userName, D.doctorSpecialization, D.roomNumber FROM UserTbl U JOIN DoctorTbl D ON U.user_id = D.doctor_id WHERE U.userRole = 'Doctor'", Con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string docName = reader.GetString(0);
                    docNameCb.Items.Add(docName);

                    // Store the doctor specialization and room number in the dictionary
                    DoctorNameToDetailsMap[docName] = (reader.GetString(1), reader.GetString(2));
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

        private void patNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patNameCb.SelectedItem != null)
            {
                string selectedName = patNameCb.SelectedItem.ToString();

                // Get the patient ID from the dictionary using the selected name
                if (patientNameToIdMap.TryGetValue(selectedName, out string patientId))
                {
                    // Display the patient ID in the patIdTb TextBox
                    patContactTb.Text = patientId;
                }
            }
        }

        private void patIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (docNameCb.SelectedItem != null)
            {
                string selectedName = docNameCb.SelectedItem.ToString();

                // Get the doctor details from the dictionary using the selected name
                if (DoctorNameToDetailsMap.TryGetValue(selectedName, out var doctorDetails))
                {
                    // Display the doctor details in the respective text boxes
                    specializationTb.Text = doctorDetails.doctorSpecialization;
                    docRoomNumTb.Text = doctorDetails.roomNumber;
                }
            }
        }

        private void sheduleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the necessary details from the form controls
                string selectedPatientName = patNameCb.SelectedItem?.ToString();
                string selectedDoctorName = docNameCb.SelectedItem?.ToString();
                string appointmentNotes = appoinmentNoteTb.Text;
                string appointmentStatus = statusCb.SelectedItem?.ToString();
                DateTime appointmentDate = appointmentDateDTP.Value;

                // Get the patient ID and doctor ID from the respective dictionaries
                if (patientNameToIdMap.TryGetValue(selectedPatientName, out string patientContact))
                {
                    if (DoctorNameToDetailsMap.TryGetValue(selectedDoctorName, out var doctorDetails))
                    {
                        // Open the database connection
                        Con.Open();

                        // Find the user ID of the doctor from the UserTbl
                        SqlCommand findDoctorIdCmd = new SqlCommand("SELECT user_id FROM UserTbl WHERE userName = @docName", Con);
                        findDoctorIdCmd.Parameters.AddWithValue("@docName", selectedDoctorName);
                        int doctorId = (int)findDoctorIdCmd.ExecuteScalar();

                        // Create a SQL command to insert the new appointment record
                        SqlCommand cmd = new SqlCommand("INSERT INTO AppointmentTbl (patient_id, doctor_id, appointmentDate, appointmentStatus, appointmentnotes) VALUES ((SELECT patient_id FROM PatientTbl WHERE PatientContact = @patContact), @docId, @appDate, @appStatus, @appNotes)", Con);
                        cmd.Parameters.AddWithValue("@patContact", patientContact);
                        cmd.Parameters.AddWithValue("@docId", doctorId);
                        cmd.Parameters.AddWithValue("@appDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@appStatus", appointmentStatus);
                        cmd.Parameters.AddWithValue("@appNotes", appointmentNotes);

                        // Execute the SQL command
                        cmd.ExecuteNonQuery();

                        // Inform the user that the appointment has been scheduled
                        MessageBox.Show("Appointment Scheduled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Doctor not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                LoadAppointmentsIntoDataGridView();
            }
        }

        private void AppoinmenysLoadDGV_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0) // Make sure user select at least one row 
    {
        DataGridViewRow row = appoinmenysLoadDGV.Rows[e.RowIndex];

        selectedAppointmentId = Convert.ToInt32(row.Cells[0].Value);

        // Assuming that column index 1 contains patient name and column index 2 contains doctor name
        patNameCb.SelectedItem = row.Cells[1].Value.ToString();
        docNameCb.SelectedItem = row.Cells[2].Value.ToString();

        // Set other fields using appropriate column indexes
        appointmentDateDTP.Value = Convert.ToDateTime(row.Cells[3].Value);
        statusCb.SelectedItem = row.Cells[4].Value.ToString();
        appoinmentNoteTb.Text = row.Cells[5].Value.ToString();

        // You will need to call the SelectedIndexChanged event handlers manually
        // to update fields that depend on selected patient and doctor
        patNameCb_SelectedIndexChanged(patNameCb, EventArgs.Empty);
        docNameCb_SelectedIndexChanged(docNameCb, EventArgs.Empty);
    }
}

        private void LoadAppointmentsIntoDataGridView()
        {
            try
            {
                Con.Open();

                // Get the search text and create parameters for the SQL query
                string searchText = searchTb.Text;
                string query = @"
            SELECT 
                A.appointment_id, 
                P.PatientFirstName AS 'Patient Name', 
                U.userName AS 'Doctor Name', 
                A.appointmentDate AS 'Appointment Date', 
                A.appointmentStatus AS 'Status', 
                A.appointmentnotes AS 'Notes' 
            FROM 
                AppointmentTbl A 
                JOIN PatientTbl P ON A.patient_id = P.patient_id 
                JOIN UserTbl U ON A.doctor_id = U.user_id 
            WHERE 
                P.PatientFirstName LIKE @searchText OR 
                U.userName LIKE @searchText OR 
                A.appointmentStatus LIKE @searchText
        ";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                appoinmenysLoadDGV.DataSource = dt;

                foreach (DataGridViewColumn column in appoinmenysLoadDGV.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }



        private void appoinmentNoteTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void specializationTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docRoomNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void appointmentDateDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reSheduleBtn_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment to reschedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string selectedPatientName = patNameCb.SelectedItem?.ToString();
                string selectedDoctorName = docNameCb.SelectedItem?.ToString();
                string appointmentNotes = appoinmentNoteTb.Text;
                string appointmentStatus = statusCb.SelectedItem?.ToString();
                DateTime appointmentDate = appointmentDateDTP.Value;

                if (patientNameToIdMap.TryGetValue(selectedPatientName, out string patientContact))
                {
                    if (DoctorNameToDetailsMap.TryGetValue(selectedDoctorName, out var doctorDetails))
                    {
                        Con.Open();

                        SqlCommand findDoctorIdCmd = new SqlCommand("SELECT user_id FROM UserTbl WHERE userName = @docName", Con);
                        findDoctorIdCmd.Parameters.AddWithValue("@docName", selectedDoctorName);
                        int doctorId = (int)findDoctorIdCmd.ExecuteScalar();

                        SqlCommand cmd = new SqlCommand("UPDATE AppointmentTbl SET patient_id = (SELECT patient_id FROM PatientTbl WHERE PatientContact = @patContact), doctor_id = @docId, appointmentDate = @appDate, appointmentStatus = @appStatus, appointmentnotes = @appNotes WHERE appointment_id = @appId", Con);
                        cmd.Parameters.AddWithValue("@patContact", patientContact);
                        cmd.Parameters.AddWithValue("@docId", doctorId);
                        cmd.Parameters.AddWithValue("@appDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@appStatus", appointmentStatus);
                        cmd.Parameters.AddWithValue("@appNotes", appointmentNotes);
                        cmd.Parameters.AddWithValue("@appId", selectedAppointmentId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Appointment Rescheduled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Doctor not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                LoadAppointmentsIntoDataGridView();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment to cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to cancel this appointment?", "Confirm Cancelation", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM AppointmentTbl WHERE appointment_id = @appId", Con);
                    cmd.Parameters.AddWithValue("@appId", selectedAppointmentId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment Cancelled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancelation Aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                LoadAppointmentsIntoDataGridView();
            }
        }


        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            LoadAppointmentsIntoDataGridView();
            ClearFields();
        }
    }
}
