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

namespace HealthCare_Plus__HMS.HospitalStaff
{
    public partial class DoctorAvailability : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public DoctorAvailability()
        {
            InitializeComponent();
            LoadDoctorIds();

            startTimeCb.Format = DateTimePickerFormat.Time;
            startTimeCb.ShowUpDown = true;
            endTimeCb.Format = DateTimePickerFormat.Time;
            endTimeCb.ShowUpDown = true;
        }


        private void LoadDoctorIds()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT doctor_id FROM DoctorTbl", Con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    docIdCb.Items.Add(reader.GetInt32(0));
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

        private void LoadDoctorAvailability()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DoctorAvailabileTbl", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                docAvailableDGV.DataSource = dt;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }


        private bool ValidateInputs()
        {
            if (docIdCb.SelectedItem == null)
            {
                MessageBox.Show("Please select a doctor ID.");
                return false;
            }

            // Check if at least one day is selected
            if (!mondayCheckBox.Checked &&
                !tuesdayCheckBox.Checked &&
                !wednesdayCheckBox.Checked &&
                !thursdayCheckBox.Checked &&
                !fridayCheckBox.Checked &&
                !saturdayCheckBox.Checked &&
                !sundayCheckBox.Checked)
            {
                MessageBox.Show("Please select at least one day.");
                return false;
            }

            if (startTimeCb.Value >= endTimeCb.Value)
            {
                MessageBox.Show("Start time must be earlier than end time.");
                return false;
            }

            return true;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Con.Open();

                List<string> checkedDays = new List<string>();

                if (mondayCheckBox.Checked) checkedDays.Add("Monday");
                if (tuesdayCheckBox.Checked) checkedDays.Add("Tuesday");
                if (wednesdayCheckBox.Checked) checkedDays.Add("Wednesday");
                if (thursdayCheckBox.Checked) checkedDays.Add("Thursday");
                if (fridayCheckBox.Checked) checkedDays.Add("Friday");
                if (saturdayCheckBox.Checked) checkedDays.Add("Saturday");
                if (sundayCheckBox.Checked) checkedDays.Add("Sunday");

                foreach (string day in checkedDays)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO DoctorAvailabileTbl (doctor_id, weekDays, availabilityStartTime, availabilityEndTime, doctorIsVacation) VALUES (@doctorId, @weekDays, @availabilityStartTime, @availabilityEndTime, @doctorIsVacation)", Con);
                    cmd.Parameters.AddWithValue("@doctorId", docIdCb.SelectedItem);
                    cmd.Parameters.AddWithValue("@weekDays", day);
                    cmd.Parameters.AddWithValue("@availabilityStartTime", startTimeCb.Value.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@availabilityEndTime", endTimeCb.Value.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@doctorIsVacation", vacationCheckBox.Checked ? 1 : 0);

                    cmd.ExecuteNonQuery();
                }
                LoadDoctorAvailability();

                MessageBox.Show("Doctor availability added successfully");
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


        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void docAvailableDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void docIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT D.doctorSpecialization, D.doctorQualifications, D.roomNumber, U.userName FROM DoctorTbl D INNER JOIN UserTbl U ON D.doctor_id = U.user_id WHERE D.doctor_id = @doctorId", Con);
                cmd.Parameters.AddWithValue("@doctorId", docIdCb.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    docNameTb.Text = reader.GetString(3);
                    docSpecTb.Text = reader.GetString(0);
                    docRoomTb.Text = reader.GetString(2);
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


    private void docNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docSpecTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docRoomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void weekDaysCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vacationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startTimeCb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endTimeCb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void mondayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tuesdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wednesdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void thursdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fridayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saturdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sundayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
