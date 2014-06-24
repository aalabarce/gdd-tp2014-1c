using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rubro
{
    public partial class BajaRubro : Form
    {
        public BajaRubro()
        {
            InitializeComponent();
        }

        private void BajaRubro_Load(object sender, EventArgs e)
        {
            this.rUBROTableAdapter.Fill(this.gD1C2014DataSet.RUBRO);
            dataGridView1.Columns[2].DefaultCellStyle.NullValue = "Eliminar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rUBROTableAdapter.Fill(this.gD1C2014DataSet.RUBRO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? codigo = null;
            string desc = null;

            if (textBox1.Text != "")
                codigo = Convert.ToInt32(textBox1.Text);
            if (textBox2.Text != "")
                desc = textBox2.Text;

          //  rUBROTableAdapter.FiltroRubro(gD1C2014DataSet.RUBRO, desc, codigo);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                int cod = Convert.ToInt32(fila.Cells[0].Value);

                DataRow FilaAModificar = gD1C2014DataSet.RUBRO.NewRow();
                FilaAModificar = gD1C2014DataSet.RUBRO.FindByRUBRO_ID(cod);

                FilaAModificar["RUBRO_BAJA"] = 1;

                rUBROTableAdapter.Update(gD1C2014DataSet.RUBRO);
            }
        }
    }
}
