using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rol
{
    public partial class BuscarRol : Form
    {
        public BuscarRol()
        {
            InitializeComponent();
        }

        private void BuscarRol_Load(object sender, EventArgs e)
        {
            this.rOLTableAdapter.Fill(this.gD1C2014DataSet1.ROL);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Modificar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rOLTableAdapter.Fill(this.gD1C2014DataSet1.ROL);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rOLTableAdapter.FiltrarNombre(gD1C2014DataSet1.ROL,textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                string nombre_rol = Convert.ToString(fila.Cells[1].Value);
                new FrbaCommerce.Abm_Rol.ModRol(nombre_rol).Show();
                this.Close();
            }
        }
    }
}
