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
            DisplayPat();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niras\OneDrive\Documents\HospitalDb.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;
        private void DisplayPat()
        {
            Con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            PatientsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void Clear()
        {
            PatNameTb.Text = "";
            PatAddTb.Text = "";
            PatGenCb.SelectedIndex = 0;
            PatPhoneTb.Text = "";
            PatDOB.Text = "";
            PatHIVCb.SelectedIndex = 0;
            PatAlTb.Text = "";
            Key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || PatAddTb.Text == "" || PatGenCb.SelectedIndex == -1 || PatPhoneTb.Text == "" || PatHIVCb.SelectedIndex == -1 || PatAlTb.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName,PatAdd,PatGen,PatPhone,PatDOB,PatHIV,PatAll)values(@PN,@PA,@PG,@PP,@PD,@PH,@PAL)", Con);
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PH", PatHIVCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", PatAlTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || PatAddTb.Text == "" || PatGenCb.SelectedIndex == -1 || PatPhoneTb.Text == "" || PatHIVCb.SelectedIndex == -1 || PatAlTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTbl set PatName=@PN, PatAdd=@PA, PatGen=@PG, PatPhone=@PP, PatDOB=@PD, PatHIV=@PH, PatAll=@PAL where PatId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PH", PatHIVCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", PatAlTb.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl where PatId= @PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = PatientsDGV.Rows[e.RowIndex];

                PatNameTb.Text = row.Cells["PatName"].Value?.ToString() ?? "";
                PatAddTb.Text = row.Cells["PatAdd"].Value?.ToString() ?? "";
                PatGenCb.SelectedItem = row.Cells["PatGen"].Value?.ToString() ?? "";
                PatPhoneTb.Text = row.Cells["PatPhone"].Value?.ToString() ?? "";
                // Use the DateTimePicker's Value property to set its value
                if (DateTime.TryParse(row.Cells["PatDOB"].Value?.ToString(), out DateTime result))
                {
                    PatDOB.Value = result;
                }
                PatHIVCb.SelectedItem = row.Cells["PatHIV"].Value?.ToString() ?? "";
                PatAlTb.Text = row.Cells["PatAll"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(PatNameTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["PatId"].Value?.ToString() ?? "0");
                }
            }
        }
    }
}
