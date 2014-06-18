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
    public partial class VerVendedor : Form
    {
        int usuarioId;
        string tipo;

        public VerVendedor(int uId, string type)
        {
            InitializeComponent();
            usuarioId = uId;
            tipo = type;
        }

        private void VerVendedor_Load(object sender, EventArgs e)
        {
            this.empresaTableAdapter1.Fill(this.gD1C2014DataSet1.EMPRESA);
            this.clienteTableAdapter1.Fill(this.gD1C2014DataSet1.CLIENTE);

            if (tipo == "C")
            {
                int? clienteId = empresaTableAdapter1.getIdByUsuId((int?)usuarioId);

                DataRow cliente = gD1C2014DataSet1.CLIENTE.NewRow();
                cliente = gD1C2014DataSet1.CLIENTE.FindByCLI_ID((int)clienteId);
                label2.Text = Convert.ToString(cliente["CLI_NOMBRE"]);
                label3.Text = Convert.ToString(cliente["CLI_TELEFONO"]);
                label5.Text = Convert.ToString(cliente["CLI_LOCALIDAD"]);
                label7.Text = Convert.ToString(cliente["CLI_MAIL"]);
            }
            else
            {
                int? empresaId = empresaTableAdapter1.getIdByUsuId((int?)usuarioId);
                DataRow empresa = gD1C2014DataSet1.EMPRESA.NewRow();
                empresa = gD1C2014DataSet1.EMPRESA.FindByEMP_ID((int)empresaId);

//              DataRow[] foundRows = gD1C2014DataSet1.EMPRESA.Select("EMP_ID > 0");
                label2.Text = Convert.ToString(empresa["EMP_RAZON_SOCIAL"]);
                label3.Text = Convert.ToString(empresa["EMP_TELEFONO"]);
                label5.Text = Convert.ToString(empresa["EMP_LOCALIDAD"]);
                label7.Text = Convert.ToString(empresa["EMP_MAIL"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Comprar_Ofertar.Comprar().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Menu().Show();
            this.Close();
        }
    }
}
