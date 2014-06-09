using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            empresaTableAdapter1.FiltrarBaja(gD1C2014DataSet1.EMPRESA);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Modificar";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BUSCAR

            string razonSocial = null;
            string cuit = null;
            string email = null;

            if (textBox1.Text != "")
                razonSocial = textBox1.Text;
            if (textBox2.Text != "")
                cuit = textBox2.Text;
            if (textBox3.Text != "")
                email = textBox3.Text;

            empresaTableAdapter1.FiltroEmpresa(gD1C2014DataSet1.EMPRESA, razonSocial, cuit, email);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // LIMPIAR
            empresaTableAdapter1.FiltrarBaja(gD1C2014DataSet1.EMPRESA);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Abro el popup
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells[4].Value);
            new FrbaCommerce.Abm_Empresa.PopupModificacion(id).Show();
        }
    }
}
