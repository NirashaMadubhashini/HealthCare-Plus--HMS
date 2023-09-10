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
using System.Windows.Input;

namespace HealthCare_Plus__HMS.Admin
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            loadTblDoctor();
            doctorDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(DoctorDGV_DataBindingComplete);
            LoadDoctorNames();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        private void LoadDoctorNames()
        {
            docNameCb.Items.Clear();  // Clear the combo box items

            try
            {
                Con.Open();  // Open the database connection
                SqlCommand cmd = new SqlCommand("SELECT userName  FROM UserTbl WHERE userRole = 'Doctor'", Con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    docNameCb.Items.Add(reader.GetString(0));  // Add doctor usernames to the combo box
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // Show any error messages
            }
            finally
            {
                Con.Close();  // Close the database connection
            }
        }

        private void loadTblDoctor()
        {
            try
            {
                Con.Open();

                // Construct the SQL query to retrieve data from the Users and DoctorProfiles tables using an INNER JOIN
                string query = "SELECT u.user_id AS 'Doctor ID', u.userName AS 'Doctor Name', " +
                               "u.userContact AS 'Contact Number', dp.specialization_id AS 'Specialization ID', " +
                               "dp.doctorQualifications AS 'Qualifications', dp.doctorLocation AS 'Location' " +
                               "FROM UserTbl u " +
                               "INNER JOIN DoctorTbl dp ON u.user_id = dp.doctor_id";

                // Create a SqlDataAdapter to execute the query and fetch the data
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);

                // Create a DataTable to hold the fetched data
                DataTable dt = new DataTable();

                // Fill the DataTable with the data fetched from the database
                sda.Fill(dt);

                // Bind the DataTable as the data source for the DataGridView (tblDoctor)
                doctorDGV.DataSource = dt;

                // Set the AutoSizeMode property of each column to Fill to make them fill the available space
                foreach (DataGridViewColumn column in doctorDGV.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                // Display an error message and additional debugging information if there's an exception while fetching data
                MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.StackTrace);
            }
            finally
            {
                // Close the database connection in the 'finally' block to ensure it's always closed
                Con.Close();
            }
        }

        int Key = 0;
        private void Clear()
        {
            docIdTb.Text = "";
            docPhoneTb.Text = "";
            docEmailTb.Text = "";
            docSpecCb.SelectedIndex = -1;
            docNameCb.SelectedIndex = -1;
            docexperienceTb.Text = "";
            docRoomTb.Text = "";
            // Add code to clear other text fields and combo boxes as needed
            // AdditionalTextField.Text = "";
            // AdditionalComboBox.SelectedIndex = -1;
            Key = 0;
        }
      
     

        private void DoctorDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in doctorDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void DoctorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row index is valid (not a header row)
            {
                DataGridViewRow row = doctorDGV.Rows[e.RowIndex]; // Get the clicked row
                int doctorId = int.Parse(row.Cells["Doctor ID"].Value.ToString());

                try
                {
                    Con.Open();

                    // Fetch the doctor details based on the clicked doctor's ID
                    SqlCommand cmd = new SqlCommand("SELECT u.userName, u.userContact, u.userEmail, dp.specialization_id, dp.doctorQualifications, dp.doctorLocation FROM UserTbl u INNER JOIN DoctorTbl dp ON u.user_id = dp.doctor_id WHERE dp.doctor_id = @DoctorId", Con);
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            docIdTb.Text = reader["user_id"].ToString();  // Set the doctor's ID
                            docPhoneTb.Text = reader["userContact"].ToString();  // Set the doctor's mobile number
                            docEmailTb.Text = reader["userEmail"].ToString();  // Set the doctor's email
                            docNameCb.Text = reader["userName"].ToString();  // Set the doctor's name
                            docSpecCb.SelectedValue = reader["specialization_id"];
                            docexperienceTb.Text = reader["doctorQualifications"].ToString();
                            docRoomTb.Text = reader["doctorLocation"].ToString();
                        }
                    }
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

        private void RoomNumCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            LoadSpecializations();
        }

        private void LoadSpecializations()
        {
            try
            {
                // Open the database connection
                Con.Open();

                // Fetch specializations from the database
                string query = "SELECT specializationName FROM SpecializationTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                // Create a DataTable to hold the fetched data
                DataTable dt = new DataTable();

                // Fill the DataTable with the data fetched from the database
                dt.Load(rdr);

                // Bind the DataTable as the data source for the ComboBox (docSpecCb)
                docSpecCb.DataSource = dt;
                docSpecCb.DisplayMember = "specializationName";
                docSpecCb.ValueMember = "specializationName";

                // Close the reader
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the database connection
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }


        private void addBtn_Click_1(object sender, EventArgs e)
        {
            // Check if any of the text fields are empty or if no specialization is selected
            if (string.IsNullOrWhiteSpace(docIdTb.Text) ||
                docSpecCb.SelectedItem == null ||
                string.IsNullOrWhiteSpace(docexperienceTb.Text) ||
                string.IsNullOrWhiteSpace(docRoomTb.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
                return;  // Exit the method early
            }

            // Validate txtLocation for integer value
            if (!int.TryParse(docRoomTb.Text, out int roomNumber))
            {
                MessageBox.Show("Room Number should be a valid integer!");
                return;
            }

            try
            {
                // Fetch the doctor ID from the form (this might be from a text box or combo box)
                int doctor_id = int.Parse(docIdTb.Text);

                // Fetch the selected specialization name from the combo box
                string specializationName = docSpecCb.SelectedItem.ToString();

                // Fetch doctor's qualifications and location from the form
                string doctorQualifications = docexperienceTb.Text;
                string doctorLocation= docRoomTb.Text;

                // Open the database connection
                Con.Open();

                // Fetch the specialization ID based on the selected specialization name
                SqlCommand cmdSpec = new SqlCommand("SELECT specialization_id FROM SpecializationTbl WHERE specializationName = @SpecName", Con);
                cmdSpec.Parameters.AddWithValue("@SpecName", specializationName);
                int specialization_id = (int)cmdSpec.ExecuteScalar();

                // Insert the new doctor's profile into the DoctorProfiles table
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO DoctorTbl (doctor_id, specialization_id, doctorQualifications, doctorLocation) VALUES (@DoctorId, @SpecId, @Qualifications, @Location)", Con);
                cmdInsert.Parameters.AddWithValue("@DoctorId", doctor_id);
                cmdInsert.Parameters.AddWithValue("@SpecId", specialization_id);
                cmdInsert.Parameters.AddWithValue("@Qualifications", doctorQualifications);
                cmdInsert.Parameters.AddWithValue("@Location", doctorLocation);
                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Doctor's profile added successfully!");
                // Call the method to load/refresh the table here
                loadTblDoctor();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clear();

            }
            finally
            {
                Con.Close();  // Close the database connection
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(docIdTb.Text))
            {
                MessageBox.Show("Please select a doctor to edit.");
                return;
            }

            // Check if any of the text fields are empty or if no specialization is selected
            if (string.IsNullOrWhiteSpace(docIdTb.Text) ||
                docSpecCb.SelectedItem == null ||
                string.IsNullOrWhiteSpace(docexperienceTb.Text) ||
                string.IsNullOrWhiteSpace(docRoomTb.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
                return;  // Exit the method early
            }

            try
            {
                int doctorId = int.Parse(docIdTb.Text);
                string specializationName = docSpecCb.SelectedItem.ToString();
                string doctorQualifications = docexperienceTb.Text;
                int doctorLocation = int.Parse(docRoomTb.Text);  // Assuming location is a numeric field

                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Fetch the specialization ID based on the selected specialization name
                SqlCommand cmdSpec = new SqlCommand("SELECT specialization_id FROM SpecializationTbl  WHERE specializationName = @SpecName", Con);
                cmdSpec.Parameters.AddWithValue("@SpecName", specializationName);
                int specializationId = (int)cmdSpec.ExecuteScalar();

                // Update the doctor's profile in the DoctorProfiles table
                SqlCommand cmdUpdate = new SqlCommand("UPDATE DoctorTbl SET specialization_id = @SpecId, doctorQualifications  = @Qualifications, doctorLocation = @Location WHERE doctor_id = @DoctorId", Con);
                cmdUpdate.Parameters.AddWithValue("@DoctorId", doctorId);
                cmdUpdate.Parameters.AddWithValue("@SpecId", specializationId);
                cmdUpdate.Parameters.AddWithValue("@Qualifications", doctorQualifications);
                cmdUpdate.Parameters.AddWithValue("@Location", doctorLocation);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Doctor's profile updated successfully!");
                loadTblDoctor();  // Refresh the table to show the updated details
                Clear();  // Clear the input fields

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(docIdTb.Text))
            {
                MessageBox.Show("Please select a doctor to delete.");
                return;
            }

            try
            {
                int doctorId = int.Parse(docIdTb.Text);

                Con.Open();

                // Delete the doctor's profile from the DoctorProfiles table
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM DoctorTbl WHERE doctor_id = @DoctorId", Con);
                cmdDelete.Parameters.AddWithValue("@DoctorId", doctorId);
                cmdDelete.ExecuteNonQuery();

                MessageBox.Show("Doctor's profile deleted successfully!");
                loadTblDoctor();  // Refresh the table
                Clear();  // Clear the input fields

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

        private void docNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (docNameCb.SelectedItem == null)
                return;  // Exit early if no item is selected

            // Fetch selected doctor's name
            string selectedDoctorName = docNameCb.SelectedItem.ToString();


            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();  // Only open if it's closed
                }
                SqlCommand cmd = new SqlCommand("SELECT user_id, userContact, userEmail FROM UserTbl WHERE userName = @DoctorName", Con);
                cmd.Parameters.AddWithValue("@DoctorName", selectedDoctorName);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    docIdTb.Text = reader["user_id"].ToString();      // Set the doctor's ID
                    docPhoneTb.Text = reader["userContact"].ToString();  // Set the doctor's mobile number
                    docEmailTb.Text = reader["userEmail"].ToString();      // Set the doctor's email

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // Show any error messages
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();  // Close the database connection
            }
        }

        private void docSpecCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
