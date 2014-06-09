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
    public partial class editar : Form
    {
        public int codigo { get; set; }
        public editar(int codigo_mod)
        {
            InitializeComponent();
            codigo = codigo_mod;
            
        }

        private void editar_Load(object sender, EventArgs e)
        {
            this.publicacionTableAdapter1.Fill(this.gD1C2014DataSet1.PUBLICACION);
            DataRow fila = gD1C2014DataSet1.PUBLICACION.NewRow();
            fila = gD1C2014DataSet1.PUBLICACION.FindByPUB_ID(codigo);
            txtDescripcion.Text = fila["PUB_DESCRIPCION"].ToString();
            txtPrecio.Text = fila["PUB_PRECIO"].ToString();
            txtStock.Text = fila["PUB_STOCK"].ToString();

            
        }

      
    }
}
