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


            startTimeCb.Format = DateTimePickerFormat.Time;
            startTimeCb.ShowUpDown = true;
            endTimeCb.Format = DateTimePickerFormat.Time;
            endTimeCb.ShowUpDown = true;

            LoadDoctorIDs();

            docAvailableDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(docAvailableDGV_DataBindingComplete);
            docAvailableDGV.CellClick += new DataGridViewCellEventHandler(docAvailableDGV_CellContentClick);

            docAvailableDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            docAvailableDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            docAvailableDGV.MultiSelect = false;
            docAvailableDGV.ReadOnly = true;
        }

        private void ResetForm()
        {
            // Clear text fields
            docNameTb.Text = "";
            docSpecTb.Text = "";
            docRoomTb.Text = "";

            // Uncheck checkboxes
            mondayCheckBox.Checked = false;
            tuesdayCheckBox.Checked = false;
            wednesdayCheckBox.Checked = false;
            thursdayCheckBox.Checked = false;
            fridayCheckBox.Checked = false;
            saturdayCheckBox.Checked = false;
            sundayCheckBox.Checked = false;

            // Set date pickers to default values (if any)
            startTimeCb.Value = DateTime.Now;
            endTimeCb.Value = DateTime.Now;

            // Clear selection in combobox
            docIdCb.SelectedIndex = -1;

            // Uncheck vacation checkbox
            vacationCheckBox.Checked = false;

            // Additional controls can be reset here if needed
        }


        private void LoadDoctorIDs()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT doctor_id FROM DoctorTbl", Con);
                SqlDataReader dr = cmd.ExecuteReader();

                docIdCb.Items.Clear();
                while (dr.Read())
                {
                    docIdCb.Items.Add(dr["doctor_id"].ToString());
                }

                dr.Close();

                // Modifying the query to join with the UserTbl to get the doctor names
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT D.doctor_id, U.userName as doctorName, D.weekDays, D.availabilityStartTime, D.availabilityEndTime, D.doctorIsVacation FROM DoctorAvailabileTbl D INNER JOIN UserTbl U ON D.doctor_id = U.user_id", Con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                docAvailableDGV.DataSource = dt;

                docAvailableDGV.AutoResizeColumns();  // Resize columns to fit content
                docAvailableDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
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




        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string weekDays = string.Join(",",
                    new List<string>()
                    {
                mondayCheckBox.Checked ? "Monday" : string.Empty,
                tuesdayCheckBox.Checked ? "Tuesday" : string.Empty,
                wednesdayCheckBox.Checked ? "Wednesday" : string.Empty,
                thursdayCheckBox.Checked ? "Thursday" : string.Empty,
                fridayCheckBox.Checked ? "Friday" : string.Empty,
                saturdayCheckBox.Checked ? "Saturday" : string.Empty,
                sundayCheckBox.Checked ? "Sunday" : string.Empty,
                    }.Where(s => !string.IsNullOrEmpty(s))
                );

                Con.Open();
                string query = "INSERT INTO DoctorAvailabileTbl (doctor_id,weekDays, availabilityStartTime, availabilityEndTime,doctorIsVacation) VALUES (@DoctorId, @WeekDays, @Start_time, @End_time, @IsOnVacation)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@DoctorId", int.Parse(docIdCb.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@WeekDays", weekDays);
                cmd.Parameters.AddWithValue("@Start_time", startTimeCb.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@End_time", endTimeCb.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@IsOnVacation", vacationCheckBox.Checked);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Availability details added successfully");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
                LoadDoctorIDs();
            }
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string weekDays = string.Join(",",
                    new List<string>()
                    {
                mondayCheckBox.Checked ? "Monday" : string.Empty,
                tuesdayCheckBox.Checked ? "Tuesday" : string.Empty,
                wednesdayCheckBox.Checked ? "Wednesday" : string.Empty,
                thursdayCheckBox.Checked ? "Thursday" : string.Empty,
                fridayCheckBox.Checked ? "Friday" : string.Empty,
                saturdayCheckBox.Checked ? "Saturday" : string.Empty,
                sundayCheckBox.Checked ? "Sunday" : string.Empty,
                    }.Where(s => !string.IsNullOrEmpty(s))
                );

                Con.Open();
                string query = "UPDATE DoctorAvailabileTbl SET weekDays = @WeekDays, availabilityStartTime = @Start_time, availabilityEndTime = @End_time, doctorIsVacation = @IsOnVacation WHERE doctor_id = @DoctorId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@DoctorId", int.Parse(docIdCb.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@WeekDays", weekDays);
                cmd.Parameters.AddWithValue("@Start_time", startTimeCb.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@End_time", endTimeCb.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@IsOnVacation", vacationCheckBox.Checked);

                int updatedRows = cmd.ExecuteNonQuery();

                if (updatedRows > 0)
                {
                    MessageBox.Show("Availability details updated successfully");
                }
                else
                {
                    MessageBox.Show("No record found to update. Please select a valid record.");
                }

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
                LoadDoctorIDs();
            }
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a doctor ID is selected
                if (docIdCb.SelectedItem == null)
                {
                    MessageBox.Show("Please select a doctor ID.");
                    return;
                }

                Con.Open();

                // SQL query to delete the record of the selected doctor ID
                string query = "DELETE FROM DoctorAvailabileTbl WHERE doctor_id = @DoctorId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@DoctorId", int.Parse(docIdCb.SelectedItem.ToString()));

                // Execute the SQL command
                int deletedRows = cmd.ExecuteNonQuery();

                // Check if any rows were deleted
                if (deletedRows > 0)
                {
                    MessageBox.Show("Availability details deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No record found to delete. Please select a valid record.");
                }

                // Reset the form controls
                ResetForm();
            }
            catch (Exception ex)
            {
                // Show any error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the database connection
                Con.Close();

                // Reload the doctor IDs
                LoadDoctorIDs();
            }
        }


        private void docAvailableDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in docAvailableDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void docAvailableDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.docAvailableDGV.Rows[e.RowIndex];

                // Set doctor ID ComboBox
                docIdCb.SelectedItem = row.Cells["doctor_id"].Value.ToString();

                // Set WeekDays checkboxes
                string weekDays = row.Cells["weekDays"].Value.ToString();
                mondayCheckBox.Checked = weekDays.Contains("Monday");
                tuesdayCheckBox.Checked = weekDays.Contains("Tuesday");
                wednesdayCheckBox.Checked = weekDays.Contains("Wednesday");
                thursdayCheckBox.Checked = weekDays.Contains("Thursday");
                fridayCheckBox.Checked = weekDays.Contains("Friday");
                saturdayCheckBox.Checked = weekDays.Contains("Saturday");
                sundayCheckBox.Checked = weekDays.Contains("Sunday");

                // Set Time Pickers
                startTimeCb.Value = DateTime.Today.Add((TimeSpan)row.Cells["availabilityStartTime"].Value);
                endTimeCb.Value = DateTime.Today.Add((TimeSpan)row.Cells["availabilityEndTime"].Value);

                // Set Vacation Checkbox
                vacationCheckBox.Checked = (bool)row.Cells["doctorIsVacation"].Value;
            }
        }





        private void docIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (docIdCb.SelectedItem != null)
                {
                    Con.Open();
                    string query = "SELECT U.userName, D.doctorSpecialization, D.roomNumber FROM DoctorTbl D INNER JOIN UserTbl U ON D.doctor_id = U.user_id WHERE D.doctor_id = @doctor_id";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@doctor_id", docIdCb.SelectedItem.ToString());
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        docNameTb.Text = dr["userName"].ToString();
                        docSpecTb.Text = dr["doctorSpecialization"].ToString();
                        docRoomTb.Text = dr["roomNumber"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No details found for the selected ID");
                    }

                    dr.Close();
                }
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

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = @"SELECT D.*, U.userName FROM DoctorAvailabileTbl D
                         INNER JOIN UserTbl U ON D.doctor_id = U.user_id 
                         WHERE U.userName LIKE @searchText
                         OR CAST(D.availabilityStartTime AS VARCHAR(5)) LIKE @searchText 
                         OR CAST(D.availabilityEndTime AS VARCHAR(5)) LIKE @searchText
                         OR D.weekDays LIKE @searchText";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchTb.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                docAvailableDGV.DataSource = dt;
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
