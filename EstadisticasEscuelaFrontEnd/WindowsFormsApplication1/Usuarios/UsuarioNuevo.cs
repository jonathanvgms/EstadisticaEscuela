using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Dominio;
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Usuarios;
using EstadisticasEscuelaFrontEnd.Modelo;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    public partial class frmUsuarioNuevo : Form
    {
        Usuario usuarioNuevo;

        EestadisticasEscuelaEntities context;

        public bool estado = true;

        internal Usuario UsuarioNuevo
        {
            get { return usuarioNuevo; }
            set { usuarioNuevo = value; }
        }

        public frmUsuarioNuevo()
        {
            InitializeComponent();

            context = new EestadisticasEscuelaEntities();

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

            Usuario usuar;

            if (!checkData(txtUsuarioNuevoUsuario, lblUsuarioNuevoUsuarioError)) error = false;
            if (!checkData(txtUsuarioNuevoContrasenia, lblUsuarioNuevoContraseniaError)) error = false;
            

            if (error)
            {                
                if(estado)
                {
                    if (context.usuario.Any(x => x.Nombre == txtUsuarioNuevoUsuario.Text))
                    {
                        lblUsuarioNuevoError.Text = "EL USUARIO YA EXISTE";
                    }
                    
                        
                    else
                    {
                        try
                        {
                            context.usuario.Add(new usuario { Nombre = txtUsuarioNuevoUsuario.Text, Contrasenia = txtUsuarioNuevoContrasenia.Text, Habilitado = false, IdRol = lsbUsuarioNuevoTipo.SelectedIndex + 1 });

                            context.SaveChanges();

                            lblUsuarioNuevoError.Text = "USUARIO GUARDADO CON EXITO";
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                }
                //antes de realizar el insert en la base de datos, falta verificar que no existe el usuario
                /*
                Usuario.Add(new Usuario(txtUsuarioNuevoUsuario.Text, txtUsuarioNuevoContrasenia.Text, "1", (lsbUsuarioNuevoTipo.SelectedIndex + 1).ToString()));

                usuarioNuevo = Usuario.Select().Find(x => x.Nombre.Equals(txtUsuarioNuevoUsuario.Text));

                lblUsuarioNuevoError.Text = "USUARIO GUARDADO CON EXITO";
                 * */
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
        public void loadUsuarioNuevo()
        {
            context.rol.Select(x => lsbUsuarioNuevoTipo.Items.Add(x.Nombre));
        }

        private void frmUsuarioNuevo_Load(object sender, EventArgs e)
        {
            //context.rol.Select(x => lsbUsuarioNuevoTipo.Items.Add(x.Nombre));
            try
            {
                context.rol.ToList().ForEach(x => Console.WriteLine(x.Nombre));
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }
    }
}
