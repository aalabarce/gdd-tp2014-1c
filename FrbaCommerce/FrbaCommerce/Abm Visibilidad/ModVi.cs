using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Abm_Visibilidad;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class ModVi : Form
    {

        public int codigo { get; set; }

        public ModVi(int codigo_mod)
        {
            InitializeComponent();
            codigo = codigo_mod;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModVi_Load(object sender, EventArgs e)
        {
            this.visibilidadTableAdapter1.Fill(this.gD1C2014DataSet1.VISIBILIDAD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Valido que no dejen campos vacios
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }



            //Valido que los tipos de datos sean correctos
      /*      if (!AltaVi.esInteger(textBox1.Text))               
            {
                return;
            }

*/
                    //Valido que el codigo no exista
        /* if (Convert.ToInt32(visibilidadTableAdapter1.existeCodigo(Convert.ToInt32(textBox1.Text))) == 1)
         {
             MessageBox.Show("Ese codigo de rubro ya existe");
             return;
         }*/


            //Si hay errores, agrego a la base de datos
            modificar();

        }
      
        private void modificar()
        {
            DataRow nuevo = gD1C2014DataSet1.VISIBILIDAD.NewRow();
            if(textBox1.Text != "")
            nuevo["VIS_CODIGO"] = textBox1.Text;
            if (textBox2.Text != "")
            nuevo["VIS_DESCRIPCION"] = textBox2.Text;
            if (textBox3.Text != "")
            nuevo["VIS_PRECIO"] = textBox3.Text;
            if (textBox4.Text != "")
            nuevo["VIS_PORCENTAJE"] = textBox4.Text;

            gD1C2014DataSet1.VISIBILIDAD.Rows.Add(nuevo);

            visibilidadTableAdapter1.Update(gD1C2014DataSet1.VISIBILIDAD);

            MessageBox.Show("La visibilidad " + textBox1.Text + " ha sido dada de alta");

            this.Close();

        }
    }
}
