using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteCare
{
    public partial class EditDoctor : Form
    {
        byte[] image;
        string name, occupation, contact, availability;
        int id;

        private void submitButton_Click(object sender, EventArgs e)
        {
            name=textBox1.Text;
            occupation=textBox2.Text;
            contact=textBox3.Text;
            availability=comboBox1.Text;
            System.Drawing.Image img = patientPic.Image;
            using (MemoryStream mem = new MemoryStream())
            {
                if (img != null)
                {

                    img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                    image = mem.ToArray();
                }

            }
            DataBaseHelper db = new DataBaseHelper();
            db.MedStaffUpdate(id, name, occupation, contact, availability, image);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            openImg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                string path = openImg.FileName;
                patientPic.Image = System.Drawing.Image.FromFile(path);
            }
        }

        public EditDoctor(int id, string name, string occ, string contact, string avail, byte[] image)
        {

            InitializeComponent();
            this.id = id;
            this.name = name;
            occupation = occ;
            this.contact = contact;
            availability = avail;
            this.image = image;

            textBox1.Text = name;
            textBox2.Text = occupation;
            textBox3.Text = contact;
            comboBox1.Text = avail;
            ImageConverter convert = new ImageConverter();
            System.Drawing.Image image1 = (System.Drawing.Image)convert.ConvertFrom(image);
            patientPic.Image = image1;
        }
    }
}
