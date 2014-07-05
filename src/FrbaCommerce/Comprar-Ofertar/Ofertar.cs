using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Ofertar : Form
    {
        int contador = 0;
        int? maxPaginas, rubro;
        string descripcion;
        decimal rubroId;

        public Ofertar()
        {
            InitializeComponent();
        }

        private void Ofertar_Load(object sender, EventArgs e)
        {

        }

        private void Ofertar_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.OFERTAS_ACTIVAS' Puede moverla o quitarla según sea necesario.
            this.oFERTAS_ACTIVASTableAdapter.Fill(this.gD1C2014DataSet.OFERTAS_ACTIVAS);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Ofertar";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abro el popup
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int publicacionId = Convert.ToInt32(fila.Cells[5].Value);

            new FrbaCommerce.Comprar_Ofertar.RealizarOferta(publicacionId).Show();
        }
    }
}
