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
    public partial class AllAppoinments : Form
    {
        private string _userName; // or _doctorId if you're using the doctor's user ID
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public AllAppoinments(string userName)
        {
            InitializeComponent();
            _userName = userName;
            LoadDoctorAppointments();
            appoinmentsDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(appoinmentsDGV_DataBindingComplete);

        }

        private void LoadDoctorAppointments()
        {
            try
            {
                Con.Open();

                string query = @"SELECT * 
                        FROM AppointmentTbl a
                        INNER JOIN UserTbl u ON a.doctor_id = u.user_id
                        WHERE u.userName = @userName";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@userName", _userName);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                appoinmentsDGV.DataSource = dt;  // Assuming appoinmentsDGV is your DataGridView's name
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

        private void appoinmentsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in appoinmentsDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void appoinmentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AllAppoinments allAppointmentsForm = new AllAppoinments(_userName); // or use _userId if you prefer
            allAppointmentsForm.Show();

        }

        private void SearchAppointments(string searchTerm)
        {
            try
            {
                Con.Open();

                string query = @"
                    SELECT * 
                    FROM AppointmentTbl a
                    INNER JOIN UserTbl u ON a.doctor_id = u.user_id
                    WHERE (u.userName = @userName) AND 
                          (a.appointment_id LIKE @search OR 
                           a.patient_id LIKE @search OR 
                           a.doctor_id LIKE @search OR 
                           a.appointmentStatus LIKE @search)";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@userName", _userName);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                appoinmentsDGV.DataSource = dt;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTb.Text))
            {
                SearchAppointments(searchTb.Text);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadDoctorAppointments();
            searchTb.Text = "";  // Clear the search textbox
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTb.Text))
            {
                SearchAppointments(searchTb.Text);
            }
            else
            {
                LoadDoctorAppointments();  // If search box is empty, load all appointments.
            }
        }
    }
}
