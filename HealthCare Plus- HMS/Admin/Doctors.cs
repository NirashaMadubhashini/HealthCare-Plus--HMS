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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            GetRoomNum();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void GetRoomNum()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select roomNumber from RoomTbl", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                // Remove the manual addition of the column
                dt.Load(rdr);
                docRoomCb.ValueMember = "roomNumber";
                docRoomCb.DisplayMember = "roomNumber"; // Set the DisplayMember property here
                docRoomCb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }




        private void LoadDoctorNames()
        {
            docNameCb.Items.Clear();

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT userName  FROM UserTbl WHERE userRole = 'Doctor'", Con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    docNameCb.Items.Add(reader.GetString(0));
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

        private void loadTblDoctor()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                string query = "SELECT u.user_id AS 'Doctor ID', u.userName AS 'Doctor Name', " +
               "u.userContact AS 'Contact Number', dp.doctorSpecialization AS 'Specialization', " +
               "dp.doctorQualifications AS 'Qualifications', dp.roomNumber AS 'Room Number' " + // Updated column alias to 'Room Number'
               "FROM UserTbl u " +
               "INNER JOIN DoctorTbl dp ON u.user_id = dp.doctor_id";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                doctorDGV.DataSource = dt;

                foreach (DataGridViewColumn column in doctorDGV.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.StackTrace);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
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
            docRoomCb.SelectedIndex = -1;
            docexperienceTb.Text = "";
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.doctorDGV.Rows[e.RowIndex];

                docIdTb.Text = row.Cells["Doctor ID"].Value.ToString();
                docNameCb.Text = row.Cells["Doctor Name"].Value.ToString();
                docPhoneTb.Text = row.Cells["Contact Number"].Value.ToString();
                docSpecCb.Text = row.Cells["Specialization"].Value.ToString();
                docexperienceTb.Text = row.Cells["Qualifications"].Value.ToString();
                docRoomCb.Text = row.Cells["Room Number"].Value.ToString();

                // If you have email in your DataGridView add it like the lines above.
                // For example:
                // docEmailTb.Text = row.Cells["Email"].Value.ToString();
            }

            /*            if (e.RowIndex >= 0)  // Check if row index is valid
                        {
                            DataGridViewRow row = this.doctorDGV.Rows[e.RowIndex];

                            // Populate text fields with data from the row
                            docIdTb.Text = row.Cells["Doctor ID"].Value.ToString();
                            docNameCb.Text = row.Cells["Doctor Name"].Value.ToString();
                            docPhoneTb.Text = row.Cells["Contact Number"].Value.ToString();
                            docSpecCb.Text = row.Cells["Specialization"].Value.ToString();
                            docexperienceTb.Text = row.Cells["Qualifications"].Value.ToString();
                            docRoomCb.Text = row.Cells["Room Number"].Value.ToString();


                            // Update the Key variable, which seems to be used for editing and deleting records
                            if (string.IsNullOrEmpty(docIdTb.Text))
                            {
                                Key = 0;
                            }
                            else
                            {
                                Key = Convert.ToInt32(row.Cells["doctor_id"].Value?.ToString() ?? "0");
                            }
                        }*/
        }




        private void RoomNumCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doctors_Load(object sender, EventArgs e)
        {
        
        }


        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(docIdTb.Text) ||
                docSpecCb.SelectedItem == null || docRoomCb.SelectedValue == null||
                string.IsNullOrWhiteSpace(docexperienceTb.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }

            try
            {
                int doctor_id = int.Parse(docIdTb.Text);
                string specializationName = docSpecCb.SelectedItem.ToString();
                string doctorQualifications = docexperienceTb.Text;
                string roomNumber = docRoomCb.SelectedValue.ToString();

                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO DoctorTbl (doctor_id, doctorSpecialization, doctorQualifications, roomNumber) VALUES (@DoctorId, @DoctorSpec, @Qualifications, @RoomNumber)", Con);
                cmdInsert.Parameters.AddWithValue("@DoctorId", doctor_id);
                cmdInsert.Parameters.AddWithValue("@DoctorSpec", specializationName);
                cmdInsert.Parameters.AddWithValue("@Qualifications", doctorQualifications);
                cmdInsert.Parameters.AddWithValue("@RoomNumber", docRoomCb.SelectedValue.ToString());
                cmdInsert.ExecuteNonQuery();


                MessageBox.Show("Doctor's profile added successfully!");
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
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(docIdTb.Text))
            {
                MessageBox.Show("Please select a doctor to edit.");
                return;
            }
            if (string.IsNullOrWhiteSpace(docIdTb.Text) ||
                docSpecCb.SelectedItem == null ||
                string.IsNullOrWhiteSpace(docexperienceTb.Text) ||
                string.IsNullOrWhiteSpace(docRoomCb.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }

            try
            {

                int doctor_id = int.Parse(docIdTb.Text);
                string specializationName = docSpecCb.SelectedItem.ToString();
                string doctorQualifications = docexperienceTb.Text;
                string roomNumber = docRoomCb.SelectedItem.ToString();


                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                SqlCommand cmdUpdate = new SqlCommand("UPDATE DoctorTbl SET doctorSpecialization =@DoctorSpec, doctorQualifications=@Qualifications, roomNumber=@RoomNumber WHERE doctor_id = @DoctorId", Con);
                cmdUpdate.Parameters.AddWithValue("@DoctorId", doctor_id);
                cmdUpdate.Parameters.AddWithValue("@DoctorSpec", specializationName);
                cmdUpdate.Parameters.AddWithValue("@Qualifications", doctorQualifications);
                cmdUpdate.Parameters.AddWithValue("@RoomNumber", docRoomCb.SelectedValue.ToString());
                cmdUpdate.ExecuteNonQuery();


                MessageBox.Show("Doctor's profile updated successfully!");
                loadTblDoctor();
                Clear();

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

                SqlCommand cmdDelete = new SqlCommand("DELETE FROM DoctorTbl WHERE doctor_id = @DoctorId", Con);
                cmdDelete.Parameters.AddWithValue("@DoctorId", doctorId);
                cmdDelete.ExecuteNonQuery();

                MessageBox.Show("Doctor's profile deleted successfully!");
                loadTblDoctor();
                Clear();

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
                return;

            string selectedDoctorName = docNameCb.SelectedItem.ToString();


            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT user_id, userContact, userEmail FROM UserTbl WHERE userName = @DoctorName", Con);
                cmd.Parameters.AddWithValue("@DoctorName", selectedDoctorName);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    docIdTb.Text = reader["user_id"].ToString();
                    docPhoneTb.Text = reader["userContact"].ToString();
                    docEmailTb.Text = reader["userEmail"].ToString();

                }
                reader.Close();
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

        private void docSpecCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
