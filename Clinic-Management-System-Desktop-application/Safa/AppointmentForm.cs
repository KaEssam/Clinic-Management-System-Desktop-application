using Clinic_Management_System_Desktop_application.Ahmed_yosury;
using Clinic_Management_System_Desktop_application.Safa.Enums;
using database_test;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application.Safa
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void OnLoad()
        {
            using (ClinicDB dbContext = new ClinicDB())
            {
                comboBox2.DataSource = dbContext.Staffs.Where(x => x.StaffRole == StaffType.Doctor.ToString()).ToList();
                comboBox2.ValueMember = nameof(Staff.StaffId);
                comboBox2.DisplayMember = nameof(Staff.StaffName);
            }

            dateTimePicker1.Value = DateTime.Now;
        }

        private void LoadAppointments()
        {

            OnLoad();

            using (ClinicDB dbContext = new ClinicDB())
            {
                dataGridViewAppointments.DataSource = dbContext.Appointments
                    .OrderBy(x => x.AppointmenDate)
                    .Select(x => new
                    {
                        Id = x.AppointmentId,
                        Date = x.AppointmenDate,
                        Staff = x.Staff.StaffName,
                    }).ToList();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DateTime appointmenDate = dateTimePicker1.Value;

            if (dateTimePicker1.Value == DateTime.MinValue)
            {
                MessageBox.Show("Invalid AppointmentDate");
                return;
            }

            var staffId = (comboBox2.SelectedItem as Staff)?.StaffId;

            using (ClinicDB dbContext = new ClinicDB())
            {
                dbContext.Appointments.Add(new Appointment
                {
                    AppointmenDate = appointmenDate,
                    StaffId = staffId
                });

                dbContext.SaveChanges();
            }

            // Refresh the DataGridView
            LoadAppointments();
        }

        private void dataGridViewAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewAppointments.Rows[e.RowIndex];
            var cell = row.Cells["Id"].Value;

            DialogResult dialogResult = MessageBox.Show("are you sure you want to delete this Appointment?", "Delete Appointment", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                using (ClinicDB dbContext = new ClinicDB())
                {
                    var appointment = dbContext.Appointments.Find(cell);

                    dbContext.Appointments.Remove(appointment);
                    dbContext.SaveChanges();
                }

                LoadAppointments();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
            this.Hide();
        }
    }
}