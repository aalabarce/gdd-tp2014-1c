﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FrbaCommerce.Abm_Rubro
{
    public partial class AltaRubro : Form
    {
        public AltaRubro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Valido que el codigo sea int y que no exista en la abse de datos y no este vacio los campos
            if( textBox1.Text=="" || textBox2.Text=="" ){
                MessageBox.Show("Debe completar todos los campos");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaRubro_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(rubroTableAdapter1.proximoCodigo());
            textBox1.Enabled = false;
        }
    }
}

