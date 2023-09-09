using HealthCare_Plus__HMS.Admin;
using HealthCare_Plus__HMS.BillingStaff;
using HealthCare_Plus__HMS.Doctor;
using HealthCare_Plus__HMS.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus__HMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StaffDashboard());
        }
    }
}
