using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteCare
{
    public partial class Form_AppointmentSchedules : Form
    {


        DataBaseHelper dbhelper = new DataBaseHelper();
        public Form_AppointmentSchedules()
        {

            InitializeComponent();


            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Appointments", con);
                SqlDataReader read = cmd.ExecuteReader();
                dataGridView1.Columns.Add("patientId", "No.");
                dataGridView1.Columns.Add("patientName", "Patient Name");
                dataGridView1.Columns.Add("appointmentDate", "Appointment Date");

                while (read.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1,
                        read["PatientId"],
                        read["PatientName"],
                        read["AppointmentDate"]
                        );

                    dataGridView1.Rows.Add(row);
                }


            }

            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("Select * from Radiology", con);
                SqlDataReader read1 = cmd1.ExecuteReader();
                dataGridView2.Columns.Add("patientId", "No.");
                dataGridView2.Columns.Add("patientName", "Patient Name");
                dataGridView2.Columns.Add("appointmentDate", "Appointment Date");

                while (read1.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView2,
                        read1["PatientId"],
                        read1["PatientName"],
                        read1["AppointmentDate"]
                        );

                    dataGridView2.Rows.Add(row);
                }
            }
            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("Select * from Laboratory", con);
                SqlDataReader read1 = cmd1.ExecuteReader();
                dataGridView3.Columns.Add("patientId", "No.");
                dataGridView3.Columns.Add("patientName", "Patient Name");
                dataGridView3.Columns.Add("appointmentDate", "Appointment Date");

                while (read1.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView3,
                        read1["PatientId"],
                        read1["PatientName"],
                        read1["AppointmentDate"]
                        );

                    dataGridView3.Rows.Add(row);
                }
            }

            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("Select * from Neurology", con);
                SqlDataReader read1 = cmd1.ExecuteReader();
                dataGridView5.Columns.Add("patientId", "No.");
                dataGridView5.Columns.Add("patientName", "Patient Name");
                dataGridView5.Columns.Add("appointmentDate", "Appointment Date");

                while (read1.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView5,
                        read1["PatientId"],
                        read1["PatientName"],
                        read1["AppointmentDate"]
                        );

                    dataGridView5.Rows.Add(row);
                }
            }

            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("Select * from OperatingRoom", con);
                SqlDataReader read1 = cmd1.ExecuteReader();
                dataGridView7.Columns.Add("patientId", "No.");
                dataGridView7.Columns.Add("patientName", "Patient Name");
                dataGridView7.Columns.Add("appointmentDate", "Appointment Date");

                while (read1.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView7,
                        read1["PatientId"],
                        read1["PatientName"],
                        read1["AppointmentDate"]
                        );

                    dataGridView7.Rows.Add(row);
                }
            }

            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("Select * from Covid", con);
                SqlDataReader read1 = cmd1.ExecuteReader();
                dataGridView6.Columns.Add("patientId", "No.");
                dataGridView6.Columns.Add("patientName", "Patient Name");
                dataGridView6.Columns.Add("appointmentDate", "Appointment Date");

                while (read1.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView6,
                        read1["PatientId"],
                        read1["PatientName"],
                        read1["AppointmentDate"]
                        );

                    dataGridView6.Rows.Add(row);
                }
            }
            /*  public void IntensiveCare() {
                  using (SqlConnection con = new SqlConnection(dbhelper.connection))
                  {
                      con.Open();

                      SqlCommand cmd = new SqlCommand("Select * from Appointments", con);
                      SqlDataReader read = cmd.ExecuteReader();
                      dataGridView2.Columns.Add("patientIdR", "No.");
                      dataGridView2.Columns.Add("patientNameR", "Patient Name");
                      dataGridView2.Columns.Add("appointmentDateR", "Appointment Date");

                      while (read.Read())
                      {
                          DataGridViewRow row = new DataGridViewRow();
                          row.CreateCells(dataGridView2,
                              read["PatientId"],
                              read["PatientName"],
                              read["AppointmentDate"]
                              );

                          dataGridView2.Rows.Add(row);
                      }

                  }

              }*/

        }
    }
}
