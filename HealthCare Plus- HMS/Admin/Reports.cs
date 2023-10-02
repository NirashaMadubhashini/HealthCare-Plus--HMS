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
using Microsoft.Reporting.WinForms;


namespace HealthCare_Plus__HMS.Admin
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            LoadReportTypes();
            reportDGV.CellClick += new DataGridViewCellEventHandler(reportDGV_CellContentClick);
            exportBtn.Click -= new EventHandler(exportBtn_Click); // Unregister the event handler
            exportBtn.Click += new EventHandler(exportBtn_Click); // Register the event handler
            reportDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(reportDGV_DataBindingComplete);

            reportDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportDGV.MultiSelect = false;
            reportDGV.ReadOnly = true;

        }



        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void LoadReportTypes()
        {
            payRollCb.Items.Add("Appointments");
            payRollCb.Items.Add("Patients");
            payRollCb.Items.Add("Doctors");
        }

        private void reportTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void reportDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in reportDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void reportDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = reportDGV.Rows[e.RowIndex];
                StringBuilder reportText = new StringBuilder();
                reportText.AppendLine($"------- SINGLE RECORD REPORT -------");
                reportText.AppendLine(DateTime.Now.ToString("f"));
                reportText.AppendLine(new string('-', 50));
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        reportText.AppendLine($"{reportDGV.Columns[cell.ColumnIndex].Name,-20} : {cell.Value.ToString(),-20}");
                    }
                }
                reportText.AppendLine(new string('-', 50));
                reportTxt.Font = new Font("Courier New", 10);
                reportTxt.Text = reportText.ToString();
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
                    default:
                        throw new Exception("Unknown report type");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                reportDGV.DataSource = dt;

                reportDGV.AutoResizeColumns();  // Resize columns to fit content
                reportDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                foreach (DataGridViewColumn column in reportDGV.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                StringBuilder reportText = new StringBuilder();
                reportText.AppendLine($"------- {selectedReportType.ToUpper()} REPORT -------");
                reportText.AppendLine(DateTime.Now.ToString("f"));
                reportText.AppendLine(new string('-', 50));

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        reportText.AppendLine($"{column.ColumnName,-20} : {row[column],-20}");
                    }
                    reportText.AppendLine(new string('-', 50));
                }

                reportTxt.Font = new Font("Courier New", 10);
                reportTxt.Text = reportText.ToString();
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
            printDocument2.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
            printDocument2.Print();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Courier New", 12);
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

            if (count < reportLines.Length)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {

     
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Report.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvContent = new StringBuilder();

                    // Adding column names
                    for (int i = 0; i < reportDGV.Columns.Count; i++)
                    {
                        csvContent.Append(reportDGV.Columns[i].Name);

                        if (i < reportDGV.Columns.Count - 1)
                        {
                            csvContent.Append(",");
                        }
                    }
                    csvContent.AppendLine();

                    // Adding row data
                    if (reportDGV.SelectedRows.Count == 1) // If a single row is selected, only export that row
                    {
                        DataGridViewRow row = reportDGV.SelectedRows[0];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            csvContent.Append(row.Cells[i].Value?.ToString() ?? "");

                            if (i < row.Cells.Count - 1)
                            {
                                csvContent.Append(",");
                            }
                        }
                        csvContent.AppendLine();
                    }
                    else // Otherwise, export all rows
                    {
                        foreach (DataGridViewRow row in reportDGV.Rows)
                        {
                            if (row.IsNewRow) // Skip the new row at the end used for insertion
                            {
                                continue;
                            }

                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                csvContent.Append(row.Cells[i].Value?.ToString() ?? "");

                                if (i < row.Cells.Count - 1)
                                {
                                    csvContent.Append(",");
                                }
                            }
                            csvContent.AppendLine();
                        }
                    }

                    // Writing data to CSV file
                    System.IO.File.WriteAllText(sfd.FileName, csvContent.ToString());
                    MessageBox.Show("Report exported successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
