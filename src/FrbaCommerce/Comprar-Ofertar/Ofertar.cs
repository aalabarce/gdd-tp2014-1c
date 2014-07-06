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
        int? maxPaginas, rubro = null;
        string descripcion = "";
        decimal rubroId;
        public Ofertar()
        {
            InitializeComponent();
        }

        private void Ofertar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.RUBRO' Puede moverla o quitarla según sea necesario.
            this.rUBROTableAdapter.Fill(this.gD1C2014DataSet.RUBRO);
            this.ofertasLIMITTableAdapter1.Fill(this.gD1C2014DataSet.OfertasLIMIT, 0, null, "", Global.usuario_id);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Ofertar";
            maxPaginas = (int?)publicacionTableAdapter1.maxPaginasOfertas(Global.usuario_id);  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SIGUIENTE
            contador = contador + 10;
            if (contador <= maxPaginas)
            {
                ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
            }
            else
            {
                contador = (int)maxPaginas;
                ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // ULTIMA PAGINA
            contador = (int)maxPaginas;
            ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ANTERIOR
            contador = contador - 10;
            if (contador >= 0)
            {
                ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
            }
            else
            { 
                contador = 0;
                ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // PRIMERA PAGINA
            contador = 0;
            ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int publicacionId = Convert.ToInt32(fila.Cells[5].Value);
            int cantidadComprasSinCalificar;
            string estadoPublicacion;
            estadoPublicacion = (string)publicacionTableAdapter1.getEstadoByPubId(publicacionId);
            cantidadComprasSinCalificar = (int)compraTableAdapter1.cantidadComprasSinCalificar(Global.usuario_id);
            if (estadoPublicacion == "P")
            {
                MessageBox.Show("No se puede comprar esta publicacion, su estado es 'Pausado'");
                return;
            }

            if (cantidadComprasSinCalificar >= 5)
            {
                MessageBox.Show("No se puede comprar esta publicacion debido a que tiene 5 o más compras sin calificar");
                return;

            }
            new FrbaCommerce.Comprar_Ofertar.RealizarOferta(publicacionId).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FILTRAR

            DataRowView r = (DataRowView)comboBox1.SelectedItem;
            int rId = (int)r["RUBRO_ID"];
            rubroId = (decimal)rId;
            rubro = (int?)rubroId;
            descripcion = textBox2.Text;

            maxPaginas = (int?)publicacionTableAdapter1.maxPaginasRubroOfertas(descripcion, rubroId, Global.usuario_id);
            ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rubro = null;
            descripcion = "";
            maxPaginas = (int?)publicacionTableAdapter1.maxPaginasOfertas(Global.usuario_id);
            ofertasLIMITTableAdapter1.Fill(gD1C2014DataSet.OfertasLIMIT, contador, rubro, descripcion, Global.usuario_id);
        }
    }
}
