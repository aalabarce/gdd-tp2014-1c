﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Ofertar : Form
    {
        public Ofertar()
        {
            InitializeComponent();
        }

        private void Ofertar_Load(object sender, EventArgs e)
        {
            publicacionTableAdapter1.SubastasActivas(gD1C2014DataSet1.PUBLICACION);
            dataGridView1.Columns[3].DefaultCellStyle.NullValue = "Ofertar";
        }
    }
}
