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

namespace HealthCare_Plus__HMS.Admin
{
    public partial class MedicalResources : Form
    {
        public MedicalResources()
        {
            InitializeComponent();
            DisplayTest();
            medResourcesDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(LabTestDGV_DataBindingComplete);

            // Improve DataGridView initial settings
            medResourcesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medResourcesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            medResourcesDGV.MultiSelect = false;
            medResourcesDGV.ReadOnly = true;

            resourceNameTb.KeyDown += resourceNameTb_KeyDown;
            resourceDescriptionTb.KeyDown += resourceDescriptionTb_KeyDown;
            resourceQuantityTb.KeyDown += resourceQuantityTb_KeyDown;

        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");
        int Key = 0;

        private void resourceNameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                resourceDescriptionTb.Focus();
                e.SuppressKeyPress = true; // to prevent the beep sound on pressing enter
                e.Handled = true;
            }
        }

        private void resourceDescriptionTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                resourceQuantityTb.Focus();
                e.SuppressKeyPress = true;  // to prevent the beep sound on pressing enter
                e.Handled = true;
            }
        }

        private void resourceQuantityTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBtn.PerformClick(); // or any other button you want to be triggered
                e.SuppressKeyPress = true;  // to prevent the beep sound on pressing enter
                e.Handled = true;
            }
        }

        private bool IsValidResourceName(string name)
        {
            // Check if name contains only alphabetical characters
            return System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]+$");
        }

        private bool IsValidResourceQuantity(string quantity)
        {
            // Check if quantity contains only numbers
            return System.Text.RegularExpressions.Regex.IsMatch(quantity, "^[0-9]+$");
        }

        private void DisplayTest()
        {
            Con.Open();
            string Query = "Select * from MedicalResourceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            medResourcesDGV.AutoResizeColumns();  // Resize columns to fit content
            medResourcesDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            medResourcesDGV.DataSource = ds.Tables[0];
            medResourcesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medResourcesDGV.Columns["resourceName"].HeaderText = "Name";
            medResourcesDGV.Columns["resourceDescription"].HeaderText = "Description";
            medResourcesDGV.Columns["resourceQuantityAvailable"].HeaderText = "Quantity Available";
            medResourcesDGV.Columns["resource_id"].HeaderText = "Resource ID";
            Con.Close();
        }

        private void Clear()
        {
            resourceNameTb.Text = "";
            resourceDescriptionTb.Text = "";
            resourceQuantityTb.Text = "";
            Key = 0;
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (!IsValidResourceName(resourceNameTb.Text))
            {
                MessageBox.Show("Resource Name must contain only alphabetical characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidResourceQuantity(resourceQuantityTb.Text))
            {
                MessageBox.Show("Resource Quantity must contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(resourceNameTb.Text) ||
         string.IsNullOrWhiteSpace(resourceDescriptionTb.Text) ||
         string.IsNullOrWhiteSpace(resourceQuantityTb.Text))
            {
                MessageBox.Show("Please complete all fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into MedicalResourceTbl(resourceName,resourceDescription,resourceQuantityAvailable)values(@RN,@RD,@RQ)", Con);
                    cmd.Parameters.AddWithValue("@RN", resourceNameTb.Text);
                    cmd.Parameters.AddWithValue("@RD", resourceDescriptionTb.Text);
                    cmd.Parameters.AddWithValue("@RQ", resourceQuantityTb.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Resource successfully added to the database.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error while adding the resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (!IsValidResourceName(resourceNameTb.Text))
            {
                MessageBox.Show("Resource Name must contain only alphabetical characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidResourceQuantity(resourceQuantityTb.Text))
            {
                MessageBox.Show("Resource Quantity must contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (resourceNameTb.Text == "" || resourceDescriptionTb.Text == "" || resourceQuantityTb.Text == "")
            {
                MessageBox.Show("Please complete all fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update MedicalResourceTbl  set resourceName=@RN,  resourceDescription=@RD,  resourceQuantityAvailable=@RQ  where  resource_id=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", resourceNameTb.Text);
                    cmd.Parameters.AddWithValue("@RD", resourceDescriptionTb.Text);
                    cmd.Parameters.AddWithValue("@RQ", resourceQuantityTb.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resource successfully updated.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error while updating the resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Resource");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from MedicalResourceTbl where resource_id = @RKey", Con); // Fixed typo and added '='
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resource successfully deleted.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error while deleting the resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LabTestDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in medResourcesDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void LabTestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if row index is valid
            {
                DataGridViewRow row = medResourcesDGV.Rows[e.RowIndex];

                resourceNameTb.Text = row.Cells["resourceName"].Value?.ToString() ?? ""; // Using column name for clarity
                resourceDescriptionTb.Text = row.Cells["resourceDescription"].Value?.ToString() ?? "";
                resourceQuantityTb.Text = row.Cells["resourceQuantityAvailable"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(resourceNameTb.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["resource_id"].Value?.ToString() ?? "0");  // Use StaffId or appropriate unique key field
                }
            }
        }

        private void resourceNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MedicalResources_Load(object sender, EventArgs e)
        {

        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM MedicalResourceTbl WHERE resourceName LIKE @search";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@search", "%" + searchTb.Text + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            medResourcesDGV.DataSource = dt;
            Con.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
