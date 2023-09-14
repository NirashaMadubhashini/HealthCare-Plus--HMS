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
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public AppointmentBooking()
        {
            InitializeComponent();
            LoadPatientIds();
            LoadDoctorIds(); // Load doctor IDs when the form loads

        }

        private void LoadDoctorIds()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT doctor_id FROM DoctorTbl", Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                docIdCb.Items.Clear(); // Clear existing items to avoid duplications

                while (rdr.Read())
                {
                    docIdCb.Items.Add(rdr["doctor_id"]);
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private void LoadPatientIds()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT patient_id FROM PatientTbl", Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                patIdCb.Items.Clear();  // Clear existing items

                while (rdr.Read())
                {
                    patIdCb.Items.Add(rdr["patient_id"]);
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private void ClearFields()
        {
   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }



        private void patNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patIdCb.SelectedItem != null)
            {
                int selectedPatientId = Convert.ToInt32(patIdCb.SelectedItem.ToString());

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT PatientFirstName, PatientLastName, PatientContact FROM PatientTbl WHERE patient_id = @PatientId", Con);
                    cmd.Parameters.AddWithValue("@PatientId", selectedPatientId);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        patFirstNameTb.Text = rdr["PatientFirstName"].ToString();
                        patLastNameTb.Text = rdr["PatientLastName"].ToString();
                       patContactTb.Text = rdr["PatientContact"].ToString();
                    }

                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        private void patIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (docIdCb.SelectedItem != null)
            {
                int selectedDoctorId = Convert.ToInt32(docIdCb.SelectedItem.ToString());

                try
                {
                    Con.Open();

                    // Fetching the doctor details
                    SqlCommand cmd = new SqlCommand(@"SELECT U.userName, D.doctorSpecialization, D.roomNumber 
                                              FROM DoctorTbl D
                                              JOIN UserTbl U ON D.doctor_id = U.user_id
                                              WHERE D.doctor_id = @DoctorId", Con);
                    cmd.Parameters.AddWithValue("@DoctorId", selectedDoctorId);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                       docNameTb.Text = rdr["userName"].ToString();
                        specializationTb.Text = rdr["doctorSpecialization"].ToString();
                        docRoomTb.Text = rdr["roomNumber"].ToString();
                    }

                    rdr.Close();

                    // Fetching the doctor availability
                    cmd = new SqlCommand(@"SELECT weekDays, CONVERT(VARCHAR, availabilityStartTime, 0) AS availabilityStartTime, 
                                   CONVERT(VARCHAR, availabilityEndTime, 0) AS availabilityEndTime 
                                   FROM DoctorAvailabileTbl
                                   WHERE doctor_id = @DoctorId", Con);
                    cmd.Parameters.AddWithValue("@DoctorId", selectedDoctorId);

                    rdr = cmd.ExecuteReader();

                    docAvailCb.Items.Clear(); // Clear existing items

                    while (rdr.Read())
                    {
                        string availability = $"{rdr["weekDays"]} {rdr["availabilityStartTime"]} - {rdr["availabilityEndTime"]}";
                        docAvailCb.Items.Add(availability);
                    }

                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        private void sheduleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal hospitalCharge = decimal.Parse(hospitalChargeTb.Text);
                decimal doctorCharge = decimal.Parse(docChargeTb.Text);
                decimal totalAmount = hospitalCharge + doctorCharge;

                string bill = "********************** HealthCare Plus - Bill **********************\n";
                bill += "Patient Name: " + patFirstNameTb.Text + " " + patLastNameTb.Text + "\n";
                bill += "Patient ID: " + patIdCb.SelectedItem.ToString() + "\n";
                bill += "Contact: " + patContactTb.Text + "\n\n";

                bill += "Doctor ID: " + docIdCb.SelectedItem.ToString() + "\n";
                bill += "Doctor Name: " + docNameTb.Text + "\n";
                bill += "Specialization: " + specializationTb.Text + "\n\n";

                bill += "Room No: " + docRoomTb.Text + "\n\n";

                bill += "Appoinment Date : " + appointmentDateDTP.Text + "\n\n";


                bill += "Hospital Charges: " + hospitalChargeTb.Text + "\n";
                bill += "Doctor Charges: " + docChargeTb.Text + "\n";
                bill += "-------------------------------------------------------------\n";
                bill += "Total Amount: " + totalAmount.ToString("F2") + "\n";
                bill += "***************************************************************\n";

                // Display bill (replace txtBill with the name of your TextBox/RichTextBox where you want to display the bill)
                appoinmentSumTxt.Text = bill;
            }
            catch
            {
                // Handle invalid number format here, if necessary
                MessageBox.Show("Invalid number format in charges.");
            }
        }

        private void reSheduleBtn_Click(object sender, EventArgs e)
        {
           
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


     
    }
}
