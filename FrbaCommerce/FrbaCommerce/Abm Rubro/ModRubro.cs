using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rubro
{
    public partial class ModRubro : Form
    {

        public int codigo { get; set; }

        public ModRubro(int codigo_mod)
        {
            InitializeComponent();
            codigo = codigo_mod;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Valido que el codigo sea int y que no exista en la abse de datos y no este vacio los 2 campos
            if (textBox2.Text == "" )
            {
                MessageBox.Show("Debe completar por lo menos 1 campo");
                return;
            }

            DataRow FilaAModificar = gD1C2014DataSet1.RUBRO.NewRow();

            FilaAModificar = gD1C2014DataSet1.RUBRO.FindByRUBRO_ID(codigo);
            /*
                 DataRow ModifFila = gD2C2013DataSet1.PERSONAL_DATOS.NewRow(); 
             * ModifFila = gD2C2013DataSet1.PERSONAL_DATOS.FindByPERSDAT_CODIGO(profesional.codigo); 
             * ModifFila["PERSDAT_TIPO_DOC"] = textBox3.Text;
            */
            MessageBox.Show(Convert.ToString(FilaAModificar["RUBRO_ID"]) + " 2");

           
            if(textBox2.Text!="") {
                FilaAModificar["RUBRO_DESCRIPCION"] = textBox2.Text; 
            }

            rubroTableAdapter1.Update(gD1C2014DataSet1.RUBRO);
        }
     
        private bool esInteger(TextBox txt)
        {
            int number;

            bool result = Int32.TryParse(txt.Text, out number);
            if (result)
            {
                return true;
            }
            else
            {
                string errores = "El campo " + txt.Tag + " debe ser de tipo numérico";
                MessageBox.Show(errores);
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModRubro_Load(object sender, EventArgs e)
        {
            this.rubroTableAdapter1.Fill(this.gD1C2014DataSet1.RUBRO);
        }
    }
}
