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
    public partial class AltaCliente : Form
    {
        public string entrada;
        public int? parametro_id { get; set; }

        public AltaCliente(int? user)
        {
            InitializeComponent();
            parametro_id = user;
            comboBox1.Items.Add("DNI");
            comboBox1.Items.Add("CI");
            comboBox1.Items.Add("LE");
            comboBox1.Items.Add("LC");
            comboBox1.Items.Add("C.EXT");
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            usuarioTableAdapter1.Fill(gD1C2014DataSet1.USUARIO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? usu_id;

            //Valido que complete todos los campos menos piso y depto q son optativos
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
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

            //Valido que el documento sea unico
            if (Convert.ToInt32(clienteTableAdapter1.ExisteDoc(Convert.ToInt32(textBox3.Text),(comboBox1.SelectedIndex+1).ToString())) > 0)
            {
                MessageBox.Show("Número de documento o tipo de documento inválido, intente nuevamente");
                return;
            }

            
            DataRow ClienteNuevo = gD1C2014DataSet1.CLIENTE.NewRow();
            DataRow UsuarioNuevo = gD1C2014DataSet1.USUARIO.NewRow();
            DataRow UsuRolNuevo = gD1C2014DataSet1.USUARIO_ROL.NewRow();


            ClienteNuevo["CLI_NOMBRE"] = textBox1.Text;
            ClienteNuevo["CLI_APE"] = textBox2.Text;
            if (comboBox1.SelectedIndex != -1)
                ClienteNuevo["CLI_TIPO_DOC"] = (comboBox1.SelectedIndex + 1).ToString();
            else
                ClienteNuevo["CLI_TIPO_DOC"] = 1;
            ClienteNuevo["CLI_DOC"] = Convert.ToInt32(textBox3.Text);
            ClienteNuevo["CLI_MAIL"] = textBox4.Text;
            ClienteNuevo["CLI_LOCALIDAD"] = textBox11.Text;
            ClienteNuevo["CLI_TELEFONO"] = Convert.ToInt32(textBox5.Text);
            ClienteNuevo["CLI_FECHA_NAC"] = dateTimePicker1.Value;
            ClienteNuevo["CLI_COD_POSTAL"] = textBox7.Text;
            ClienteNuevo["CLI_CALLE"] = textBox8.Text;
            if (textBox9.Text != "")
                ClienteNuevo["CLI_PISO"] = Convert.ToInt32(textBox9.Text);
            if(textBox10.Text!="")
                ClienteNuevo["CLI_DEPTO"] = textBox10.Text;
            ClienteNuevo["CLI_CALLE_NRO"] = Convert.ToInt32(textBox6.Text);
            ClienteNuevo["CLI_BAJA"] = 0;

            if (parametro_id == -1)
            {
                UsuRolNuevo["USU_ROL_ROL_ID"] = 1;

                UsuarioNuevo["USU_USERNAME"] = textBox3.Text;
                UsuarioNuevo["USU_PASSWORD"] = MetodosGlobales.sha256("1234");
                UsuarioNuevo["USU_INTENTOS_LOGIN"] = 0;
                UsuarioNuevo["USU_TIPO"] = 'C';
                UsuarioNuevo["USU_BAJA"] = 0;
                gD1C2014DataSet1.USUARIO.Rows.Add(UsuarioNuevo);
                usuarioTableAdapter1.Update(gD1C2014DataSet1.USUARIO);

                usu_id = usuarioTableAdapter1.get_id_by_username(textBox3.Text);
                MessageBox.Show(usu_id.ToString());
                ClienteNuevo["CLI_USU_ID"] = usu_id;
                UsuRolNuevo["USU_ROL_USUARIO_ID"] = usu_id;
                gD1C2014DataSet1.USUARIO_ROL.Rows.Add(UsuRolNuevo);
                usuariO_ROLTableAdapter1.Update(gD1C2014DataSet1.USUARIO_ROL);
            }
            else
            {
                ClienteNuevo["CLI_USU_ID"] = parametro_id;
            }

            gD1C2014DataSet1.CLIENTE.Rows.Add(ClienteNuevo);
            clienteTableAdapter1.Update(gD1C2014DataSet1.CLIENTE);


            MessageBox.Show("El cliente " + textBox1.Text + " ha sido dado de alta");
            clienteTableAdapter1.Fill(gD1C2014DataSet1.CLIENTE);

            new FrbaCommerce.Login.Login().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (parametro_id == -1)
            {
                new FrbaCommerce.Abm_Cliente.Clientes(3).Show();
                this.Close();
            }
            else
            {
                DataRow FilaABorrar = gD1C2014DataSet1.USUARIO.NewRow();
                FilaABorrar = gD1C2014DataSet1.USUARIO.FindByUSU_ID((int)parametro_id);
                
                FilaABorrar.Delete();
                usuarioTableAdapter1.Update(gD1C2014DataSet1.USUARIO);

                new Registro_de_Usuario.Alta().Show();
                this.Close();
            }
        }
    }
}
