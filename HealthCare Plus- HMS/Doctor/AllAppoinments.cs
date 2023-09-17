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

namespace HealthCare_Plus__HMS.Doctor
{
    public partial class AllAppoinments : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        public AllAppoinments()
        {
            InitializeComponent();
        }

        private void LoadAppointments()
        {
            try
            {
                // Open the connection
                Con.Open();

                // Create a command to select all appointments
                SqlCommand cmd = new SqlCommand("SELECT * FROM AppointmentTbl", Con);

                // Create a data adapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Create a new DataTable
                DataTable dt = new DataTable();

                // Fill the DataTable with the result set
                adapter.Fill(dt);

                // Set the DataGridView's data source to the DataTable
                appoinmentsDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Display any errors that occur in a message box
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the connection
                Con.Close();
            }
        }

        private void AllAppointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void appoinmentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
