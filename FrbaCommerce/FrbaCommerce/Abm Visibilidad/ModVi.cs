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
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Debe completar por lo menos 1 campo");
                return;
            }



            //Valido que los tipos de datos sean correctos
            //LOS 3 NUMERIC




         //Valido que el codigo no exista
         if (textBox1.Text !="" && Convert.ToInt32(visibilidadTableAdapter1.existeCod(Convert.ToDecimal(textBox1.Text))) >0)
         {
             MessageBox.Show("Ese codigo de rubro ya existe");
             return;
         }


            //Si hay errores, agrego a la base de datos
            modificar();

        }
      
        private void modificar()
        {
            decimal id = Convert.ToDecimal(visibilidadTableAdapter1.BuscarID(codigo));
            DataRow FilaAModificar = gD1C2014DataSet1.VISIBILIDAD.NewRow();
            FilaAModificar = gD1C2014DataSet1.VISIBILIDAD.FindByVIS_ID(id);

            if(textBox1.Text != "")
                FilaAModificar["VIS_CODIGO"] = textBox1.Text;
            if (textBox2.Text != "")
                FilaAModificar["VIS_DESCRIPCION"] = textBox2.Text;
            if (textBox3.Text != "")
                FilaAModificar["VIS_PRECIO"] = textBox3.Text;
            if (textBox4.Text != "")
                FilaAModificar["VIS_PORCENTAJE"] = textBox4.Text;

            visibilidadTableAdapter1.Update(gD1C2014DataSet1.VISIBILIDAD);

            MessageBox.Show("La visibilidad " + textBox1.Text + " ha sido modificada");
            visibilidadTableAdapter1.Fill(gD1C2014DataSet1.VISIBILIDAD);
            new FrbaCommerce.Abm_Visibilidad.BuscarVi().Show();
            this.Close();

        }
    }
}
