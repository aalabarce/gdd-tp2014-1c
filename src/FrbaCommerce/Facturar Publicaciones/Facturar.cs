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
        
        public Facturar()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2014DataSet.LINEAS_FACTURACION' Puede moverla o quitarla según sea necesario.
            this.lINEAS_FACTURACIONTableAdapter.FillByUsuID(this.gD1C2014DataSet.LINEAS_FACTURACION,Global.usuario_id);

        }
    }
}
