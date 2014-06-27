using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class Publicaciones : Form
    {
        public Publicaciones()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.PUBLICACION_COMPLETA' Puede moverla o quitarla según sea necesario.
            this.pUBLICACION_COMPLETATableAdapter.FillByUsuID(this.gD1C2014DataSet.PUBLICACION_COMPLETA,Global.usuario_id);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.PUBLICACION' Puede moverla o quitarla según sea necesario.
            dataGridView1.Columns[0].DefaultCellStyle.NullValue = "Modificar";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Boton modificar
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                int codigo = Convert.ToInt32(fila.Cells[1].Value);
                if (Convert.ToChar(fila.Cells[5].Value) == 'F')
                {
                    MessageBox.Show("No se puede editar una publicación finalizada.");
                    return;
                }
                if(Convert.ToChar(fila.Cells[5].Value) == 'P')
                {
                    DialogResult result = MessageBox.Show("La publicación está pausada, no se puede modificar. Desea activarla?", "Publicación pausada",
                    MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.publicacionTableAdapter1.Fill(this.gD1C2014DataSet.PUBLICACION);

                        DataRow publicacion = gD1C2014DataSet.PUBLICACION.FindByPUB_ID(codigo);
                        publicacion["PUB_ESTADO_ID"] = 'A';

                        publicacionTableAdapter1.Update(gD1C2014DataSet.PUBLICACION);
                        MessageBox.Show("La publicación ha sido activada.");
                        this.Hide();
                        new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
                    }
                    return;
                }
                this.Hide();
                new FrbaCommerce.Editar_Publicacion.Editar(codigo).Show();
            }
        }

    }
}
