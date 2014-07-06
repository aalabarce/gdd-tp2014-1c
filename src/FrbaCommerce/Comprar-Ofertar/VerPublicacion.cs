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

    public partial class VerPublicacion : Form
    {
        int usuarioId, publicacionId, stock;
        string tipo;

        public VerPublicacion(int id, string tipoUsuario, int pubId)
        {
            InitializeComponent();
            usuarioId = id;
            tipo = tipoUsuario;
            publicacionId = pubId;
            
            
        }

        private void VerPublicacion_Load(object sender, EventArgs e)
        {
            this.publicacionTableAdapter1.Fill(this.gD1C2014DataSet1.PUBLICACION);
            DataRow publicacion = gD1C2014DataSet1.PUBLICACION.NewRow();
            publicacion = gD1C2014DataSet1.PUBLICACION.FindByPUB_ID(publicacionId);

            label3.Text = Convert.ToString(publicacion["PUB_DESCRIPCION"]);
            label4.Text = Convert.ToString(publicacion["PUB_STOCK"]);
            label6.Text = Convert.ToString(publicacion["PUB_PRECIO"]);
            stock = Convert.ToInt32(publicacion["PUB_STOCK"]);

            // Escondo el boton si la publicacion no permite preguntas
            if ( Convert.ToString(publicacion["PUB_PERMITIR_PREGUNTAS"]) == "0")
                button2.Visible = false;

            }

        private void button1_Click(object sender, EventArgs e)
        {
           // CONFIRMAR COMPRA

            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe indicar la cantidad que desea comprar");
                return;
            }

            if (Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("La cantidad minima es 1 unidad");
                return;
            }

            if (Convert.ToInt32(textBox1.Text) > stock)
            {
                MessageBox.Show("La cantidad máxima que puede comprar es de: " + Convert.ToString(stock) + " unidades");
                return;
            }

            DataRow nuevaCompra = gD1C2014DataSet1.COMPRA.NewRow();
            nuevaCompra["COM_PUB_ID"] = publicacionId;
            nuevaCompra["COM_CANTIDAD"] = textBox1.Text;
            nuevaCompra["COM_FECHA"] = DateTime.Now;
            nuevaCompra["COM_USU_ID"] = Global.usuario_id;

            gD1C2014DataSet1.COMPRA.Rows.Add(nuevaCompra);

            compraTableAdapter1.Update(gD1C2014DataSet1.COMPRA);

            // Si termina el stock, doy por finalizada la publicacion

            if (Convert.ToInt32(textBox1.Text) == stock)
            { 
                DataRow publicacion = gD1C2014DataSet1.PUBLICACION.NewRow();
                publicacion = gD1C2014DataSet1.PUBLICACION.FindByPUB_ID(publicacionId);
                publicacion["PUB_ESTADO_ID"] = 'F';

                publicacionTableAdapter1.Update(gD1C2014DataSet1.PUBLICACION);

                GD1C2014DataSet.LINEAS_FACTURACIONDataTable lineas;
                lineas = this.lineaS_FACTURACIONTableAdapter1.GetByUsuID(Global.usuario_id);
                int cantPublicaciones = (int)this.lineaS_FACTURACIONTableAdapter1.cantPublicacionesUsuario(Global.usuario_id);
                if (cantPublicaciones >= 10)
                {
                    usuarioTableAdapter1.deshabilitarUsuario((int)Global.usuario_id);
                    MessageBox.Show("Usted tiene " + cantPublicaciones + " publicaciones sin rendir. Todas sus publicaciones activas fueron pausadas, y usted fue inhabilitado del sistema. Contáctese con la oficina de administración para solucionar el inconveniente.");
                    this.Hide();
                    new FrbaCommerce.Login.Login().Show();

                }
 
            }

            new FrbaCommerce.Comprar_Ofertar.VerVendedor(usuarioId, tipo).Show();
            this.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Convert.ToBoolean(publicacionTableAdapter1.admitePreguntas(Convert.ToDecimal(publicacionId))))
            {
                new FrbaCommerce.Comprar_Ofertar.Preguntar(publicacionId).Show();
            }
            else
            {
                MessageBox.Show("No esta permitido realizar preguntas en esta publicacion");
            }
 
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrbaCommerce.Comprar_Ofertar.Comprar().Show(); 
        }


      }
  }


