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
                
        public Calificar(int id)
        {
            InitializeComponent();
            compra_id = id;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calificar_Load(object sender, EventArgs e)
        {
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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Text = "1";

            compraTableAdapter1.Fill(gD1C2014DataSet1.COMPRA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agrego datos a la tabla de calificacion
            DataRow nueva = gD1C2014DataSet1.CALIFICACION.NewRow();
            nueva["CAL_CANT_ESTRELLAS"] = comboBox1.Text;
            nueva["CAL_DESCRIPCION"] = textBox1.Text;

            gD1C2014DataSet1.CALIFICACION.Rows.Add(nueva);
            calificacionTableAdapter1.Update(gD1C2014DataSet1.CALIFICACION);

            //Actualizo la tabla compras
            DataRow fila = gD1C2014DataSet1.COMPRA.NewRow();
            fila = gD1C2014DataSet1.COMPRA.FindByCOM_ID(compra_id);
            fila["COM_CAL_ID"] = Convert.ToDecimal(nueva["CAL_ID"]);
            compraTableAdapter1.Update(gD1C2014DataSet1.COMPRA);

            string usuario = usuarioTableAdapter1.get_username_by_id((int)Global.usuario_id);

            new FrbaCommerce.Calificar_Vendedor.BuscarCalificar(usuario).Show();
            this.Close();
        }
    }
}
