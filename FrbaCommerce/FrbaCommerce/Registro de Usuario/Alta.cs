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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string password = textBox2.Text;
            char tipo;
            if (radioButton1.Checked)
            {
               tipo = 'E';
            }
            else
            {
                tipo = 'C';
            }

            string passSHA = MetodosGlobales.sha256(textBox2.Text);
            

            DataRow nuevoUsuario = gD1C2014DataSet1.USUARIO.NewRow();
            nuevoUsuario["USU_USERNAME"] = textBox1.Text;
            nuevoUsuario["USU_PASSWORD"] = passSHA;
            nuevoUsuario["USU_TIPO"] = tipo;
            nuevoUsuario["USU_INTENTOS_LOGIN"] = 0;
            nuevoUsuario["USU_BAJA"] = 0;

            gD1C2014DataSet1.USUARIO.Rows.Add(nuevoUsuario);

            usuarioTableAdapter1.Update(gD1C2014DataSet1.USUARIO);

            int? id = usuarioTableAdapter1.get_id_by_username(textBox1.Text);

            if (radioButton1.Checked)
                new FrbaCommerce.Abm_Empresa.Alta(id).Show();
            //else
                //new FrbaCommerce.Abm_Cliente.AltaCliente().Show();
            this.Close();
        }
    }
}
