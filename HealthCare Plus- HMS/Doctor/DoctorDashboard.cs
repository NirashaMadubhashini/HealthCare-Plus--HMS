using FontAwesome.Sharp;
using HealthCare_Plus__HMS.Staff;
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

namespace HealthCare_Plus__HMS.Doctor
{
    
    public partial class DoctorDashboard : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string _userName;
        private string _userPassword;
        private Chart myChart;
        public DoctorDashboard(string userName, string userPassword)
        {
            InitializeComponent();
            _userName = userName;
            _userPassword = userPassword;
            CountAppoinments();
            CountPatients();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            Timer timer = new Timer();
            timer.Interval = 1000; // Set the timer interval to 1 second
            timer.Tick += new EventHandler(Timer_Tick); // Add the Tick event handler
            timer.Start(); // Start the timer


            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            if (Login.Role == "Admin")
            {

            }
        }

        public DoctorDashboard(string v1, object userName, string v2, object userPassword)
        {
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F"); // "F" format specifier displays the full date and time
        }

        private void UpdateDashboardStats()
        {
            CountAppoinments();
            CountPatients();
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



        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            patientRecordsNumlbl.Text = dt.Rows[0][0].ToString();
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
        private void iconPictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnPrescription_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Profile(_userName, _userPassword));
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new AllAppoinments());
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new PatientRecords());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void panelShadow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartPnl1_Paint(object sender, PaintEventArgs e)
        {
            // Step 2: Retrieve the necessary data
            CountPatients();
            CountAppoinments();
            // ... (Call other count methods as well)

            // Step 3: Create a new Chart object, configure it, and add the data to it
            myChart = new Chart();
            ChartArea chartArea = new ChartArea();
            myChart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.Name = "DataSeries";
            series.ChartType = SeriesChartType.Bubble;

            series.Points.AddXY("Patients", int.Parse(patientRecordsNumlbl.Text));
            series.Points.AddXY("Appointments", int.Parse(appoinmentNumlbl.Text));
            
            // ... (Add other data points as needed)

            myChart.Series.Add(series);

            // Step 4: Add the Chart object to your chartPnl panel
            myChart.Dock = DockStyle.Fill;
            chartPnl1.Controls.Add(myChart);
        }

        private void chartPnl2_Paint(object sender, PaintEventArgs e)
        {
            // Step 2: Retrieve the necessary data
            CountPatients();
            CountAppoinments();
            // ... (Call other count methods as well)

            // Step 3: Create a new Chart object, configure it, and add the data to it
            myChart = new Chart();
            ChartArea chartArea = new ChartArea();
            myChart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.Name = "DataSeries";
            series.ChartType = SeriesChartType.Doughnut
;

            series.Points.AddXY("Patients", int.Parse(patientRecordsNumlbl.Text));
            series.Points.AddXY("Appointments", int.Parse(appoinmentNumlbl.Text));

            // ... (Add other data points as needed)

            myChart.Series.Add(series);

            // Step 4: Add the Chart object to your chartPnl panel
            myChart.Dock = DockStyle.Fill;
            chartPnl2.Controls.Add(myChart);
        }

        private void AppoinmentNumlbl_Click(object sender, EventArgs e)
        {
            CountAppoinments();
        }

        private void patientRecordsNumlbl_Click(object sender, EventArgs e)
        {
            CountPatients();
        }
    }
}
