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

            pub_rubro_TableAdapter.Fill(gD1C2014DataSet1.PUBLICACION_RUBRO);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if(validateCampos()){
                persistir('A'); //estado activa.
            }
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            if(validateCampos()){
                persistir('B'); //estado borrador
            }
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
            publicacion["PUB_USU_ID"] = 1/*Convert.ToInt32(Global.usuario)*/; //TODO: GLOBAL TIENE QUE ESTAR EL ID del usuario.
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
            DataRowView drv;
            int rubroId;
            DataRow publicacion_rubro;
            foreach (object rubro in chkRubros.CheckedItems)
            {
                drv = (DataRowView)rubro;
                rubroId = Convert.ToInt32(drv["RUBRO_ID"]);

                publicacion_rubro = gD1C2014DataSet1.PUBLICACION_RUBRO.NewRow();

                publicacion_rubro["PUB_RUB_PUB_ID"] = publicacion_id;
                publicacion_rubro["PUB_RUB_RUBRO_ID"] = rubroId;

                gD1C2014DataSet1.PUBLICACION_RUBRO.Rows.Add(publicacion_rubro);
            }

            pub_rubro_TableAdapter.Update(gD1C2014DataSet1.PUBLICACION_RUBRO);
            MessageBox.Show("Se asociaron a la publicacion " + chkRubros.CheckedItems.Count.ToString() + " rubros");
        }

        private void radTipoSubasta_CheckedChanged(object sender, EventArgs e)
        {
            lblAclaracionSubasta.Visible = true;
        }

        private void radTipoCompra_CheckedChanged(object sender, EventArgs e)
        {
            lblAclaracionSubasta.Visible = false;
        }

        public bool validateCampos()
        {
            //Valido que no dejen campos vacios
            if (txtDescripcion.Text == "" || txtStock.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }

            //Valido que los tipos de datos sean correctos
            if (!esInteger(txtStock))
            {
                return false;
            }

            //valido que la fecha inicio sea mayor o igual a hoy.
            /*if (dateFechaInicio.Value < DateTime.Now) {
                MessageBox.Show("La fecha de inicio no puede ser anterior a hoy.");
                return false;
            }*/ //TODO: lo comento porque cuando es igual a hoy me tira como que es anterior.

            //valido que la fecha inicio sea menor a la fecha de vencimiento.
            if (dateFechaInicio.Value > dateFechaVenc.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de vencimiento.");
                return false;
            }

            //valido que la publicacion tenga al menos un rubro.
            if (chkRubros.CheckedItems.Count == 0)
            {
                MessageBox.Show("La publicación debe estar asociada al menos a un rubro.");
                return false;
            }

            return true;
        }

        public static bool esInteger(TextBox txt)
        {
            int number;

            bool result = Int32.TryParse(txt.Text, out number);
            if (result)
            {
                return true;
            }
            else
            {
                string errores = "El campo " + txt.Tag + " debe ser de tipo numérico";
                MessageBox.Show(errores);
                return false;
            }
        }
    }
}
