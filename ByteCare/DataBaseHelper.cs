using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ByteCare
{
    internal class DataBaseHelper
    {
        public string connection = "Server=DESKTOP-SE8FQTR;" +
            "Database=ByteCare;" +
            "User Id=ByteCare;" +
            "Password=byte";


        public void insertPatient(string surName, string firstName, string middleName, string birth, string adress, string sex, string contact, string civilStatus, string rname, string rcontact, string rrelate, byte[] image, int roomnum, string note)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                string insertCom = "Insert into PatientForm(Surname, Firstname, Middlename, Birthdate,Adress, Sex, ContactNumber, Civilstatus, Name, RelativeContact, Relationship, Image, RoomNum, Notes)" +
                        "Values (@Surname, @Firstname, @Middlename, @Birthdate, @Adress, @Sex, @ContactNumber, @Civilstatus, @Name, @RelativeContact, @Relationship, @Image, @RoomNum, @Notes)";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(insertCom, con))
                    {
                        cmd.Parameters.AddWithValue("@Surname", surName);
                        cmd.Parameters.AddWithValue("@Firstname", firstName);
                        cmd.Parameters.AddWithValue("@Middlename", middleName);
                        cmd.Parameters.AddWithValue("@Birthdate", birth);
                        cmd.Parameters.AddWithValue("@Adress", adress);
                        cmd.Parameters.AddWithValue("@Sex", sex);
                        cmd.Parameters.AddWithValue("@ContactNumber", contact);
                        cmd.Parameters.AddWithValue("@Civilstatus", civilStatus);
                        cmd.Parameters.AddWithValue("@Name", rname);
                        cmd.Parameters.AddWithValue("@RelativeContact", rcontact);
                        cmd.Parameters.AddWithValue("@Relationship", rrelate);
                        cmd.Parameters.AddWithValue("@Image", image);
                        cmd.Parameters.AddWithValue("@RoomNum", roomnum);
                        cmd.Parameters.AddWithValue("@Notes", note);
                        int check = cmd.ExecuteNonQuery();

                        if (check > 0)
                        {
                            MessageBox.Show("Sussesfully Added");
                        }
                        else
                        {
                            MessageBox.Show("Unsuccesful");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Incomplete");
                }

            }
        }
        public void Update(int id, string surname, string fname, string middlename, string birthdate, string adress, string sex, string civilstatus,
            string contact, string roomnum, string rname, string rcontact, string rrelationship, string notes, byte[] image)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string q = "Update PatientForm set Surname=@surname, Firstname=@firstname, Middlename=@middlename," +
                    " Birthdate=@birthdate,Adress=@adress, Sex=@sex, ContactNumber=@contact," +
                    " Civilstatus=@civilstatus, Name=@rname, RelativeContact=@rcontact, Relationship=@rrelate, Image=@image, RoomNum=@roomnum, Notes =@notes" +
                    " Where ID=@id";
                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@firstname", fname);
                    cmd.Parameters.AddWithValue("@middlename", middlename);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@adress", adress);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@civilstatus", civilstatus);
                    cmd.Parameters.AddWithValue("@rname", rname);
                    cmd.Parameters.AddWithValue("@rcontact", rcontact);
                    cmd.Parameters.AddWithValue("@rrelate", rrelationship);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.Parameters.AddWithValue("@roomnum", roomnum);
                    cmd.Parameters.AddWithValue("@notes", notes);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sucessful");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful");
                    }
                }
            }
        }

        public void addAppointments(string name, DateTime date)
        {

        }

        public void MedStaffAdd(string name, string occupation, string contact, string availability, byte[] image)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                string insertCom = "Insert into MedicalStaff(Name, Occupation, Contact, Availability, Image)" +
                        "Values (@Name, @Occupation, @Contact, @Availability, @Image )";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(insertCom, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Occupation", occupation);
                        cmd.Parameters.AddWithValue("@Contact", contact);
                        cmd.Parameters.AddWithValue("@Availability", availability);
                        cmd.Parameters.AddWithValue("@Image", image);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sucessful");
                        }
                        else
                        {
                            MessageBox.Show("Unsuccessful");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unsuccessful");
                }
            }

        }

        public void MedStaffUpdate(int id, string name, string occupation, string contact, string availability, byte[] image)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string q = "Update MedicalStaff set Name=@Name, Occupation=@Occupation, Contact=@Contact, Availability=@Availability, Image=@Image"  +
                    " Where Id=@id";
                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Occupation", occupation);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@Availability", availability);
                    cmd.Parameters.AddWithValue("@Image", image);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sucessful");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful");
                    }
                }

            }
        }

    }
}
 