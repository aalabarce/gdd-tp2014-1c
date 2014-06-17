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
        int usuarioId;
        string tipo;

        public VerPublicacion(int id1, string tipoUsuario)
        {
            InitializeComponent();
            usuarioId = id1;
            tipo = tipoUsuario;

        }

        private void VerPublicacion_Load(object sender, EventArgs e)
        {
            this.empresaTableAdapter1.Fill(this.gD1C2014DataSet1.EMPRESA);
            this.clienteTableAdapter1.Fill(this.gD1C2014DataSet1.CLIENTE);

            if (tipo == "C")
            {
                DataRow cliente = gD1C2014DataSet1.CLIENTE.NewRow();
                cliente = gD1C2014DataSet1.CLIENTE.FindByCLI_ID(usuarioId);
                label3.Text = (string)cliente["CLI_NOM"];
            }
            else
            {
                int id =1;
                DataRow empresa = gD1C2014DataSet1.EMPRESA.NewRow();
                empresa = gD1C2014DataSet1.EMPRESA.FindByEMP_ID(id);

                DataRow[] foundRows = gD1C2014DataSet1.EMPRESA.Select("");
                label3.Text = "HOLA";//(string)usuario["EMP_RAZON_SOCIAL"];
            }
        }
    }
}
