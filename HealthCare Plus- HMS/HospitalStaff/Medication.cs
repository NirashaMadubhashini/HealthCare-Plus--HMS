﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace HealthCare_Plus__HMS.HospitalStaff
{
    public partial class Medication : Form
    {
        public Medication()
        {
            InitializeComponent();
            DisplayMed();
            medicationDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(medicationDGV_DataBindingComplete);

            medicationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medicationDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            medicationDGV.MultiSelect = false;
            medicationDGV.ReadOnly = true;

            medNameTb.KeyDown += MedNameTb_KeyDown;
            medDescriptionTb.KeyDown += MedDescriptionTb_KeyDown;
            medDosageTb.KeyDown += MedDosageTb_KeyDown;
            medSideEffectsTb.KeyDown += MedSideEffectsTb_KeyDown;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        int Key = 0;

        private void MedNameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                medDescriptionTb.Focus();
                e.SuppressKeyPress = true;  // To prevent the beep sound
                e.Handled = true;
            }
        }

        private void MedDescriptionTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                medDosageTb.Focus();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void MedDosageTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                medSideEffectsTb.Focus();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void MedSideEffectsTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                medStockQuantityTb.Focus();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private bool IsValidInputs()
        {
            // Validate medicationName for A-z letters only
            if (!Regex.IsMatch(medNameTb.Text, "^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Medication Name should contain only letters.");
                return false;
            }

            // Validate medicationStockQuantity for 0-9 numbers only
            if (!Regex.IsMatch(medStockQuantityTb.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Medication Stock Quantity should contain only numbers.");
                return false;
            }

            return true;
        }

        private void DisplayMed()
        {
            Con.Open();
            string Query = "Select * from MedicationTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            medicationDGV.DataSource = ds.Tables[0];
            medicationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            medicationDGV.AutoResizeColumns();  // Resize columns to fit content
            medicationDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            Con.Close();
        }

        private void Clear()
        {
            medNameTb.Text = "";
            medDescriptionTb.Text = "";
            medDosageTb.Text = "";
            medSideEffectsTb.Text = "";
            medStockQuantityTb.Text = "";
            Key = 0;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidInputs())
                return;

            if (medNameTb.Text == "" || medDescriptionTb.Text == "" || medDosageTb.Text == "" || medSideEffectsTb.Text == "" || medStockQuantityTb.Text == "")

            {
                MessageBox.Show("Missing Essential Information. Please fill in all the fields."); // Error message for missing information
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into MedicationTbl(medicationName,medicationDescription,medicationDosage,medicationSideEffects ,medicationStockQuantity)values(@MN,@MDES,@MDOS,@MSE,@MQ)", Con);
                    cmd.Parameters.AddWithValue("@MN", medNameTb.Text);
                    cmd.Parameters.AddWithValue("@MDES", medDescriptionTb.Text);
                    cmd.Parameters.AddWithValue("@MDOS", medDosageTb.Text);
                    cmd.Parameters.AddWithValue("@MSE", medSideEffectsTb.Text);
                    cmd.Parameters.AddWithValue("@MQ", medStockQuantityTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medication Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayMed();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An Error Occurred: " + Ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidInputs())
                return;

            if (medNameTb.Text == "" || medDescriptionTb.Text == "" || medDosageTb.Text == "" || medSideEffectsTb.Text == "" || medStockQuantityTb.Text == "")
            {
                MessageBox.Show("Missing Essential Information. Please fill in all the fields."); // Error message for missing information
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update MedicationTbl  set medicationName=@MN,medicationDescription=@MDES,medicationDosage=@MDOS,medicationSideEffects=@MSE,medicationStockQuantity=@MQ  where medication_id=@MKey", Con);
                    cmd.Parameters.AddWithValue("@MN", medNameTb.Text);
                    cmd.Parameters.AddWithValue("@MDES", medDescriptionTb.Text);
                    cmd.Parameters.AddWithValue("@MDOS", medDosageTb.Text);
                    cmd.Parameters.AddWithValue("@MSE", medSideEffectsTb.Text);
                    cmd.Parameters.AddWithValue("@MQ", medStockQuantityTb.Text);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medication Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayMed();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An Error Occurred: " + Ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("No Medication Selected. Please select a Medication to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from MedicationTbl  where medication_id= @MKey", Con);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medication Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayMed();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void medicationDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in medicationDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void medicationDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = medicationDGV.Rows[e.RowIndex];

                medNameTb.Text = row.Cells["medicationName"].Value?.ToString() ?? "";
                medDescriptionTb.Text = row.Cells["medicationDescription"].Value?.ToString() ?? "";
                medDosageTb.Text = row.Cells["medicationDosage"].Value?.ToString() ?? "";
                medSideEffectsTb.Text = row.Cells["medicationSideEffects"].Value?.ToString() ?? "";
                medStockQuantityTb.Text = row.Cells["medicationStockQuantity"].Value?.ToString() ?? "";
                // Use the DateTimePicker's Value property to set its value
            
                if (string.IsNullOrEmpty(medNameTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["medication_id"].Value?.ToString() ?? "0");
                }
            }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM MedicationTbl WHERE medicationName LIKE @search";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@search", "%" + searchTb.Text + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            medicationDGV.DataSource = dt;
            Con.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
