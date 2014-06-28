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

            comboBox1.Items.Add("DNI");
            comboBox1.Items.Add("CI");
            comboBox1.Items.Add("LE");
            comboBox1.Items.Add("LC");
            comboBox1.Items.Add("C.EXT");

            textBox1.Text = Convert.ToString(FilaAModificar["CLI_NOMBRE"]);
            textBox2.Text = Convert.ToString(FilaAModificar["CLI_APE"]);
            comboBox1.SelectedIndex = Convert.ToInt32(FilaAModificar["CLI_TIPO_DOC"])-1;
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

        private void button1_Click(object sender, EventArgs e)
        {

            //Valido que complete todos los campos menos piso y depto q son optativos
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios, exceptuando Piso y Departamento");
                return;
            }

            //Valido el tipo de datos
            if (!MetodosGlobales.esInteger(textBox3) || !MetodosGlobales.esInteger(textBox5) || !MetodosGlobales.esInteger(textBox6))
            {
                return;
            }

            //Valido el tipo de dato del piso solo si es vive en depto
            if (textBox9.Text != "" && !MetodosGlobales.esInteger(textBox9))
            {
                return;
            }

            //Valido que el telefono sea unico
            if (clienteTableAdapter1.ExisteTel(Convert.ToInt32(textBox5.Text)) > 0)
            {
                MessageBox.Show("Número de teléfono invalido, intente nuevamente");
                return;
            }
                                    
           
            DataRow FilaAModificar = gD1C2014DataSet1.CLIENTE.NewRow();
            FilaAModificar = gD1C2014DataSet1.CLIENTE.FindByCLI_ID((int)cliente);

            //Valido que el documento sea unico
            if (Convert.ToString(FilaAModificar["CLI_DOC"]) != textBox3.Text)
            {
                MessageBox.Show("entre");
                if (Convert.ToInt32(clienteTableAdapter1.ExisteDoc(Convert.ToInt32(textBox3.Text), (comboBox1.SelectedIndex + 1).ToString())) > 0)
                {
                    MessageBox.Show("Número de documento o tipo de documento inválido, intente nuevamente");
                    return;
                }
            }

            //Guardo todos los datos
            FilaAModificar["CLI_NOMBRE"] = textBox1.Text;
            FilaAModificar["CLI_APE"] = textBox2.Text;
            if (comboBox1.SelectedIndex != -1)
                FilaAModificar["CLI_TIPO_DOC"] = (comboBox1.SelectedIndex + 1).ToString();
            else
                FilaAModificar["CLI_TIPO_DOC"] = 1;
            FilaAModificar["CLI_DOC"] = Convert.ToInt32(textBox3.Text);
            FilaAModificar["CLI_MAIL"] = textBox4.Text;
            FilaAModificar["CLI_LOCALIDAD"] = textBox11.Text;
            FilaAModificar["CLI_TELEFONO"] = Convert.ToInt32(textBox5.Text);
            FilaAModificar["CLI_FECHA_NAC"] = dateTimePicker1.Value;
            FilaAModificar["CLI_COD_POSTAL"] = textBox7.Text;
            FilaAModificar["CLI_CALLE"] = textBox8.Text;
            if (textBox9.Text != "")
                FilaAModificar["CLI_PISO"] = Convert.ToInt32(textBox9.Text);
            else
                FilaAModificar["CLI_PISO"] = DBNull.Value;
            if (textBox10.Text != "")
                FilaAModificar["CLI_DEPTO"] = textBox10.Text;
            else
                FilaAModificar["CLI_DEPTO"] = DBNull.Value;
            FilaAModificar["CLI_CALLE_NRO"] = Convert.ToInt32(textBox6.Text);
            FilaAModificar["CLI_BAJA"] = 0;
            
            clienteTableAdapter1.Update(gD1C2014DataSet1.CLIENTE);

            MessageBox.Show("El cliente " + textBox1.Text + " ha sido modificado");
            clienteTableAdapter1.Fill(gD1C2014DataSet1.CLIENTE);

            new FrbaCommerce.Abm_Cliente.Clientes(1).Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
