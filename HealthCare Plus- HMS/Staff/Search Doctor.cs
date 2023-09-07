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

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplaySearchDoc()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorLoadDGV.DataSource = ds.Tables[0];
            DoctorLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string docName = SerachByNameTb.Text; // Get the text from the SearchByName text box
            string docSpec = SerachBySpecTb.Text; // Get the text from the SearchBySpec text box
            DateTime? docDOB = DocAvailableDate.Checked ? DocAvailableDate.Value.Date : (DateTime?)null; // Get the selected date from the DateTimePicker

            if (string.IsNullOrWhiteSpace(docName) && string.IsNullOrWhiteSpace(docSpec) && docDOB == null)
            {
                MessageBox.Show("Please enter a name, specialization, or date to search.", "Input Error");
                return;
            }

            Con.Open();  // Open the connection

            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM DoctorTbl");

            List<string> conditions = new List<string>();
            SqlCommand cmd = new SqlCommand();

            if (!string.IsNullOrWhiteSpace(docName))
            {
                conditions.Add("DocName LIKE @DocName");
                cmd.Parameters.AddWithValue("@DocName", "%" + docName + "%");
            }

            if (!string.IsNullOrWhiteSpace(docSpec))
            {
                conditions.Add("DocSpec LIKE @DocSpec");
                cmd.Parameters.AddWithValue("@DocSpec", "%" + docSpec + "%");
            }

            if (docDOB != null)
            {
                conditions.Add("CAST(DocDOB AS DATE) = @DocDOB");
                cmd.Parameters.AddWithValue("@DocDOB", docDOB.Value);
            }

            if (conditions.Any())
            {
                queryBuilder.Append(" WHERE ");
                queryBuilder.Append(string.Join(" AND ", conditions));
            }

            string query = queryBuilder.ToString();
            cmd.CommandText = query;
            cmd.Connection = Con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No doctor found with the given criteria.", "No Results");
            }
            else
            {
                DoctorLoadDGV.DataSource = dt;
                DoctorLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            Con.Close();

            SerachByNameTb.Text = string.Empty;
            SerachBySpecTb.Text = string.Empty;
            DocAvailableDate.Value = DateTime.Now;
            DocAvailableDate.Checked = false;
        }




        private void DoctorLoadDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SerachByNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerachBySpecTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocAvailableDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DisplaySearchDoc();
        }
    }
}
