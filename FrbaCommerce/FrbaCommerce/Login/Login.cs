﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Login
{
    public partial class Login : Form
    {
        public bool exito { get; set; }
        public string usuario { get; set; }
        public string rol { get; set; }

        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exito = false;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
                return;                
            }
            usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            if (usuarioTableAdapter1.existeUsuario(usuario)==1) //Le mando a usuarioTableAdaapter el mensaje "Existe Usuario", que me devuelve 0 o 1
            {
                MessageBox.Show("Existe!!");
                if (usuarioTableAdapter1.habilitadoUsuario(usuario) == 1)
                {
                    MessageBox.Show("Está habilitado");
                    if (Convert.ToInt32(usuarioTableAdapter1.passValido(usuario, contraseña)) == 1)
                    {
                        MessageBox.Show("Contraseña coincide");
                        usuarioTableAdapter1.resetearIntentosFallidos(usuario);
                        if (usuariO_ROLTableAdapter1.cantidadRoles(usuario) > 1)
                        {

                            new FrbaCommerce.Login.MasDeUno(this).Show();
                            this.Hide();
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Rol chequeado");
                            this.rol = usuariO_ROLTableAdapter1.rolPorDefecto(usuario);
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Contraseña NO coincide, se te agrega intento fallido. Cabió");
                        usuarioTableAdapter1.agregaIntentoFallido(usuario);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario inhabilitado, comuníquese con Administración para resolver el problema");
                }

            }
            else
            {
                MessageBox.Show("No existe!!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}