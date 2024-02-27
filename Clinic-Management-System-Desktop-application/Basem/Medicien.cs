using Clinic_Management_System_Desktop_application.Karim_Essam;
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
using System.Xml.Linq;

namespace Clinic_Management_System_Desktop_application
{
    public partial class Medicien : Form
    {
        Prescription model = new Prescription();
        public Medicien()
        {
            InitializeComponent();
        }

        private void btnCnacle_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtName.Text = txtType.Text = txtNote.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.PrescriptionId = 0;
        }

        private void Medicien_Load(object sender, EventArgs e)
        {
            NameValid.Visible = false;
            TypeValid.Visible = false;

            Clear();
            this.ActiveControl = txtName;
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                NameValid.Visible = true;
                return;
            }
            else
            {
                NameValid.Visible = false;
            }

            if (string.IsNullOrEmpty(txtType.Text))
            {
                TypeValid.Visible = true;
                return;
            }
            else
            {
                TypeValid.Visible = false;
            }

            model.PrescriptionName = txtName.Text;
            model.PrescriptionType = txtType.Text;
            model.PrescriptionNotes = txtNote.Text;
            using (ClinicDB db = new ClinicDB())
            {
                if (model.PrescriptionId == 0)
                    db.Prescriptions.Add(model);
                else
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            LoadData();
            MessageBox.Show("saved ");
        }
        void LoadData()
        {
            dataGridView.AutoGenerateColumns = false;
            using (ClinicDB db = new ClinicDB())
            {
                dataGridView.DataSource = db.Prescriptions.ToList<Prescription>();
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                model.PrescriptionId = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgPrescriptionId"].Value);
                using (ClinicDB db = new ClinicDB())
                {
                    model = db.Prescriptions.Where(p => p.PrescriptionId == model.PrescriptionId).FirstOrDefault();
                    txtName.Text = model.PrescriptionName;
                    txtType.Text = model.PrescriptionType;
                    txtNote.Text = model.PrescriptionNotes;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ClinicDB db = new ClinicDB())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Prescriptions.Attach(model);
                        db.Prescriptions.Remove(model);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }
        }

        //for search 

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DoctorOverview doctor=new DoctorOverview();
            doctor.Show();
            this.Hide();
        }
    }
}


