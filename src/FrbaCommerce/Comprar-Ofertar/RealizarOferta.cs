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
        int publicacionId, cantidadComprasSinCalificar;
        decimal? maxOferta;
        public RealizarOferta(int pubId)
        {
            InitializeComponent();
            publicacionId = pubId;
            maxOferta = (decimal?)ofertaTableAdapter1.maximaOfertaDePublicacion(pubId);
            if (maxOferta == null)
                maxOferta = 0;
            label3.Text = Convert.ToString(maxOferta);
            cantidadComprasSinCalificar = (int)compraTableAdapter1.cantidadComprasSinCalificar(Global.usuario_id);
            if (cantidadComprasSinCalificar >= 5)
            {
                label4.Text = "No se puede comprar esta publicacion debido a que tiene 5 o más compras sin calificar";
                button1.Visible = false;
                button2.Visible = false;
            }
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
            decimal? pubId = (decimal?)publicacionId;
            if (MetodosGlobales.esInteger(textBox1))
            {
                decimal? oferta = Convert.ToDecimal(textBox1.Text);

                if (MetodosGlobales.esInteger(textBox1))
                {
                    if (maxOferta < oferta)
                        persistir();
                    else
                        MessageBox.Show("Su oferta es menor a la maximo valor ofertado previamente");
                }
                else
                {
                    MessageBox.Show("El monto no es entero");
                    return;
                }
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
