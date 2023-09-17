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
                StringBuilder reportText = new StringBuilder();
                reportText.AppendLine("Bill ID\tTotal Amount\tBill Date\tAppointment Date\tAppointment Status\tAppointment Notes");
                reportText.AppendLine(new string('-', 100));

                foreach (DataRow row in dt.Rows)
                {
                    reportText.AppendLine($"{row["bill_id"]}\t{row["totalAmount"]}\t{row["billDate"]}\t{row["appointmentDate"]}\t{row["appointmentStatus"]}\t{row["appointmentNotes"]}");
                }

                e.Graphics.DrawString(reportText.ToString(), new Font("Arial", 12), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
            }
        }


    }
}