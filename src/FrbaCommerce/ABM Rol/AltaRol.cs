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
               
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            funcionalidadTableAdapter1.Fill(gD1C2014DataSet1.FUNCIONALIDAD);
            checkedListBox1.DataSource = gD1C2014DataSet1.FUNCIONALIDAD;
            checkedListBox1.DisplayMember = "FUN_NOMBRE";
            checkedListBox1.ValueMember = "FUN_ID";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            //VALIDO
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos 1 funcionalidad");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe completar el campo nombre");
                return;
            }
            if (rolTableAdapter1.existeRol(textBox1.Text) >0 )
            {
                MessageBox.Show("Ya existe un rol con ese nombre");
                return;
            }


            //Doy el alta al rol
            altaRol();

            this.Close();
            
        }

        private void altaRol()
        {
            DataRow nuevo = gD1C2014DataSet1.ROL.NewRow();

            nuevo["ROL_NOMBRE"] = textBox1.Text;
            nuevo["ROL_BAJA"]= 0;

            gD1C2014DataSet1.ROL.Rows.Add(nuevo);
            rolTableAdapter1.Update(gD1C2014DataSet1.ROL);

            int rol_id = Convert.ToInt32(rolTableAdapter1.buscarID(textBox1.Text));
            altaRolXFun(rol_id);
        }

        private void altaRolXFun(int rol_id)
        {
            DataRowView drv;
            int fun_Id;
            DataRow rol_funcionalidad;
            foreach (object funcionalidad in checkedListBox1.CheckedItems)
            {
                drv = (DataRowView)funcionalidad;
                fun_Id = Convert.ToInt32(drv["FUN_ID"]);

                rol_funcionalidad = gD1C2014DataSet1.ROL_FUNCIONALIDAD.NewRow();

                rol_funcionalidad["ROL_FUN_ROL_ID"] = rol_id;
                rol_funcionalidad["ROL_FUN_FUN_ID"] = fun_Id;

                gD1C2014DataSet1.ROL_FUNCIONALIDAD.Rows.Add(rol_funcionalidad);
            }

            roL_FUNCIONALIDADTableAdapter1.Update(gD1C2014DataSet1.ROL_FUNCIONALIDAD);
            MessageBox.Show("Se asociaron al rol " + checkedListBox1.CheckedItems.Count.ToString() + " funcionalidades");
        
        }
    }
}
