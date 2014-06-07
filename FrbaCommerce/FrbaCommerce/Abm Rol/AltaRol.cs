using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





 /*           List<string> checkedItems = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
                checkedItems.Add(item.ToString());
            MessageBox.Show("" + checkedItems);
            

            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(checkedListBox1.Items[e.Index].ToString());
*/
          /*DataGridViewCheckBoxCell cellSelecion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;

            // Se valida si esta checkeada
            //
            if (Convert.ToBoolean(cellSelecion.Value)) {

            string mensaje = string.Format("Evento CellValueChanged.\n\nSe ha seccionado, \nDescripcion: '{0}', \nPrecio Unitario: '{1}', \nMedida: '{2}'",
            row.Cells["Descripcion"].Value,
            row.Cells["PrecioUnitario"].Value,
            row.Cells["UnidadMedida"].Value);
             
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
          */
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            rolTableAdapter1.Fill(gD1C2014DataSet1.ROL);
            checkedListBox1.DataSource = gD1C2014DataSet1.ROL;
            checkedListBox1.DisplayMember = "ROL_NOMBRE";
            checkedListBox1.ValueMember = "ROL_NOMBRE";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkedListBox1.CheckedItems.ToString());

           
        }
    }
}
