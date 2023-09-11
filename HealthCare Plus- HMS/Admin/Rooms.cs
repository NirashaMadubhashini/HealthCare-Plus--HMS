﻿using System;
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

        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        int Key = 0;
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



        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (roomNumTb.Text == "" || roomFloorCb.SelectedIndex == -1 || roomTypeCb.SelectedIndex == -1 || statusCb.Text == "" || roomNoteTb.Text == "")
            {
                MessageBox.Show("Missing Information");
                return; // Add a return statement to exit early
            }
            // Validate that roomNumber starts with "R"
            if (!roomNumTb.Text.StartsWith("R"))
            {
                MessageBox.Show("Room number must start with 'R'");
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
                        MessageBox.Show("A room with this number already exists.");
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

                MessageBox.Show("Room Added");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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
            if (roomNumTb.Text == "" || roomFloorCb.SelectedIndex == -1 || roomTypeCb.SelectedIndex == -1 || statusCb.Text == "" || roomNoteTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            // Validate that roomNumber starts with "R"
            if (!roomNumTb.Text.StartsWith("R"))
            {
                MessageBox.Show("Room number must start with 'R'");
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
                            MessageBox.Show("A room with this number already exists.");
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
                    MessageBox.Show("Room Updated");
                    Con.Close();
                    DisplayRoom();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Room");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from RoomTbl where room_id= @RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Deleted");
                    Con.Close();
                    DisplayRoom();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
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
    }
}
