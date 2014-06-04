using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        public Form1(string usuario, string rol)
        {
            InitializeComponent();
            label1.Text = "Usuario: " + usuario;
            label2.Text = "    Rol: " + rol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PANEL DE CLIENTES");
            new FrbaCommerce.Abm_Cliente.Clientes().Show(); 
        }

        private void generarNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Generar_Publicacion.Generar_Publicacion().Show(); 
        }
    }
}
