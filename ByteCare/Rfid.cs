using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteCare
{
    internal class Rfid
    {
        public SerialPort serialPort;
       // string id;
        public bool auth;
/*
        public Rfid(Form_Doctors formDoctors)
        {
            this.fd = formDoctors;
        }

        public Rfid()
        {
        }
*/
        public void BluetoothHandler(string port, int baud) { 
        serialPort = new SerialPort(port, baud);
            try
            {
                serialPort.Open();
               // serialPort.DataReceived += DataReceive;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Unsuccessful\n"+ex);
            }
            
        }
      /*  public void DataReceiveHandler() {
            serialPort.DataReceived += DataReceive;
        }*/

        /*public void DataReceive(object sender, SerialDataReceivedEventArgs e) {
            id = Convert.ToString(serialPort.ReadLine());
            // Form_Doctors fd = new Form_Doctors();
             MessageBox.Show(id);
             fd.Authorization(id);
            string id1 = new string(id.Where(c => !Char.IsWhiteSpace(c)).ToArray());
            Console.WriteLine(id1);
            if (id1== "d0013b21")
            {
                //MessageBox.Show("Id num: "+ id1 + "\nAuthorized");
                //auth = true;
                //Authenticator(true);
                
            }
            else
            {
               // MessageBox.Show("Id num: " + id1+ "\nNot Authorized");
               auth= false;
            }
        }*/

        /*
        public bool Authenticator(bool auth) { 
            if (auth ==true) {
                return true;
            }
            return false;
        }
        */

        /*public void Get() {
            try
            {
                serialPort= new SerialPort();

                serialPort.DataReceived += DataReceive;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsucessful\n" + ex);
            }
        }*/

        public void Close()
        {
            if (serialPort !=null && serialPort.IsOpen)
                serialPort.Close();
        }
    }
}
