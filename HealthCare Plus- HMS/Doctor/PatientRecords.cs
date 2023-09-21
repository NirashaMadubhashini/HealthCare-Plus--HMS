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

namespace HealthCare_Plus__HMS.Doctor
{
    public partial class PatientRecords : Form
    {
        private int _doctor_id;

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public PatientRecords(int doctor_id)
        {
            InitializeComponent();
            _doctor_id = doctor_id;
            LoadPatientsByDoctorId();
            FillPatientsComboBox();
        }


        private void LoadPatientsByDoctorId()
        {
            string query = @"
                SELECT 
                    p.*,
                    a.appointmentDate, 
                    a.appointmentnotes 
                FROM 
                    PatientTbl p
                JOIN 
                    AppointmentTbl a
                ON 
                    p.patient_id = a.patient_id
                WHERE 
                    a.doctor_id = @doctorId;
            ";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@doctorId", _doctor_id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            patRecordsDGV.DataSource = dt;
        }

        private void FillPatientsComboBox()
        {
            try
            {
                Con.Open();

                string query = "SELECT DISTINCT patient_id FROM AppointmentTbl WHERE doctor_id = @doctorId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@doctorId", _doctor_id);

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

        private void patIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
