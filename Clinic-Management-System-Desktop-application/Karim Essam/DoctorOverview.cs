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

namespace Clinic_Management_System_Desktop_application.Karim_Essam
{
    public partial class DoctorOverview : Form
    {
        ClinicDB clinicDB=new ClinicDB();
        public DoctorOverview()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm");
            lbSecond.Text = DateTime.Now.ToString("ss");
            lbDate.Text = DateTime.Now.ToString("MMMM dd yyyy");

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
        public void Doneornot()
        {
            var colection = clinicDB.Patients.Where(e => e.appointments.Day == DateTime.Today.Day).Select(e => new { id = e.PatientId }).Count();
            var done = clinicDB.Patients.Where(e => e.appointments.Day == DateTime.Today.Day).Count(e => e.done == true);
            var notdone = clinicDB.Patients.Where(e => e.appointments.Day == DateTime.Today.Day).Count(e => e.done == false);
            Colecion.Text = colection.ToString();
            Waiting.Text = notdone.ToString();
            Done.Text = done.ToString();
        }

        private void DoctorOverview_Load(object sender, EventArgs e)
        {
            Doneornot();
            Getdata();
            timer.Start();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medicien medicien= new Medicien();
            medicien.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllPatient allPatient = new AllPatient();
            allPatient.Show();
            this.Hide();
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
    }
}
