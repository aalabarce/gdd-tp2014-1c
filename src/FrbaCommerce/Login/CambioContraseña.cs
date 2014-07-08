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
    public partial class CambioContraseña : Form
    {
        public int usu_id { get; set; }
        public int tipo_ejecucion { get; set; }

        public CambioContraseña(int usu,int tipo)
        {
            InitializeComponent();

            usu_id = usu;
            tipo_ejecucion = tipo;
        }

        private void CambioContraseña_Load(object sender, EventArgs e)
        {
            usuarioTableAdapter1.Fill(gD1C2014DataSet1.USUARIO);

            if (tipo_ejecucion == 0)
                label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tipo_ejecucion == 0)
            {
                if (MessageBox.Show("Si cancela, su usuario sera dado de baja. ¿Esta seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataRow fila = gD1C2014DataSet1.USUARIO.NewRow();
                    fila = gD1C2014DataSet1.USUARIO.FindByUSU_ID(usu_id);

                    fila["USU_BAJA"] = 1;

                    usuarioTableAdapter1.Update(gD1C2014DataSet1.USUARIO);
                }
                else
                {
                    return;
                }
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ( textBox1.Text == "")
            {
                MessageBox.Show("El campo contraseña no puede estar vacio");
                return;
            }
            if ( textBox1.Text == "1234")
            {
                MessageBox.Show("La nueva contraseña es invalida");
                return;
            }

            DataRow fila = gD1C2014DataSet1.USUARIO.NewRow();
            fila = gD1C2014DataSet1.USUARIO.FindByUSU_ID(usu_id);

            fila["USU_PASSWORD"] = MetodosGlobales.sha256(textBox1.Text);

            usuarioTableAdapter1.Update(gD1C2014DataSet1.USUARIO);

            MessageBox.Show("La contraseña ha sido cambiada correctamente");
            this.Close();
        }
    }
}
