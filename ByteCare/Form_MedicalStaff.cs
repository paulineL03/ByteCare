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
    public partial class Form_MedicalStaff : Form
    {
        string name, occupation, contact, availability;
        byte[] image;

        DataBaseHelper dbhelper=new DataBaseHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            openImg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                string path = openImg.FileName;
                patientPic.Image = Image.FromFile(path);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            name=textBox1.Text;
            occupation=textBox2.Text;   
            contact=textBox3.Text;
            availability = comboBox1.Text;

            Image img = patientPic.Image;


            using (MemoryStream mem = new MemoryStream())
            {
                if (img != null)
                {

                    img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                    image = mem.ToArray();
                }

            }
            dbhelper.MedStaffAdd(name, occupation, contact, availability, image);

        }

        public Form_MedicalStaff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
