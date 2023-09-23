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

namespace HealthCare_Plus__HMS.BillingStaff
{
    public partial class Billing : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public Billing()
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

            billDGV.AutoResizeColumns();  // Resize columns to fit content
            billDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

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

        private void payRollCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string query = "SELECT * FROM BillTbl WHERE appointment_id IN (SELECT appointment_id FROM AppointmentTbl WHERE patient_id = @patient_id)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@patient_id", payRollCb.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                billDGV.DataSource = dt;
                billTxt.Text = GetBillAndAppointmentDetailsAsString();

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
        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DisplaySearchPrescription();
        }

        private DataTable GetBillAndAppointmentDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                string query = @"
        SELECT 
            BillTbl.*, 
            AppointmentTbl.appointmentDate, 
            AppointmentTbl.appointmentStatus, 
            AppointmentTbl.appointmentNotes 
        FROM 
            BillTbl
        INNER JOIN 
            AppointmentTbl ON BillTbl.appointment_id = AppointmentTbl.appointment_id
        WHERE 
            AppointmentTbl.patient_id = @patient_id";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@patient_id", payRollCb.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

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
            try
            {
                // Print the document
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                // Display any errors that occur during the printing process
                MessageBox.Show("An error occurred while trying to print the document: " + ex.Message);
            }
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataTable dt = GetBillAndAppointmentDetails();

            if (dt.Rows.Count == 0) return;

            Font headerFont = new Font("Arial", 24, FontStyle.Bold);
            Font sectionFont = new Font("Arial", 18, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 14);
            Font footerFont = new Font("Arial", 12, FontStyle.Italic);

            Brush brush = Brushes.Black;
            int yPosition = 100;

            // Header (consider adding a logo here)
            e.Graphics.DrawString("HealthCare Plus - Invoice", headerFont, brush, 50, yPosition);
            yPosition += 60;

            foreach (DataRow row in dt.Rows)
            {
                // Bill Details
                e.Graphics.DrawString("Bill Details", sectionFont, brush, 50, yPosition);
                yPosition += 40;
                e.Graphics.DrawString("Bill ID: " + row["bill_id"], bodyFont, brush, 50, yPosition);
                yPosition += 30;
                e.Graphics.DrawString("Total Amount: $" + row["totalAmount"], bodyFont, brush, 50, yPosition);
                yPosition += 30;
                e.Graphics.DrawString("Bill Date: " + row["billDate"], bodyFont, brush, 50, yPosition);
                yPosition += 30;

                // Appointment Details
                e.Graphics.DrawString("Appointment Details", sectionFont, brush, 50, yPosition);
                yPosition += 40;
                e.Graphics.DrawString("Date: " + row["appointmentDate"], bodyFont, brush, 50, yPosition);
                yPosition += 30;
                e.Graphics.DrawString("Status: " + row["appointmentStatus"], bodyFont, brush, 50, yPosition);
                yPosition += 30;
                e.Graphics.DrawString("Notes: " + row["appointmentNotes"], bodyFont, brush, 50, yPosition);
                yPosition += 40;

                // Line Separator
                e.Graphics.DrawLine(Pens.Black, 50, yPosition, 780, yPosition);
                yPosition += 20;
            }

            // Footer
            e.Graphics.DrawString("Thank you for choosing HealthCare Plus!", footerFont, brush, 50, yPosition);
            yPosition += 30;

            // Signature (consider adding a line for the signature)
            e.Graphics.DrawString("Signature: ", bodyFont, brush, 50, yPosition);
            yPosition += 30;
            e.Graphics.DrawLine(Pens.Black, 150, yPosition - 10, 350, yPosition - 10); // Line for signature
        }




        private string GetBillAndAppointmentDetailsAsString()
        {
            if (payRollCb.SelectedItem == null) return "No data available";

            DataTable dt = GetBillAndAppointmentDetails();
            if (dt.Rows.Count == 0) return "No data available";

            StringBuilder report = new StringBuilder();

            report.AppendLine("HealthCare Plus - Invoice");
            report.AppendLine(new string('=', 30));

            foreach (DataRow row in dt.Rows)
            {
                // Bill Details
                report.AppendLine($"Bill ID: {row["bill_id"]}");
                report.AppendLine($"Total Amount: ${row["totalAmount"]}");
                report.AppendLine($"Bill Date: {row["billDate"]}");

                // Appointment Details
                report.AppendLine($"Appointment Date: {row["appointmentDate"]}");
                report.AppendLine($"Status: {row["appointmentStatus"]}");
                report.AppendLine($"Notes: {row["appointmentNotes"]}");

                report.AppendLine(new string('-', 30));
            }

            // Footer
            report.AppendLine("Thank you for choosing HealthCare Plus!");

            return report.ToString();
        }

        private void billDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
