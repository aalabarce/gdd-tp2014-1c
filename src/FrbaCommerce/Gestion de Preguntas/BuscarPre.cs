using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class BuscarPre : Form
    {
        public BuscarPre()
        {
            InitializeComponent();
        }

        private void ResponderPre_Load(object sender, EventArgs e)
        {
            this.pREGUNTAS_A_RESPONDERTableAdapter.FillByUsuario(this.gD1C2014DataSet.PREGUNTAS_A_RESPONDER, Global.usuario_id);
            dataGridView1.Columns[2].DefaultCellStyle.NullValue = "Responder";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                int preg_id = Convert.ToInt32(fila.Cells[3].Value);
                
                new FrbaCommerce.Gestion_de_Preguntas.Responder(preg_id).Show();
                this.Close();
            }
        }
    }
}
