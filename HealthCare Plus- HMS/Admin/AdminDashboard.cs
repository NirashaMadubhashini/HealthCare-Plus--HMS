using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace HealthCare_Plus__HMS.Admin
{
    public partial class AdminDashboard : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public AdminDashboard()
        {
            InitializeComponent();
            UpdateDashboardStats();
            CountPatients();
            CountDoctors();
            CountStaffs();
            CountHIV();
            CountRooms();
            CountResources();
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F"); // "F" format specifier displays the full date and time
        }

        private void UpdateDashboardStats()
        {
            CountPatients();
            CountDoctors();
            CountStaffs();
            CountHIV();
            CountRooms();
            CountResources();
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
            PatNumlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DocNumlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountStaffs()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UserTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StaffNumlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountRooms()
                {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from RoomTbl ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            roomNumlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        } 
        
        private void CountResources()
                {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from MedicalResourceTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            resourcesNumlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountHIV()
        {
           /* string Status = "Positive";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTbl where PatHIV = '" + Status + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HIVlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();*/
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

        private void iconPictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Doctors());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Patients());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Staff());
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new BillingandInvoicing());
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Rooms());
        }

        private void btnLaboratoryTest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new MedicalResources());
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new Reports());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void DocNumlbl_Click(object sender, EventArgs e)
        {
            CountDoctors();
        }

        private void PatNumlbl_Click(object sender, EventArgs e)
        {
            CountPatients();
        }

        private void StaffNumlbl_Click(object sender, EventArgs e)
        {
            CountStaffs();
        }

        private void roomNumlbl_Click(object sender, EventArgs e)
        {
            CountRooms();
        }

        private void resourcesNumlbl_Click(object sender, EventArgs e)
        {

        }
        private void Prescriptionlbl_Click(object sender, EventArgs e)
        {

        }

        private void HIVlbl_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelShadow_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
