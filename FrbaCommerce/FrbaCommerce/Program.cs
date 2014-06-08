using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;




namespace FrbaCommerce
{
    public class Global
    {
        public static int? usuario_id;
        public static string rol;
    }

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
            Global.usuario_id = login.usuario_id;
            Global.rol = login.rol;
            Application.Run(new Form1());

            
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

        public static bool esNumericConDosDecimales(TextBox txt)
        {
            string sValue = txt.Text;

            if (sValue.IndexOf(',') > -1)
            {
                MessageBox.Show("El campo "+txt.Tag+" debe tener . y 2 decimales");
                return false;
            }
            MessageBox.Show("El campo " + txt.Tag + " debe tener . y 2 decimales");
            return Regex.IsMatch(sValue, "(^[0-9]{1,16}(.[0-9]{2})$)");
        }

        public static string sha256(string password)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }
    }
}
