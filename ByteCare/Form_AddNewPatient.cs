using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ByteCare
{
    public partial class Form_AddNewPatient : Form
    {
        string firstName, middleName, surName, birthDate, adress, sex, status, contact, note, rName, rContact, rRelate;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        int roomnum;
        string month, day, year;
        byte[] image;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg= new OpenFileDialog();
            openImg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openImg.ShowDialog() == DialogResult.OK) { 
            string path=openImg.FileName;
            patientPic.Image=Image.FromFile(path);
                    }
        }

        string[] monthArray;
        DataBaseHelper dbHelper = new DataBaseHelper();
        

        public Form_AddNewPatient()
        {
            InitializeComponent();
            monthArray = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string m in monthArray)
            {
                mont.Items.Add(m);
            }
            for (int i = 1; i <= 31; i++)
            {
                date.Items.Add(i);
            }
            for (int i = 2023; i >=1900; i--)
            {
                yearBox.Items.Add(i);
            }

        }

        private void submitPatient_Click(object sender, EventArgs e)
        {
            surName = textBox1.Text;
            firstName = textBox2.Text;
            middleName = textBox3.Text;
            contact = textBox4.Text;
            note = textBox9.Text;
            rName=textBox6.Text;
            rContact=textBox7.Text; 
            rRelate=textBox8.Text;
            adress=textBox5.Text;
            roomnum = 0;
            if (mont.SelectedItem != null)
            {
                month = mont.SelectedItem.ToString();
            }
            if (date.SelectedItem != null)
            {

                day = date.SelectedItem.ToString();
            }
            if (yearBox.SelectedItem != null)
            {

                year = yearBox.SelectedItem.ToString();
            }
            
            Image img = patientPic.Image;

            birthDate=month+" " +day+" "+year;

            if (radFemale.Checked )
            {
                sex = "Female";
            }
            if (radMale.Checked )
            {
                sex = "Male";
            }

            if (civilStatus.SelectedItem != null)
            {

                status = civilStatus.SelectedItem.ToString();
            }
            
            //MessageBox.Show(status);

            using (MemoryStream mem = new MemoryStream()) {
                if (img != null)
                {

                    img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                    image = mem.ToArray();
                }
                
            }
            Form_EditPatient ed = new Form_EditPatient(month, day, year);
                dbHelper.insertPatient(surName, firstName, middleName, birthDate, adress, sex, contact, status, rName, rContact, rRelate,
                    image,roomnum, note);
        }
        private void Form_AddNewPatient_Load(object sender, EventArgs e)
        {


        }
    }
}
