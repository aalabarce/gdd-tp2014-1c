﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{

    public partial class VerPublicacion : Form
    {
        int usuarioId, publicacionId, stock;
        string tipo;

        public VerPublicacion(int id, string tipoUsuario, int pubId)
        {
            InitializeComponent();
            usuarioId = id;
            tipo = tipoUsuario;
            publicacionId = pubId;

        }

        private void VerPublicacion_Load(object sender, EventArgs e)
        {
            this.publicacionTableAdapter1.Fill(this.gD1C2014DataSet1.PUBLICACION);
            DataRow publicacion = gD1C2014DataSet1.PUBLICACION.NewRow();
            publicacion = gD1C2014DataSet1.PUBLICACION.FindByPUB_ID(publicacionId);

            label3.Text = Convert.ToString(publicacion["PUB_DESCRIPCION"]);
            label4.Text = Convert.ToString(publicacion["PUB_STOCK"]);
            label6.Text = Convert.ToString(publicacion["PUB_PRECIO"]);
            stock = Convert.ToInt32(publicacion["PUB_STOCK"]);
            // Escondo el boton si la publicacion no permite preguntas
            if ( Convert.ToString(publicacion["PUB_PERMITIR_PREGUNTAS"]) == "0")
                button2.Visible = false;

            /* this.empresaTableAdapter1.Fill(this.gD1C2014DataSet1.EMPRESA);
            this.clienteTableAdapter1.Fill(this.gD1C2014DataSet1.CLIENTE);

            if (tipo == "C")
            {
                DataRow cliente = gD1C2014DataSet1.CLIENTE.NewRow();
                cliente = gD1C2014DataSet1.CLIENTE.FindByCLI_ID(usuarioId);
                label3.Text = (string)cliente["CLI_NOM"];
            }
            else
            {

                DataRow empresa = gD1C2014DataSet1.EMPRESA.NewRow();

                empresa = gD1C2014DataSet1.EMPRESA.FindByEMP_ID(usuarioId);

                //DataRow gello = gD1C2014DataSet1.EMPRESA.FindByEMP_ID(id);
                // int? hola = 88;
                //usuario = empresaTableAdapter1.BuscarPorUsuId(gD1C2014DataSet1.EMPRES, 5);
                //empresaTableAdapter1.BuscarPorUsuId(gD1C2014DataSet1.EMPRESA, hola);

                DataRow[] foundRows = gD1C2014DataSet1.EMPRESA.Select("");
                label3.Text = "HOLA";//(string)usuario["EMP_RAZON_SOCIAL"];*/
            }

        private void button1_Click(object sender, EventArgs e)
        {
           // CONFIRMAR COMPRA

            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe indicar la cantidad que desea comprar");
                return;
            }

            if (Convert.ToInt32(textBox1.Text) > stock)
            {
                MessageBox.Show("La cantidad máxima que puede comprar es de: " + Convert.ToString(stock) + " unidades");
                return;
            }

            DataRow nuevaCompra = gD1C2014DataSet1.COMPRA.NewRow();
            nuevaCompra["COM_PUB_ID"] = publicacionId;
            nuevaCompra["COM_CANTIDAD"] = textBox1.Text;
            nuevaCompra["COM_FECHA"] = DateTime.Now;
            nuevaCompra["COM_USU_ID"] = Global.usuario_id;

            gD1C2014DataSet1.COMPRA.Rows.Add(nuevaCompra);

            compraTableAdapter1.Update(gD1C2014DataSet1.COMPRA);

            // Actualizo el stock de ese producto
            publicacionTableAdapter1.ActualizarStock((decimal?)stock, (decimal)publicacionId);
            // Actualizo el datagrid
            //this.publicacionTableAdapter1.Fill(this.gD1C2014DataSet1.PUBLICACION);
            // Le muestro los datos del vendedor
            new FrbaCommerce.Comprar_Ofertar.VerVendedor(usuarioId, tipo).Show();
            this.Close();
            
            
        }


      }
  }


