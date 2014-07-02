using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Login
{
    public partial class MasDeUno : Form
    {
        public string usuario {get;set;}
        public FrbaCommerce.Login.Login login { get; set; }
        public MasDeUno(FrbaCommerce.Login.Login logTraido)
        {
            InitializeComponent();
            login=logTraido;
            usuario=login.usuario;
            
     
            DataTable roles = new DataTable();
            roles = rolTableAdapter1.getRolesByUsername(usuario);

            for (int i = 0; i < roles.Rows.Count; i++)
            {
         
                comboBox1.Items.Add(roles.Rows[i][1].ToString());
            }
            
   
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
                return;
            }

            MessageBox.Show("Rol chequeado");
            login.exito = true;
            login.rol = comboBox1.SelectedItem.ToString();
            login.Close();
            
         
        }

        private void MasDeUno_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
