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
            this.vISIBILIDADTableAdapter.getOrdenados(this.gD1C2014DataSet.VISIBILIDAD);
            dataGridView1.Columns[5].DefaultCellStyle.NullValue = "Modificar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vISIBILIDADTableAdapter.Fill(gD1C2014DataSet.VISIBILIDAD);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int codigo = Convert.ToInt32(fila.Cells[0].Value);
            new FrbaCommerce.Abm_Visibilidad.ModVi(codigo).Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal? cod = null; 
            string des = null; 
            decimal? pre = null; 
            decimal? por = null;
            int? dur = null;

            if (textBox1.Text != "")
                cod = Convert.ToDecimal(textBox1.Text);
            if (textBox2.Text != "")
                des = textBox2.Text;
            if (textBox3.Text != "")
                pre = Convert.ToDecimal(textBox3.Text);
            if (textBox4.Text != "")
                por = Convert.ToDecimal(textBox4.Text);
            if (textBox5.Text != "")
                dur = Convert.ToInt32(textBox5.Text);


            vISIBILIDADTableAdapter.Filtrar(gD1C2014DataSet.VISIBILIDAD, cod, des, pre, por, dur);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            vISIBILIDADTableAdapter.Fill(gD1C2014DataSet.VISIBILIDAD);
        }

 
    }
}
