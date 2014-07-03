using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            this.rOLTableAdapter.FillByActivos(this.gD1C2014DataSet1.ROL);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == ""){
                MessageBox.Show("Ingrese usuario y password");
                return;
            }

            if (textBox2.Text == "1234")
            {
                MessageBox.Show("Introduzca una contraseña valida");
                return;
            }

            if (usuarioTableAdapter1.existeUsuario(textBox1.Text) == 1)
            {
                MessageBox.Show("El nombre de usuario es inválido");
                return;
            }

            string usuario = textBox1.Text;
            string password = textBox2.Text;
            DataRowView rolElegido = (DataRowView)comboBox1.SelectedItem;
      
            string passSHA = MetodosGlobales.sha256(textBox2.Text);
            
            DataRow nuevoUsuario = gD1C2014DataSet1.USUARIO.NewRow();
            nuevoUsuario["USU_USERNAME"] = textBox1.Text;
            nuevoUsuario["USU_PASSWORD"] = passSHA;
            nuevoUsuario["USU_INTENTOS_LOGIN"] = 0;
            nuevoUsuario["USU_BAJA"] = 0;


            if  ((rolElegido["ROL_NOMBRE"].ToString())=="Empresa")
            {
                nuevoUsuario["USU_TIPO"] = 'E';
            }
            else if ((rolElegido["ROL_NOMBRE"].ToString()) == "Cliente")
            {
                nuevoUsuario["USU_TIPO"] = 'C';
            }
            else
            {
                nuevoUsuario["USU_TIPO"] = DBNull.Value;
            }


            gD1C2014DataSet1.USUARIO.Rows.Add(nuevoUsuario);
            usuarioTableAdapter1.Update(gD1C2014DataSet1.USUARIO);
            int? id = usuarioTableAdapter1.get_id_by_username(textBox1.Text);
            DataRow nuevoUsuRol = gD1C2014DataSet1.USUARIO_ROL.NewRow();
            nuevoUsuRol["USU_ROL_USUARIO_ID"] = id;
            nuevoUsuRol["USU_ROL_ROL_ID"] = rolElegido["ROL_ID"];


            if ((rolElegido["ROL_NOMBRE"].ToString()) == "Empresa")
            {
                new FrbaCommerce.Abm_Empresa.Alta(id).Show();
            }
            else if ((rolElegido["ROL_NOMBRE"].ToString()) == "Cliente")
            {
                new FrbaCommerce.Abm_Cliente.AltaCliente(id).Show();
            }

            this.Close();
        }
    }
}
