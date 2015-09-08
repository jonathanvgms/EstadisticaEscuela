using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    public partial class frmUsuarioNuevo : Form
    {
        Usuario usuarioNuevo;

        internal Usuario UsuarioNuevo
        {
            get { return usuarioNuevo; }
            set { usuarioNuevo = value; }
        }

        public frmUsuarioNuevo()
        {
            InitializeComponent();
        }

        private bool checkData(ComboBox comboA, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0)
            {
                label.Text = "Seleccione Tipo de Usuario";

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
            bool error = true;
            if (!checkData(txtUsuarioNuevoUsuario, lblUsuarioNuevoUsuarioError)) error = false;
            if (!checkData(txtUsuarioNuevoContrasenia, lblUsuarioNuevoContraseniaError)) error = false;
            

            if (error)
            {                
                //antes de realizar el insert en la base de datos, falta verificar que no existe el usuario

                Usuario.Add(new Usuario(txtUsuarioNuevoUsuario.Text, txtUsuarioNuevoContrasenia.Text, "1", (lsbUsuarioNuevoTipo.SelectedIndex + 1).ToString()));

                usuarioNuevo = Usuario.Select().Find(x => x.Nombre.Equals(txtUsuarioNuevoUsuario.Text));

                lblUsuarioNuevoError.Text = "USUARIO GUARDADO CON EXITO";
            }

            Close();
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
        
        private bool checkdata(ComboBox comboUsuario, ComboBox comboRol, Label labelUsuario, Label labelRol)
        {
            labelUsuario.Text = "";

            labelRol.Text = "";


            if (comboRol.SelectedIndex < 0)
            {
                labelRol.Text = "Seleccione Rol";

                return false;

            }
            if (comboUsuario.SelectedIndex < 0)
            {
                labelUsuario.Text = "Seleccione Usuario";

                return false;

            }

            return true;
        }
        /*
        private bool checkdata(ComboBox comboTipoUsuario, ComboBox comboTipoRol, Label label)
        {
            label.Text = "";

            if (comboTipoUsuario.SelectedIndex < 0 && comboTipoRol.SelectedIndex < 0)
            {
                label.Text = "Seleccione Tipo de Usuario y Tipo De Rol";
                return false;
            }
            else
            {
                if (comboTipoUsuario.SelectedIndex < 0)
                {
                    label.Text = "Seleccione Tipo de Usuario";

                    return false;

                }
                if (comboTipoRol.SelectedIndex < 0)
                {
                    label.Text = "Seleccione TipoRol";

                    return false;

                }
            }
            return true;
        }
         * */
    }
}
