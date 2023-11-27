using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ByteCare
{
    public partial class Form_EditPatient : Form
    {

        byte[] imag;
        int idd;
        string monthh, dayy, yer;
        string firstN, middleN, lastN, birthday, adres, sexx, civiltatuss, note, contactt, room, rnam, rcontactt, rrelat;

      

        public Form_EditPatient(string month, string day, string year) {
            monthh = month;
            dayy= day;
            yer = year;
        }
        public Form_EditPatient(int id, string surname, string fname, string middlename, string birthdate, string adress, string sex, string civilstatus,
            string contact, string roomnum, string rname, string rcontact, string rrelationship, string notes, byte[] image)
        {
            InitializeComponent();
            idd = id;
            lastN = surname;
            firstN= fname;
            middleN= middlename;
            birthday = birthdate;
            adres = adress;
            sexx = sex;
            civiltatuss = civilstatus;
            contactt= contact;
            room = roomnum;
            rnam = rname;
            rcontactt = rcontact;
            rrelat = rrelationship;
            note = notes;
            imag = image;

            textBox1.Text = surname;
            textBox2.Text = fname;
            textBox3.Text = middlename;
            civilStatus.Text = civilstatus;
            textBox4.Text = contact;
            textBox5.Text = adress;    
            textBox6.Text = rname;
            textBox7.Text = rcontact;
            textBox8.Text = rrelationship;
            textBox9.Text = notes;
            mont.Text = monthh;
            date.Text = dayy;
            yearBox.Text = yer;
            ImageConverter convert = new ImageConverter();
            System.Drawing.Image image1 = (System.Drawing.Image)convert.ConvertFrom(image);
            patientPic.Image = image1;
            if (sex.Equals("Female")) { 
            radFemale.Checked = true;
            }
            if (sex.Equals("Male"))
            {
                radMale.Checked = true;
            }

        }

        private void buttPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            openImg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                string path = openImg.FileName;
                patientPic.Image = System.Drawing.Image.FromFile(path);
            }
        }
        private void saveButt_Click(object sender, EventArgs e)
        {
            lastN=textBox1.Text;
            firstN=textBox2.Text;
            middleN=textBox3.Text;

            adres=textBox5.Text;
            if(radFemale.Checked)
            {
                sexx = "Female";
            }
            if(radMale.Checked)
            {
                sexx = "Male";
            }
            civiltatuss = civilStatus.Text;
            contactt = textBox4.Text;
            rnam=textBox6.Text;
            rcontactt = textBox7.Text;
            rrelat=textBox8.Text;   
            note=textBox9.Text;
            System.Drawing.Image img = patientPic.Image;
            using (MemoryStream mem = new MemoryStream())
            {
                if (img != null)
                {

                    img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imag = mem.ToArray();
                }

            }
            DataBaseHelper db=new DataBaseHelper();
            db.Update(idd, lastN, firstN, middleN, birthday,
                adres,sexx,civiltatuss,contactt, room,rnam,rcontactt,rrelat,note,imag);

        }
    }
}
