using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrbaCommerce
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrbaCommerce.Login.Login login = new Login.Login();
            Application.Run(login);
            Application.Run(new Form1(login.usuario,login.rol));
        }
    }
    static class MetodosGlobales
    {
        public static bool esInteger(TextBox txt)
        {
            int number;

            bool result = Int32.TryParse(txt.Text, out number);
            if (result)
            {
                return true;
            }
            else
            {
                string errores = "El campo " + txt.Tag + " debe ser de tipo numérico";
                MessageBox.Show(errores);
                return false;
            }
        }
    }
}
