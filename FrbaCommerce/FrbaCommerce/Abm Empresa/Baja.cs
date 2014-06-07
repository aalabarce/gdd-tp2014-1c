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
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void Baja_Load(object sender, EventArgs e)
{
            empresaTableAdapter1.FiltrarBaja(gD1C2014DataSet1.EMPRESA);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Eliminar";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells[4].Value);
            string razonSocial = Convert.ToString(fila.Cells[0].Value);

            DataRow FilaAModificar = gD1C2014DataSet1.EMPRESA.NewRow();
            FilaAModificar = gD1C2014DataSet1.EMPRESA.FindByEMP_ID(id);
         
            FilaAModificar["EMP_BAJA"] = 1;

            empresaTableAdapter1.Update(gD1C2014DataSet1.EMPRESA);

            MessageBox.Show("La empresa " + razonSocial + " ha sido eliminada");

            empresaTableAdapter1.FiltrarBaja(gD1C2014DataSet1.EMPRESA);
        
        }
    }
}
