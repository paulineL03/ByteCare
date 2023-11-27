using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace ByteCare
{
    public partial class Form_AddNewAppointment : Form
    {
        /*
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
        protected override void OnHandleCreated(EventArgs e)
        {
            SetWindowTheme(Handle, string.Empty, string.Empty);
            base.OnHandleCreated(e);
        }
        */
        DataBaseHelper dbhelper= new DataBaseHelper();
        Form_AppointmentSchedules ap= new Form_AppointmentSchedules();
        DateTime selectedDate;
        string pname;
        public string dep;
        //TextBox textBox2 = new TextBox();
        public Form_AddNewAppointment()
        {
            InitializeComponent();
            autocomplete();
            calendar.DateSelected += monthCalendar1_DateSelected;
        }

        public void autocomplete() {
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.TextChanged += patientIdHandler;

            AutoCompleteStringCollection patienNames = new AutoCompleteStringCollection();

            using (SqlConnection con = new SqlConnection(dbhelper.connection)) { 
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Surname From PatientForm", con);
                SqlDataReader read= cmd.ExecuteReader();

                while(read.Read()) 
                {
                    string name = read.GetString(0);
                    patienNames.Add(name);
                }
            
            }
            textBox1.AutoCompleteCustomSource=patienNames;
        }

        private void patientIdHandler(object sender, EventArgs e)
        {
                pname= textBox1.Text;
                using (SqlConnection con = new SqlConnection(dbhelper.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From PatientForm Where CONVERT(nvarchar(MAX), Surname)=@surname", con);
                    cmd.Parameters.AddWithValue("@surname", pname);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows) { 
                            reader.Read();
                            richTextBox1.Text = Convert.ToString(reader.GetInt32(0));    
                        }
                    }

                }
         
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = calendar.SelectionRange.Start;
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dep = comboBox1.Text;
            SqlConnection con;

            //dbhelper.addAppointments(pname, selectedDate);
            using ( con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                string insertCom = "Insert into Appointments(PatientName, AppointmentDate)" +
                        "Values (@PatientName, @AppointmentDate)";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(insertCom, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", pname);
                        cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                        int check = cmd.ExecuteNonQuery();

                        if (check > 0)
                        {
                            MessageBox.Show("Appointed");
                        }
                        else
                        {
                            MessageBox.Show("Unsuccesful");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unsuccessful");
                }
                if (dep.Equals("Radiology"))
                {
                    using (con = new SqlConnection(dbhelper.connection))
                    {
                        con.Open();

                        string insertCom1 = "Insert into Radiology(PatientName, AppointmentDate)" +
                                "Values (@PatientName, @AppointmentDate)";
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(insertCom1, con))
                            {
                                cmd.Parameters.AddWithValue("@PatientName", pname);
                                cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                                int check = cmd.ExecuteNonQuery();

                                if (check > 0)
                                {
                                 //   MessageBox.Show("Appointed");
                                }
                                else
                                {
                                    MessageBox.Show("Unsuccesful");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unsuccessful");
                        }
                    }
                }
                else if (dep.Equals("Intensive Care Unit"))
                {
                    using (con = new SqlConnection(dbhelper.connection))
                    {
                        con.Open();

                        string insertCom1 = "Insert into IntensiveCare(PatientName, AppointmentDate)" +
                                "Values (@PatientName, @AppointmentDate)";
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(insertCom1, con))
                            {
                                cmd.Parameters.AddWithValue("@PatientName", pname);
                                cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                                int check = cmd.ExecuteNonQuery();

                                if (check > 0)
                                {
                                    //   MessageBox.Show("Appointed");
                                }
                                else
                                {
                                    MessageBox.Show("Unsuccesful");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unsuccessful");
                        }
                    }
                }
                else if (dep.Equals("Laboratory"))
                {

                    using (con = new SqlConnection(dbhelper.connection))
                    {
                        con.Open();

                        string insertCom1 = "Insert into Laboratory(PatientName, AppointmentDate)" +
                                "Values (@PatientName, @AppointmentDate)";
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(insertCom1, con))
                            {
                                cmd.Parameters.AddWithValue("@PatientName", pname);
                                cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                                int check = cmd.ExecuteNonQuery();

                                if (check > 0)
                                {
                                   // MessageBox.Show("Appointed");
                                }
                                else
                                {
                                    MessageBox.Show("Unsuccesful");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unsuccessful");
                        }
                    }
                }

                else if (dep.Equals("Neurology"))
                {

                    using (con = new SqlConnection(dbhelper.connection))
                    {
                        con.Open();

                        string insertCom1 = "Insert into Neurology(PatientName, AppointmentDate)" +
                                "Values (@PatientName, @AppointmentDate)";
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(insertCom1, con))
                            {
                                cmd.Parameters.AddWithValue("@PatientName", pname);
                                cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                                int check = cmd.ExecuteNonQuery();

                                if (check > 0)
                                {
                                  //  MessageBox.Show("Appointed");
                                }
                                else
                                {
                                    MessageBox.Show("Unsuccesful");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unsuccessful");
                        }
                    }
                }
                else if (dep.Equals("Operating Room"))
                {

                    using (con = new SqlConnection(dbhelper.connection))
                    {
                        con.Open();

                        string insertCom1 = "Insert into OperatingRoom(PatientName, AppointmentDate)" +
                                "Values (@PatientName, @AppointmentDate)";
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(insertCom1, con))
                            {
                                cmd.Parameters.AddWithValue("@PatientName", pname);
                                cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                                int check = cmd.ExecuteNonQuery();

                                if (check > 0)
                                {
                                 //   MessageBox.Show("Appointed");
                                }
                                else
                                {
                                    MessageBox.Show("Unsuccesful");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unsuccessful");
                        }
                    }
                }
                else if (dep.Equals("COVID-19"))
                {

                    using (con = new SqlConnection(dbhelper.connection))
                    {
                        con.Open();

                        string insertCom1 = "Insert into Covid(PatientName, AppointmentDate)" +
                                "Values (@PatientName, @AppointmentDate)";
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(insertCom1, con))
                            {
                                cmd.Parameters.AddWithValue("@PatientName", pname);
                                cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                                int check = cmd.ExecuteNonQuery();

                                if (check > 0)
                                {
                                   // MessageBox.Show("Appointed");
                                }
                                else
                                {
                                    MessageBox.Show("Unsuccesful");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unsuccessful");
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
