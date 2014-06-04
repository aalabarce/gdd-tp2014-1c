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
    public partial class AltaRubro : Form
    {
        public AltaRubro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Valido que el codigo sea int y que no exista en la abse de datos y no este vacio los campos
            if( textBox2.Text=="" || textBox1.Text=="" ){
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            if (!esInteger(textBox1)) {
                return;
            }

            if (Convert.ToInt32(rubroTableAdapter1.existeCodigo(Convert.ToInt32(textBox1.Text))) == 1) {
                MessageBox.Show("Ese codigo de rubro ya existe");
                return;
            }
            
            //Si no tira errores, agrego a la base de datos
            darAlta();

        }

        private void darAlta() {

            
            DataRow nuevo = gD1C2014DataSet1.RUBRO.NewRow();

            nuevo["RUBRO_ID"] = textBox1.Text;
            nuevo["RUBRO_DESCRIPCION"] = textBox2.Text;
            nuevo["RUBRO_BAJA"] = 0;
            
            gD1C2014DataSet1.RUBRO.Rows.Add(nuevo);

            rubroTableAdapter1.Update(gD1C2014DataSet1.RUBRO);
            
            MessageBox.Show("El rubro " + textBox1.Text + " ha sido dada de alta");

            this.Close();
                     
        }



         private bool esInteger(TextBox txt)    {
            int number;

            bool result = Int32.TryParse(txt.Text, out number);
            if (result) {
                return true;
            } 
            else {
                string errores = "El campo " + txt.Tag + " debe ser de tipo numérico";
                MessageBox.Show(errores);
                return false;
            }   
        }

         private void AltaRubro_Load(object sender, EventArgs e)
         {

         }

         private void button2_Click(object sender, EventArgs e)
         {
             this.Close();
         }
    }
}

