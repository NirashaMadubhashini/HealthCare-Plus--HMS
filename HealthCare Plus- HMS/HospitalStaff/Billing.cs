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
                Con.Open();
                string query = "SELECT * FROM BillTbl WHERE appointment_id IN (SELECT appointment_id FROM AppointmentTbl WHERE patient_id = @patient_id)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@patient_id", payRollCb.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                billDGV.DataSource = dt;
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
    }
}
