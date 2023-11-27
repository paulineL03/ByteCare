using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteCare
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Login());

            Login login = new Login();
            login.Show();

            while (!login.IsDisposed)
            {
                Application.DoEvents();
            }

            if (login.auth)
            {

               // login.Close();
                Application.Run(new ByteCare());
            }


            /*if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ByteCare());
            }
            else
            {
                // Handle login failure or cancellation
            }
            */
        }
    }
}
