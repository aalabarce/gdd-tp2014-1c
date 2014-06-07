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
            this.empresaTableAdapter1.Fill(this.gD1C2014DataSet1.EMPRESA);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet nuevoDS = empresaTableAdapter1.FiltroEmpresa(gD1C2014DataSet1.EMPRESA, textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            this.empresaTableAdapter1.Fill(nuevoDS);
        }
    }
}
