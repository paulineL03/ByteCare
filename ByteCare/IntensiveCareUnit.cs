using ByteCare;
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
using static Jenga.Theme;

namespace ByteCare
{
    public partial class IntensiveCareUnit : Form
    {
        
        DataBaseHelper dbhelper= new DataBaseHelper();



        public IntensiveCareUnit()
        {
            InitializeComponent();
            
            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("Select * from IntensiveCare", con);
                SqlDataReader read1 = cmd1.ExecuteReader();
                patientTable.Columns.Add("patientId", "No.");
                patientTable.Columns.Add("patientName", "Patient Name");
                patientTable.Columns.Add("appointmentDate", "Appointment Date");

                while (read1.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(patientTable,
                        read1["PatientId"],
                        read1["PatientName"],
                    read1["AppointmentDate"]
                        );

                    patientTable.Rows.Add(row);
                }
            }
        }
        public void FormClosedEventHandler(FormClosedEventArgs e) { 
        this.Dispose();
        }


    }
}
