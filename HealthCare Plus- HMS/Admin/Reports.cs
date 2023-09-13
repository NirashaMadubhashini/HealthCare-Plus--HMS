using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace HealthCare_Plus__HMS.Admin
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            LoadReportTypes();
            reportDGV.CellClick += new DataGridViewCellEventHandler(reportDGV_CellContentClick);
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
                if (e.RowIndex >= 0) // Ensure a valid row has been clicked
                {
                    DataGridViewRow row = reportDGV.Rows[e.RowIndex];

                    // Access individual cell values like: row.Cells["ColumnName"].Value
                    // Create a report based on the selected row's data.

                    StringBuilder reportText = new StringBuilder();
                    reportText.AppendLine($"------- SINGLE RECORD REPORT -------");
                    reportText.AppendLine(DateTime.Now.ToString("f")); // Adding current date and time
                    reportText.AppendLine(new string('-', 50)); // Add a separator

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            // Format each line to have a fixed width for the column name and value
                            reportText.AppendLine($"{reportDGV.Columns[cell.ColumnIndex].Name,-20} : {cell.Value.ToString(),-20}");
                        }
                    }
                    reportText.AppendLine(new string('-', 50)); // Add a separator

                    reportTxt.Font = new Font("Courier New", 10); // Set a monospace font for aligned text
                    reportTxt.Text = reportText.ToString(); // Set the report text
                }
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

                // Generate styled report text with enhanced formatting
                StringBuilder reportText = new StringBuilder();
                reportText.AppendLine($"------- {selectedReportType.ToUpper()} REPORT -------");
                reportText.AppendLine(DateTime.Now.ToString("f")); // Adding current date and time
                reportText.AppendLine(new string('-', 50)); // Add a separator

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        // Format each line to have a fixed width for the column name and value
                        reportText.AppendLine($"{column.ColumnName,-20} : {row[column],-20}");
                    }
                    reportText.AppendLine(new string('-', 50)); // Add a separator between records
                }

                reportTxt.Font = new Font("Courier New", 10); // Set a monospace font for aligned text
                reportTxt.Text = reportText.ToString(); // 
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
            // Set the print document to use the custom print logic defined in the printDocument2_PrintPage event handler
            printDocument2.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
            // Start the printing process
            printDocument2.Print();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Courier New", 12); // Changed font to Courier New for better alignment
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            int count = 0;
            float yPos = e.MarginBounds.Top;
            string[] reportLines = reportTxt.Text.Split('\n');

            while (count < reportLines.Length && count < linesPerPage)
            {
                string line = reportLines[count];
                e.Graphics.DrawString(line, printFont, Brushes.Black, e.MarginBounds.Left, yPos, new StringFormat());
                count++;
                yPos += printFont.GetHeight(e.Graphics);
            }

            // Check to see if more pages are to be printed
            if (count < reportLines.Length)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
    }
}
