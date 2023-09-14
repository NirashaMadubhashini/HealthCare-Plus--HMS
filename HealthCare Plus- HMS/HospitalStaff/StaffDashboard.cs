using FontAwesome.Sharp;
using HealthCare_Plus__HMS.Admin;
using HealthCare_Plus__HMS.BillingStaff;
using HealthCare_Plus__HMS.Doctor;
using HealthCare_Plus__HMS.HospitalStaff;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthCare_Plus__HMS.Staff
{
    public partial class StaffDashboard : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Chart myChart;
        public StaffDashboard()
        {
            InitializeComponent();
            CountDoctors();
            CountAppoinments();
            CountPatients();
            CountMedications();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            if (Login.Role == "Admin")
            {

            }
        }
        private void UpdateDashboardStats()
        {
            CountDoctors();
            CountAppoinments();
            CountPatients();
            CountMedications();
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(6, 59, 130);
            public static Color color2 = Color.FromArgb(6, 59, 130);
            public static Color color3 = Color.FromArgb(6, 59, 130);
            public static Color color4 = Color.FromArgb(6, 59, 130);
            public static Color color5 = Color.FromArgb(6, 59, 130);
            public static Color color6 = Color.FromArgb(6, 59, 130);
            public static Color color7 = Color.FromArgb(6, 59, 130);
            public static Color color8 = Color.FromArgb(6, 59, 130);
        }

        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            docNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountAppoinments()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from AppointmentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            appoinmentNumlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }


        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            patientRecordsNumlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        } 
        
        private void CountMedications()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from MedicationTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            medNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        //Methods
        private void ActivateButton(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(158, 158, 158);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                /* iconCurrentChildForm.IconChar = currentBtn.IconChar;
                 iconCurrentChildForm.IconColor = color;*/
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(250, 250, 250);
                currentBtn.ForeColor = Color.FromArgb(7, 76, 119);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(7, 76, 119);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void InitializeDashboard()
        {
            // Close the current child form to display the dashboard
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Your logic for setting up the dashboard
            lblTitleChildForm.Text = "Dashboard";
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            UpdateDashboardStats();  // Update the dashboard statistics
            InitializeDashboard();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new AppointmentBooking());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Patients());
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Search_Doctor());
        }

        private void btnMedication_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new DoctorAvailability());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Medication());
        }

        private void btnBill_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Billing());
        }
        private void docNumLbl_Click(object sender, EventArgs e)
        {
            CountDoctors();
        }

        private void appoinmentNumlbl_Click(object sender, EventArgs e)
        {
            CountAppoinments();
        }

        private void patientRecordsNumlbl_Click(object sender, EventArgs e)
        {
            CountPatients();
        }

        private void medNumLbl_Click(object sender, EventArgs e)
        {
            CountMedications();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartPnl_Paint(object sender, PaintEventArgs e)
        {
            CountPatients();
            CountDoctors();
            CountMedications();
            // ... (Call other count methods as well)

            // Step 3: Create a new Chart object, configure it, and add the data to it
            myChart = new Chart();
            ChartArea chartArea = new ChartArea();
            myChart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.Name = "DataSeries";
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Patients", int.Parse(patientRecordsNumlbl.Text));
            series.Points.AddXY("Doctors", int.Parse(docNumLbl.Text));
            series.Points.AddXY("Medications", int.Parse(medNumLbl.Text));
            // ... (Add other data points as needed)

            myChart.Series.Add(series);

            // Step 4: Add the Chart object to your chartPnl panel
            myChart.Dock = DockStyle.Fill;
            chartPnl.Controls.Add(myChart);
        }
    }
}
