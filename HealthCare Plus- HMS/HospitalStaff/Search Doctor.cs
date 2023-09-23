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

namespace HealthCare_Plus__HMS.Staff
{
    public partial class Search_Doctor : Form
    {
        public Search_Doctor()
        {
            InitializeComponent();
            DisplaySearchDoc();

            DoctorLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DoctorLoadDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DoctorLoadDGV.MultiSelect = false;
            DoctorLoadDGV.ReadOnly = true;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void DisplaySearchDoc()
        {
            try
            {
                Con.Open();
                string query = "Select D.doctor_id, doctorSpecialization, userName, weekDays, availabilityStartTime, availabilityEndTime " +
                               "from DoctorTbl D " +
                               "inner join UserTbl U on D.doctor_id = U.user_id " +
                               "inner join DoctorAvailabileTbl DA on D.doctor_id = DA.doctor_id";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                var ds = new DataSet();
                sda.Fill(ds);

                DoctorLoadDGV.AutoResizeColumns();  // Resize columns to fit content
                DoctorLoadDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                DoctorLoadDGV.DataSource = null; // Clear the DataSource
                DoctorLoadDGV.DataSource = ds.Tables[0]; // Set the new DataSource
                DoctorLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // Set each column to a fixed portion of the total width
                int totalWidth = DoctorLoadDGV.Width;
                DoctorLoadDGV.Columns[0].Width = totalWidth * 10 / 100; // 10% of the total width
                DoctorLoadDGV.Columns[1].Width = totalWidth * 20 / 100; // 20% of the total width
                DoctorLoadDGV.Columns[2].Width = totalWidth * 20 / 100; // 20% of the total width
                DoctorLoadDGV.Columns[3].Width = totalWidth * 15 / 100; // 15% of the total width
                DoctorLoadDGV.Columns[4].Width = totalWidth * 15 / 100; // 15% of the total width
                DoctorLoadDGV.Columns[5].Width = totalWidth * 20 / 100; // 20% of the total width
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
        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "SELECT D.doctor_id, doctorSpecialization, userName, weekDays, availabilityStartTime, availabilityEndTime " +
                    "FROM DoctorTbl D " +
                    "INNER JOIN UserTbl U ON D.doctor_id = U.user_id " +
                    "INNER JOIN DoctorAvailabileTbl DA ON D.doctor_id = DA.doctor_id " +
                    "WHERE (userName LIKE @nameParam OR doctorSpecialization LIKE @specializationParam OR weekDays LIKE @weekDaysParam " +
                    "OR FORMAT(availabilityStartTime, 'hh:mm tt') LIKE @timeParam OR FORMAT(availabilityEndTime, 'hh:mm tt') LIKE @timeParam)";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@nameParam", "%" + searchTb.Text + "%");
                cmd.Parameters.AddWithValue("@specializationParam", "%" + searchTb.Text + "%");
                cmd.Parameters.AddWithValue("@weekDaysParam", "%" + searchTb.Text + "%");
                cmd.Parameters.AddWithValue("@timeParam", "%" + searchTb.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                sda.Fill(ds);
                DoctorLoadDGV.DataSource = null; // Clear the DataSource
                DoctorLoadDGV.DataSource = ds.Tables[0]; // Set the new DataSource

                SetColumnWidths(); // Call a new method to set the column widths
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

        private void SetColumnWidths()
        {
            int totalWidth = DoctorLoadDGV.Width;
            DoctorLoadDGV.Columns[0].Width = totalWidth * 10 / 100; // 10% of the total width
            DoctorLoadDGV.Columns[1].Width = totalWidth * 20 / 100; // 20% of the total width
            DoctorLoadDGV.Columns[2].Width = totalWidth * 20 / 100; // 20% of the total width
            DoctorLoadDGV.Columns[3].Width = totalWidth * 15 / 100; // 15% of the total width
            DoctorLoadDGV.Columns[4].Width = totalWidth * 15 / 100; // 15% of the total width
            DoctorLoadDGV.Columns[5].Width = totalWidth * 20 / 100; // 20% of the total width
        }

        private void DoctorLoadDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DocAvailableDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            searchTb.Text = string.Empty; // Clear the text in searchTb
            DisplaySearchDoc();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            searchBtn_Click_1(sender, e);
        }
    }
}
