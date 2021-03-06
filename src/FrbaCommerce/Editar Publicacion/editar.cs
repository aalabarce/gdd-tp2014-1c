﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace FrbaCommerce.Editar_Publicacion
{
    public partial class Editar : Form
    {
        public int codigo { get; set; }
        public char estado { get; set; }
        public DataRow fila { get; set; }

        public Editar(int codigo_mod)
        {
            InitializeComponent();
            codigo = codigo_mod;
            
        }

        private void editar_Load(object sender, EventArgs e)
        {

            chkRubros.DataSource = this.gD1C2014DataSet1.RUBRO;
            chkRubros.DisplayMember = "RUBRO_DESCRIPCION";
            chkRubros.ValueMember = "RUBRO_ID";

            this.visibilidadTableAdapter1.getOrdenados(this.gD1C2014DataSet1.VISIBILIDAD);

            cmbVisibilidad.DataSource = this.gD1C2014DataSet1.VISIBILIDAD;
            cmbVisibilidad.DisplayMember = "VIS_DESCRIPCION";

            cmbVisibilidad.ValueMember = "VIS_ID";

            cargarDatosPublicacion();

            cmbVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;

            pub_rubro_TableAdapter.Fill(gD1C2014DataSet1.PUBLICACION_RUBRO);
            
        }

        private void cargarDatosPublicacion()
        {
            this.publicacionTableAdapter1.Fill(this.gD1C2014DataSet1.PUBLICACION);
            
            fila = gD1C2014DataSet1.PUBLICACION.FindByPUB_ID(codigo);
            txtDescripcion.Text = fila["PUB_DESCRIPCION"].ToString();
            txtPrecio.Text = fila["PUB_PRECIO"].ToString();
            txtStock.Text = fila["PUB_STOCK"].ToString();

            if (fila["PUB_TIPO_ID"].ToString() == "C")
                radTipoCompra.Checked = true;
            else
                radTipoSubasta.Checked = true;

            cmbVisibilidad.SelectedValue = fila["PUB_VIS_ID"];

            estado = Convert.ToChar(fila["PUB_ESTADO_ID"]);

            accionesPorEstado(Convert.ToChar(fila["PUB_TIPO_ID"]));
            

        }

        private void accionesPorEstado(char tipo)
        {
            if (tipo == 'S')
            {
                lblAclaracionSubasta.Visible = true;
            }
            if (estado == 'B')
            { 
                btnCambiarEstado.Text = "Activar publicación";
                btnFinalizar.Hide();
                //si es borrador, muestro todos los rubros, y marcados los de la publicacion
                //puedo modificar todo.
                this.rubroTableAdapter1.getOrdenados(this.gD1C2014DataSet1.RUBRO);

                GD1C2014DataSet.RUBRODataTable rubros = this.rubroTableAdapter2.getByPubId(codigo);

                foreach (GD1C2014DataSet.RUBRORow rubro in rubros)
                {
                    int index = getIndexRubro(Convert.ToInt32(rubro["RUBRO_ID"]));

                    if (index > 0)
                    {
                        chkRubros.SetItemChecked(index, true);
                    }
                }
            }
            else 
            {
                btnCambiarEstado.Text = "Pausar publicación";
                btnFinalizar.Show();
                //si esta activa, muestro solo los rubros de la publicacion, porque total no se pueden modificar.
                this.rubroTableAdapter1.fillByPubId(this.gD1C2014DataSet1.RUBRO, codigo);
                //Solo puedo incrementar el stock si es compra inmediata... y cambiar la descripcion.
                //inhabilito todo lo demás.
                radTipoCompra.Enabled = false;
                radTipoSubasta.Enabled = false;
                if (tipo == 'S') txtStock.Enabled = false;
                txtPrecio.Enabled = false;
                chkRubros.Enabled = false;
                cmbVisibilidad.Enabled = false;
                chkPreguntas.Enabled = false;
            }
        }

        private int getIndexRubro(int rubroId)
        {
            DataRowView drv;

            foreach (object rubro in chkRubros.Items)
            {
                drv = (DataRowView)rubro;
                if (rubroId == Convert.ToInt32(drv["RUBRO_ID"]))
                {
                    return chkRubros.Items.IndexOf(rubro);
                }
            }
            return -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (estado == 'B')
            {
                if(validateBorrador()){
                    persistirBorrador();
                }
            }
            else
            {
                if(validateActiva()){
                    fila["PUB_DESCRIPCION"] = txtDescripcion.Text;
                    fila["PUB_STOCK"] = txtStock.Text;

                    publicacionTableAdapter1.Update(gD1C2014DataSet1.PUBLICACION);
                    MessageBox.Show("La publicación fue modificada");
                    this.Close();
                    new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
                }
            }
        }

        private bool validateActiva()
        {
            //Valido que no dejen la descripcion vacia
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe completar la descripción");
                return false;
            }

            //Valido que el stock sea mayor o igual al anterior
            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(fila["PUB_STOCK"]))
            {
                MessageBox.Show("El stock actual debe ser mayor al anterior!");
                return false;
            }

            return true;
        }

        public bool validateBorrador()
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

            if (Convert.ToDouble(txtPrecio.Text) <= 0)
            {
                MessageBox.Show("El producto no puede valer $0 o menos.");
                return false;
            }

            return true;
        }

        public void persistirBorrador(){
            if (radTipoCompra.Checked)
            {
                fila["PUB_TIPO_ID"] = 'C';
            }
            else
            {
                fila["PUB_TIPO_ID"] = 'S';
            }
            fila["PUB_STOCK"] = txtStock.Text;
            fila["PUB_PRECIO"] = txtPrecio.Text;
            fila["PUB_DESCRIPCION"] = txtDescripcion.Text;
            fila["PUB_VIS_ID"] = cmbVisibilidad.SelectedValue;
            fila["PUB_PERMITIR_PREGUNTAS"] = chkPreguntas.Checked;

            // persistirRubros(); TODO

            publicacionTableAdapter1.Update(gD1C2014DataSet1.PUBLICACION);
            MessageBox.Show("La publicación fue modificada");
            this.Close();
            new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
        }

        private void radTipoCompra_CheckedChanged_1(object sender, EventArgs e)
        {
            lblAclaracionSubasta.Visible = false;
            lblPrecio.Text = "Precio (por unidad):";
        }

        private void radTipoSubasta_CheckedChanged_1(object sender, EventArgs e)
        {
            lblAclaracionSubasta.Visible = true;
            lblPrecio.Text = "Precio (lote):";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("Está seguro que desea finalizar la publicación?", "Finalizar Publicación",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes){
                fila["PUB_ESTADO_ID"] = 'F';
                publicacionTableAdapter1.Update(gD1C2014DataSet1.PUBLICACION);

                if (Convert.ToChar(fila["PUB_TIPO_ID"]) == 'S')
                {
                    GD1C2014DataSet.OFERTADataTable oferta = this.ofertaTableAdapter1.GetGanadoraByPubId(codigo);

                    if (oferta.Count > 0)
                    {
                        DataRow compra = gD1C2014DataSet1.COMPRA.NewRow();
                        compra["COM_PUB_ID"] = codigo;
                        compra["COM_CANTIDAD"] = fila["PUB_STOCK"];
                        compra["COM_FECHA"] = DateTime.Now;
                        compra["COM_USU_ID"] = oferta[0]["OFE_USU_ID"];

                        gD1C2014DataSet1.COMPRA.Rows.Add(compra);
                        compraTableAdapter1.Update(gD1C2014DataSet1.COMPRA);

                        string usuario = usuarioTableAdapter1.get_username_by_id((int)compra["COM_USU_ID"]);
                        MessageBox.Show("La publicación fue finalizada. El ganador fue " + usuario + " por $" + oferta[0]["OFE_MONTO"]);
                    }
                    else
                    {
                        MessageBox.Show("La publicación fue finalizada sin ningún ganador");
                    }
                }
                else
                {
                    MessageBox.Show("La publicación fue finalizada");
                }

                //me fijo si el vendedor sumó 10 publicaciones sin pagar.
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
                else
                {
                    this.Hide();
                    new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
                }

                
            }
            
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (estado == 'B')
            {
                int cantGratisActivas = (int)this.publicacionTableAdapter1.cantGratisActivasUsuario(Global.usuario_id);
                if (cantGratisActivas >= 2 && cmbVisibilidad.Text == "Gratis")
                {
                    MessageBox.Show("No puede tener tres publicaciones gratis activas al mismo tiempo.");
                    return;
                }

                DialogResult result = MessageBox.Show("Está seguro que desea activar la publicación?", "Activar Publicación",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    fila["PUB_ESTADO_ID"] = 'A';
                    publicacionTableAdapter1.Update(gD1C2014DataSet1.PUBLICACION);
                    MessageBox.Show("La publicación se encuentra activa");
                    this.Hide();
                    new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro que desea pausar la publicación?", "Pausar Publicación",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    fila["PUB_ESTADO_ID"] = 'P';
                    publicacionTableAdapter1.Update(gD1C2014DataSet1.PUBLICACION);
                    MessageBox.Show("La publicación se encuentra pausada");
                    this.Hide();
                    new FrbaCommerce.Editar_Publicacion.Publicaciones().Show();
                }
            }
            
        }
    }
}
