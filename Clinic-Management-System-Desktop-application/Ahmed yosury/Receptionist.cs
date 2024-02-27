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

namespace Clinic_Management_System_Desktop_application.Ahmed_yosury
{
    public partial class Receptionist : Form
    {
        ClinicDB clinicDB=new ClinicDB();
        public Receptionist()
        {
            InitializeComponent();
        }
        public void Getdata()
        {
            var pathiontdata = clinicDB.Patients.Where(e => e.done == false && e.appointments.Day == DateTime.Today.Day).Select(e => new
            {
                id = e.PatientId,
                name = e.PatientName,
                phone = e.PatientPhone,
                address = e.PatientAddress,
                age = e.PatientAge,
                MaritalStatus = e.PatientMaritalStatus,
                Gender = e.PatientGender,
                Appointment = e.appointments
            }).ToList();
            dataGridView1.DataSource = pathiontdata;

        }


        private void Receptionist_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        private void Addpathaint_Click(object sender, EventArgs e)
        {
            AddPatient add = new AddPatient();
            add.Show();
            this.Hide();

        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            string Search = SearchValue.Text;
            var SearchR = clinicDB.Patients.Where(s => s.PatientName.Contains(Search)).Select(p => new {
                id = p.PatientId,
                name = p.PatientName,
                phone = p.PatientPhone,
                address = p.PatientAddress,
                age = p.PatientAge,
                MaritalStatus = p.PatientMaritalStatus,
                Gender =p.PatientGender,
                Appointment = p.appointments
            }).ToList();
            dataGridView1.DataSource = SearchR;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppointmentForm  addappointment=new AppointmentForm();
            addappointment.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
