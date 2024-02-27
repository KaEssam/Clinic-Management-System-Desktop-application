using Clinic_Management_System_Desktop_application.Ahmed_yosury;
using Clinic_Management_System_Desktop_application.Karim_Essam;
using Clinic_Management_System_Desktop_application.Safa.Enums;
using database_test;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application.Safa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                using (ClinicDB dbContext = new ClinicDB())
                {
                    var user = dbContext.Staffs.FirstOrDefault(x => x.StaffUserName == userName && x.StaffPassword == password);
                    if (user != null)
                    {
                        MessageBox.Show("Login Successfully");

                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;

                        if (user.StaffRole == StaffType.Receptionist.ToString())
                        {
                            Receptionist appointment = new Receptionist();
                            appointment.Show();
                        }
                        else
                        {
                            DoctorOverview doctorOverview = new DoctorOverview();
                            doctorOverview.Show();
                        }

                        Hide();

                        return;
                    }
                }
            }

            MessageBox.Show("Invalid username or password", "Login invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}