using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rol
{
    public partial class ModRol : Form
    {
        public string nombre { get; set; }

        public ModRol(string nom_rol)
        {
            InitializeComponent();
            nombre = nom_rol;
        }

        private void ModRol_Load(object sender, EventArgs e)
        {
            rolTableAdapter1.Fill(gD1C2014DataSet1.ROL);
            funcionalidadTableAdapter1.Fill(gD1C2014DataSet1.FUNCIONALIDAD);
            roL_FUNCIONALIDADTableAdapter1.Fill(gD1C2014DataSet1.ROL_FUNCIONALIDAD);

            int id = Convert.ToInt32(rolTableAdapter1.buscarID(nombre));
            DataRow FilaAModificar = gD1C2014DataSet1.ROL.NewRow();
            FilaAModificar = gD1C2014DataSet1.ROL.FindByROL_ID(id);
            textBox1.Text = Convert.ToString(FilaAModificar["ROL_NOMBRE"]);

            if(Convert.ToInt32(FilaAModificar["ROL_BAJA"]) == 0) 
            {
                radioButton4.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            comboBox1.Visible = false;
            textBox1.Enabled = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = true;

            comboBox1.Text = "";
            comboBox1.DataSource = rolTableAdapter1.funcionalidadesDeUnRol(nombre);
            comboBox1.DisplayMember = "FUN_NOMBRE";
            comboBox1.ValueMember = "FUN_ID";


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = true;

            comboBox1.Text = "";
            comboBox1.DataSource = rolTableAdapter1.funcQueNoTieneUnRol(nombre);
            comboBox1.DisplayMember = "FUN_NOMBRE";
            comboBox1.ValueMember = "FUN_ID";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label1.Visible = true;
            
            comboBox1.Visible = false;
            textBox1.Text = nombre;
            textBox1.Visible = true;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Abm_Rol.BuscarRol().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rol_id = Convert.ToInt32(rolTableAdapter1.buscarID(nombre));

            if (radioButton1.Checked || (!radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked))
            {

                DataRow filaAModificar = gD1C2014DataSet1.ROL.NewRow();
                filaAModificar = gD1C2014DataSet1.ROL.FindByROL_ID(rol_id);
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Debe completar el campo nombre");
                    return;
                }
                if (rolTableAdapter1.existeRol(textBox1.Text) > 0)
                {
                    MessageBox.Show("Ya existe un rol con ese nombre");
                    return;
                }

                filaAModificar["ROL_NOMBRE"] = textBox1.Text;
                rolTableAdapter1.Update(gD1C2014DataSet1.ROL);
                MessageBox.Show("El nombre del rol ha sido cambiado");
            }
          
            if (radioButton2.Checked)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("No hay funcionalidades para quitar");
                    return;
                }
                string fun = comboBox1.Text;
                int fun_id = Convert.ToInt32(funcionalidadTableAdapter1.BuscarID(fun));

                roL_FUNCIONALIDADTableAdapter1.borrarFila(rol_id, fun_id);
                MessageBox.Show("Se le quito al rol 1 funcionalidad");
            }

            if (radioButton3.Checked)
            {
                if (comboBox1.Text == "") 
                {
                    MessageBox.Show("No hay funcionalidades para agregar");
                    return;
                }
                string fun = comboBox1.Text;
                int fun_id = Convert.ToInt32(funcionalidadTableAdapter1.BuscarID(fun));

                DataRow rol_funcionalidad = gD1C2014DataSet1.ROL_FUNCIONALIDAD.NewRow();

                rol_funcionalidad["ROL_FUN_ROL"] = rol_id;
                rol_funcionalidad["ROL_FUN_FUN"] = fun_id;

                gD1C2014DataSet1.ROL_FUNCIONALIDAD.Rows.Add(rol_funcionalidad);
                roL_FUNCIONALIDADTableAdapter1.Update(gD1C2014DataSet1.ROL_FUNCIONALIDAD);
                MessageBox.Show("Se asocio al rol 1 funcionalidad");
            }

            if (radioButton4.Checked) 
            {
                DataRow filaAModificar = gD1C2014DataSet1.ROL.NewRow();
                filaAModificar = gD1C2014DataSet1.ROL.FindByROL_ID(rol_id);

                filaAModificar["ROL_BAJA"] = 0;
                rolTableAdapter1.Update(gD1C2014DataSet1.ROL);
                MessageBox.Show("El rol ha sido habilitado");
            }

            new FrbaCommerce.Abm_Rol.BuscarRol().Show();
            this.Close();
        }


    }
}
