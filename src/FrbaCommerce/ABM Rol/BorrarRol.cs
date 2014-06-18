using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rol
{
    public partial class BorrarRol : Form
    {
        public BorrarRol()
        {
            InitializeComponent();
        }

        private void BorrarRol_Load(object sender, EventArgs e)
        {
            this.rOLTableAdapter.filtrarHabilitados(this.gD1C2014DataSet.ROL);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Eliminar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rOLTableAdapter.filtrarHabilitados(this.gD1C2014DataSet.ROL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rOLTableAdapter.FiltrarNombreHabilitado(gD1C2014DataSet.ROL, textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int rol_id = Convert.ToInt32(fila.Cells[0].Value);
            
            DataRow filaAModificar = gD1C2014DataSet.ROL.NewRow();
            filaAModificar = gD1C2014DataSet.ROL.FindByROL_ID(rol_id);

            filaAModificar["ROL_BAJA"] = 1;
            rOLTableAdapter.Update(gD1C2014DataSet.ROL);

            darBajaUsuarios(rol_id);
            MessageBox.Show("El rol ha sido deshabilitado");

            this.rOLTableAdapter.filtrarHabilitados(this.gD1C2014DataSet.ROL);
        }


        private void darBajaUsuarios(int rol_id)
        {
            DataTable usuariosRol = usuariO_ROLTableAdapter1.rolesDeUsuario(rol_id);
            int usu_id;

            foreach(DataRow row in usuariosRol.Rows)
            {
                usu_id = Convert.ToInt32(row["USU_ROL_USUARIO_ID"]);
                usuariO_ROLTableAdapter1.borrarUsuarioRol(usu_id,rol_id);
            }
        }
    }
}
