using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Preguntar : Form
    {
        public decimal pub_id { get; set; }

        public Preguntar(decimal pub)
        {
            InitializeComponent();
            pub_id = pub;
        }

        private void Preguntar_Load(object sender, EventArgs e)
        {
            preguntaTableAdapter1.Fill(gD1C2014DataSet1.PREGUNTA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe escribir la preguntaTableAdapter1");
                return;
            }

            DataRow nueva = gD1C2014DataSet1.PREGUNTA.NewRow();
            
            nueva["PRE_PUB_ID"]= pub_id;
            nueva["PRE_USU_ID"]= Global.usuario_id;
            nueva["PRE_TEXTO"] = textBox1.Text;

            gD1C2014DataSet1.PREGUNTA.Rows.Add(nueva);
            preguntaTableAdapter1.Update(gD1C2014DataSet1.PREGUNTA);

            MessageBox.Show("La pregunta ha sido enviada");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
