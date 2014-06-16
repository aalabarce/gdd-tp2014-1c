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
            DataRow usuario = gD1C2014DataSet1.USUARIO.NewRow();
            //string nombre; 


            if (tipoUsuario == "C")
            {
                usuario = gD1C2014DataSet1.CLIENTE.FindByCLI_ID(usuarioId);
                label3.Text = (string) usuario["CLI_NOM"];
            }
            else
            {
                int id = 32;
                usuario = gD1C2014DataSet1.EMPRESA.FindByEMP_ID(id);

                DataRow gello = gD1C2014DataSet1.EMPRESA.FindByEMP_ID(id);
                // int? hola = 88;
                //usuario = empresaTableAdapter1.BuscarPorUsuId(gD1C2014DataSet1.EMPRES, 5);
                //empresaTableAdapter1.BuscarPorUsuId(gD1C2014DataSet1.EMPRESA, hola); 

                DataRow[] foundRows = gD1C2014DataSet1.EMPRESA.Select("");
                label3.Text = "HOLA";//(string)usuario["EMP_RAZON_SOCIAL"];
            }
            

        }
    }
}
