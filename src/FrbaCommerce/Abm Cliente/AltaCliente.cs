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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? usu_id;


            if (textBox5.Text != "")
            {
                if (clienteTableAdapter1.ExisteTel(Convert.ToInt32(textBox5.Text)) > 0)
                {
                    MessageBox.Show("Número de teléfono invalido, intente nuevamente");
                    return;
                }
            }

            if (Convert.ToInt32(clienteTableAdapter1.ExisteDoc(Convert.ToInt32(textBox3.Text), comboBox1.Text)) > 0)
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




            DataRow ClienteNuevo = gD1C2014DataSet1.CLIENTE.NewRow();
            DataRow UsuarioNuevo = gD1C2014DataSet1.USUARIO.NewRow();
            DataRow UsuRolNuevo = gD1C2014DataSet1.USUARIO_ROL.NewRow();


            ClienteNuevo["CLI_NOMBRE"] = textBox1.Text;
            ClienteNuevo["CLI_APE"] = textBox2.Text;
            ClienteNuevo["CLI_TIPO_DOC"] = 1; //SeleComb
            ClienteNuevo["CLI_DOC"] = Convert.ToInt32(textBox3.Text);
            nullear(textBox4.Text, ref entrada);
            ClienteNuevo["CLI_MAIL"] = entrada;
            nullear(textBox11.Text, ref entrada);
            ClienteNuevo["CLI_LOCALIDAD"] = entrada;
            nullear(textBox5.Text, ref entrada);
            ClienteNuevo["CLI_TELEFONO"] = Convert.ToInt32(entrada);
            ClienteNuevo["CLI_FECHA_NAC"] = dateTimePicker1.Value;
            nullear(textBox7.Text, ref entrada);
            ClienteNuevo["CLI_COD_POSTAL"] = Convert.ToInt32(entrada);
            nullear(textBox8.Text, ref entrada);
            ClienteNuevo["CLI_CALLE"] = entrada;
            nullear(textBox9.Text, ref entrada);
            ClienteNuevo["CLI_PISO"] = Convert.ToInt32(entrada);
            nullear(textBox10.Text, ref entrada);
            ClienteNuevo["CLI_DEPTO"] = entrada;
            nullear(textBox6.Text, ref entrada);
            ClienteNuevo["CLI_CALLE_NRO"] = Convert.ToInt32(entrada);
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


            new FrbaCommerce.Abm_Cliente.Clientes().Show();
            this.Close();
        }

        private void nullear(string texto, ref string entrada)
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

    }
}
