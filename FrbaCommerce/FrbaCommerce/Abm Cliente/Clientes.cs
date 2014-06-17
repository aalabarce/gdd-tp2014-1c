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
            this.cLIENTETableAdapter.FillActivos(this.gD1C2014DataSet.CLIENTE);

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
                new FrbaCommerce.Abm_Cliente.ModifCliente((Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value))).Show();
                this.Close();
            }
            if (e.ColumnIndex == 3)
            {
                
                MessageBox.Show("¿Está seguro que desea eliminar al cliente "+ (dataGridView1.Rows[e.RowIndex].Cells[5]).Value.ToString()+"?\nNúmero de documento: "+ (dataGridView1.Rows[e.RowIndex].Cells[7]).Value.ToString(),"Eliminar Cliente",MessageBoxButtons.YesNo);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // BUSCAR

            string nombre = null;
            string apellido = null;
            string  documento = null;
            string email = null;

            if (textBox1.Text != "")
                nombre = textBox1.Text;
            if (textBox2.Text != "")
                apellido = textBox2.Text;
            if (textBox3.Text != "")
                email = textBox3.Text;
            if (maskedTextBox1.Text != "")
                documento = maskedTextBox1.Text;


            cLIENTETableAdapter.FiltroCliente(gD1C2014DataSet.CLIENTE,nombre,apellido,email); //+DOC +TIPO
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cLIENTETableAdapter.FillActivos(gD1C2014DataSet.CLIENTE);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Cliente.AltaCliente(-1).Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
