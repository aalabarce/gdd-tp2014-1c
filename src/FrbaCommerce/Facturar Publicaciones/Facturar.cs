using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class Facturar : Form
    {
        GD1C2014DataSet.LINEAS_FACTURACIONDataTable lineas;
        int cantPublicaciones;
        
        public Facturar()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.formA_PAGOTableAdapter1.Fill(this.gD1C2014DataSet.FORMA_PAGO);

            cmbFormaPago.DataSource = this.gD1C2014DataSet.FORMA_PAGO;
            cmbFormaPago.DisplayMember = "FORMA_DESCRIPCION";

            cmbFormaPago.ValueMember = "FORMA_ID";

            this.lINEAS_FACTURACIONTableAdapter.FillByUsuID(this.gD1C2014DataSet.LINEAS_FACTURACION,Global.usuario_id);
            lineas = this.lINEAS_FACTURACIONTableAdapter.GetByUsuID(Global.usuario_id);
            cantPublicaciones = (int)this.lINEAS_FACTURACIONTableAdapter.cantPublicacionesUsuario(Global.usuario_id);
            lblCantFacturaciones.Text = "Usted tiene " + cantPublicaciones + " publicaciones sin facturar.";
            
            cmbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantidad.Text) <= 0)
            {
                MessageBox.Show("La cantidad de publicaciones a facturar debe ser mayor a 0");
                return;
            }

            if (Convert.ToInt32(txtCantidad.Text) > cantPublicaciones)
            {
                MessageBox.Show("Usted no tiene " + txtCantidad.Text + " publicaciones pendientes de facturación, el máximo es " + cantPublicaciones);
                return;
            }

            //si pago con tarjeta, valido los datos.
            if (cmbFormaPago.SelectedValue.ToString() == "1")
            {
                if (txtNumero.Text == "" || txtAnio.Text == "" || txtMes.Text == "" || txtCodSeguridad.Text == "") {
                    MessageBox.Show("Debe completar todos los datos de la tarjeta");
                    return;
                }
                if(!MetodosGlobales.esInteger(txtAnio)){
                    return;
                }
                if(!MetodosGlobales.esInteger(txtMes)){
                    return;
                }
                if (!MetodosGlobales.esInteger(txtCodSeguridad))
                {
                    return;
                }
            }

            //creo la factura.
            DataRow factura = gD1C2014DataSet.FACTURA.NewRow();
            factura["FAC_FECHA"] = DateTime.Now;
            factura["FAC_USU_ID"] = Global.usuario_id;
            factura["FAC_FORMA_ID"] = cmbFormaPago.SelectedValue;

            gD1C2014DataSet.FACTURA.Rows.Add(factura);

            facturaTableAdapter1.Update(gD1C2014DataSet.FACTURA);

            double total = 0;
            int cantFacturada = 0;
            string codPubAnterior = "";

            string pubBonificadas = "";
            bool debeBonificar = false;

            //recorro las lineas, y voy creando items factura hasta llegar a la cant de publicaciones elegida por el usuario.
            foreach (GD1C2014DataSet.LINEAS_FACTURACIONRow linea in lineas)
            {
                if (codPubAnterior != linea["CODIGO_PUB"].ToString())
                {
                    cantFacturada++;
                    codPubAnterior = linea["CODIGO_PUB"].ToString();
                    int cantItemsVisUsuario = (int)this.iteM_FACTURATableAdapter1.getCantPublicacionesUsuVis(Global.usuario_id, (decimal)linea["CODIGO_PUB"]);
                    debeBonificar = cantItemsVisUsuario % 10 == 0; //si la publicacion es multiplo de 10 (de la misma visibilidad), bonifico

                    if (debeBonificar){
                        if (pubBonificadas.Length > 0) {
                            pubBonificadas += ", ";
                        }
                        pubBonificadas += linea["CODIGO_PUB"].ToString();
                    }
                }
                if (cantFacturada <= Convert.ToInt32(txtCantidad.Text))
                {
                    DataRow itemFactura = gD1C2014DataSet.ITEM_FACTURA.NewRow();
                    int cantItemsVisUsuario = (int)this.iteM_FACTURATableAdapter1.getCantPublicacionesUsuVis(Global.usuario_id, (decimal)linea["CODIGO_PUB"]);
                    if (debeBonificar)
                    {
                        itemFactura["ITEM_MONTO"] = 0;
                    }
                    else
                    {
                        itemFactura["ITEM_MONTO"] = linea["PRECIO"];
                        total = total + Convert.ToDouble(linea["PRECIO"]);
                    }

                    itemFactura["ITEM_CANTIDAD"] = linea["CANTIDAD"];
                    itemFactura["ITEM_PUB_ID"] = linea["CODIGO_PUB"];
                    itemFactura["ITEM_FAC_ID"] = factura["FAC_ID"];

                    gD1C2014DataSet.ITEM_FACTURA.Rows.Add(itemFactura);

                    iteM_FACTURATableAdapter1.Update(gD1C2014DataSet.ITEM_FACTURA);
                }
            }

            if (pubBonificadas.Length > 0)
            {
                MessageBox.Show("Las publicaciones " + pubBonificadas + " han sido bonificadas, son gratuitas");
            }

            //actualizo la factura con el total pagado.
            factura["FAC_TOTAL"] = total;
            facturaTableAdapter1.Update(gD1C2014DataSet.FACTURA);

            //si pago con tarjeta, guardo los datos de la misma.
            if (cmbFormaPago.SelectedValue.ToString() == "1")
            {
                DataRow tarjeta = gD1C2014DataSet.TARJETA.NewRow();
                tarjeta["TAR_NUMERO"] = txtNumero.Text;
                tarjeta["TAR_ANIO_VENC"] = txtAnio.Text;
                tarjeta["TAR_MES_VENC"] = txtMes.Text;
                tarjeta["TAR_CODIGO_SEGURIDAD"] = txtCodSeguridad.Text;
                tarjeta["TAR_FAC_ID"] = factura["FAC_ID"];

                gD1C2014DataSet.TARJETA.Rows.Add(tarjeta);

                tarjetaTableAdapter1.Update(gD1C2014DataSet.TARJETA);
            }

            this.Close();
            new FrbaCommerce.Facturar_Publicaciones.verFactura(Convert.ToInt32(factura["FAC_ID"])).Show();
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.SelectedValue.ToString() == "1")
            {
                grDatosTarjeta.Show();
                label8.Show();
                label4.Show();
                label6.Show();
                label7.Show();
                txtNumero.Show();
                txtMes.Show();
                txtAnio.Show();
                txtCodSeguridad.Show();
            }
            else
            {
                grDatosTarjeta.Hide();
                label8.Hide();
                label4.Hide();
                label6.Hide();
                label7.Hide();
                txtNumero.Hide();
                txtMes.Hide();
                txtAnio.Hide();
                txtCodSeguridad.Hide();
            }
        }
    }
}
