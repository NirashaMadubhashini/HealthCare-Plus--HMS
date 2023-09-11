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

namespace HealthCare_Plus__HMS.Doctor
{
    public partial class Profile : Form
    {
        public int DoctorId { get; set; }

        public Profile(int doctorId)
        {
            InitializeComponent();
            this.DoctorId = doctorId;
        }


        SqlConnection Con = new SqlConnection(@"Data Source=NIRASHA\SQLEXPRESS;Initial Catalog=Hospital_Management;Integrated Security=True");


        private void docNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docEmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docSpecTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void docRoomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void experienceTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
