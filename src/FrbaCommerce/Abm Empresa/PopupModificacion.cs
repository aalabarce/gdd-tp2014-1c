using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class PopupModificacion : Form
    {
        int? empresaId;

        public PopupModificacion(int? id)
        {
            InitializeComponent();
            empresaId = id;
        }

        private void PopupModificacion_Load(object sender, EventArgs e)
        {
            // Cargo los valores que traje de la base de datos
            this.empresaTableAdapter1.Fill(this.gD1C2014DataSet1.EMPRESA);
            DataRow FilaAModificar = gD1C2014DataSet1.EMPRESA.NewRow();
            FilaAModificar = gD1C2014DataSet1.EMPRESA.FindByEMP_ID((int)empresaId);

            textBox1.Text = Convert.ToString(FilaAModificar["EMP_RAZON_SOCIAL"]);
            textBox2.Text = Convert.ToString(FilaAModificar["EMP_MAIL"]);
            textBox3.Text = Convert.ToString(FilaAModificar["EMP_TELEFONO"]);
            textBox4.Text = Convert.ToString(FilaAModificar["EMP_CALLE"]);
            textBox5.Text = Convert.ToString(FilaAModificar["EMP_CALLE_NRO"]);
            textBox6.Text = Convert.ToString(FilaAModificar["EMP_PISO"]);
            textBox12.Text = Convert.ToString(FilaAModificar["EMP_DPTO"]);
            textBox11.Text = Convert.ToString(FilaAModificar["EMP_LOCALIDAD"]);
            textBox10.Text = Convert.ToString(FilaAModificar["EMP_COD_POSTAL"]);
            textBox9.Text = Convert.ToString(FilaAModificar["EMP_CIUDAD"]);
            textBox8.Text = Convert.ToString(FilaAModificar["EMP_CUIT"]);
            textBox7.Text = Convert.ToString(FilaAModificar["EMP_NOM_CONTACTO"]);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // VOLVER
            if (MessageBox.Show("¿Está seguro que desea volver? Perdera todos los datos cargados hasta ahora", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PERSISTIR MODIFICACION
            /* VALIDO */
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
                return;
            }

            if (empresaTableAdapter1.ExisteEmpresa(textBox1.Text, textBox8.Text) > 0)
            {
                MessageBox.Show("Ya existe una empresa con esa razón social y CUIT");
                return;
            }

            if (empresaTableAdapter1.ExisteCUIT(textBox11.Text) > 0)
            {
                MessageBox.Show("Ya existe una empresa con ese CUIT");
                return;
            }

            if (!MetodosGlobales.esInteger(textBox3) || !MetodosGlobales.esInteger(textBox5) || !MetodosGlobales.esInteger(textBox6))
            {
                return;
            }
            // Si está todo bien, le pego a la base de datos
            MessageBox.Show("1");
            persistir();

        }

        private void persistir()
        {
            DataRow FilaAModificar = gD1C2014DataSet1.EMPRESA.NewRow();
            FilaAModificar = gD1C2014DataSet1.EMPRESA.FindByEMP_ID((int)empresaId);

              FilaAModificar["EMP_RAZON_SOCIAL"] = textBox1.Text;
              FilaAModificar["EMP_MAIL"] = textBox2.Text;
              FilaAModificar["EMP_TELEFONO"] = textBox3.Text;
              FilaAModificar["EMP_CALLE"] = textBox4.Text;
              FilaAModificar["EMP_CALLE_NRO"] = textBox5.Text;
              FilaAModificar["EMP_PISO"] = textBox6.Text;
              FilaAModificar["EMP_DPTO"] = textBox12.Text;
              FilaAModificar["EMP_LOCALIDAD"] = textBox11.Text;
              FilaAModificar["EMP_COD_POSTAL"] = textBox10.Text;
              FilaAModificar["EMP_CIUDAD"] = textBox9.Text;
              FilaAModificar["EMP_CUIT"] = textBox8.Text;
              FilaAModificar["EMP_NOM_CONTACTO"] = textBox7.Text;

              empresaTableAdapter1.Update(gD1C2014DataSet1.EMPRESA);

              MessageBox.Show("La empresa " + textBox1.Text + " ha sido modificada");
              empresaTableAdapter1.Fill(gD1C2014DataSet1.EMPRESA);

              new FrbaCommerce.Abm_Empresa.Modificacion().Show();
              this.Close();

        }
    }
}
