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
    public partial class Session : Form
    {
        ClinicDB clinicDB = new ClinicDB();
        public Session()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            var pathiontdata = clinicDB.Patients.Where(a => a.done == false).Select(p => p).ToList();
            foreach (var item in pathiontdata)
            {
                NameValue.Items.Add(item.PatientName);
            }
            
            var mi = clinicDB.Prescriptions.Select(s => s.PrescriptionName);
            foreach (var item in mi)
            {
                comboBox1.Items.Add(item);
            }


        }
        public void getmidicen()
        {
            var x = comboBox1.Text;

            var mo = clinicDB.Prescriptions.Where(a => a.PrescriptionName == x).Select(s => s.PrescriptionName).FirstOrDefault();
            textBox8.Text = mo;

        }

        private void NameValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    string pationtName = NameValue.SelectedItem.ToString();
        //    var data = clinicDB.Patients.Where(o => o.PatientName == pationtName).FirstOrDefault();

        //    if (data != null)
        //    {
        //        data.done = true;
        //        clinicDB.SaveChanges();
        //    }
        //    DoctorOverview doctor = new DoctorOverview();
        //    doctor.Show();
        //    this.Hide();
        }

        private void phonedata_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            DoctorOverview doctorOverview = new DoctorOverview();
            doctorOverview.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getmidicen();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }

        private void NameValue_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string Na = NameValue.SelectedItem.ToString();
            var datapatient = clinicDB.Patients.Where(o => o.PatientName == Na).FirstOrDefault();
            phonedata.Text = datapatient.PatientPhone;
            addressdata.Text = datapatient.PatientAddress;
            genderdata.Text = datapatient.PatientGender;
            agedata.Text = datapatient.PatientAge.ToString();
            maritaldata.Text = datapatient.PatientMaritalStatus;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


    }
}

