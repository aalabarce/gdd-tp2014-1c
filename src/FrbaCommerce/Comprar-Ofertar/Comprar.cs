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
        int? maxPaginas, rubro;
        string descripcion;
        decimal rubroId;
        public Comprar()
        {
            InitializeComponent();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            this.rUBROTableAdapter.Fill(this.gD1C2014DataSet1.RUBRO);
            comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, 0, 0, "");
            maxPaginas = (int?)publicacionTableAdapter1.maxPaginas();
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
            DataRowView r = (DataRowView)comboBox1.SelectedItem;
            int rId = (int)r["RUBRO_ID"];            
            rubroId = (decimal)rId;
            rubro = (int?)rubroId;
            descripcion = textBox2.Text;
            maxPaginas = (int?)publicacionTableAdapter1.maxPaginasRubro(descripcion,rubroId);
            comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // LIMPIAR
            rubro = null;
            descripcion = "";
            maxPaginas = (int?)publicacionTableAdapter1.maxPaginas();
            comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Siguiente pagina
            contador = contador + 10;
            if (contador <= maxPaginas)
            {
                comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
            }
            else
            {
                contador = (int)maxPaginas;
                comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Primera pagina
            contador = 0;
            comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Pagina anterior
            contador = contador - 10;
            if (contador >= 0)
            {
                comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
            }
            else
            {
                contador = 0;
                comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Ultima pagina
            contador = (int)maxPaginas;
            comprasLIMIT1TableAdapter1.Fill(gD1C2014DataSet1.ComprasLIMIT1, contador, rubro, descripcion);
        }
    }
}
