﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using HealthCare_Plus__HMS.HospitalStaff;

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

            hospitalChargeTb.Text = "800";

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

                        // Set doctor charge based on specialization
                        switch (rdr["doctorSpecialization"].ToString().ToLower())
                        {
                            case "urology":
                            case "surgery":
                                docChargeTb.Text = "1200";
                                break;

                            case "gynecology":
                            case "ophtalmo":
                            case "dermato":
                            case "generalist":
                                docChargeTb.Text = "800";
                                break;

                            default:
                                docChargeTb.Text = "800"; // Default charge in case specialization does not match any predefined category
                                break;
                        }
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
                // Step 1: Validate inputs
                if (patIdCb.SelectedItem == null)
                {
                    MessageBox.Show("Please select a patient.");
                    return;
                }

                if (docIdCb.SelectedItem == null)
                {
                    MessageBox.Show("Please select a doctor.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(hospitalChargeTb.Text) || !decimal.TryParse(hospitalChargeTb.Text, out decimal hospitalCharge))
                {
                    MessageBox.Show("Please enter a valid hospital charge.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(docChargeTb.Text) || !decimal.TryParse(docChargeTb.Text, out decimal doctorCharge))
                {
                    MessageBox.Show("Please enter a valid doctor charge.");
                    return;
                }

                if (appointmentDateDTP.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Appointment date cannot be in the past.");
                    return;
                }

                // Step 2: Insert appointment details
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO AppointmentTbl(patient_id, doctor_id, appointmentDate,appointmentStatus,appointmentnotes) 
                                  VALUES(@PatientId, @DoctorId, @DateTime, 'Scheduled', @Notes); 
                                  SELECT SCOPE_IDENTITY()", Con))
                {
                    cmd.Parameters.AddWithValue("@PatientId", Convert.ToInt32(patIdCb.SelectedItem));
                    cmd.Parameters.AddWithValue("@DoctorId", Convert.ToInt32(docIdCb.SelectedItem));
                    cmd.Parameters.AddWithValue("@DateTime", appointmentDateDTP.Value);
                    cmd.Parameters.AddWithValue("@Notes", "");
                    int appointmentId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Step 3: Insert billing details
                    cmd.CommandText = @"INSERT INTO BillTbl(totalAmount, hospitalCharges, doctorCharges, appointment_id) 
                               VALUES(@TotalAmount, @HospitalCharges, @DoctorCharges, @AppointmentId)";
                    cmd.Parameters.AddWithValue("@TotalAmount", hospitalCharge + doctorCharge);
                    cmd.Parameters.AddWithValue("@HospitalCharges", hospitalCharge);
                    cmd.Parameters.AddWithValue("@DoctorCharges", doctorCharge);
                    cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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


        private void reSheduleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal hospitalCharge = decimal.Parse(hospitalChargeTb.Text);
                decimal doctorCharge = decimal.Parse(docChargeTb.Text);
                decimal totalAmount = hospitalCharge + doctorCharge;

                StringBuilder bill = new StringBuilder();
                bill.AppendLine($"              ------- BILL REPORT -------");
                bill.AppendLine(DateTime.Now.ToString("f")); // Adding current date and time
                bill.AppendLine(new string('-', 60)); // Add a separator

                // Add desired details about the appointment from your existing controls
                // or from selected row of a DataGridView (assuming you have one)
                bill.AppendLine($"Patient Name   : {patFirstNameTb.Text} {patLastNameTb.Text}");
                bill.AppendLine($"Doctor Name    : {docNameTb.Text}");
                bill.AppendLine($"Appointment Date: {appointmentDateDTP.Value:dd/MM/yyyy}");
                bill.AppendLine("------------------");

                // Charges Detail
                bill.AppendLine($"Hospital Charges: {hospitalCharge:C2}");
                bill.AppendLine($"Doctor Charges  : {doctorCharge:C2}");
                bill.AppendLine("------------------");
                bill.AppendLine($"Total Amount    : {totalAmount:C2}");
                bill.AppendLine(new string('-', 60)); // Add a separator

                // Thank You Note
                bill.AppendLine("          Thank you for choosing HealthCare Plus!");
                bill.AppendLine("                      Visit again.");
                bill.AppendLine(new string('-', 60)); // Add a separator

                appoinmentSumTxt.Font = new Font("Courier New", 10); // Set a monospace font for aligned text
                appoinmentSumTxt.Text = bill.ToString(); // Set the bill text

                // Offer to save the report to a file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Save Report";
                saveFileDialog.FileName = "HealthCarePlus_Report.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile()))
                    {
                        sw.Write(bill.ToString());
                    }

                    MessageBox.Show("Report saved successfully.");
                }
            }
            catch
            {
                // Handle invalid number format here, if necessary
                MessageBox.Show("Invalid number format in charges.");
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

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            patFirstNameTb.Text = string.Empty;
            patLastNameTb.Text = string.Empty;
            patContactTb.Text = string.Empty;
            docNameTb.Text = string.Empty;
            specializationTb.Text = string.Empty;
            docRoomTb.Text = string.Empty;
            hospitalChargeTb.Text = string.Empty;
            docChargeTb.Text = string.Empty;
            appoinmentSumTxt.Text = string.Empty;
            

            // Reset all combo boxes
            patIdCb.SelectedIndex = -1;
            docIdCb.SelectedIndex = -1;
            docAvailCb.SelectedIndex = -1;
            

            // Reset DateTimePicker
            appointmentDateDTP.Value = DateTime.Now;
        }

        private void appoinmentSumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentBooking_Load(object sender, EventArgs e)
        {

        }

        private void viewAppoinmentsBtn_Click(object sender, EventArgs e)
        {
           ViewAppoinments modalForm = new ViewAppoinments();

            // Show the form as a modal dialog
            modalForm.ShowDialog();

        }
    }
}
