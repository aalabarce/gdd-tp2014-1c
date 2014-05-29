using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Alta : Form
    {

        public DataRow nuevaEmpresa;

        public Alta()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gD1C2014DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro que desea volver? Perdera todos los datos cargados hasta ahora.")
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*VALIDAD QUE LOS CAMPOS NO SEAN NULL, EXCEPTO EL SEXO, TELEFONO Y EMAIL */
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
                return;
            }

            persistir();
        }

        private void persistir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO sometable VALUES(@text1,@text2)");

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand(sb.ToString());
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("text1", text1.Text);
            command.Parameters.AddWithValue("text2", text2.Text);
            command.ExecuteNonQuery();

        }



    }
}
