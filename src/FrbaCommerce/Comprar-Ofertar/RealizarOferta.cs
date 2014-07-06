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
    public partial class RealizarOferta : Form
    {
        int publicacionId;
        public RealizarOferta(int pubId)
        {
            InitializeComponent();
            publicacionId = pubId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(publicacionTableAdapter1.admitePreguntas(Convert.ToDecimal(publicacionId))))
            {
                new FrbaCommerce.Comprar_Ofertar.Preguntar(publicacionId).Show();
            }
            else
            {
                MessageBox.Show("No esta permitido realizar preguntas en esta publicacion");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Validar que sea entero
            if (MetodosGlobales.esInteger(textBox1))
            {
                persistir();
            }
            else
            {
                MessageBox.Show("El monto no es entero");
                return;
            }
        }

        private void persistir()
        {
            DataRow oferta = gD1C2014DataSet1.OFERTA.NewRow();

            oferta["OFE_PUB_ID"] = publicacionId;
            oferta["OFE_MONTO"] = textBox1.Text;
            oferta["OFE_FECHA"] = DateTime.Now;
            oferta["OFE_USU_ID"] = Global.usuario_id;

            gD1C2014DataSet1.OFERTA.Rows.Add(oferta);            
            ofertaTableAdapter1.Update(gD1C2014DataSet1.OFERTA);

            MessageBox.Show("Su oferta ha sido enviada");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrbaCommerce.Comprar_Ofertar.Ofertar().Show();
        }   

    }
}
