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
    public partial class ModifCliente : Form
    {
        public int cliente { get; set; }
        public string entrada;
        public ModifCliente(int clienteId)
        {
            
            InitializeComponent();
            cliente = clienteId;

        }

        private void ModifCliente_Load(object sender, EventArgs e)
        {

            // Cargo los valores que traje de la base de datos
            this.clienteTableAdapter1.Fill(this.gD1C2014DataSet1.CLIENTE);
            DataRow FilaAModificar = gD1C2014DataSet1.CLIENTE.NewRow();
            FilaAModificar = gD1C2014DataSet1.CLIENTE.FindByCLI_ID((int)cliente);

            textBox1.Text = Convert.ToString(FilaAModificar["CLI_NOMBRE"]);
            textBox2.Text = Convert.ToString(FilaAModificar["CLI_APE"]);
            comboBox1.Text = Convert.ToString(FilaAModificar["CLI_TIPO_DOC"]);
            textBox3.Text = Convert.ToString(FilaAModificar["CLI_DOC"]);
            textBox4.Text = Convert.ToString(FilaAModificar["CLI_MAIL"]);
            textBox5.Text = Convert.ToString(FilaAModificar["CLI_TELEFONO"]);
            dateTimePicker1.Value = Convert.ToDateTime(FilaAModificar["CLI_FECHA_NAC"]);
            textBox7.Text = Convert.ToString(FilaAModificar["CLI_COD_POSTAL"]);
            textBox8.Text = Convert.ToString(FilaAModificar["CLI_CALLE"]);
            textBox9.Text = Convert.ToString(FilaAModificar["CLI_PISO"]);
            textBox10.Text = Convert.ToString(FilaAModificar["CLI_DEPTO"]);
            textBox11.Text = Convert.ToString(FilaAModificar["CLI_LOCALIDAD"]);
            textBox6.Text = Convert.ToString(FilaAModificar["CLI_CALLE_NRO"]);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox5.Text!="")
            {
                if (clienteTableAdapter1.ExisteTel(Convert.ToInt32(textBox5.Text))>1)
                {
                MessageBox.Show("Número de teléfono invalido, intente nuevamente");
                return;
                }
            }

            if (Convert.ToInt32(clienteTableAdapter1.ExisteDoc(Convert.ToInt32(textBox3.Text),comboBox1.Text))>1)
            {
                MessageBox.Show("Número de documento o tipo de documento inválido, intente nuevamente");
                return;
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
                return;
            }

            if (!MetodosGlobales.esInteger(textBox3) & textBox3.Text != "" || !MetodosGlobales.esInteger(textBox5) & textBox5.Text != "" || !MetodosGlobales.esInteger(textBox6) & textBox6.Text != "" || !MetodosGlobales.esInteger(textBox7) & textBox7.Text != "" || !MetodosGlobales.esInteger(textBox9) & textBox9.Text != "")
            {
                MessageBox.Show("Alguno de los datos no es del tipo que se requiere");
                return;
            }

            
            
           
            DataRow FilaAModificar = gD1C2014DataSet1.CLIENTE.NewRow();
            FilaAModificar = gD1C2014DataSet1.CLIENTE.FindByCLI_ID((int)cliente);

           
             FilaAModificar["CLI_NOMBRE"] = textBox1.Text;
             FilaAModificar["CLI_APE"]=textBox2.Text;
             FilaAModificar["CLI_TIPO_DOC"] = 1; //comboBox1.Text;
             FilaAModificar["CLI_DOC"]=Convert.ToInt32(textBox3.Text);
             nullear(textBox4.Text, ref entrada);
             FilaAModificar["CLI_MAIL"]=entrada;
             nullear(textBox11.Text, ref entrada);
             FilaAModificar["CLI_LOCALIDAD"] = entrada;
             nullear(textBox5.Text, ref entrada);
             FilaAModificar["CLI_TELEFONO"]=Convert.ToInt32(entrada);
             FilaAModificar["CLI_FECHA_NAC"]=dateTimePicker1.Value;
             nullear(textBox7.Text, ref entrada);
             FilaAModificar["CLI_COD_POSTAL"]=Convert.ToInt32(entrada);
             nullear(textBox8.Text, ref entrada);
             FilaAModificar["CLI_CALLE"] = entrada;
             nullear(textBox9.Text, ref entrada);
             FilaAModificar["CLI_PISO"]=Convert.ToInt32(entrada);
             nullear(textBox10.Text, ref entrada);
             FilaAModificar["CLI_DEPTO"]=entrada;
             nullear(textBox6.Text, ref entrada);
             FilaAModificar["CLI_CALLE_NRO"]=Convert.ToInt32(entrada);
               
       

            clienteTableAdapter1.Update(gD1C2014DataSet1.CLIENTE);

            MessageBox.Show("El cliente " + textBox1.Text + " ha sido modificado");
            clienteTableAdapter1.Fill(gD1C2014DataSet1.CLIENTE);

            new FrbaCommerce.Abm_Cliente.Clientes().Show();
            this.Close();
        }
        
        private void nullear (string texto,ref string entrada)
        {
            if (texto == "")
            {
                entrada = null;
            }
            else
            {
                entrada = texto;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
