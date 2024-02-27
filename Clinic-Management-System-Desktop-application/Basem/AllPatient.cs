using Clinic_Management_System_Desktop_application.Karim_Essam;
using Clinic_Management_System_Desktop_application.Safa;
using database_test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application
{
    public partial class AllPatient : Form
    {
        public AllPatient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {


            LoadData();
        }
        void LoadData()
        {
            dataGridView.AutoGenerateColumns = true;
            using (ClinicDB db = new ClinicDB())
            {
                //here we change (prescripation to patient table to show all pattient )
                dataGridView.DataSource = db.Patients.ToList<Patient>();
            }
        }

        //search in patient  

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                using (ClinicDB db = new ClinicDB())
                {
                    var patients = db.Prescriptions
                        .Where(p => p.PrescriptionName.Contains(searchQuery) || p.PrescriptionType.Contains(searchQuery))
                        .ToList();

                    dataGridView.DataSource = patients;
                }
            }
            else
            {
                // If search query is empty, load all data
                LoadData();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DoctorOverview doctor=new DoctorOverview();
            doctor.Show();
            this.Hide();
        }
    }
}
