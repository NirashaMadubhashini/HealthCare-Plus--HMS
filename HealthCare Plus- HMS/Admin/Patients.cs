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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplaySearchPat();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplaySearchPat()
        {
           /* Con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            patientsLoadDGV.DataSource = ds.Tables[0];
            patientsLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();*/
        }

        private void PatNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           /* try
            {
                Con.Open();
                string query = "SELECT * FROM PatientTbl WHERE PatName LIKE @PatName";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.SelectCommand.Parameters.AddWithValue("@PatName", "%" + serachByNameTb.Text + "%");
                DataSet ds = new DataSet();
                sda.Fill(ds);
                patientsLoadDGV.DataSource = ds.Tables[0];
                patientsLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }*/
        }


        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DisplaySearchPat();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
