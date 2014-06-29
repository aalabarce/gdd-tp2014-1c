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
    public partial class verFactura : Form
    {
        public verFactura(int facturaId)
        {
            InitializeComponent();
            GD1C2014DataSet.FACTURADataTable factura = this.facturaTableAdapter1.GetDataById(facturaId);

            lblNumero.Text = factura[0]["FAC_ID"].ToString();
            lblFecha.Text = factura[0]["FAC_FECHA"].ToString();
            lblTotal.Text = "$" + factura[0]["FAC_TOTAL"].ToString();

            GD1C2014DataSet.FORMA_PAGODataTable formaPago = this.formA_PAGOTableAdapter1.GetByFORMA_ID(Convert.ToInt32(factura[0]["FAC_FORMA_ID"]));
            lblForma.Text = formaPago[0]["FORMA_DESCRIPCION"].ToString();

            GD1C2014DataSet.ITEM_FACTURADataTable items_factura = this.iteM_FACTURATableAdapter1.GetDataByFacId(facturaId);
            iTEM_FACTURADataGridView.DataSource = items_factura;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Facturar_Publicaciones.Facturar().Show();
            this.Close();
        }
    }
}
