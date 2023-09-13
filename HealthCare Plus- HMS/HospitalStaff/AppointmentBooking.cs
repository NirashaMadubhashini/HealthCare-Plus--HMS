using FontAwesome.Sharp;
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
    public partial class AppointmentBooking : Form
    {
        public AppointmentBooking()
        {
            InitializeComponent();

        }


        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");

        private void ClearFields()
        {
   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }



        private void patNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void patIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void sheduleBtn_Click(object sender, EventArgs e)
        {
          
        }

    



        private void appoinmentNoteTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void specializationTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docRoomNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void appointmentDateDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reSheduleBtn_Click(object sender, EventArgs e)
        {
           
        }

    }
}
