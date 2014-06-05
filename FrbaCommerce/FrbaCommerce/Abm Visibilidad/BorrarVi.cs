using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class BorrarVi : Form
    {
        public BorrarVi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BorrarVi_Load(object sender, EventArgs e)
        {
            visibilidadTableAdapter1.Fill(gD1C2014DataSet.VISIBILIDAD);
            dataGridView1.Columns[4].DefaultCellStyle.NullValue = "Eliminar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visibilidadTableAdapter1.Fill(gD1C2014DataSet.VISIBILIDAD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GD1C2014DataSet.VISIBILIDADDataTable filtrada = gD1C2014DataSet.VISIBILIDAD;
            
            if (textBox1.Text != "")
                visibilidadTableAdapter1.FiltrarCod(filtrada, Convert.ToDecimal(textBox1.Text));
            if (textBox2.Text!="")
                visibilidadTableAdapter1.FiltrarDes(filtrada,textBox2.Text);
            if (textBox3.Text != "")
                visibilidadTableAdapter1.FiltrarPre(filtrada, Convert.ToDecimal(textBox3.Text));
            if (textBox4.Text != "")
                visibilidadTableAdapter1.FiltrarPor(filtrada, Convert.ToDecimal(textBox4.Text));

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int codigo = Convert.ToInt32(fila.Cells[0].Value);

            decimal id = Convert.ToDecimal(visibilidadTableAdapter1.BuscarID(codigo));
 
            DataRow FilaAModificar = gD1C2014DataSet.VISIBILIDAD.NewRow();
            FilaAModificar = gD1C2014DataSet.VISIBILIDAD.FindByVIS_ID(id);
         
            FilaAModificar["VIS_BAJA"] = 1; 

            visibilidadTableAdapter1.Update(gD1C2014DataSet.VISIBILIDAD);

            MessageBox.Show("La visibilidad " + codigo + " ha sido eliminada");

            visibilidadTableAdapter1.Fill(gD1C2014DataSet.VISIBILIDAD);
        }

    }
}
