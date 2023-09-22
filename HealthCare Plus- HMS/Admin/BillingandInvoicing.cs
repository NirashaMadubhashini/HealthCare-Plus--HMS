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

namespace HealthCare_Plus__HMS.Admin
{
    public partial class BillingandInvoicing : Form
    {

        public BillingandInvoicing()
        {
            InitializeComponent();
            DisplaySearchPrescription();
            LoadPatientIds();

            // Improve DataGridView initial settings
            billDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            billDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billDGV.MultiSelect = false;
            billDGV.ReadOnly = true;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void DisplaySearchPrescription()
        {
            Con.Open();
            string Query = "Select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
           billDGV.DataSource = ds.Tables[0];
            billDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void LoadPatientIds()
        {
            try
            {
                Con.Open();
                string query = "SELECT patient_id FROM PatientTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    payRollCb.Items.Add(reader["patient_id"].ToString());
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


        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            DisplaySearchPrescription();
        }


        private void billDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void billTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void payRollCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = @"SELECT 
                            BillTbl.bill_id, BillTbl.totalAmount, BillTbl.billDate, 
                            AppointmentTbl.appointmentDate, AppointmentTbl.appointmentStatus, AppointmentTbl.appointmentNotes 
                        FROM 
                            BillTbl
                        INNER JOIN 
                            AppointmentTbl ON BillTbl.appointment_id = AppointmentTbl.appointment_id
                        WHERE 
                            AppointmentTbl.patient_id = @patient_id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@patient_id", payRollCb.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                billDGV.DataSource = dt;

                // Improve DataGridView appearance
                billDGV.AutoResizeColumns();  // Resize columns to fit content
                billDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                // Generate report text
                StringBuilder reportText = new StringBuilder();
                reportText.AppendLine("Bill ID\tTotal Amount\tBill Date\tAppointment Date\tAppointment Status\tAppointment Notes");
                reportText.AppendLine(new string('-', 100));

                foreach (DataRow row in dt.Rows)
                {
                    reportText.AppendLine($"{row["bill_id"]}\t{row["totalAmount"]}\t{row["billDate"]}\t{row["appointmentDate"]}\t{row["appointmentStatus"]}\t{row["appointmentNotes"]}");
                }

                // Set the report text as the Text property of billTxt
                billTxt.Text = reportText.ToString();
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


        private DataTable GetBillAndAppointmentDetails(int patientId)
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                string query = @"
            SELECT 
                BillTbl.bill_id, BillTbl.totalAmount, BillTbl.billDate, 
                AppointmentTbl.appointmentDate, AppointmentTbl.appointmentStatus, AppointmentTbl.appointmentNotes 
            FROM 
                BillTbl
            INNER JOIN 
                AppointmentTbl ON BillTbl.appointment_id = AppointmentTbl.appointment_id
            WHERE 
                AppointmentTbl.patient_id = @patient_id";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@patient_id", patientId);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                // Improve DataGridView appearance
                billDGV.AutoResizeColumns();  // Resize columns to fit content
                billDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return dt;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (payRollCb.SelectedItem != null)
            {
                int selectedPatientId = int.Parse(payRollCb.SelectedItem.ToString());
                billDGV.DataSource = GetBillAndAppointmentDetails(selectedPatientId);

                // Initiate printing
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Please select a patient ID.");
            }
        }




        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (billDGV.DataSource is DataTable dt)
            {
                Font headerFont = new Font("Arial", 16, FontStyle.Bold);
                Font sectionFont = new Font("Arial", 12, FontStyle.Bold);
                Font bodyFont = new Font("Arial", 10);
                Font footerFont = new Font("Arial", 10, FontStyle.Italic);

                // Header Section
                // Drawing Logo (Replace "path_to_logo.png" with the actual path to your logo)
                try
                {
                    Image logo = Image.FromFile("path_to_logo.png");
                    e.Graphics.DrawImage(logo, e.MarginBounds.Right - 100, e.MarginBounds.Top, 100, 100);
                }
                catch
                {
                    // Handle missing logo file
                }
                e.Graphics.DrawString("HealthCare Plus - Invoice", headerFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
                e.Graphics.DrawString("Address: 49/12- Circular Road, Galle", bodyFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 30);
                e.Graphics.DrawString("Contact: 076-1319259", bodyFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 50);

                // Bill Details Section
                e.Graphics.DrawString("Bill Details", sectionFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 100);

                // Variables to hold X and Y positions
                int xPosition = e.MarginBounds.Left;
                int yPosition = e.MarginBounds.Top + 130;

                foreach (DataRow row in dt.Rows)
                {
                    // Display data in a more structured and beautiful format rather than just tab separated
                    e.Graphics.DrawString($"Bill ID: {row["bill_id"]}", bodyFont, Brushes.Black, xPosition, yPosition);
                    yPosition += 20;
                    e.Graphics.DrawString($"Total Amount: {row["totalAmount"]}", bodyFont, Brushes.Black, xPosition, yPosition);
                    yPosition += 20;
                    e.Graphics.DrawString($"Bill Date: {row["billDate"]}", bodyFont, Brushes.Black, xPosition, yPosition);
                    yPosition += 20;
                    e.Graphics.DrawString($"Appointment Date: {row["appointmentDate"]}", bodyFont, Brushes.Black, xPosition, yPosition);
                    yPosition += 20;
                    e.Graphics.DrawString($"Status: {row["appointmentStatus"]}", bodyFont, Brushes.Black, xPosition, yPosition);
                    yPosition += 20;
                    e.Graphics.DrawString($"Notes: {row["appointmentNotes"]}", bodyFont, Brushes.Black, xPosition, yPosition);
                    yPosition += 30; // Extra space between entries
                }

                // Footer Section
                e.Graphics.DrawString("Thank you for choosing HealthCare Plus!", footerFont, Brushes.Black, e.MarginBounds.Left, yPosition + 30);
            }
        }





    }
}