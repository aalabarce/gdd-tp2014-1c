using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Login
{
    public partial class Login : Form
    {
        public bool exito { get; set; }
        public string usuario { get; set; }
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exito = false;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
                return;                
            }
            usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            if (usuarioTableAdapter1.existeUsuario(usuario)==1)
            {
                MessageBox.Show("Existe!!");
            }
            else
            {
                MessageBox.Show("No existe!!");
            }
        }


    }
}
