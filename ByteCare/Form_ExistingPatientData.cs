using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteCare
{
    public partial class Form_ExistingPatientData : Form
    {
        byte[] image;
        public int id;
        string surname, firstname, middlename, birthday, adres, sexx, civilstatus, note, pContact, rname, rcontact, rrelationship, roomnum;

        DataBaseHelper dbhelper = new DataBaseHelper();
        public Form_ExistingPatientData()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from PatientForm", con);
                SqlDataReader read = cmd.ExecuteReader();
                patientTable.Columns.Add("patientNo", "No.");
                patientTable.Columns.Add("surname", "Surname");
                patientTable.Columns.Add("firstname", "Firstname");
                patientTable.Columns.Add("middlename", "Middle name");
                patientTable.Columns.Add("birthdate", "Birthdate");
                patientTable.Columns.Add("sex", "Sex");
                patientTable.Columns.Add("civilstatus", "Civil Status");
                patientTable.Columns.Add("contactnumber", "Contact No.");


                while (read.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(patientTable,
                        read["ID"],
                        read["Surname"],
                        read["Firstname"],
                        read["Middlename"],
                        read["Birthdate"],
                        read["Sex"],
                        read["Civilstatus"],
                        read["ContactNumber"]
                        ); 
                    /*id = read.GetInt32(0);
                    surname=read.GetString(1);
                    firstname=read.GetString(2);
                    middlename=read.GetString(3);
                    birthday=read.GetString(4);
                    sexx=read.GetString(5);
                    civilstatus = read.GetString(6);*/
                    try { 
                    pContact = read.GetString(7);

                    }
                    catch
                    {
                        pContact = " ";
                    }    
                    
                    
                    patientTable.Rows.Add(row);
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            
        }
        private void patientTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = patientTable.Rows[e.RowIndex];
                using (SqlConnection con = new SqlConnection(dbhelper.connection))
                {
                    con.Open();
                    DataGridViewRow selected = patientTable.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selected.Cells["patientNo"].Value);
                    string query = "Select * from PatientForm Where ID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                surname = reader.GetString(1);
                                firstname = reader.GetString(2);
                                middlename = reader.GetString(3);
                                birthday = reader.GetString(4);
                                sexx = reader.GetString(5);
                                civilstatus = reader.GetString(6);
                                pContact =Convert.ToString( reader.GetDecimal(7));
                                roomnum =Convert.ToString( reader.GetInt32(8));
                                rname = reader.GetString(9);
                                rrelationship = reader.GetString(10);
                                rcontact = Convert.ToString(reader.GetDecimal(11));
                                try {
                                    adres = reader.GetString(12);
                                }
                                catch { 
                                    adres = "Dude's a homeless bum"; 
                                }
                                note = reader.GetString(13);
                                image = reader.GetSqlBinary(14).Value;

                                PatientDetails pd = new PatientDetails(id, surname, firstname, middlename, birthday, adres, sexx, civilstatus, pContact,roomnum, rname, rcontact, rrelationship, note, image );
                                /*pd.lastN = surname;
                                pd.firstN = firstname;
                                pd.middleN = middlename;*/
                                pd.Show();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the selected patient.");
                            }
                        }
                    }
                }
            }
        }

    }
}
