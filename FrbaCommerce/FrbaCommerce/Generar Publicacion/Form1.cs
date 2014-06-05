using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Windows;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Generar_Publicacion : Form
    {
        public Generar_Publicacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rubroTableAdapter1.getOrdenados(this.gD1C2014DataSet1.RUBRO);

            chkRubros.DataSource = this.gD1C2014DataSet1.RUBRO;
            chkRubros.DisplayMember = "RUBRO_DESCRIPCION";
            chkRubros.ValueMember="RUBRO_ID";

            this.visibilidadTableAdapter1.getOrdenados(this.gD1C2014DataSet1.VISIBILIDAD);

            cmbVisibilidad.DataSource = this.gD1C2014DataSet1.VISIBILIDAD;
            cmbVisibilidad.DisplayMember = "VIS_DESCRIPCION";
            cmbVisibilidad.ValueMember = "VIS_ID";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            //TODO: VALIDAR
            persistir('A'); //estado activa.
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            persistir('B'); //estado borrador
        }

        private void persistir(char estado)
        {
            DataRow publicacion = gD1C2014DataSet1.PUBLICACION.NewRow();

            if (radTipoCompra.Checked)
            {
                publicacion["PUB_TIPO_ID"] = 'C';
            }
            else
            {
                publicacion["PUB_TIPO_ID"] = 'S';
            }

            publicacion["PUB_STOCK"] = txtStock.Text;
            publicacion["PUB_PRECIO"] = txtPrecio.Text;
            publicacion["PUB_ESTADO_ID"] = estado;
            publicacion["PUB_FECHA_INICIO"] = dateFechaInicio.Value;
            publicacion["PUB_FECHA_FINALIZACION"] = dateFechaVenc.Value;
            publicacion["PUB_DESCRIPCION"] = txtDescripcion.Text;
            publicacion["PUB_VIS_ID"] = cmbVisibilidad.SelectedValue;
            publicacion["PUB_USU_ID"] = 1; //TODO: cambiar por el id del usuario loggeado!
            publicacion["PUB_PERMITIR_PREGUNTAS"] = chkPreguntas.Checked;

            gD1C2014DataSet1.PUBLICACION.Rows.Add(publicacion);

            publicacionTableAdapter1.Update(gD1C2014DataSet1.PUBLICACION);

            string mensaje = "La publicacion ha sido publicada";
            if (estado == 'B')
            {
                mensaje += " como borrador.";
            }

            persistirRubros(Convert.ToInt32(publicacion["PUB_ID"]));
            MessageBox.Show(mensaje);

        }

        private void persistirRubros(int publicacion_id)
        {
           /* TODO!! ESTOY CERCA 
            * foreach (System.Data.DataRowView rubro in chkRubros.SelectedItems)
            {
                
                chkRubros.getitemGetItemCheckState(rubro_pos).ToString();
                MessageBox.Show(chkRubros.valu.ToString());
                DataRow publicacion_rubro = gD1C2014DataSet1.PUBLICACION_RUBRO.NewRow();

                publicacion_rubro["PUB_RUB_PUB_ID"] = publicacion_id;
                publicacion_rubro["PUB_RUB_RUBRO_ID"] = chkRubros.Items[rubro_pos];

                gD1C2014DataSet1.PUBLICACION_RUBRO.Rows.Add(publicacion_rubro);
                MessageBox.Show("rubro_id:" + chkRubros.Items[rubro_pos] + " creado");
            }

            pub_rubro_TableAdapter.Update(gD1C2014DataSet1.PUBLICACION_RUBRO);*/

        }

        private void radTipoSubasta_CheckedChanged(object sender, EventArgs e)
        {
            lblAclaracionSubasta.Visible = true;
        }

    }
}
