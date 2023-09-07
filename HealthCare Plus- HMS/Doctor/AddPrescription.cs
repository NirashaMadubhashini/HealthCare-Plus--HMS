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
            DocNameTb.Text = "";
            PatNameTb.Text = "";
            TestNameTb.Text = "";
            CostTb.Text = "";
            MedTb.Text = "";
            PrescSumTxt.Text = "";

            // Clearing all combo boxes
            DocIdCb.SelectedIndex = -1;
            PatIdCb.SelectedIndex = -1;
            TestIdCb.SelectedIndex = -1;
        }

        private void DisplayPrescription()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescriptionDGV.DataSource = ds.Tables[0];
            PrescriptionDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }
        private void Clear()
        {
            DocIdCb.SelectedIndex = -1; // No selection
            DocNameTb.Text = "";
            PatIdCb.SelectedIndex = -1; // No selection
            PatNameTb.Text = "";
            TestIdCb.SelectedIndex = -1; // No selection
            TestNameTb.Text = "";
            CostTb.Text = "";
            MedTb.Text = "";
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

        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            TestIdCb.ValueMember = "TestNum";
            TestIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetTest()
        {
            Con.Open();
            string Query = "Select * from TestTbl where TestNum = " + TestIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TestNameTb.Text = dr["TestName"].ToString();
                CostTb.Text = dr["TestCost"].ToString();

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
            SizeF stringSize = e.Graphics.MeasureString(PrescSumTxt.Text, font);

            // Centering text by calculating starting point
            float startPointX = (e.PageBounds.Width - stringSize.Width) / 2;
            float startPointY = (e.PageBounds.Height - stringSize.Height) / 2;

            // Drawing the text
            e.Graphics.DrawString(PrescSumTxt.Text, font, Brushes.Black, new PointF(startPointX, startPointY));

            // Drawing "Thanks" centered
            string thanksString = "\n\t" + "Thanks";
            SizeF thanksStringSize = e.Graphics.MeasureString(thanksString, font);
            float thanksPointX = (e.PageBounds.Width - thanksStringSize.Width) / 2;
            float thanksPointY = startPointY + stringSize.Height + 20; // 20 pixels below the last text
            e.Graphics.DrawString(thanksString, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new PointF(thanksPointX, thanksPointY));

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PatNameTb.Text == "" || TestNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId,DocName,PatId,PatName,LabTestId,LabTestName,Medicines,Cost)values(@DI,@DN,@PI,@PN,@TI,@TN,@MED,@CO)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", PatIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@TI", TestIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", TestNameTb.Text);
                    cmd.Parameters.AddWithValue("@MED", MedTb.Text);
                    cmd.Parameters.AddWithValue("@CO", CostTb.Text);
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
                DataGridViewRow row = this.PrescriptionDGV.Rows[e.RowIndex];

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
                PrescSumTxt.Text = sb.ToString();
            }
        }
    }
}
