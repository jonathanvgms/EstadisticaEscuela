﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    public partial class UsuarioNuevo : Form
    {
        public UsuarioNuevo()
        {
            InitializeComponent();
        }

        private void btnfrmUsuarioAceptar_Click(object sender, EventArgs e)
        {
            string cadena = "";
            if (!txtUsuario.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtUsuario.Text))
                {
                    cadena += "El campo Usuario tiene valores incorrectos.\n";
                }
               
            }

            else
            {
                cadena += " El campo Usuario esta vacio.\n";
            }

            if (!txtContrasenia.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtContrasenia.Text))
                {
                    cadena += "El campo Contraseña tiene valores incorrectos.\n";
                }
            }

            else
            {
                cadena += "El campo Contraseña esta vacio.\n";
            }

            if (this.cmbUsuarioTipodeUsuario.Text.Equals(""))
            {
                cadena += "Seleccione un tipo de usuario.\n";
            }

            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }

        }

        private void btnfrmUsuarioCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnfrmUsuarioLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.cmbUsuarioTipodeUsuario.Items.Add("Alumno");
            this.cmbUsuarioTipodeUsuario.Items.Add("Loyaga");
            this.cmbUsuarioTipodeUsuario.Items.Add("Administrador");
        }
    }
}
