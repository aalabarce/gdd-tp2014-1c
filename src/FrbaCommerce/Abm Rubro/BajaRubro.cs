using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rubro
{
    public partial class BajaRubro : Form
    {
        public BajaRubro()
        {
            InitializeComponent();
        }

        private void BajaRubro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.RUBRO' Puede moverla o quitarla según sea necesario.
            this.rUBROTableAdapter.Fill(this.gD1C2014DataSet.RUBRO);

        }
    }
}
