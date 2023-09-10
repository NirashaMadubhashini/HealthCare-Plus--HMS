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
            patientsDGV.DataSource = ds.Tables[0];
            patientsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void Clear()
        {
            patNameTb.Text = "";
            patAddTb.Text = "";
            patGenCb.SelectedIndex = 0;
            patPhoneTb.Text = "";
            patDOB.Text = "";
            patHIVCb.SelectedIndex = 0;
            patAlTb.Text = "";
            Key = 0;
        }
        private void PatNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (patNameTb.Text == "" || patAddTb.Text == "" || patGenCb.SelectedIndex == -1 || patPhoneTb.Text == "" || patHIVCb.SelectedIndex == -1 || patAlTb.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName,PatAdd,PatGen,PatPhone,PatDOB,PatHIV,PatAll)values(@PN,@PA,@PG,@PP,@PD,@PH,@PAL)", Con);
                    cmd.Parameters.AddWithValue("@PN", patNameTb.Text);
                    cmd.Parameters.AddWithValue("@PA", patAddTb.Text);
                    cmd.Parameters.AddWithValue("@PG", patGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", patPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PD", patDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PH", patHIVCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", patAlTb.Text);
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
            if (patNameTb.Text == "" || patAddTb.Text == "" || patGenCb.SelectedIndex == -1 || patPhoneTb.Text == "" || patHIVCb.SelectedIndex == -1 || patAlTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTbl set PatName=@PN, PatAdd=@PA, PatGen=@PG, PatPhone=@PP, PatDOB=@PD, PatHIV=@PH, PatAll=@PAL where PatId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", patNameTb.Text);
                    cmd.Parameters.AddWithValue("@PA", patAddTb.Text);
                    cmd.Parameters.AddWithValue("@PG", patGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", patPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PD", patDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PH", patHIVCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", patAlTb.Text);
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
                DataGridViewRow row = patientsDGV.Rows[e.RowIndex];

                patNameTb.Text = row.Cells["PatName"].Value?.ToString() ?? "";
                patAddTb.Text = row.Cells["PatAdd"].Value?.ToString() ?? "";
                patGenCb.SelectedItem = row.Cells["PatGen"].Value?.ToString() ?? "";
                patPhoneTb.Text = row.Cells["PatPhone"].Value?.ToString() ?? "";
                // Use the DateTimePicker's Value property to set its value
                if (DateTime.TryParse(row.Cells["PatDOB"].Value?.ToString(), out DateTime result))
                {
                    patDOB.Value = result;
                }
                patHIVCb.SelectedItem = row.Cells["PatHIV"].Value?.ToString() ?? "";
                patAlTb.Text = row.Cells["PatAll"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(patNameTb.Text))
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
