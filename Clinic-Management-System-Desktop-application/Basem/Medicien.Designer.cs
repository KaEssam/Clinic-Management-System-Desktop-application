namespace Clinic_Management_System_Desktop_application
{
    partial class Medicien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameValid = new System.Windows.Forms.Label();
            this.TypeValid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.btnCnacle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgPrescriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrescriptionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrescriptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrescriptionNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.NameValid);
            this.panel1.Controls.Add(this.TypeValid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.btnCnacle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 599);
            this.panel1.TabIndex = 14;
            // 
            // NameValid
            // 
            this.NameValid.AutoSize = true;
            this.NameValid.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameValid.ForeColor = System.Drawing.Color.Red;
            this.NameValid.Location = new System.Drawing.Point(44, 89);
            this.NameValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameValid.Name = "NameValid";
            this.NameValid.Size = new System.Drawing.Size(157, 20);
            this.NameValid.TabIndex = 13;
            this.NameValid.Text = "Enter Medicien Name";
            // 
            // TypeValid
            // 
            this.TypeValid.AutoSize = true;
            this.TypeValid.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeValid.ForeColor = System.Drawing.Color.Red;
            this.TypeValid.Location = new System.Drawing.Point(44, 160);
            this.TypeValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeValid.Name = "TypeValid";
            this.TypeValid.Size = new System.Drawing.Size(152, 20);
            this.TypeValid.TabIndex = 12;
            this.TypeValid.Text = "Select Medicien Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(37, 518);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Visible = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Logout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logout.Location = new System.Drawing.Point(99, 535);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(78, 28);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "syrup",
            "Tablet",
            "Ointment"});
            this.txtType.Location = new System.Drawing.Point(9, 130);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(220, 24);
            this.txtType.TabIndex = 9;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged);
            // 
            // btnCnacle
            // 
            this.btnCnacle.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCnacle.Location = new System.Drawing.Point(8, 436);
            this.btnCnacle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCnacle.Name = "btnCnacle";
            this.btnCnacle.Size = new System.Drawing.Size(211, 44);
            this.btnCnacle.TabIndex = 2;
            this.btnCnacle.Text = "Cancle";
            this.btnCnacle.UseVisualStyleBackColor = true;
            this.btnCnacle.Click += new System.EventHandler(this.btnCnacle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 24);
            this.txtName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(7, 208);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(220, 100);
            this.txtNote.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(8, 332);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(8, 384);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(840, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(969, 60);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(156, 42);
            this.searchTextBox.TabIndex = 15;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgPrescriptionId,
            this.dgPrescriptionName,
            this.dgPrescriptionType,
            this.dgPrescriptionNotes});
            this.dataGridView.Location = new System.Drawing.Point(240, 130);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(877, 450);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // dgPrescriptionId
            // 
            this.dgPrescriptionId.DataPropertyName = "PrescriptionId";
            this.dgPrescriptionId.HeaderText = "PrescriptionID";
            this.dgPrescriptionId.MinimumWidth = 6;
            this.dgPrescriptionId.Name = "dgPrescriptionId";
            this.dgPrescriptionId.ReadOnly = true;
            this.dgPrescriptionId.Visible = false;
            this.dgPrescriptionId.Width = 125;
            // 
            // dgPrescriptionName
            // 
            this.dgPrescriptionName.DataPropertyName = "PrescriptionName";
            this.dgPrescriptionName.HeaderText = "Prescription Name";
            this.dgPrescriptionName.MinimumWidth = 6;
            this.dgPrescriptionName.Name = "dgPrescriptionName";
            this.dgPrescriptionName.ReadOnly = true;
            this.dgPrescriptionName.Width = 125;
            // 
            // dgPrescriptionType
            // 
            this.dgPrescriptionType.DataPropertyName = "PrescriptionType";
            this.dgPrescriptionType.HeaderText = "Prescription Type";
            this.dgPrescriptionType.MinimumWidth = 6;
            this.dgPrescriptionType.Name = "dgPrescriptionType";
            this.dgPrescriptionType.ReadOnly = true;
            this.dgPrescriptionType.Width = 125;
            // 
            // dgPrescriptionNotes
            // 
            this.dgPrescriptionNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgPrescriptionNotes.DataPropertyName = "PrescriptionNotes";
            this.dgPrescriptionNotes.HeaderText = "Prescription Notes";
            this.dgPrescriptionNotes.MinimumWidth = 6;
            this.dgPrescriptionNotes.Name = "dgPrescriptionNotes";
            this.dgPrescriptionNotes.ReadOnly = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(1000, 13);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Medicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 594);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Medicien";
            this.Text = "Medicien";
            this.Load += new System.EventHandler(this.Medicien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Button btnCnacle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label NameValid;
        private System.Windows.Forms.Label TypeValid;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}