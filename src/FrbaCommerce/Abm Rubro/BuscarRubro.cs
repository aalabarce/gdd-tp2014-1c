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
    public partial class BuscarRubro : Form
    {
              
        public BuscarRubro()
        {
            InitializeComponent();
        }

        private void BuscarRubro_Load(object sender, EventArgs e)
        {
            this.rUBROTableAdapter.Fill(this.gD1C2014DataSet.RUBRO);
            dataGridView1.Columns[2].DefaultCellStyle.NullValue = "Modificar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? codigo = null;
            string desc = null;

            if (textBox1.Text != "")            
                codigo = Convert.ToInt32(textBox1.Text);            
            if (textBox2.Text != "")            
                desc = textBox2.Text;            
            
            rUBROTableAdapter.FiltroRubro(gD1C2014DataSet.RUBRO, desc, codigo);
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            rUBROTableAdapter.Fill(gD1C2014DataSet.RUBRO);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int cod = Convert.ToInt32(fila.Cells[0].Value);
            new FrbaCommerce.Abm_Rubro.ModRubro(cod).Show();
            this.Close();
        }
    }
}
