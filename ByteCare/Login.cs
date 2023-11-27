using Org.BouncyCastle.Asn1.X509;
using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ByteCare
{
    public partial class Login : Form
    {
        Rfid bt= new Rfid();
        string id;
        ByteCare bc = new ByteCare();
        IntensiveCareUnit icu= new IntensiveCareUnit();
        public bool auth;
        SerialPort sp;
       
        public Login()
        {
            InitializeComponent();
            bt.BluetoothHandler("COM5", 9600);
            sp = bt.serialPort;
            sp.DataReceived += Auth;
           
        }
        

        public void Auth(object sender, SerialDataReceivedEventArgs e) {
            id = Convert.ToString(bt.serialPort.ReadLine());
            // Form_Doctors fd = new Form_Doctors();
            /* MessageBox.Show(id);
             fd.Authorization(id);*/
            string id1 = new string(id.Where(c => !Char.IsWhiteSpace(c)).ToArray());
            Console.WriteLine(id1);
            if (id1 == "d0013b21")
            {
                //MessageBox.Show("Id num: "+ id1 + "\nAuthorized");
                //auth = true;
                //Authenticator(true);
                // bytecare.Show();
                //  Application.Run(bytecare);
                // Authenticator(true);
                auth = true;
                bc.serialPort = sp;
                try {
                    this.Invoke(new Action(() => this.Close()));
                } catch {
                    try
                    {
                        Application.Run(icu);
                    }
                    catch {

                    }
                }


            }
            else
            {
                MessageBox.Show("ALERT! " + "\nId num: " + id1 + "\nNot Authorized");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox1.Text;

            if (username == "bytecare" && password == "byte")
            {
                auth = true;
                this.Invoke(new Action(() => this.Close()));
            }

            else
            {
                MessageBox.Show("Unauthorized");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainFormClose(object sender, FormClosedEventArgs e)
        {
          //  bt.Close();
        }


    }
}