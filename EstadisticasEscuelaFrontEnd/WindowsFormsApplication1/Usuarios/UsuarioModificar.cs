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
    public partial class frmUsuarioModificar : Form
    {
        public frmUsuarioModificar()
        {
            InitializeComponent();
        }
        private Usuario usuarioModificado;

        internal Usuario UsuarioModificado
        {
            get { return usuarioModificado; }
            set { usuarioModificado = value; }
        }
                
        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtUsuarioModificarNombre") || textBox.Equals("txtUsuarioModificarContrasenia"))
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

            return false;
        }

        private bool checkData(ComboBox combo, Label label)
        {
            label.Text = "";

            if (combo.SelectedIndex < 0)
            {
                label.Text = "Seleccione Tipo de Usuario";

                return false;
            }

            return true;
        }
            
        
        private void frmUsuarioModificar_Load(object sender, EventArgs e)
        {
            this.cmbUsuarioModificarTipoDeUsuario.Items.Add("Usuario");
            this.cmbUsuarioModificarTipoDeUsuario.Items.Add("Administrador");
        }

        private void btnUsuarioModificarCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarioModificarAceptar_Click_1(object sender, EventArgs e)
        {
            Usuario.Update(new Usuario(usuarioModificado.Id, txtUsuarioModificarNombre.Text, txtUsuarioModificarContrasenia.Text, "1"));

            bool error = true;

            if (!checkData(txtUsuarioModificarNombre, lblUsuarioModificarNombreError)) error = false;

            if (!checkData(txtUsuarioModificarContrasenia, lblUsuarioModificarContraseniaError)) error = false;

            if (!checkData(cmbUsuarioModificarTipoDeUsuario, lblUsuarioModificarTipoDeUsuarioError)) error = false;

            if (error)
            {
                Usuario.Add(new Usuario(txtUsuarioModificarNombre.Text, txtUsuarioModificarContrasenia.Text, cmbUsuarioModificarTipoDeUsuario.Text.ToString()));
                
                lblUsuarioModificarError.Text = "USUARIO MODIFICADO CON EXITO";
            }
        }

        private void btnUsuarioModificarLimpiar_Click_1(object sender, EventArgs e)
        {
            txtUsuarioModificarNombre.Clear();
            txtUsuarioModificarContrasenia.Clear();
        }
    }
}
