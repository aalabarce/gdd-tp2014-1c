using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Login
{
    public partial class ContraseñasUsuarios : Form
    {
        public ContraseñasUsuarios()
        {
            InitializeComponent();
        }

        private void ContraseñasUsuarios_Load(object sender, EventArgs e)
        {
            this.uSUARIOTableAdapter.Fill(this.gD1C2014DataSet.USUARIO);
            dataGridView1.Columns[1].DefaultCellStyle.NullValue = "Modificar";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                int codigo = Convert.ToInt32(fila.Cells[2].Value);

                new FrbaCommerce.Login.CambioContraseña(codigo).Show();
            }
        }
    }
}
