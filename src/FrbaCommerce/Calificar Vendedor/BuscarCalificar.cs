using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class BuscarCalificar : Form
    {
        public string usuario { get; set; }

        public BuscarCalificar(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void BuscarCalificar_Load(object sender, EventArgs e)
        {
            cOMPRAS_SIN_CALIFICARTableAdapter.FillByUsuario(gD1C2014DataSet.COMPRAS_SIN_CALIFICAR, usuario);
            dataGridView1.Columns[1].DefaultCellStyle.NullValue = "Calificar";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                string publicacion = Convert.ToString(fila.Cells[0].Value);
                char tipo_compra = Convert.ToChar(cOMPRAS_SIN_CALIFICARTableAdapter.tipoCompra(publicacion, usuario));
                int compra_id;

                if (tipo_compra == 'S')
                {
                    compra_id = Convert.ToInt32(subastas_ganadoresTableAdapter1.ofertaId(publicacion));
                }
                else
                {
                    compra_id = Convert.ToInt32(compraTableAdapter1.compraId(publicacion,usuario));
                }

                new FrbaCommerce.Calificar_Vendedor.Calificar(compra_id,tipo_compra).Show();
                this.Close();
            }     
        }
    }
}
