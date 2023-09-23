using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace HealthCare_Plus__HMS.Admin
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            DisplayRoom();
            ClearAllFields();  // Clears all fields
            roomDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(RoomDGV_DataBindingComplete);

            roomDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomDGV.MultiSelect = false;
            roomDGV.ReadOnly = true;

            roomNumTb.KeyDown += new KeyEventHandler(roomNumTb_KeyDown);

        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        int Key = 0;

        private void roomNumTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                roomNoteTb.Focus();
                e.Handled = true; // To prevent the default behavior (e.g., beep sound)
                e.SuppressKeyPress = true; // Prevents the ding sound
            }
        }

        private void ClearAllFields()
        {
            // Clearing all textboxes
            roomNumTb.Text = "";
            roomNoteTb.Text = "";

            // Clearing all combo boxes
            roomFloorCb.SelectedIndex = -1;
            roomTypeCb.SelectedIndex = -1;
            statusCb.SelectedIndex = -1;
        }

        private void DisplayRoom()
        {
            Con.Open();
            string Query = "Select * from RoomTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            roomDGV.AutoResizeColumns();  // Resize columns to fit content
            roomDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            roomDGV.DataSource = ds.Tables[0];
            roomDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomDGV.Columns["patient_id"].Visible = false;
            Con.Close();
        }

        private void Clear()
        {
            roomNumTb.Text = "";
            roomFloorCb.SelectedIndex = -1;
            roomTypeCb.SelectedIndex = -1;
            statusCb.SelectedIndex = -1;
            roomNoteTb.Text = "";
            Key = 0;
        }

        private bool IsValidRoom(string roomNumber)
        {
            if (!roomNumber.StartsWith("R"))
            {
                MessageBox.Show("Invalid Room Number. The room number must start with 'R'.");
                return false;
            }

            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM RoomTbl WHERE roomNumber = @RNUM", Con))
            {
                Con.Open();  // Explicitly open the connection here
                cmd.Parameters.AddWithValue("@RNUM", roomNumber);
                var exists = (int)cmd.ExecuteScalar() > 0;
                Con.Close(); // Close the connection after executing the command

                if (exists)
                {
                    MessageBox.Show("Room Number Conflict. A room with this number already exists.");
                    return false; // Room number is already in use
                }
            }

            return true; // All validations passed
        }



        private void addBtn_Click_1(object sender, EventArgs e)
        {

            if (!IsValidRoom(roomNumTb.Text))
            {
                return;
            }

            if (roomNumTb.Text == "" || roomFloorCb.SelectedIndex == -1 || roomTypeCb.SelectedIndex == -1 || statusCb.Text == "" || roomNoteTb.Text == "")
            {
                MessageBox.Show("Please complete all fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Con.Open();

                // Check if a room with the entered number already exists
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM RoomTbl WHERE roomNumber = @RNUM", Con))
                {
                    cmd.Parameters.AddWithValue("@RNUM", roomNumTb.Text);
                    var exists = (int)cmd.ExecuteScalar() > 0;

                    if (exists)
                    {
                        MessageBox.Show("Room Number Conflict. A room with this number already exists.");
                        Con.Close();
                        return; // Room number is already in use, exit early
                    }
                }

                // Proceed to add the new room record
                using (SqlCommand cmd = new SqlCommand("insert into RoomTbl(roomNumber,roomFloor,roomType,roomStatus,roomNotes)values(@RNUM,@RF,@RT,@RS,@RN)", Con))
                {
                    cmd.Parameters.AddWithValue("@RNUM", roomNumTb.Text);
                    cmd.Parameters.AddWithValue("@RF", roomFloorCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RT", roomTypeCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RS", statusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RN", roomNoteTb.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Room Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred while processing your request: " + Ex.Message);
            }
            finally
            {
                Con.Close();
                DisplayRoom();
                Clear();  // Clear the fields here
            }
        }


        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (!IsValidRoom(roomNumTb.Text))
            {
                return;
            }

            if (roomNumTb.Text == "" || roomFloorCb.SelectedIndex == -1 || roomTypeCb.SelectedIndex == -1 || statusCb.Text == "" || roomNoteTb.Text == "")
            {
                MessageBox.Show("Please complete all fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                try
                {
                    Con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT room_id FROM RoomTbl WHERE roomNumber = @RNUM", Con))
                    {
                        cmd.Parameters.AddWithValue("@RNUM", roomNumTb.Text);
                        object result = cmd.ExecuteScalar();

                        if (result != null && Convert.ToInt32(result) != Key)
                        {
                            MessageBox.Show("Room Number Conflict. A room with this number already exists.");
                            Con.Close();
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("update RoomTbl set roomNumber=@RNUM,roomFloor=@RF,roomType=@RT,roomStatus=@RS,roomNotes=@RN where room_id=@RKey", Con))
                    {
                        cmd.Parameters.AddWithValue("@RNUM", roomNumTb.Text);
                        cmd.Parameters.AddWithValue("@RF", roomFloorCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RT", roomTypeCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RS", statusCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RN", roomNoteTb.Text);
                        cmd.Parameters.AddWithValue("@RKey", Key);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Room Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
);
                    Con.Close();
                    DisplayRoom();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occurred while processing your request: " + Ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("No Room Selected. Please select a room to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from RoomTbl where room_id= @RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayRoom();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occurred while processing your request: " + Ex.Message);
                }
            }
        }

        private void RoomDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in roomDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void RoomDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = roomDGV.Rows[e.RowIndex]; // Get the selected row

                // Populate text fields with data from the row
                roomNumTb.Text = row.Cells["roomNumber"].Value.ToString();
                roomNoteTb.Text = row.Cells["roomNotes"].Value.ToString();
                roomFloorCb.SelectedItem = row.Cells["roomFloor"].Value.ToString();
                roomTypeCb.SelectedItem = row.Cells["roomType"].Value.ToString();
                statusCb.SelectedItem = row.Cells["roomStatus"].Value.ToString();


                // Update the Key variable, which seems to be used for editing and deleting records
                if (string.IsNullOrEmpty(roomNumTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["room_id"].Value?.ToString() ?? "0");
                }
            }
        }


        private void roomFloorCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
          
        }

        private void patIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM RoomTbl WHERE roomType LIKE @search";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@search", "%" + searchTb.Text + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            roomDGV.DataSource = dt;
            Con.Close();
        }
    }
}
