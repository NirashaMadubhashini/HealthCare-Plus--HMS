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
    public partial class AddPrescription : Form
    {
        public AddPrescription()
        {
            InitializeComponent();
            DisplayPrescription();
            GetDocId();
            GetDocName();
            GetPatId();
            GetPatName();
            GetTestId();
            GetTest();
            ClearAllFields();  // Clears all fields
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        int Key = 0;
        private void ClearAllFields()
        {
            // Clearing all textboxes
            docNameTb.Text = "";
            patNameTb.Text = "";
            testNameTb.Text = "";
            costTb.Text = "";
            medTb.Text = "";
            prescSumTxt.Text = "";

            // Clearing all combo boxes
            docIdCb.SelectedIndex = -1;
            patIdCb.SelectedIndex = -1;
            testIdCb.SelectedIndex = -1;
        }

        private void DisplayPrescription()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prescriptionDGV.DataSource = ds.Tables[0];
            prescriptionDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }
        private void Clear()
        {
            docIdCb.SelectedIndex = -1; // No selection
            docNameTb.Text = "";
            patIdCb.SelectedIndex = -1; // No selection
            patNameTb.Text = "";
            testIdCb.SelectedIndex = -1; // No selection
            testNameTb.Text = "";
            costTb.Text = "";
            medTb.Text = "";
            //Key = 0;
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
            docIdCb.ValueMember = "DocId";
            docIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetDocName()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl where DocId = " + docIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                docNameTb.Text = dr["DocName"].ToString();
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
            patIdCb.ValueMember = "PatId";
            patIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetPatName()
        {
            Con.Open();
            string Query = "Select * from PatientTbl where PatId = " + patIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patNameTb.Text = dr["PatName"].ToString();
            }
            Con.Close();
        }

        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            testIdCb.ValueMember = "TestNum";
            testIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetTest()
        {
            Con.Open();
            string Query = "Select * from TestTbl where TestNum = " + testIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                testNameTb.Text = dr["TestName"].ToString();
                costTb.Text = dr["TestCost"].ToString();

            }
            Con.Close();
        }


        private void PrescSumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PatIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void TestIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTest();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Century Gothic", 18, FontStyle.Regular);
            SizeF stringSize = e.Graphics.MeasureString(prescSumTxt.Text, font);

            // Centering text by calculating starting point
            float startPointX = (e.PageBounds.Width - stringSize.Width) / 2;
            float startPointY = (e.PageBounds.Height - stringSize.Height) / 2;

            // Drawing the text
            e.Graphics.DrawString(prescSumTxt.Text, font, Brushes.Black, new PointF(startPointX, startPointY));

            // Drawing "Thanks" centered
            string thanksString = "\n\t" + "Thanks";
            SizeF thanksStringSize = e.Graphics.MeasureString(thanksString, font);
            float thanksPointX = (e.PageBounds.Width - thanksStringSize.Width) / 2;
            float thanksPointY = startPointY + stringSize.Height + 20; // 20 pixels below the last text
            e.Graphics.DrawString(thanksString, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new PointF(thanksPointX, thanksPointY));

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (docNameTb.Text == "" || patNameTb.Text == "" || testNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId,DocName,PatId,PatName,LabTestId,LabTestName,Medicines,Cost)values(@DI,@DN,@PI,@PN,@TI,@TN,@MED,@CO)", Con);
                    cmd.Parameters.AddWithValue("@DI", docIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", docNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", patIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", patNameTb.Text);
                    cmd.Parameters.AddWithValue("@TI", testIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", testNameTb.Text);
                    cmd.Parameters.AddWithValue("@MED", medTb.Text);
                    cmd.Parameters.AddWithValue("@CO", costTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Added");
                    Con.Close();
                    DisplayPrescription();
                    Clear();  // Clear the fields here
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.prescriptionDGV.Rows[e.RowIndex];

                // Create a StringBuilder to hold the text
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("                                   Health Care Plus");
                sb.AppendLine("                                     PRESCRIPTION");
                sb.AppendLine("***************************************************************");
                sb.AppendFormat("Date: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendFormat("Doctor: {0}", row.Cells["DocName"].Value.ToString());
                sb.AppendLine();
                sb.AppendFormat("Patient: {0}", row.Cells["PatName"].Value.ToString());
                sb.AppendLine();
                sb.AppendLine("------------------------------");
                sb.AppendFormat("Test: {0}", row.Cells["LabTestName"].Value.ToString());
                sb.AppendLine();
                sb.AppendFormat("Medicines: {0}", row.Cells["Medicines"].Value.ToString());
                sb.AppendLine();
                sb.AppendLine("------------------------------");
                sb.AppendFormat("Cost: {0}", row.Cells["Cost"].Value.ToString());
                sb.AppendLine();
                sb.AppendLine("***************************************************************");

                // Assign text to PrescSumTxt
                prescSumTxt.Text = sb.ToString();
            }
        }

        private void docIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {

        }
    }
}
