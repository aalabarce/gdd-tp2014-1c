﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class Listado : Form
    {
        public DateTime fecha_ini { get; set; }
        public DateTime fecha_fin { get; set; }

        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet1.CANTIDAD_SIN_CALIFICAR' Puede moverla o quitarla según sea necesario.
            this.cANTIDAD_SIN_CALIFICARTableAdapter.Fill(this.gD1C2014DataSet1.CANTIDAD_SIN_CALIFICAR);
            DateTime hoy = DateTime.Now; 
            int año_actual = hoy.Year;
            
            //Agrego los años
            for (int año=2013; año<=año_actual; año++) 
            {
               comboBox1.Items.Add(año);
            }

            //Agrego los trimestres
            comboBox2.Items.Add("Primero");
            comboBox2.Items.Add("Segundo");
            comboBox2.Items.Add("Tercero");
            comboBox2.Items.Add("Cuarto");

            //Seteo el default del listado
            comboBox1.Text=Convert.ToString(año_actual);
            comboBox2.Text = "Primero";
            radioButton1.Checked = true;

            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            fecha_ini = new DateTime(Convert.ToInt32(comboBox1.Text), 1, 1, 0, 0, 0);
            fecha_fin = new DateTime(Convert.ToInt32(comboBox1.Text), 3, 31, 23, 59, 59); 

        }

        private void button1_Click(object sender, EventArgs e)
        {

             //Pongo visible el listado correspondiente
            if (radioButton1.Checked == true)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
            }
            if (radioButton2.Checked == true)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                fACTURACIONES_VENDEDORESTableAdapter.top5(gD1C2014DataSet1.FACTURACIONES_VENDEDORES, Convert.ToInt32(comboBox1.Text), comboBox2.Text);
            }
            if (radioButton3.Checked == true)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                dataGridView4.Visible = false;

                cALIFICACIONES_VENDEDORESTableAdapter.top5(gD1C2014DataSet1.CALIFICACIONES_VENDEDORES, Convert.ToInt32(comboBox1.Text), comboBox2.Text);
            }
            if (radioButton4.Checked == true)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = true;

                cANTIDAD_SIN_CALIFICARTableAdapter.top5(gD1C2014DataSet1.CANTIDAD_SIN_CALIFICAR, Convert.ToInt32(comboBox1.Text), comboBox2.Text);

            }         
        }
    }
}
