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

namespace HealthCare_Plus__HMS.Admin
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            DisplayRoom();
            GetDocId();
            GetDocName();
            GetPatId();
            GetPatName();
            ClearAllFields();  // Clears all fields
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        int Key = 0;
        private void ClearAllFields()
        {
            // Clearing all textboxes
            DocNameTb.Text = "";
            PatNameTb.Text = "";
            RDate.Text = "";

            // Clearing all combo boxes
            DocIdCb.SelectedIndex = -1;
            PatIdCb.SelectedIndex = -1;
            RACb.SelectedIndex = -1;
        }

        private void DisplayRoom()
        {
            Con.Open();
            string Query = "Select * from RoomTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RoomDGV.DataSource = ds.Tables[0];
            RoomDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void Clear()
        {
            DocIdCb.SelectedIndex = -1;
            DocNameTb.Text = "";
            PatIdCb.SelectedIndex = -1;
            PatNameTb.Text = "";
            RACb.SelectedIndex = -1;
            RDate.Text = "";
            Key = 0;
        }

        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocId from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId", typeof(int));
            dt.Load(rdr);
            DocIdCb.ValueMember = "DocId";
            DocIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetDocName()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl where DocId = " + DocIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DocNameTb.Text = dr["DocName"].ToString();
            }
            Con.Close();
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
            PatIdCb.ValueMember = "PatId";
            PatIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetPatName()
        {
            Con.Open();
            string Query = "Select * from PatientTbl where PatId = " + PatIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PatName"].ToString();
            }
            Con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PatNameTb.Text == "" || RACb.Text == "")
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
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", PatIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@RD", RDate.Value.Date);
                    cmd.Parameters.AddWithValue("@RA", RACb.SelectedItem.ToString());
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
            }
        }

        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PatNameTb.Text == "" || RACb.SelectedIndex == -1)
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
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", PatIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@RD", RDate.Value.Date);
                    cmd.Parameters.AddWithValue("@RA", RACb.SelectedItem.ToString());
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
            }
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
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = RoomDGV.Rows[e.RowIndex]; // Get the selected row

                // Populate text fields with data from the row
                DocNameTb.Text = row.Cells["DocName"].Value.ToString();
                PatNameTb.Text = row.Cells["PatName"].Value.ToString();
                RACb.SelectedItem = row.Cells["RoomAvailability"].Value.ToString();

                // Use the DateTimePicker's Value property to set its value
                if (DateTime.TryParse(row.Cells["RoomDate"].Value.ToString(), out DateTime result))
                {
                    RDate.Value = result;
                }


                // Update the Key variable, which seems to be used for editing and deleting records
                if (string.IsNullOrEmpty(DocNameTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["RoomId"].Value?.ToString() ?? "0");
                }

            }
        }
    }
}
