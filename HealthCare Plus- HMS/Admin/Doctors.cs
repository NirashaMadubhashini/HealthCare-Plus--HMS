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
                Con.Open();

              
                string query = "SELECT u.user_id AS 'Doctor ID', u.userName AS 'Doctor Name', " +
                               "u.userContact AS 'Contact Number', dp.specialization_id AS 'Specialization ID', " +
                               "dp.doctorQualifications AS 'Qualifications', dp.doctorLocation AS 'Location' " +
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
                DataGridViewRow row = doctorDGV.Rows[e.RowIndex];
                int doctorId = int.Parse(row.Cells["Doctor ID"].Value.ToString());

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT u.userName, u.userContact, u.userEmail, dp.specialization_id, dp.doctorQualifications, dp.doctorLocation FROM UserTbl u INNER JOIN DoctorTbl dp ON u.user_id = dp.doctor_id WHERE dp.doctor_id = @DoctorId", Con);
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            docIdTb.Text = reader["user_id"].ToString();
                            docPhoneTb.Text = reader["userContact"].ToString();
                            docEmailTb.Text = reader["userEmail"].ToString();
                            docNameCb.Text = reader["userName"].ToString();
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
                Con.Open();

                string query = "SELECT specializationName FROM SpecializationTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(rdr);

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
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }


        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(docIdTb.Text) ||
                docSpecCb.SelectedItem == null ||
                string.IsNullOrWhiteSpace(docexperienceTb.Text) ||
                string.IsNullOrWhiteSpace(docRoomTb.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }

            if (!int.TryParse(docRoomTb.Text, out int roomNumber))
            {
                MessageBox.Show("Room Number should be a valid integer!");
                return;
            }

            try
            {
                int doctor_id = int.Parse(docIdTb.Text);

                string specializationName = docNameCb.SelectedItem.ToString();

                string doctorQualifications = docexperienceTb.Text;
                string doctorLocation= docRoomTb.Text;

                Con.Open();

                SqlCommand docSpecCb = new SqlCommand("SELECT specialization_id FROM SpecializationTbl WHERE specializationName = @SpecName", Con);
                docSpecCb.Parameters.AddWithValue("@SpecName", specializationName);
                int specialization_id = (int)docSpecCb.ExecuteScalar();

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO DoctorTbl (doctor_id, specialization_id, doctorQualifications, doctorLocation) VALUES (@DoctorId, @SpecId, @Qualifications, @Location)", Con);
                cmdInsert.Parameters.AddWithValue("@DoctorId", doctor_id);
                cmdInsert.Parameters.AddWithValue("@SpecId", specialization_id);
                cmdInsert.Parameters.AddWithValue("@Qualifications", doctorQualifications);
                cmdInsert.Parameters.AddWithValue("@Location", doctorLocation);
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
                Con.Close();
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
                int doctorLocation = int.Parse(docRoomTb.Text);

                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                SqlCommand cmdSpec = new SqlCommand("SELECT specialization_id FROM SpecializationTbl  WHERE specializationName = @SpecName", Con);
                cmdSpec.Parameters.AddWithValue("@SpecName", specializationName);
                int specializationId = (int)cmdSpec.ExecuteScalar();

                SqlCommand cmdUpdate = new SqlCommand("UPDATE DoctorTbl SET specialization_id = @SpecId, doctorQualifications  = @Qualifications, doctorLocation = @Location WHERE doctor_id = @DoctorId", Con);
                cmdUpdate.Parameters.AddWithValue("@DoctorId", doctorId);
                cmdUpdate.Parameters.AddWithValue("@SpecId", specializationId);
                cmdUpdate.Parameters.AddWithValue("@Qualifications", doctorQualifications);
                cmdUpdate.Parameters.AddWithValue("@Location", doctorLocation);
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
