using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteCare
{
    public partial class DoctorDetails : Form
    {
        string namee, occc, contacc, availl;
        byte[] imgg;
        int idd;
        public DoctorDetails(int id, string name, string occ, string contact, string avail, byte[] image)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = occ;
            label3.Text = contact;
            label4.Text = avail;
            namee = name;
            occc = occ;
            contacc = contact;
            availl = avail;
            imgg = image;
            ImageConverter convert = new ImageConverter();
            System.Drawing.Image image1 = (System.Drawing.Image)convert.ConvertFrom(image);
            imagebox1.Image = image1;
            idd=id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseHelper db = new DataBaseHelper();
            using (SqlConnection con = new SqlConnection(db.connection))
            {
                con.Open();
                int id = idd;

                string query = "DELETE FROM MedicalStaff WHERE Id = @id";

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

        private void button1_Click(object sender, EventArgs e)
        {
            EditDoctor ed = new EditDoctor(idd, namee, occc, contacc, availl, imgg);
            ed.Show();
        }
    }
}
