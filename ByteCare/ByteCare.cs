using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteCare
{
    public partial class ByteCare : Form
    {

        Rfid bt = new Rfid();
        public SerialPort serialPort;
        //IntensiveCareUnit icu;
        
        public ByteCare()
        {   
           
           InitializeComponent();
            design();
           // this.HandleCreated += ByteCare_HandleCreated;
        }

        private void design()
        {
            PatientSubmenuPanel.Visible = false;
            AppointmentsSubmenuPanel.Visible = false;
            DoctorsSubmenuPanel.Visible = false;
        }
        
        public void Authh() {
            //  this.Invoke(new Action(() => icu.Show()));
            //  if (this.IsHandleCreated && !this.IsDisposed)
            // {
            // this.Invoke((MethodInvoker)delegate
            // {
                  //  MessageBox.Show("u suck");
               // });
           // }
        }
        private void HideSubMenu()
        {
            if (PatientSubmenuPanel.Visible == true)
                PatientSubmenuPanel.Visible = false;
            if (AppointmentsSubmenuPanel.Visible == true)
                AppointmentsSubmenuPanel.Visible = false;
            if (DoctorsSubmenuPanel.Visible == true)
                DoctorsSubmenuPanel.Visible = false;
        }


        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                //Animate the panel sliding down
                SubMenu.Height = 0;
                SubMenu.Visible = true;
                SubMenu.CreateGraphics().Clear(SubMenu.BackColor);

                int targetHeight = SubMenu.PreferredSize.Height;
                int stepSize = 10;
                int delay = 3;//delay

                for (int h = 0; h <= targetHeight; h += stepSize)
                {
                    SubMenu.Height = h;
                    System.Threading.Thread.Sleep(delay);
                    Application.DoEvents(); //Para po hindi lag
                }

                SubMenu.Height = targetHeight;
            }
            else
            {
                //Animate the panel sliding up
                int targetHeight = 0;
                int stepSize = 10;
                int delay = 3;//delay

                for (int h = SubMenu.Height; h >= targetHeight; h -= stepSize)
                {
                    SubMenu.Height = h;
                    System.Threading.Thread.Sleep(delay);
                    Application.DoEvents(); //Para po hindi lag
                }

                SubMenu.Height = targetHeight;
                SubMenu.Visible = false;
            }
        }

        //Patient Menu
        private void BTN_Patient_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PatientSubmenuPanel);
        }

        private void BTN_ExistingPatientData_Click(object sender, EventArgs e)
        {
            Form_ExistingPatientData form_existing_patient_data = new Form_ExistingPatientData();

            form_existing_patient_data.Size = new Size(870, 700);

            form_existing_patient_data.StartPosition = FormStartPosition.CenterParent;

            form_existing_patient_data.ShowDialog();


            HideSubMenu();
        }

        private void BTN_AddNewPatient_Click(object sender, EventArgs e)
        {
            Form_AddNewPatient form_add_new_patient = new Form_AddNewPatient();

            form_add_new_patient.Size = new Size(1000, 700);

            form_add_new_patient.StartPosition = FormStartPosition.CenterParent;

            form_add_new_patient.ShowDialog();

            HideSubMenu();
        }

        //Appointemnt Menu
        private void BTN_Appointments_Click(object sender, EventArgs e)
        {
            ShowSubMenu(AppointmentsSubmenuPanel);
        }

        private void BTN_AppointmentSchedules_Click(object sender, EventArgs e)
        {
            Form_AppointmentSchedules form_appointment_schedules = new Form_AppointmentSchedules();

            form_appointment_schedules.Size = new Size(700, 700);

            form_appointment_schedules.StartPosition = FormStartPosition.CenterParent;

            form_appointment_schedules.ShowDialog();

            HideSubMenu();
        }

        private void BTN_AddNewAppointment_Click(object sender, EventArgs e)
        {
            Form_AddNewAppointment form_add_new_appointment = new Form_AddNewAppointment();

            form_add_new_appointment.Size = new Size(1000, 700);

            form_add_new_appointment.StartPosition = FormStartPosition.CenterParent;

            form_add_new_appointment.ShowDialog();
            
            HideSubMenu();
        }


        //Recidency Menu
        private void BTN_Residency_Click(object sender, EventArgs e)
        {
            ShowSubMenu(DoctorsSubmenuPanel);
        }

        private void BTN_Doctors_Click(object sender, EventArgs e)
        {
            Form_Doctors form_doctors = new Form_Doctors();

            form_doctors.Size = new Size(600, 700);

            form_doctors.StartPosition = FormStartPosition.CenterParent;

            form_doctors.ShowDialog();

            HideSubMenu();
        }

        private void BTN_MedicalStaff_Click(object sender, EventArgs e)
        {
            Form_MedicalStaff form_medical_staff = new Form_MedicalStaff();

            form_medical_staff.Size = new Size(1000, 700);

            form_medical_staff.StartPosition = FormStartPosition.CenterParent;

            form_medical_staff.ShowDialog();
            
            HideSubMenu();
        }


        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
