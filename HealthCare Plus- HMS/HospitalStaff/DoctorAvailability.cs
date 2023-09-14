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
