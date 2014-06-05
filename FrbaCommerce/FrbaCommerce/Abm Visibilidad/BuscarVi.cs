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
    public partial class BuscarVi : Form
    {
        public BuscarVi()
        {
            InitializeComponent();
        }

        private void BuscarVi_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.VISIBILIDAD' Puede moverla o quitarla según sea necesario.
            this.vISIBILIDADTableAdapter.Fill(this.gD1C2014DataSet.VISIBILIDAD);
            dataGridView1.Columns[4].DefaultCellStyle.NullValue = "Modificar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vISIBILIDADTableAdapter.Fill(gD1C2014DataSet.VISIBILIDAD);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int codigo = Convert.ToInt32(fila.Cells[0].Value);
            new FrbaCommerce.Abm_Visibilidad.ModVi(codigo);
            dataGridView1.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GD1C2014DataSet.VISIBILIDADDataTable filtrada = gD1C2014DataSet.VISIBILIDAD;

            if (textBox1.Text != "")
                vISIBILIDADTableAdapter.FiltrarCod(filtrada, Convert.ToDecimal(textBox1.Text));
            if (textBox2.Text != "")
                vISIBILIDADTableAdapter.FiltrarDes(filtrada, textBox2.Text);
            if (textBox3.Text != "")
                vISIBILIDADTableAdapter.FiltrarPre(filtrada, Convert.ToDecimal(textBox3.Text));
            if (textBox4.Text != "")
                vISIBILIDADTableAdapter.FiltrarPor(filtrada, Convert.ToDecimal(textBox4.Text));

        }
    }
}
