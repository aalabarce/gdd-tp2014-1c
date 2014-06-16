using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class Calificar : Form
    {
        public int compra_id {get;set;}
        public char tipo_compra { get; set; }
        
        public Calificar(int? id, char tipo)
        {
            InitializeComponent();
            compra_id = (int) id;
            tipo_compra = tipo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calificar_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "1";
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
            comboBox1.Items.Add(9);
            comboBox1.Items.Add(10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow nueva = gD1C2014DataSet1.CALIFICACION.NewRow();
            
            nueva["CAL_CANT_ESTRELLAS"] = comboBox1.Text;
            nueva["CAL_DESCRIPCION"] = textBox1.Text;

            gD1C2014DataSet1.CALIFICACION.Rows.Add(nueva);
            calificacionTableAdapter1.Update(gD1C2014DataSet1.CALIFICACION);

            int cal_id = Convert.ToInt32(nueva["CAL_ID"]);
            string usuario;

            if (tipo_compra == 'O')
            {
                DataRow fila = gD1C2014DataSet1.OFERTA.NewRow();
                fila["OFE_CAL_ID"] = cal_id;
                usuario =Convert.ToString(fila["OFE_USU_ID"]);
                ofertaTableAdapter1.Update(gD1C2014DataSet1.OFERTA);
            }
            else
            {
                DataRow fila = gD1C2014DataSet1.COMPRA.NewRow();
                fila["OFE_CAL_ID"] = cal_id;
                usuario = Convert.ToString( fila["COM_USU_ID"]);
                compraTableAdapter1.Update(gD1C2014DataSet1.COMPRA);
            }

            new FrbaCommerce.Calificar_Vendedor.BuscarCalificar(usuario).Show();
            this.Close();
        }
    }
}
