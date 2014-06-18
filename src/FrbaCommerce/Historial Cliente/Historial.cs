using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Historial : Form
    {
        public string usuario { get; set; }

        public Historial(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sUBASTAS_USUARIOSTableAdapter.FillByUsuario(gD1C2014DataSet1.SUBASTAS_USUARIOS,usuario);
            cOMPRAS_DIRECTAS_USUARIOSTableAdapter.FillByUsuario(gD1C2014DataSet1.COMPRAS_DIRECTAS_USUARIOS, usuario);

            dataGridView2.Visible = false;
            comboBox1.Items.Add("Compras directas");
            comboBox1.Items.Add("Subastas");
            comboBox1.Text = "Compras directas";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Compras directas")
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
            else
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
            }
        }
    }
}

