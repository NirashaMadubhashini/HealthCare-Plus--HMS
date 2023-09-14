using FontAwesome.Sharp;
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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            docChargeTb.Text = "1500";
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

                StringBuilder bill = new StringBuilder();

                bill.AppendLine("********************************************************************");
                bill.AppendLine("                          HealthCare Plus");
                bill.AppendLine("                  49/12 Circular Road, Galle, Sri Lanka");
                bill.AppendLine("                      Contact: 076-131-9259");
                bill.AppendLine("********************************************************************");
                bill.AppendLine();

                // Patient Details
                bill.AppendLine("Patient Details");
                bill.AppendLine("--------------------");
                bill.AppendLine($"Name          : {patFirstNameTb.Text} {patLastNameTb.Text}");
                bill.AppendLine($"ID            : {patIdCb.SelectedItem}");
                bill.AppendLine($"Contact       : {patContactTb.Text}");
                bill.AppendLine();

                // Doctor Details
                bill.AppendLine("Doctor Details");
                bill.AppendLine("--------------------");
                bill.AppendLine($"ID            : {docIdCb.SelectedItem}");
                bill.AppendLine($"Name          : {docNameTb.Text}");
                bill.AppendLine($"Specialization: {specializationTb.Text}");
                bill.AppendLine($"Room No       : {docRoomTb.Text}");
                bill.AppendLine();

                // Appointment Details
                bill.AppendLine("Appointment Details");
                bill.AppendLine("--------------------");
                bill.AppendLine($"Date          : {appointmentDateDTP.Value:dd/MM/yyyy}");
                bill.AppendLine();

                // Charges Details
                bill.AppendLine("Charges Detail");
                bill.AppendLine("--------------------");
                bill.AppendLine($"Hospital Charges: {hospitalCharge:C2}");
                bill.AppendLine($"Doctor Charges  : {doctorCharge:C2}");
                bill.AppendLine("--------------------");
                bill.AppendLine($"Total Amount    : {totalAmount:C2}");
                bill.AppendLine();

                // Thank You Note
                bill.AppendLine("               Thank you for choosing HealthCare Plus!");
                bill.AppendLine("                           Visit again.");
                bill.AppendLine("********************************************************************");

                // Display the bill in the TextBox
                appoinmentSumTxt.Text = bill.ToString();
            }
            catch
            {
                // Handle invalid number format here, if necessary
                MessageBox.Show("Invalid number format in charges.");
            }
        }


        private void reSheduleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(appoinmentSumTxt.Text))
            {
                MessageBox.Show("No appointment summary to print.");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDoc.Print();
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
            string textToPrint = appoinmentSumTxt.Text;
            Font printFont = new Font("Arial", 12);
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, 10, 10);
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

    }
}
