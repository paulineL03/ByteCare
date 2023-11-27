namespace ByteCare
{
    partial class ByteCare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByteCare));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.DoctorsSubmenuPanel = new System.Windows.Forms.Panel();
            this.BTN_MedicalStaff = new System.Windows.Forms.Button();
            this.BTN_Doctors = new System.Windows.Forms.Button();
            this.BTN_Residency = new System.Windows.Forms.Button();
            this.AppointmentsSubmenuPanel = new System.Windows.Forms.Panel();
            this.BTN_AddNewAppointment = new System.Windows.Forms.Button();
            this.BTN_AppointmentSchedules = new System.Windows.Forms.Button();
            this.BTN_Appointments = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.PatientSubmenuPanel = new System.Windows.Forms.Panel();
            this.addNewPatientBTN = new System.Windows.Forms.Button();
            this.existingPatientDataBTN = new System.Windows.Forms.Button();
            this.PatientBTN = new System.Windows.Forms.Button();
            this.LogoSubmenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel.SuspendLayout();
            this.DoctorsSubmenuPanel.SuspendLayout();
            this.AppointmentsSubmenuPanel.SuspendLayout();
            this.PatientSubmenuPanel.SuspendLayout();
            this.LogoSubmenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.AutoScroll = true;
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.SidePanel.Controls.Add(this.DoctorsSubmenuPanel);
            this.SidePanel.Controls.Add(this.BTN_Residency);
            this.SidePanel.Controls.Add(this.AppointmentsSubmenuPanel);
            this.SidePanel.Controls.Add(this.BTN_Appointments);
            this.SidePanel.Controls.Add(this.BTN_Exit);
            this.SidePanel.Controls.Add(this.PatientSubmenuPanel);
            this.SidePanel.Controls.Add(this.PatientBTN);
            this.SidePanel.Controls.Add(this.LogoSubmenuPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidePanel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(299, 926);
            this.SidePanel.TabIndex = 0;
            // 
            // DoctorsSubmenuPanel
            // 
            this.DoctorsSubmenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.DoctorsSubmenuPanel.Controls.Add(this.BTN_MedicalStaff);
            this.DoctorsSubmenuPanel.Controls.Add(this.BTN_Doctors);
            this.DoctorsSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoctorsSubmenuPanel.Location = new System.Drawing.Point(0, 433);
            this.DoctorsSubmenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorsSubmenuPanel.Name = "DoctorsSubmenuPanel";
            this.DoctorsSubmenuPanel.Size = new System.Drawing.Size(299, 100);
            this.DoctorsSubmenuPanel.TabIndex = 26;
            // 
            // BTN_MedicalStaff
            // 
            this.BTN_MedicalStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTN_MedicalStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_MedicalStaff.FlatAppearance.BorderSize = 0;
            this.BTN_MedicalStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.BTN_MedicalStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MedicalStaff.Location = new System.Drawing.Point(0, 39);
            this.BTN_MedicalStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_MedicalStaff.Name = "BTN_MedicalStaff";
            this.BTN_MedicalStaff.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.BTN_MedicalStaff.Size = new System.Drawing.Size(299, 39);
            this.BTN_MedicalStaff.TabIndex = 2;
            this.BTN_MedicalStaff.Text = "Medical Staff Info";
            this.BTN_MedicalStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_MedicalStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_MedicalStaff.UseVisualStyleBackColor = false;
            this.BTN_MedicalStaff.Click += new System.EventHandler(this.BTN_MedicalStaff_Click);
            // 
            // BTN_Doctors
            // 
            this.BTN_Doctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTN_Doctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Doctors.FlatAppearance.BorderSize = 0;
            this.BTN_Doctors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.BTN_Doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Doctors.Location = new System.Drawing.Point(0, 0);
            this.BTN_Doctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Doctors.Name = "BTN_Doctors";
            this.BTN_Doctors.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.BTN_Doctors.Size = new System.Drawing.Size(299, 39);
            this.BTN_Doctors.TabIndex = 1;
            this.BTN_Doctors.Text = "Doctors";
            this.BTN_Doctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Doctors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Doctors.UseVisualStyleBackColor = false;
            this.BTN_Doctors.Click += new System.EventHandler(this.BTN_Doctors_Click);
            // 
            // BTN_Residency
            // 
            this.BTN_Residency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.BTN_Residency.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Residency.FlatAppearance.BorderSize = 0;
            this.BTN_Residency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.BTN_Residency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Residency.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Residency.Image")));
            this.BTN_Residency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Residency.Location = new System.Drawing.Point(0, 387);
            this.BTN_Residency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Residency.Name = "BTN_Residency";
            this.BTN_Residency.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BTN_Residency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_Residency.Size = new System.Drawing.Size(299, 46);
            this.BTN_Residency.TabIndex = 27;
            this.BTN_Residency.Text = "Recidency";
            this.BTN_Residency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Residency.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Residency.UseVisualStyleBackColor = false;
            this.BTN_Residency.Click += new System.EventHandler(this.BTN_Residency_Click);
            // 
            // AppointmentsSubmenuPanel
            // 
            this.AppointmentsSubmenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.AppointmentsSubmenuPanel.Controls.Add(this.BTN_AddNewAppointment);
            this.AppointmentsSubmenuPanel.Controls.Add(this.BTN_AppointmentSchedules);
            this.AppointmentsSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppointmentsSubmenuPanel.Location = new System.Drawing.Point(0, 287);
            this.AppointmentsSubmenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentsSubmenuPanel.Name = "AppointmentsSubmenuPanel";
            this.AppointmentsSubmenuPanel.Size = new System.Drawing.Size(299, 100);
            this.AppointmentsSubmenuPanel.TabIndex = 8;
            // 
            // BTN_AddNewAppointment
            // 
            this.BTN_AddNewAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTN_AddNewAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddNewAppointment.FlatAppearance.BorderSize = 0;
            this.BTN_AddNewAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.BTN_AddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddNewAppointment.Location = new System.Drawing.Point(0, 39);
            this.BTN_AddNewAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_AddNewAppointment.Name = "BTN_AddNewAppointment";
            this.BTN_AddNewAppointment.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.BTN_AddNewAppointment.Size = new System.Drawing.Size(299, 39);
            this.BTN_AddNewAppointment.TabIndex = 2;
            this.BTN_AddNewAppointment.Text = "Add New Appointment";
            this.BTN_AddNewAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_AddNewAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AddNewAppointment.UseVisualStyleBackColor = false;
            this.BTN_AddNewAppointment.Click += new System.EventHandler(this.BTN_AddNewAppointment_Click);
            // 
            // BTN_AppointmentSchedules
            // 
            this.BTN_AppointmentSchedules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTN_AppointmentSchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AppointmentSchedules.FlatAppearance.BorderSize = 0;
            this.BTN_AppointmentSchedules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.BTN_AppointmentSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AppointmentSchedules.Location = new System.Drawing.Point(0, 0);
            this.BTN_AppointmentSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_AppointmentSchedules.Name = "BTN_AppointmentSchedules";
            this.BTN_AppointmentSchedules.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.BTN_AppointmentSchedules.Size = new System.Drawing.Size(299, 39);
            this.BTN_AppointmentSchedules.TabIndex = 1;
            this.BTN_AppointmentSchedules.Text = "Appointment Schedules";
            this.BTN_AppointmentSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_AppointmentSchedules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AppointmentSchedules.UseVisualStyleBackColor = false;
            this.BTN_AppointmentSchedules.Click += new System.EventHandler(this.BTN_AppointmentSchedules_Click);
            // 
            // BTN_Appointments
            // 
            this.BTN_Appointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.BTN_Appointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Appointments.FlatAppearance.BorderSize = 0;
            this.BTN_Appointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.BTN_Appointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Appointments.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Appointments.Image")));
            this.BTN_Appointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Appointments.Location = new System.Drawing.Point(0, 241);
            this.BTN_Appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Appointments.Name = "BTN_Appointments";
            this.BTN_Appointments.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BTN_Appointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_Appointments.Size = new System.Drawing.Size(299, 46);
            this.BTN_Appointments.TabIndex = 7;
            this.BTN_Appointments.Text = "Appointments";
            this.BTN_Appointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Appointments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Appointments.UseVisualStyleBackColor = false;
            this.BTN_Appointments.Click += new System.EventHandler(this.BTN_Appointments_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.BTN_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Exit.FlatAppearance.BorderSize = 0;
            this.BTN_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Exit.Location = new System.Drawing.Point(0, 880);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BTN_Exit.Size = new System.Drawing.Size(299, 46);
            this.BTN_Exit.TabIndex = 6;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // PatientSubmenuPanel
            // 
            this.PatientSubmenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.PatientSubmenuPanel.Controls.Add(this.addNewPatientBTN);
            this.PatientSubmenuPanel.Controls.Add(this.existingPatientDataBTN);
            this.PatientSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientSubmenuPanel.Location = new System.Drawing.Point(0, 141);
            this.PatientSubmenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientSubmenuPanel.Name = "PatientSubmenuPanel";
            this.PatientSubmenuPanel.Size = new System.Drawing.Size(299, 100);
            this.PatientSubmenuPanel.TabIndex = 1;
            // 
            // addNewPatientBTN
            // 
            this.addNewPatientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.addNewPatientBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewPatientBTN.FlatAppearance.BorderSize = 0;
            this.addNewPatientBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.addNewPatientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPatientBTN.Location = new System.Drawing.Point(0, 39);
            this.addNewPatientBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewPatientBTN.Name = "addNewPatientBTN";
            this.addNewPatientBTN.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.addNewPatientBTN.Size = new System.Drawing.Size(299, 39);
            this.addNewPatientBTN.TabIndex = 2;
            this.addNewPatientBTN.Text = "Add New Patient";
            this.addNewPatientBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewPatientBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewPatientBTN.UseVisualStyleBackColor = false;
            this.addNewPatientBTN.Click += new System.EventHandler(this.BTN_AddNewPatient_Click);
            // 
            // existingPatientDataBTN
            // 
            this.existingPatientDataBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.existingPatientDataBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.existingPatientDataBTN.FlatAppearance.BorderSize = 0;
            this.existingPatientDataBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.existingPatientDataBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.existingPatientDataBTN.Location = new System.Drawing.Point(0, 0);
            this.existingPatientDataBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.existingPatientDataBTN.Name = "existingPatientDataBTN";
            this.existingPatientDataBTN.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.existingPatientDataBTN.Size = new System.Drawing.Size(299, 39);
            this.existingPatientDataBTN.TabIndex = 1;
            this.existingPatientDataBTN.Text = "Existing Patients";
            this.existingPatientDataBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.existingPatientDataBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.existingPatientDataBTN.UseVisualStyleBackColor = false;
            this.existingPatientDataBTN.Click += new System.EventHandler(this.BTN_ExistingPatientData_Click);
            // 
            // PatientBTN
            // 
            this.PatientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.PatientBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientBTN.FlatAppearance.BorderSize = 0;
            this.PatientBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.PatientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientBTN.Image = ((System.Drawing.Image)(resources.GetObject("PatientBTN.Image")));
            this.PatientBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatientBTN.Location = new System.Drawing.Point(0, 95);
            this.PatientBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientBTN.Name = "PatientBTN";
            this.PatientBTN.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.PatientBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PatientBTN.Size = new System.Drawing.Size(299, 46);
            this.PatientBTN.TabIndex = 1;
            this.PatientBTN.Text = "Patients";
            this.PatientBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatientBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PatientBTN.UseVisualStyleBackColor = false;
            this.PatientBTN.Click += new System.EventHandler(this.BTN_Patient_Click);
            // 
            // LogoSubmenuPanel
            // 
            this.LogoSubmenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.LogoSubmenuPanel.Controls.Add(this.pictureBox2);
            this.LogoSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoSubmenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoSubmenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoSubmenuPanel.Name = "LogoSubmenuPanel";
            this.LogoSubmenuPanel.Size = new System.Drawing.Size(299, 95);
            this.LogoSubmenuPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 47);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1333, 1231);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(667, 615);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ByteCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1376, 926);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SidePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ByteCare";
            this.Text = "ByteCare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SidePanel.ResumeLayout(false);
            this.DoctorsSubmenuPanel.ResumeLayout(false);
            this.AppointmentsSubmenuPanel.ResumeLayout(false);
            this.PatientSubmenuPanel.ResumeLayout(false);
            this.LogoSubmenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel PatientSubmenuPanel;
        private System.Windows.Forms.Button addNewPatientBTN;
        private System.Windows.Forms.Button existingPatientDataBTN;
        private System.Windows.Forms.Button PatientBTN;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Panel LogoSubmenuPanel;
        private System.Windows.Forms.Panel DoctorsSubmenuPanel;
        private System.Windows.Forms.Button BTN_MedicalStaff;
        private System.Windows.Forms.Button BTN_Doctors;
        private System.Windows.Forms.Button BTN_Residency;
        private System.Windows.Forms.Panel AppointmentsSubmenuPanel;
        private System.Windows.Forms.Button BTN_AddNewAppointment;
        private System.Windows.Forms.Button BTN_AppointmentSchedules;
        private System.Windows.Forms.Button BTN_Appointments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

