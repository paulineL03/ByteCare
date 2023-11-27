using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace ByteCare
{
    public partial class PatientDetails : Form
    {
        byte[] imag;
        int idd;
        string firstN,middleN, lastN, birthday, adres, sexx, civiltatus, note, contactt, room, rnam, rcontactt,rrelat;

       

        public void PatientDetail() { 

        
        }

        public PatientDetails(int id, string surname, string fname, string middlename, string birthdate, string adress, string sex, string civilStatus,
            string contact, string roomnum, string rname, string rcontact, string rrelationship, string notes, byte[] image)
        {
            InitializeComponent();
            patientName.Text = surname + ", " + fname + " " + middlename;
            label1.Text = "Birthdate: "+ birthdate;
            label6.Text = "Contact: " + contact;
            label2.Text = "Adress: "+adress;
            label3.Text = "Sex: "+sex;
            label4.Text = "Civil Status: "+civilStatus;
            label5.Text = "Note: "+notes;
            label8.Text = "Name: "+rname;
            label9.Text = "Contact: "+rcontact;
            label10.Text = "Relationship: "+rrelationship;
            idd = id;
            lastN = surname;
            firstN = fname;
            middleN = middlename;
            birthday=birthdate;
            adres = adress;
            sexx = sex;
            civiltatus = civilStatus;
            contactt= contact;
            room=roomnum;
            rnam = rname;   
            rcontactt = rcontact;   
            rrelat= rrelationship;
            note = notes;
            imag = image;


            if (roomnum.Equals("0")) {
                roomnum = "Unassigned";
            }
            label11.Text = "Room No.: "+roomnum;
            ImageConverter convert = new ImageConverter();
            System.Drawing.Image image1 = (System.Drawing.Image)convert.ConvertFrom(image);
            patientPic.Image = image1;



        }

        private void editButt_Click(object sender, EventArgs e)
        {
            Form_EditPatient ep = new Form_EditPatient(idd,
            lastN,
            firstN,
            middleN ,
            birthday,
            adres,
            sexx ,
            civiltatus,
            contactt,
            room ,
            rnam ,
            rcontactt ,
            rrelat,
            note, imag);
            ep.Show();
        }
        private void deleteButt_Click(object sender, EventArgs e)
        {
            DataBaseHelper db=new DataBaseHelper();
            using (SqlConnection con = new SqlConnection(db.connection))
            {
                con.Open();
                int id = idd;

                string query = "DELETE FROM PatientForm WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                }
            }
        }
    }
}
