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

        private void button1_Click(object sender, EventArgs e)
        {
            string razonSocial = null;
            string cuit = null;
            int? telefono = null;

            if (textBox1.Text != "")
                razonSocial = textBox1.Text;
            if (textBox2.Text != "")
                cuit = textBox2.Text;
            if (textBox3.Text != "")
                telefono = Convert.ToInt32(textBox3.Text);

            empresaTableAdapter1.FiltroEmpresa(gD1C2014DataSet1.EMPRESA, razonSocial, cuit, telefono);      
        }
    }
}
