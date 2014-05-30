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

        
        public Alta()
        {
            InitializeComponent();
        }

        private void gD1C2014DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea volver? Perdera todos los datos cargados hasta ahora", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                // TODO: Volver a la pantalla anterior (no está hecha)
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* VALIDO */
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
                return;
            }
            
            if (!esInteger(textBox3) || !esInteger(textBox5) || !esInteger(textBox6))
            {
                return;
            }
            // Si está todo bien, le pego a la base de datos
            persistir();
        }

        private void persistir()
        {
           DataRow empresa = gD1C2014DataSet1.EMPRESA.NewRow();
          
           // if (esInteger(textBox1))
           empresa["EMP_RAZON_SOCIAL"] = textBox1.Text;
           empresa["EMP_MAIL"] = textBox2.Text;
           empresa["EMP_TELEFONO"] = textBox3.Text;
           empresa["EMP_CALLE"] = textBox4.Text;
           empresa["EMP_CALLE_NRO"] = textBox5.Text;
           empresa["EMP_PISO"] = textBox6.Text;
           empresa["EMP_DPTO"] = textBox7.Text;
           empresa["EMP_LOCALIDAD"] = textBox8.Text;
           empresa["EMP_COD_POSTAL"] = textBox9.Text;
           empresa["EMP_CIUDAD"] = textBox10.Text;
           empresa["EMP_CUIT"] = textBox11.Text;
           empresa["EMP_NOM_CONTACTO"] = textBox12.Text;
           empresa["EMP_FECHA_CREACION"] = DateTime.Now;

           gD1C2014DataSet1.EMPRESA.Rows.Add(empresa);

           empresaTableAdapter1.Update(gD1C2014DataSet1.EMPRESA);

           string mensaje = "La empresa " + textBox1.Text + " ha sido dada de alta";
           MessageBox.Show(mensaje);
            
        }

        private bool esInteger(TextBox txt)
        {
            int number;

            bool result = Int32.TryParse(txt.Text, out number);
            if (result)
                return true;
            else
            {
                string errores = "El campo " + txt.Tag + " debe ser de tipo numérico";
                MessageBox.Show(errores);
                return false;
            }   
        }




    }
}
