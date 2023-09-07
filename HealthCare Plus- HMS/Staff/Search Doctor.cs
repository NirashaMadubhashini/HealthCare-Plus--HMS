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

            if (string.IsNullOrWhiteSpace(docName) && string.IsNullOrWhiteSpace(docSpec))
            {
                MessageBox.Show("Please enter a name or specialization to search.", "Input Error");
                return;
            }

            Con.Open();  // Open the connection

            // Prepare a query to search the doctor by name and/or specialization
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM DoctorTbl WHERE ");
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

            queryBuilder.Append(string.Join(" AND ", conditions));
            string query = queryBuilder.ToString();
            cmd.CommandText = query;
            cmd.Connection = Con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd); // Execute the query
            DataTable dt = new DataTable(); // Create a data table to hold the results
            sda.Fill(dt);  // Fill the data table

            if (dt.Rows.Count == 0)  // Check if no results were found
            {
                MessageBox.Show("No doctor found with the given criteria.", "No Results");
            }
            else
            {
                DoctorLoadDGV.DataSource = dt;  // Set the data grid view source to the data table
                DoctorLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Set the auto size mode
            }

            Con.Close();  // Close the connection

            // Clear the text fields and combo boxes
            SerachByNameTb.Text = string.Empty;
            SerachBySpecTb.Text = string.Empty;
            // ... (clear any other text fields or combo boxes you have)
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
