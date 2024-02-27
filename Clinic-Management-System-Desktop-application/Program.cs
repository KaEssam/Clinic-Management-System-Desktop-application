using Clinic_Management_System_Desktop_application.Ahmed_yosury;
using Clinic_Management_System_Desktop_application.Karim_Essam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application
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
          // Application.Run(new DoctorOverview());
            Application.Run(new Safa.Login());

        }
    }
}
