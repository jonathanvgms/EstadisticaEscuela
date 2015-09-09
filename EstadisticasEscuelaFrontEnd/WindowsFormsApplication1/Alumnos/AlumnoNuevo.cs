using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd;
using EstadisticasEscuelaFrontEnd.Database;
using EstadisticasEscuelaFrontEnd.Dominio;
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Usuarios;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoNuevo : Form
    {
        private Usuario nuevoUsuario { get; set; }

        private Alumno alumnoModificado;

        internal Alumno AlumnoModificado
        {
            get { return alumnoModificado; }
            set { alumnoModificado = value; }
        }

        public frmAlumnoNuevo()
        {
            InitializeComponent();
        }

        private void btnAlumnoNuevo_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtAlumnoNuevoNombre, lblAlumnoNuevoNombreError)) error = false;

            if (!checkData(txtAlumnoNuevoApellido, lblAlumnoNuevoApellidoError)) error = false;

            if (!checkData(txtAlumnoNuevoDNI, lblAlumnoNuevoDniError)) error = false;

            if (!checkData(txtAlumnoNuevoLegajo, lblAlumnoNuevoLegajoError)) error = false;

            if (!checkData(txtAlumnoNuevoDescripcion, lblAlumnoNuevoDescripcionError)) error = false;

            if (txtAlumnoNuevoUsuario.Text.Length == 0)
            {
                error = false;

                lblAlumnoNuevoUsuarioError.Text = "Seleccionar Usuario";
            }
            

            if (error)
            {
                if ((Alumno.Select("where DNI = " + txtAlumnoNuevoDNI.Text).Count == 0)&&(alumnoModificado.Nombre.Length != 0))
                {
                    Alumno.Add(new Alumno(txtAlumnoNuevoNombre.Text, txtAlumnoNuevoApellido.Text, txtAlumnoNuevoLegajo.Text, txtAlumnoNuevoDNI.Text, nuevoUsuario.Id));
                    lblAlumnoNuevoError.Text = "ALUMNO GUARDADO CON EXITO ";
                }

                else
                {
                    MessageBox.Show("El DNI del alumno ya existe");
                }

            }


        }

        private bool checkData(ComboBox comboA, ComboBox comboB, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0 && comboB.SelectedIndex < 0)
            {
                label.Text = "Seleccione Curso y División";
            }
            else
            {
                if (comboA.SelectedIndex < 0)
                {
                    label.Text = "Seleccione Curso";

                    return false;
                }

                if (comboB.SelectedIndex < 0)
                {
                    label.Text += "Seleccione División";

                    return false;
                }
            }

            return true;
        }

        private bool checkData(ComboBox combo, Label label)
        {
            label.Text = "";

            if (combo.SelectedIndex < 0)
            {
                label.Text = "Seleccione Especialidad";

                return false;
            }

            return true;
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtAlumnoNuevoNombre") || textBox.Name.Equals("txtAlumnoNuevoApellido") || textBox.Name.Equals("txtAlumnoNuevoDescripcion"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valor Incorrecto";

                        return false;
                    }
                }

                if (textBox.Name.Equals("txtAlumnoNuevoDNI") || textBox.Name.Equals("txtAlumnoNuevoLegajo"))
                {
                    if (!Util.todasNumeros(textBox.Text))
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

        private void btnAlumnoNuevoLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoNuevoNombre.Clear();

            txtAlumnoNuevoApellido.Clear();

            txtAlumnoNuevoLegajo.Clear();

            txtAlumnoNuevoDNI.Clear();

            txtAlumnoNuevoDescripcion.Clear();

            //lblMessage.Text = "";

            lblAlumnoNuevoNombreError.Text = "";

            lblAlumnoNuevoApellidoError.Text = "";

            lblAlumnoNuevoLegajoError.Text = "";

            lblAlumnoNuevoDniError.Text = "";

            lblAlumnoNuevoDescripcionError.Text = "";

        }

        private void btnAlumnoNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlumnoNuevoBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarioBuscar unFrmUsuarioBuscar = new frmUsuarioBuscar();

            unFrmUsuarioBuscar.ShowDialog(this);

            /*
             * error si busco un usuario y no traigo nada
             */ 
            
            nuevoUsuario = unFrmUsuarioBuscar.UsuarioBuscado;

            txtAlumnoNuevoUsuario.Text = nuevoUsuario.Nombre;
        }

        private void frmAlumnoNuevo_Load(object sender, EventArgs e)
        {
            try
            {
                if (alumnoModificado.Nombre.Length != 0)
                {
                    txtAlumnoNuevoNombre.Text = alumnoModificado.Nombre;

                    txtAlumnoNuevoApellido.Text = alumnoModificado.Apellido;

                    txtAlumnoNuevoDNI.Text = alumnoModificado.Dni;

                    txtAlumnoNuevoLegajo.Text = alumnoModificado.Legajo;

                    txtAlumnoNuevoUsuario.Text = alumnoModificado.IdUsuario;

                }
            }
            catch
            { 

            }
        }
    }
}
