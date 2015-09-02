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

<<<<<<< .mine
||||||| .r73
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

=======
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

>>>>>>> .r75
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
            if (!checkdata(cmbUsuarioNuevoTipodeUsuario, cmbUsuarioNuevoTipoDeRol, lblUsuarioNuevoTipodeUsuarioError, lblUsuarioNuevoTipoDeRolError)) error = false;
            

            if (error)
            {
                Dominio.Usuario.Add(new Dominio.Usuario(txtUsuarioNuevoUsuario.Text, txtUsuarioNuevoContrasenia.Text,"1"));
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
            this.cmbUsuarioNuevoTipoDeRol.Items.Add("Docente");
            this.cmbUsuarioNuevoTipoDeRol.Items.Add("Alumno");
            this.cmbUsuarioNuevoTipoDeRol.Items.Add("Preceptor");
            this.cmbUsuarioNuevoTipoDeRol.Items.Add("Secretario");
            this.cmbUsuarioNuevoTipoDeRol.Items.Add("Administrador");

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
