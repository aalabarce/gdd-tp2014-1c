using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;





namespace FrbaCommerce
{
    public class Global
    {
        public static string usuario;
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
            Global.usuario = login.usuario;
            Global.rol = login.rol;
            Application.Run(new Form1());

            
        }
    }
}
