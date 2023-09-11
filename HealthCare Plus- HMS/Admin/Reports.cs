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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            LoadReportTypes();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void LoadReportTypes()
        {
            // Add the different types of reports the user can generate
            payRollCb.Items.Add("Appointments");
            payRollCb.Items.Add("Patients");
            payRollCb.Items.Add("Doctors");
            // ... (add other report types as needed)
        }
        private void reportTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void payRollCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReportType = payRollCb.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedReportType)) return;

            try
            {
                Con.Open();

                SqlCommand cmd;
                switch (selectedReportType)
                {
                    case "Appointments":
                        cmd = new SqlCommand("SELECT * FROM AppointmentTbl", Con);
                        break;
                    case "Patients":
                        cmd = new SqlCommand("SELECT * FROM PatientTbl", Con);
                        break;
                    case "Doctors":
                        cmd = new SqlCommand("SELECT D.doctor_id, U.userName, D.doctorSpecialization, D.roomNumber FROM DoctorTbl D JOIN UserTbl U ON D.doctor_id = U.user_id WHERE U.userRole = 'Doctor'", Con);
                        break;
                    // ... (add other cases as needed)
                    default:
                        throw new Exception("Unknown report type");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                reportDGV.DataSource = dt;
                foreach (DataGridViewColumn column in reportDGV.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
