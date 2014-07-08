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
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int porcentaje { get; set; }
        public int duracion { get; set; }

        public ModVi(int codigo_mod)
        {
            InitializeComponent();
            codigo = codigo_mod;
        }

        private void ModVi_Load(object sender, EventArgs e)
        {
            this.visibilidadTableAdapter1.Fill(this.gD1C2014DataSet1.VISIBILIDAD);
            decimal id = Convert.ToDecimal(visibilidadTableAdapter1.BuscarID(codigo));
            DataRow FilaAModificar = gD1C2014DataSet1.VISIBILIDAD.NewRow();
            FilaAModificar = gD1C2014DataSet1.VISIBILIDAD.FindByVIS_ID(id);
            
            textBox1.Text = Convert.ToString(FilaAModificar["VIS_CODIGO"]);
            textBox2.Text = Convert.ToString(FilaAModificar["VIS_DESCRIPCION"]);
            textBox3.Text = Convert.ToString(Convert.ToDecimal(FilaAModificar["VIS_PRECIO"]));
            textBox4.Text = Convert.ToString(Convert.ToInt32(100*Convert.ToDecimal(FilaAModificar["VIS_PORCENTAJE"])));
            textBox5.Text = Convert.ToString(FilaAModificar["VIS_DURACION"]);    
       
            //Guardo los datos actuales
            nombre = Convert.ToString(FilaAModificar["VIS_DESCRIPCION"]);
            precio = Convert.ToDecimal(FilaAModificar["VIS_PRECIO"]);
            porcentaje = Convert.ToInt32(100 * Convert.ToDecimal(FilaAModificar["VIS_PORCENTAJE"]));
            duracion = Convert.ToInt32(FilaAModificar["VIS_DURACION"]);   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Valido que no dejen campos vacios
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Debe completar por lo menos 1 campo");
                return;
            }


            //Valido que los tipos de datos sean correctos
            if (!MetodosGlobales.esInteger(textBox1) || !MetodosGlobales.esInteger(textBox5) || !MetodosGlobales.esNumericConDosDecimales(textBox3) || !MetodosGlobales.esInteger(textBox4))
            {
                return;
            }
            
            //Valido que el codigo no exista
            if (Convert.ToInt32(textBox1.Text) != codigo && Convert.ToInt32(visibilidadTableAdapter1.existeCod(Convert.ToDecimal(textBox1.Text))) > 0)
            {
                MessageBox.Show("Ese codigo de visibilidad ya existe");
                return;
            }

            //Valido que el nombre no exista
            if (textBox2.Text != nombre && Convert.ToInt32(visibilidadTableAdapter1.existeNom(textBox2.Text)) > 0)
            {
                MessageBox.Show("Ese nombre de visibilidad ya existe");
                return;
            }

            //Valido que no exista la combinacion de $, % y duracion
            if ((Convert.ToInt32(textBox5.Text) != duracion || Convert.ToInt32(textBox4.Text) != porcentaje || Convert.ToDecimal(textBox3.Text) != precio) && Convert.ToInt32(visibilidadTableAdapter1.existeCombinacion(Convert.ToInt32(textBox5.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text) / 100)) > 0)
            {
                MessageBox.Show("Esa combinacion de precio, porcentaje y duracion ya existe");
                return;
            }


            //Si hay errores, agrego a la base de datos
            modificar();
        }
      
        private void modificar()
        {
            decimal porcentaje = Convert.ToDecimal(textBox4.Text) / 100;

            decimal id = Convert.ToDecimal(visibilidadTableAdapter1.BuscarID(codigo));
            DataRow FilaAModificar = gD1C2014DataSet1.VISIBILIDAD.NewRow();
            FilaAModificar = gD1C2014DataSet1.VISIBILIDAD.FindByVIS_ID(id);
            
            FilaAModificar["VIS_CODIGO"] = textBox1.Text;
            FilaAModificar["VIS_DESCRIPCION"] = textBox2.Text;
            FilaAModificar["VIS_PRECIO"] = textBox3.Text;
            FilaAModificar["VIS_PORCENTAJE"] = porcentaje;
            FilaAModificar["VIS_DURACION"] = textBox5.Text;

            visibilidadTableAdapter1.Update(gD1C2014DataSet1.VISIBILIDAD);

            MessageBox.Show("La visibilidad " + textBox1.Text + " ha sido modificada");
            visibilidadTableAdapter1.Fill(gD1C2014DataSet1.VISIBILIDAD);
            new FrbaCommerce.Abm_Visibilidad.BuscarVi().Show();
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Visibilidad.BuscarVi().Show();
            this.Close();
        }


    }
}
