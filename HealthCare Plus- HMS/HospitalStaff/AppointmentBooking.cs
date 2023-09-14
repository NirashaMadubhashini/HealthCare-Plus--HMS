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

        private void docNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void sheduleBtn_Click(object sender, EventArgs e)
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

        private void reSheduleBtn_Click(object sender, EventArgs e)
        {
           
        }

    }
}
