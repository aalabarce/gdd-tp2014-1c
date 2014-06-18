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
    public partial class Menu : Form
    {
        public string usuario { get; set; }
        public string rol { get; set; }

        public Menu()
        {            
            InitializeComponent();

            usuario = usuarioTableAdapter1.get_username_by_id((int)Global.usuario_id);

            label1.Text = "Usuario: " + usuario;
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

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Empresa.Alta(-1).Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Empresa.Baja().Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Empresa.Modificacion().Show();
        }

        private void crearRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.ABM_Rol.AltaRol().Show();
        }

        private void modificarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Rol.BuscarRol().Show();
        }

        private void eliminarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Rol.BorrarRol().Show();

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Historial_Cliente.Historial(usuario).Show();
        }

        private void calificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Calificar_Vendedor.BuscarCalificar(usuario).Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Cliente.AltaCliente(-1).Show();
        }

        private void compraDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Comprar_Ofertar.Comprar().Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
