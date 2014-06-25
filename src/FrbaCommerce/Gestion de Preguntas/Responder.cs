using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Responder : Form
    {
        public int preg_id { get; set; }

        public Responder(int pre)
        {
            InitializeComponent();
            preg_id = pre;
        }

        private void Responder_Load(object sender, EventArgs e)
        {
            respuestaTableAdapter1.Fill(gD1C2014DataSet1.RESPUESTA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe Ingresar una respuesta");
                return;
            }

            DataRow nuevo = gD1C2014DataSet1.RESPUESTA.NewRow();

            nuevo["RES_PRE_ID"]= preg_id;
            nuevo["RES_TEXTO"]= textBox1.Text;
            nuevo["RES_FECHA"] = DateTime.Now;

            gD1C2014DataSet1.RESPUESTA.Rows.Add(nuevo);
            respuestaTableAdapter1.Update(gD1C2014DataSet1.RESPUESTA);

            MessageBox.Show("La pregunta ha sido respondida correctamente");

            new FrbaCommerce.Gestion_de_Preguntas.BuscarPre().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Gestion_de_Preguntas.BuscarPre().Show();
            this.Close();
        }
    }
}
