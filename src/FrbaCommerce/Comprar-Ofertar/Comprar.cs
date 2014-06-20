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
    public partial class Comprar : Form
    {
        int contador = 0;
        public Comprar()
        {
            InitializeComponent();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            publicacionTableAdapter1.ComprasActivas(gD1C2014DataSet1.PUBLICACION);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Comprar";
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            // Abro el popup
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int usuarioId = Convert.ToInt32(fila.Cells[4].Value);           
            string tipo = usuarioTableAdapter1.getTipoUsuarioPorId(usuarioId);
            int publicacionId = Convert.ToInt32(fila.Cells[5].Value);

            new FrbaCommerce.Comprar_Ofertar.VerPublicacion(usuarioId, tipo, publicacionId).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FILTRAR
            MessageBox.Show("EN DESARROLLO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // LIMPIAR
            MessageBox.Show("EN DESARROLLO");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
