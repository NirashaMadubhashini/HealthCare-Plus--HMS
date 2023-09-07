﻿using System;
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
            DisplayDoc();
            DoctorDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(DoctorDGV_DataBindingComplete);
            GetRoomNum();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDoc()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        int Key = 0;
        private void Clear()
        {
            DNameTb.Text = "";
            DocAddTb.Text = "";
            DocGenCb.SelectedIndex = -1;
            DocPhoneTb.Text = "";
            DocDOB.Text = "";
            DocSpecCb.SelectedIndex = -1;
            DocExpTb.Text = "";
            DocPassWordTb.Text = "";
            RoomNumCb.SelectedIndex = -1;
            Key = 0;
        }
        private void GetRoomNum()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select RoomId from RoomTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            RoomNumCb.ValueMember = "RoomId";
            RoomNumCb.DataSource = dt;
            Con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocPhoneTb.Text == "" || DocSpecCb.SelectedIndex == -1 || DocPassWordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand checkRoomCmd = new SqlCommand("Select * from DoctorTbl where RoomId=@DR", Con);
                    checkRoomCmd.Parameters.AddWithValue("@DR", RoomNumCb.SelectedValue);
                    SqlDataReader reader = checkRoomCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("This room is already assigned to another doctor.");
                        Con.Close();
                        return;
                    }

                    reader.Close();

                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName, DocAdd, DocGen, DocPhone, DocDOB, DocSpec, DocExp, DocPass, RoomId)values(@DN, @DA, @DG, @DP, @DD, @DS, @DE, @DPA, @DR)", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                    cmd.Parameters.AddWithValue("@DR", RoomNumCb.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Added");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocPhoneTb.Text == "" || DocSpecCb.SelectedIndex == -1 || DocPassWordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand checkRoomCmd = new SqlCommand("Select * from DoctorTbl where RoomId=@DR AND DocId <> @DKey", Con);
                    checkRoomCmd.Parameters.AddWithValue("@DR", RoomNumCb.SelectedValue);
                    checkRoomCmd.Parameters.AddWithValue("@DKey", Key);
                    SqlDataReader reader = checkRoomCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("This room is already assigned to another doctor.");
                        Con.Close();
                        return;
                    }

                    reader.Close();

                    SqlCommand cmd = new SqlCommand("update DoctorTbl set DocName=@DN, DocAdd=@DA, DocGen=@DG, DocPhone=@DP, DocDOB=@DD, DocSpec=@DS, DocExp=@DE, DocPass=@DPA, RoomId=@DR where DocId=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                    cmd.Parameters.AddWithValue("@DR", RoomNumCb.SelectedValue);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated");
                    Con.Close();
                    DisplayDoc();
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
                MessageBox.Show("Select the Doctor");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DoctorTbl where DocId= @DKey", Con);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DoctorDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in DoctorDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void DoctorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = DoctorDGV.Rows[e.RowIndex]; // Get the selected row

                // Populate text fields with data from the row
                DNameTb.Text = row.Cells["DocName"].Value?.ToString() ?? "";
                DocAddTb.Text = row.Cells["DocAdd"].Value?.ToString() ?? "";
                DocGenCb.SelectedItem = row.Cells["DocGen"].Value?.ToString() ?? "";
                DocPhoneTb.Text = row.Cells["DocPhone"].Value?.ToString() ?? "";
                RoomNumCb.SelectedValue = row.Cells["RoomId"].Value;

                // Use the DateTimePicker's Value property to set its value
                if (DateTime.TryParse(row.Cells["DocDOB"].Value?.ToString(), out DateTime result))
                {
                    DocDOB.Value = result;
                }

                DocSpecCb.SelectedItem = row.Cells["DocSpec"].Value?.ToString() ?? "";
                DocExpTb.Text = row.Cells["DocExp"].Value?.ToString() ?? "";
                DocPassWordTb.Text = row.Cells["DocPass"].Value?.ToString() ?? "";

                // Update the Key variable, which seems to be used for editing and deleting records
                if (string.IsNullOrEmpty(DNameTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["DocId"].Value?.ToString() ?? "0");
                }

            }
        }

        private void RoomNumCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
