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

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

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

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
