﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class AltaVi : Form
    {
        public AltaVi()
        {
            InitializeComponent();
        }

        public static bool esInteger(TextBox txt)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (!esInteger(textBox1))
            {
                return;
            }



            //Valido que el codigo no exista
           /* if (Convert.ToInt32(visibilidadTableAdapter1.existeCodigo(Convert.ToInt32(textBox1.Text))) == 1)
            {
                MessageBox.Show("Ese codigo de rubro ya existe");
                return;
            }*/


            //Si hay errores, agrego a la base de datos
            darAlta();

        }
        


        private void darAlta()
        {
            DataRow nuevo = gD1C2014DataSet1.VISIBILIDAD.NewRow();

            nuevo["VIS_CODIGO"] = textBox1.Text;
            nuevo["VIS_DESCRIPCION"] = textBox2.Text;
            nuevo["VIS_PRECIO"] = textBox3.Text;
            nuevo["VIS_PORCENTAJE"] = textBox4.Text;
            nuevo["VIS_DURACION"] = null;
            nuevo["VIS_BAJA"] = 0;

            gD1C2014DataSet1.VISIBILIDAD.Rows.Add(nuevo);

            visibilidadTableAdapter1.Update(gD1C2014DataSet1.VISIBILIDAD);

            MessageBox.Show("La visibilidad " + textBox1.Text + " ha sido dada de alta");

            this.Close();

        }
    }
}