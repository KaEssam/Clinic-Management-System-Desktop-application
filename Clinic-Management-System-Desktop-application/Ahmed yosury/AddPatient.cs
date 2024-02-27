using Clinic_Management_System_Desktop_application.Safa;
using database_test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application.Ahmed_yosury
{
    public partial class AddPatient : Form
    {
        ClinicDB clinicDB = new ClinicDB();
        Patient patient = new Patient();
        Appointment appoint = new Appointment();

        public void Getdata()
        {
            appoint.AppointmenDate = DateTime.Now;
            clinicDB.SaveChanges();
            var pathiontdata = clinicDB.Patients.Select(e => new
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
        public void Clear()
        {
            NameValue.Text = "";
            PhoneValue.Text = "";
            AddressValue.Text = "";
            GenderValue.Text = "";
            MaritalStatusValue.Text = "";
            AgeValue.Text = "";
            // AddAppointmentValue.Text = "";
        }
        //public void Getappointment()
        //{
        //    //var app = clinicDB.Appointments.Select(a => a.AppointmenDate).ToList();

        //    //foreach (var item in app)
        //    //{
        //    //    AddAppointmentValue.Items.Add(app);
        //    //}
        //}

        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            //Getappointment();
            Getdata();
            IvaildPhone.Visible = false;
            Ivaildaddreess.Visible = false;
            IvaildAge.Visible = false;
            IvaildAge.Visible = false;
            IvaildAppointment.Visible = false;
            IvaildName.Visible = false;

        }


        private void Save_Click(object sender, EventArgs e)
        {
            
            bool ah = false;
            var a = PhoneValue.Text;

            foreach (var item in a)
            {
                if (!char.IsDigit(item))
                {
                    ah = true;
                }

            }
            if (NameValue.Text == "" || NameValue.Text.Length < 2)
            {
                IvaildName.Visible = true;
            }
            else
            {
                IvaildName.Visible = false;
            }
            if ( int.Parse(AgeValue.Text) > 0)
            {
                IvaildAge.Visible = false;
            }
            else
            {
                IvaildAge.Visible = true;
            }
            if (PhoneValue.Text.Length == 11 || ah == true)
            {
                IvaildPhone.Visible = false;
            }
            else
            {
                IvaildPhone.Visible = true;
            }
            if (AddressValue.Text == "" || AddressValue.Text.Length < 3)
            {
                Ivaildaddreess.Visible = true;
            }
            else
            {
                Ivaildaddreess.Visible = false;
            }

            patient.PatientName = NameValue.Text;
            patient.PatientAge = int.Parse(AgeValue.Text);
            patient.PatientMaritalStatus = MaritalStatusValue.Text;
            patient.PatientPhone = PhoneValue.Text;
            patient.PatientAddress = AddressValue.Text;
            patient.done = false;
            patient.PatientGender = GenderValue.Text;
            patient.appointments = AddAppointmentValue.Value;
            // patient.appointments = (DateTime)AddAppointmentValue.SelectedItem;
            if (IvaildName.Visible == false && IvaildAge.Visible == false && Ivaildaddreess.Visible == false && IvaildPhone.Visible == false)
            {
                clinicDB.Patients.Add(patient);
                clinicDB.SaveChanges();
                MessageBox.Show($"the patient{NameValue.Text} is add sussefuly");
            }
            else
            {
                MessageBox.Show("invaild data");
            }

            Getdata();
            Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool ah = false;
            var a = PhoneValue.Text;
            foreach (var item in a)
            {
                if (!char.IsDigit(item))
                {
                    ah = true;
                }

            }

            if (NameValue.Text == "" || NameValue.Text.Length > 2)
            {
                IvaildName.Visible = true;
            }
            else
            {
                IvaildName.Visible = false;
            }
            if (int.Parse(AgeValue.Text) > 0 || int.Parse(AgeValue.Text) < 100)
            {
                IvaildAge.Visible = true;
            }
            else
            {
                IvaildAge.Visible = false;
            }
            if (PhoneValue.Text.Length == 11 || ah==true )
            {
                IvaildPhone.Visible = false;
            }
            else
            {
                IvaildPhone.Visible = true;
            }
            if (AddressValue.Text == "" || AddressValue.Text.Length > 3)
            {
                Ivaildaddreess.Visible = true;
            }
            else
            {
                Ivaildaddreess.Visible = false;
            }
            

            patient.PatientName = NameValue.Text;
            patient.PatientAge = (int)AgeValue.Value;
            patient.PatientMaritalStatus = MaritalStatusValue.Text;
            patient.PatientPhone = PhoneValue.Text;
            patient.PatientAddress = AddressValue.Text;
            patient.done = false;
            patient.appointments = AddAppointmentValue.Value;

            //patient.appointments = (DateTime)AddAppointmentValue.SelectedItem;
            patient.PatientGender = GenderValue.Text;
            if (IvaildName.Visible == false && IvaildAge.Visible == false && Ivaildaddreess.Visible == false && IvaildPhone.Visible == false)
            {
                clinicDB.Entry(patient).State = EntityState.Modified;
                clinicDB.SaveChanges();
                MessageBox.Show($"the patient{NameValue.Text} is Updte sussefuly");


            }
            else
            {
                MessageBox.Show("invaild data");
            }


            Getdata();
            Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var data = clinicDB.Entry(patient);
            if (data.State == EntityState.Detached)
            {
                clinicDB.Patients.Attach(patient);
            }
            clinicDB.Patients.Remove(patient);
            clinicDB.SaveChanges();
            Getdata();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
            this.Hide();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                patient.PatientId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                patient = clinicDB.Patients.Where(a => a.PatientId == patient.PatientId).FirstOrDefault();
                NameValue.Text = patient.PatientName;
                PhoneValue.Text = patient.PatientPhone;
                AddressValue.Text = patient.PatientAddress;
                MaritalStatusValue.Text = patient.PatientMaritalStatus;
                AgeValue.Value = patient.PatientAge;
                AddAppointmentValue.Text = patient.appointments.ToString();
                GenderValue.Text = patient.PatientGender;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Receptionist patient = new Receptionist();
            patient.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
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

