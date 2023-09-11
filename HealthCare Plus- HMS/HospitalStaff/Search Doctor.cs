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
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void DisplaySearchDoc()
        {
            try
            {
                Con.Open();
                string query = "Select doctor_id, doctorSpecialization, userName from DoctorTbl inner join UserTbl on DoctorTbl.doctor_id = UserTbl.user_id";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                var ds = new DataSet();
                sda.Fill(ds);
                DoctorLoadDGV.DataSource = null; // Clear the DataSource
                DoctorLoadDGV.DataSource = ds.Tables[0]; // Set the new DataSource
                DoctorLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                // Debugging: Display the text from searchTb to ensure it contains the correct value
                Console.WriteLine($"Search text: {searchTb.Text}");

                string query = "SELECT doctor_id, doctorSpecialization, userName " +
                               "FROM DoctorTbl " +
                               "INNER JOIN UserTbl ON DoctorTbl.doctor_id = UserTbl.user_id " +
                               "WHERE userName LIKE @nameParam OR doctorSpecialization LIKE @specializationParam";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@nameParam", "%" + searchTb.Text + "%");
                cmd.Parameters.AddWithValue("@specializationParam", "%" + searchTb.Text + "%");

                // Debugging: Display the SQL command to be executed
                Console.WriteLine($"SQL Command: {cmd.CommandText}");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                sda.Fill(ds);
                DoctorLoadDGV.DataSource = null; // Clear the DataSource
                DoctorLoadDGV.DataSource = ds.Tables[0]; // Set the new DataSource
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
