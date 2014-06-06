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
        public string usuario { get; set; }
        public string rol { get; set; }
        public Form1()
        {
            
            InitializeComponent();
            label1.Text = "Usuario: " + Global.usuario;
            label2.Text = "    Rol: " + Global.rol;
               
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
