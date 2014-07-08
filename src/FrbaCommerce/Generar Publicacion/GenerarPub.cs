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
        public int duracion { get; set; }

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

            cmbVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;

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

                int cantGratisActivas = (int)this.publicacionTableAdapter1.cantGratisActivasUsuario(Global.usuario_id);
                if (cantGratisActivas >= 2 && cmbVisibilidad.Text == "Gratis")
                {
                    MessageBox.Show("No puede tener tres publicaciones gratis activas al mismo tiempo.");
                    return;
                }

                persistir('A'); //estado activa.
                this.Close();
            }
            
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            if(validateCampos()){
                persistir('B'); //estado borrador
                this.Close();
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
            publicacion["PUB_FECHA_INICIO"] = DateTime.Now;
            publicacion["PUB_FECHA_FINALIZACION"] = DateTime.Now.AddDays(duracion);
            publicacion["PUB_DESCRIPCION"] = txtDescripcion.Text;
            publicacion["PUB_VIS_ID"] = cmbVisibilidad.SelectedValue;
            publicacion["PUB_USU_ID"] = Global.usuario_id;
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
 //           MessageBox.Show("Se asociaron a la publicacion " + chkRubros.CheckedItems.Count.ToString() + " rubros");
        }

        private void radTipoSubasta_CheckedChanged(object sender, EventArgs e)
        {
            lblAclaracionSubasta.Visible = true;
            lblPrecio.Text = "Precio (lote):";
        }

        private void radTipoCompra_CheckedChanged(object sender, EventArgs e)
        {
            lblAclaracionSubasta.Visible = false;
            lblPrecio.Text = "Precio (por unidad):";
        }

        public bool validateCampos()
        {
            //Valido que no dejen campos vacios
            if (txtDescripcion.Text == "" || txtStock.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }

            if (!MetodosGlobales.esNumericConDosDecimales(txtPrecio))
            {
                return false;
            }

            //valido que la publicacion tenga al menos un rubro.
            if (chkRubros.CheckedItems.Count == 0)
            {
                MessageBox.Show("La publicación debe estar asociada al menos a un rubro.");
                return false;
            }

            if(Convert.ToDouble(txtPrecio.Text) <= 0){
                MessageBox.Show("El producto no puede valer $0 o menos.");
                return false;
            }

            return true;
        }

        private void cmbVisibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRowView visibilidad = (DataRowView)cmbVisibilidad.SelectedItem;
            duracion = Convert.ToInt32(visibilidad["VIS_DURACION"]);
        }
    }
}
