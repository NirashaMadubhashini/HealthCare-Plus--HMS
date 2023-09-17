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

namespace HealthCare_Plus__HMS.HospitalStaff
{
    public partial class ViewAppoinments : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public ViewAppoinments()
        {
            InitializeComponent();
            LoadPatientIds();
            patIdCb.SelectedIndexChanged += patIdCb_SelectedIndexChanged;
        }

        private void LoadPatientIds()
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("SELECT patient_id FROM PatientTbl", Con);

                SqlDataReader reader = cmd.ExecuteReader();

                patIdCb.Items.Clear();

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

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = @"
    SELECT 
        a.appointment_id AS 'Appointment ID', 
        p.PatientFirstName + ' ' + p.PatientLastName AS 'Patient Name',
        u.userName AS 'Doctor Name',
        a.appointmentDate AS 'Appointment Date',
        a.appointmentStatus AS 'Appointment Status',
        a.appointmentnotes AS 'Appointment Notes'
    FROM 
        AppointmentTbl a
    JOIN 
        PatientTbl p ON a.patient_id = p.patient_id
    JOIN 
        UserTbl u ON a.doctor_id = u.user_id
    WHERE 
        a.patient_id = @PatientId
    ";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@PatientId", int.Parse(patIdCb.SelectedItem.ToString()));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Clear existing data and set new data source
                appoinmenysLoadDGV.DataSource = null;
                appoinmenysLoadDGV.DataSource = dt;

                // Set column size to fixed
                appoinmenysLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // Set individual column widths (adjust numbers as needed)
                appoinmenysLoadDGV.Columns[0].Width = 100; // 'Appointment ID' column
                appoinmenysLoadDGV.Columns[1].Width = 200; // 'Patient Name' column
                appoinmenysLoadDGV.Columns[2].Width = 150; // 'Doctor Name' column
                appoinmenysLoadDGV.Columns[3].Width = 150; // 'Appointment Date' column
                appoinmenysLoadDGV.Columns[4].Width = 150; // 'Appointment Status' column
                appoinmenysLoadDGV.Columns[5].Width = 300; // 'Appointment Notes' column


                // Load the details of the first appointment into the fields
                if (dt.Rows.Count > 0)
                {
                    DataRow firstRow = dt.Rows[0];
                    patNameTb.Text = firstRow["Patient Name"].ToString();
                    patStatusCb.Text = firstRow["Appointment Status"].ToString();
                    appoinNoteTb.Text = firstRow["Appointment Notes"].ToString();
                    appDateCb.Value = DateTime.Parse(firstRow["Appointment Date"].ToString());
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


        private void reSheduleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (appoinmenysLoadDGV.SelectedRows.Count > 0)
                {
                    Con.Open();

                    // Assuming you have a DateTimePicker control with the name newDateDtp
                    DateTime newDate = appDateCb.Value;
                    string newStatus = patStatusCb.Text;
                    string newNotes = appoinNoteTb.Text;

                    // Get the selected appointment ID
                    int appointmentID = int.Parse(appoinmenysLoadDGV.SelectedRows[0].Cells[0].Value.ToString());

                    string query = @"
                     UPDATE AppointmentTbl 
                    SET 
                     appointmentDate = @NewDate, 
                     appointmentStatus = @NewStatus, 
                     appointmentnotes = @NewNotes
                    WHERE 
                     appointment_id = @AppointmentID
                    ";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@NewDate", newDate);
                    cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                    cmd.Parameters.AddWithValue("@NewNotes", newNotes);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment updated successfully.");
                }
                else
                {
                    MessageBox.Show("Please select an appointment to update.");
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


    }
}
