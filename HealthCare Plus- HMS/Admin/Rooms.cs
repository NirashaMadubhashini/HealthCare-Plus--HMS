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
            GetPatId();
            ClearAllFields();  // Clears all fields
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        int Key = 0;
        private void ClearAllFields()
        {
          /*  // Clearing all textboxes
            roomNumTb.Text = "";
            roomNoteTb.Text = "";
            RDate.Text = "";

            // Clearing all combo boxes
            DocIdCb.SelectedIndex = -1;
            roomFloorCb.SelectedIndex = -1;
            statusCb.SelectedIndex = -1;*/
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
            Con.Close();
        }

        private void Clear()
        {
            /*DocIdCb.SelectedIndex = -1;
            roomNumTb.Text = "";
            roomFloorCb.SelectedIndex = -1;
            roomNoteTb.Text = "";
            statusCb.SelectedIndex = -1;
            RDate.Text = "";
            Key = 0;*/
        }


        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            roomFloorCb.ValueMember = "PatId";
            roomFloorCb.DataSource = dt;
            Con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
           /* if (roomNumTb.Text == "" || roomNoteTb.Text == "" || statusCb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RoomTbl(DocId,DocName,PatId,PatName,RoomDate,RoomAvailability)values(@DI,@DN,@PI,@PN,@RD,@RA)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", roomNumTb.Text);
                    cmd.Parameters.AddWithValue("@PI", roomFloorCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", roomNoteTb.Text);
                    cmd.Parameters.AddWithValue("@RD", RDate.Value.Date);
                    cmd.Parameters.AddWithValue("@RA", statusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Added");
                    Con.Close();
                    DisplayRoom();
                    Clear();  // Clear the fields here
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }*/
        }

        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
           /* if (roomNumTb.Text == "" || roomNoteTb.Text == "" || statusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update RoomTbl set DocId=@DI,DocName=@DN,PatId=@PI,PatName=@PN,RoomDate=@RD,RoomAvailabilit=@RA where RoomId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", roomNumTb.Text);
                    cmd.Parameters.AddWithValue("@PI", roomFloorCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", roomNoteTb.Text);
                    cmd.Parameters.AddWithValue("@RD", RDate.Value.Date);
                    cmd.Parameters.AddWithValue("@RA", statusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Updated");
                    Con.Close();
                    DisplayRoom();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }*/
        }

        private void DelBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete from RoomTbl where RoomId= @RKey", Con);
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

        private void RoomDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = roomDGV.Rows[e.RowIndex]; // Get the selected row

                // Populate text fields with data from the row
                roomNumTb.Text = row.Cells["DocName"].Value.ToString();
                roomNoteTb.Text = row.Cells["PatName"].Value.ToString();
                statusCb.SelectedItem = row.Cells["RoomAvailability"].Value.ToString();

                // Use the DateTimePicker's Value property to set its value
                if (DateTime.TryParse(row.Cells["RoomDate"].Value.ToString(), out DateTime result))
                {
                    RDate.Value = result;
                }


                // Update the Key variable, which seems to be used for editing and deleting records
                if (string.IsNullOrEmpty(roomNumTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["RoomId"].Value?.ToString() ?? "0");
                }
            }*/
        }

        private void roomFloorCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
           /* roomFloorCb.Items.Add("1st Floor");
            roomFloorCb.Items.Add("2nd Floor");
            roomFloorCb.Items.Add("3rd Floor");
            roomFloorCb.Items.Add("4th Floor");

            roomTypeCb.Items.Add("Regular");
            roomTypeCb.Items.Add("ICU");
            roomTypeCb.Items.Add("OperationTheater");

            statusCb.Items.Add("Occupied");
            statusCb.Items.Add("Available");*/
        }
    }
}
