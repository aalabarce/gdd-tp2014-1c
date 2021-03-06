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
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           //Valido que no dejen campos vacios
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            
            //Valido que los tipos de datos sean correctos
            if (!MetodosGlobales.esInteger(textBox1) || !MetodosGlobales.esInteger(textBox5) || !MetodosGlobales.esNumericConDosDecimales(textBox3) || !MetodosGlobales.esInteger(textBox4))
            {
                return;
            }

            
            //Valido que el codigo no exista
            if (Convert.ToInt32(visibilidadTableAdapter1.existeCod(Convert.ToDecimal(textBox1.Text))) > 0)
            {
                MessageBox.Show("Ese codigo de visibilidad ya existe");
                return;
            }

            //Valido que el nombre no exista
            if (Convert.ToInt32(visibilidadTableAdapter1.existeNom(textBox2.Text)) > 0)
            {
                MessageBox.Show("Ese nombre de visibilidad ya existe");
                return;
            }

            //Valido que no exista la combinacion de $, % y duracion
            if (Convert.ToInt32(visibilidadTableAdapter1.existeCombinacion(Convert.ToInt32(textBox5.Text),Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text)/100)) > 0)
            {
                MessageBox.Show("Esa combinacion de precio, porcentaje y duracion ya existe");
                return;
            }
            

            //Si hay errores, agrego a la base de datos
            darAlta();

        }
        
        private void darAlta()
        {
            decimal porcentaje = Convert.ToDecimal(textBox4.Text) / 100;
            DataRow nuevo = gD1C2014DataSet1.VISIBILIDAD.NewRow();

            nuevo["VIS_CODIGO"] = textBox1.Text;
            nuevo["VIS_DESCRIPCION"] = textBox2.Text;
            nuevo["VIS_PRECIO"] = textBox3.Text;
            nuevo["VIS_PORCENTAJE"] = porcentaje;
            nuevo["VIS_DURACION"] = textBox5.Text;
            nuevo["VIS_BAJA"] = 0;

            gD1C2014DataSet1.VISIBILIDAD.Rows.Add(nuevo);

            visibilidadTableAdapter1.Update(gD1C2014DataSet1.VISIBILIDAD);

            MessageBox.Show("La visibilidad " + textBox1.Text + " ha sido dada de alta");

            this.Close();

        }
    }
}
