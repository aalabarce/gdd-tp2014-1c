using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.gD1C2014DataSet.CLIENTE);

            dataGridView1.Columns[1].DefaultCellStyle.NullValue = "Ver Completo";
            dataGridView1.Columns[2].DefaultCellStyle.NullValue = "Modificar";
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Eliminar";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                MessageBox.Show("ABRIR FICHA DE CONSULTA");
            }
            if (e.ColumnIndex == 2)
            {
                MessageBox.Show("ABRIR FORMULARIO DE MODIFICACIÓN");
            }
            if (e.ColumnIndex == 3)
            {
                
                MessageBox.Show("¿Está seguro que desea eliminar al cliente "+ (dataGridView1.Rows[e.RowIndex].Cells[5]).Value.ToString()+"?\nNúmero de documento: "+ (dataGridView1.Rows[e.RowIndex].Cells[7]).Value.ToString(),"Eliminar Cliente",MessageBoxButtons.YesNo);
            }
        }
    }
}
