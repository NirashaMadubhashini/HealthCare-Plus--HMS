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

namespace HealthCare_Plus__HMS.Admin
{
    public partial class BillingandInvoicing : Form
    {
        public BillingandInvoicing()
        {
            InitializeComponent();
            DisplaySearchPrescription();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplaySearchPrescription()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
           billDGV.DataSource = ds.Tables[0];
            billDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
          /*  try
            {
                Con.Open();
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM PrescriptionTbl WHERE ");

                if (!string.IsNullOrWhiteSpace(PatNameSearchTb.Text))
                {
                    queryBuilder.Append("PatName LIKE @PatName");
                }

                if (!string.IsNullOrWhiteSpace(DocNameSearchTb.Text))
                {
                    if (!string.IsNullOrWhiteSpace(PatNameSearchTb.Text))
                    {
                        queryBuilder.Append(" AND ");
                    }
                    queryBuilder.Append("DocName LIKE @DocName");
                }

                if (string.IsNullOrWhiteSpace(PatNameSearchTb.Text) && string.IsNullOrWhiteSpace(DocNameSearchTb.Text))
                {
                    queryBuilder.Length -= 7; // Removes the last " WHERE "
                }

                string query = queryBuilder.ToString();

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);

                if (!string.IsNullOrWhiteSpace(PatNameSearchTb.Text))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@PatName", "%" + PatNameSearchTb.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(DocNameSearchTb.Text))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@DocName", "%" + DocNameSearchTb.Text + "%");
                }

                DataSet ds = new DataSet();
                sda.Fill(ds);

                // Check if any rows were returned, if not show a notification message
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No matches found for the entered patient or doctor name.");
                }

                PrescriptionLoadDGV.DataSource = ds.Tables[0];
                PrescriptionLoadDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            DisplaySearchPrescription();
        }

        private void DocNameSearchTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatNameSearchTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}