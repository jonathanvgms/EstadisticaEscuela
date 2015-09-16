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
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoNuevo : Form
    {
        EestadisticasEscuelaEntities context;

        public bool estado = true;

        private string nombreUsuario;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        private alumno alumnoModificado;

        internal alumno AlumnoModificado
        {
            get { return alumnoModificado; }
            set { alumnoModificado = value; }
        }

        public frmAlumnoNuevo()
        {
            InitializeComponent();

            context = new EestadisticasEscuelaEntities(); 
        }

        private void btnAlumnoNuevo_Click(object sender, EventArgs e)
        {
            bool error = true;
            
            alumno alum;

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
                /*
                 * si estado es true, el alumno no existe en la base de datos, por lo tanto lo agrego
                 */ 
                if(estado)
                {
                    // preguntar si existe el dni
                    if (context.alumno.Any(x => x.Dni == txtAlumnoNuevoDNI.Text))
                    {
                        //mostrar error el dni del alumno existente
                        lblAlumnoNuevoError.Text = "El DNI DEL ALUMNO YA EXISTE";
                    }
                    else
                    {
                        //agrego al nuevo alumno
                        try
                        {
                            //Traer el idUsuario del nombre del usuario
                            int idUser = context.usuario.Where(x => x.Nombre == txtAlumnoNuevoUsuario.Text).FirstOrDefault().Id;

                            context.alumno.Add(new alumno { Nombre = txtAlumnoNuevoNombre.Text, Apellido = txtAlumnoNuevoApellido.Text, Dni = txtAlumnoNuevoDNI.Text, Legajo = txtAlumnoNuevoLegajo.Text, Descripcion = txtAlumnoNuevoDescripcion.Text, IdUsuario = idUser });

                            context.SaveChanges();

                            lblAlumnoNuevoError.Text = "ALUMNO GUARDADO CON EXITO";
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                }
                else
                {
                    //traigo al alumno existente, lo modifico y persisto los cambios
                    try
                    {                    
                        int idAlum = Convert.ToInt32(alumnoModificado.Id);

                        alum = context.alumno.Where(x => x.Id == idAlum).FirstOrDefault();

                        alum.Nombre = txtAlumnoNuevoNombre.Text;

                        alum.Apellido = txtAlumnoNuevoApellido.Text;

                        alum.Dni = txtAlumnoNuevoDNI.Text;

                        alum.Legajo = txtAlumnoNuevoLegajo.Text;

                        alum.Descripcion = txtAlumnoNuevoDescripcion.Text;

                        alum.IdUsuario = context.usuario.Where(x => x.Nombre == txtAlumnoNuevoUsuario.Text).FirstOrDefault().Id;

                        context.SaveChanges();

                        lblAlumnoNuevoError.Text = "ALUMNO GUARDADO CON EXITO";
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
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

            txtAlumnoNuevoUsuario.Text = nombreUsuario;
        }

        private void frmAlumnoNuevo_Load(object sender, EventArgs e)
        {
            if (!estado)
            {
                txtAlumnoNuevoNombre.Text = alumnoModificado.Nombre;

                txtAlumnoNuevoApellido.Text = alumnoModificado.Apellido;

                txtAlumnoNuevoDNI.Text = alumnoModificado.Dni;

                txtAlumnoNuevoLegajo.Text = alumnoModificado.Legajo;

                txtAlumnoNuevoDescripcion.Text = alumnoModificado.Descripcion;

                txtAlumnoNuevoUsuario.Text = nombreUsuario;

                this.Text = "Modificar Alumno";
            }         
        }
    }
}
