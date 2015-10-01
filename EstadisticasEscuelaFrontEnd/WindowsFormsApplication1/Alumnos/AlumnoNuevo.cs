using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd;
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Usuarios;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoNuevo : Form
    {
        EstadisticasEscuelaEntities context;

        //si el estado es true es modo Alumno Nuevo, sino es Modificar Alumno
        public bool estado = true;

        private AlumnoModificado alum;

        internal AlumnoModificado Alum
        {
            get { return alum; }
            set { alum = value; }
        }

        public frmAlumnoNuevo()
        {
            InitializeComponent();

            context = new EstadisticasEscuelaEntities(); 
        }

        private void btnAlumnoNuevo_Click(object sender, EventArgs e)
        {
            string msjError = "";

            if (!Util.EsAlfabetico(txtAlumnoNuevoNombre.Text))
            {
                msjError += "Nombre: Incorrecto/Incompleto\n";
            }

            if (!Util.EsAlfabetico(txtAlumnoNuevoApellido.Text))
            {
                msjError += "Apellido: Incorrecto/Incompleto\n";
            }
            
            if (!Util.EsNumerico(txtAlumnoNuevoDNI.Text))
            {
                msjError += "DNI: Incorrecto/Incompleto\n";
            }
            
            if (!Util.EsNumerico(txtAlumnoNuevoLegajo.Text))
            {
                msjError += "Legajo: Incorrecto/Incompleto\n";
            }

            if (txtAlumnoNuevoUsuario.Text.Equals(""))
            {
                msjError += "Usuario: Seleccionar\n";
            }
                        
            if (msjError.Length == 0)
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
                        MessageBox.Show("El DNI DEL ALUMNO YA EXISTE");
                    }
                    else
                    {
                        //agrego al nuevo alumno
                        try
                        {
                            //Traer el idUsuario del nombre del usuario
                            int idUser = context.usuario.Where(x => x.Nombre == txtAlumnoNuevoUsuario.Text).FirstOrDefault().Id;

                            context.alumno.Add(new alumno { Nombre = txtAlumnoNuevoNombre.Text, Apellido = txtAlumnoNuevoApellido.Text, Dni = txtAlumnoNuevoDNI.Text, Legajo = txtAlumnoNuevoLegajo.Text, Descripcion = txtAlumnoNuevoDescripcion.Text, IdUsuario = idUser, Habilitado = true });

                            context.SaveChanges();

                            MessageBox.Show("ALUMNO GUARDADO CON EXITO");

                            limpiarFormulario();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                }
                else
                {
                    try
                    {                    
                        alum.AlumnoMod.Nombre = txtAlumnoNuevoNombre.Text;

                        alum.AlumnoMod.Apellido = txtAlumnoNuevoApellido.Text;

                        alum.AlumnoMod.Dni = txtAlumnoNuevoDNI.Text;

                        alum.AlumnoMod.Legajo = txtAlumnoNuevoLegajo.Text;

                        alum.AlumnoMod.Descripcion = txtAlumnoNuevoDescripcion.Text;

                        alum.AlumnoMod.IdUsuario = context.usuario.Where(x => x.Nombre == txtAlumnoNuevoUsuario.Text).FirstOrDefault().Id;

                        //context.SaveChanges();
                        alum.Context.SaveChanges();

                        MessageBox.Show("ALUMNO GUARDADO CON EXITO");

                        limpiarFormulario();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }      
            }
            else
            {
                MessageBox.Show(msjError);
            }
        }

        private void btnAlumnoNuevoLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            txtAlumnoNuevoNombre.Clear();

            txtAlumnoNuevoApellido.Clear();

            txtAlumnoNuevoLegajo.Clear();

            txtAlumnoNuevoDNI.Clear();

            txtAlumnoNuevoDescripcion.Clear();

            txtAlumnoNuevoUsuario.Clear();
        }

        private void btnAlumnoNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlumnoNuevoBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarioBuscar unFrmUsuarioBuscar = new frmUsuarioBuscar();

            unFrmUsuarioBuscar.ShowDialog(this);

            txtAlumnoNuevoUsuario.Text = unFrmUsuarioBuscar.nombreUsuario;
        }

        private void frmAlumnoNuevo_Load(object sender, EventArgs e)
        {
            if (!estado)
            {
                txtAlumnoNuevoNombre.Text = alum.AlumnoMod.Nombre;

                txtAlumnoNuevoApellido.Text = alum.AlumnoMod.Apellido;

                txtAlumnoNuevoDNI.Text = alum.AlumnoMod.Dni;

                txtAlumnoNuevoLegajo.Text = alum.AlumnoMod.Legajo;

                txtAlumnoNuevoDescripcion.Text = alum.AlumnoMod.Descripcion;

                txtAlumnoNuevoUsuario.Text = alum.NombreUsuario;

                this.Text = "Modificar Alumno";
            }         
        }
    }
}
