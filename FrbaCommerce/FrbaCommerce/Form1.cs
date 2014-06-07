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
            label1.Text = "Usuario: " + Global.usuario_id;
            label2.Text = "    Rol: " + Global.rol;
               
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

        private void crearVisibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Visibilidad.AltaVi().Show();
        }

        private void modificarVisibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Visibilidad.BuscarVi().Show();
        }

        private void eliminarVisibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Visibilidad.BorrarVi().Show();
        }

        private void crearRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Rubro.AltaRubro().Show();
        }

        private void modificiarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Rubro.BuscarRubro().Show();
        }

        private void eliminarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Rubro.BajaRubro().Show();
        }

        private void editarPublicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
        }
    }
}
