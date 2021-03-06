﻿using System;
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

        private void Menu_Load(object sender, EventArgs e)
        {
            rolTableAdapter1.Fill(gD1C2014DataSet1.ROL);
            roL_FUNCIONALIDADTableAdapter1.Fill(gD1C2014DataSet1.ROL_FUNCIONALIDAD);
            funcionalidadTableAdapter1.Fill(gD1C2014DataSet1.FUNCIONALIDAD);

            int rol_id = Convert.ToInt32(rolTableAdapter1.buscarID(Global.rol));

            DataTable tablita = roL_FUNCIONALIDADTableAdapter1.tablita(rol_id);
            foreach (DataRow fila in tablita.Rows)
            {
                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 1)
                    rolToolStripMenuItem.Visible=true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 2)
                    clienteToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 3)
                    empresaToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 4)
                    rubroToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 5)
                    visibilidadToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 6)
                {
                    publicaciónToolStripMenuItem.Visible = true;
                    generarNuevaToolStripMenuItem.Visible = true;
                }

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 7)
                {
                    publicaciónToolStripMenuItem.Visible = true;
                    editarPublicaciónToolStripMenuItem.Visible = true;
                }

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 8)
                {
                    preguntasToolStripMenuItem.Visible = true;
                    verRespuestasToolStripMenuItem.Visible = true;
                }

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 9)
                    comprasToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 10)
                    historialToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 11)
                    calificarToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 12)
                    facturaciónToolStripMenuItem.Visible = true;

                if (Convert.ToInt32(fila["ROL_FUN_FUN_ID"]) == 13)
                    estadisticasToolStripMenuItem.Visible = true;
            }

            if (Global.rol == "Administrador")
                contraseñasDeUsuariosToolStripMenuItem.Visible = true;
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            new FrbaCommerce.Abm_Cliente.Clientes(1).Show(); 
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

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Facturar_Publicaciones.Facturar().Show();
        }

        private void subastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Comprar_Ofertar.Ofertar().Show();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Listado_Estadistico.Listado().Show();
        }

        private void responderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Gestion_de_Preguntas.BuscarPre().Show();
        }

        private void verRespuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Gestion_de_Preguntas.VerRespuestas().Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Cliente.Clientes(2).Show();
        }

        private void miContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Login.CambioContraseña((int)Global.usuario_id,1).Show();
        }

        private void contraseñasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Login.ContraseñasUsuarios().Show();
        }
    }
}
