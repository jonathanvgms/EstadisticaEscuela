using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    public partial class frmUsuarioNuevo : Form
    {
        public frmUsuarioNuevo()
        {
            InitializeComponent();
        }

        private bool checkData(ComboBox comboA, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0)
            {
                label.Text = "Seleccione Tipo de Usuarip";

                return false;
            }

            return true;
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtUsuarioNuevoUsuario") || textBox.Name.Equals("txtUsuarioNuevoContrasenia"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valor Incorrecto";

                        return false;
                    }
                }
            }
            else
            {
                label.Text = "Vacio";

                return false;
            }

            return true;
        }

        private void btnUsuarioNuevoAceptar_Click(object sender, EventArgs e)
        {
            /*
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
             */

            bool error = true;
            if (!checkData(txtUsuarioNuevoUsuario, lblUsuarioNuevoUsuarioError)) error = false;
            if (!checkData(txtUsuarioNuevoContrasenia, lblUsuarioNuevoContraseniaError)) error = false;
            if (!checkData(cmbUsuarioNuevoTipodeUsuario, lblUsuarioNuevoTipodeUsuarioError)) error = false;

            if (error)
            {
                Dominio.Usuario.Add(new Dominio.Usuario(txtUsuarioNuevoUsuario.Text, txtUsuarioNuevoContrasenia.Text, cmbUsuarioNuevoTipodeUsuario.SelectedIndex.ToString()));
                lblUsuarioNuevoError.Text = "USUARIO GUARDADO CON EXITO";
            }
        }

        private void btnUsuarioNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarioNuevoLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuarioNuevoUsuario.Clear();
            txtUsuarioNuevoContrasenia.Clear();
        }

        private void UsuarioNuevo_Load(object sender, EventArgs e)
        {
            this.cmbUsuarioNuevoTipodeUsuario.Items.Add("Alumno");
            this.cmbUsuarioNuevoTipodeUsuario.Items.Add("Administrador");
        }
    }
}
