using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoModificar : Form
    {
        public frmAlumnoModificar()
        {
            InitializeComponent();
        }

        private Alumno alumnoModificado;

        internal Alumno AlumnoModificado
        {
            get { return alumnoModificado; }
            set { alumnoModificado = value; }
        }

        private void btnAlumnoModificarLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoModificarNombre.Clear();

            txtAlumnoModificarApellido.Clear();

            txtAlumnoModificarLegajo.Clear();

            txtAlumnoModificarDNI.Clear();
        }

        private void btnAlumnoModificarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlumnoModificarAceptar_Click(object sender, EventArgs e)
        {
            //falta verificar que los datos sean correctos y completes

            /*AlumnoModificado.Nombre = txtAlumnoModificarNombre.Text;

            AlumnoModificado.Apellido = txtAlumnoModificarApellido.Text;

            AlumnoModificado.Legajo = txtAlumnoModificarLegajo.Text;

            AlumnoModificado.Dni = txtAlumnoModificarDNI.Text;
            
            Alumno.Update(alumnoModificado);*/

            Alumno.Update(new Alumno(alumnoModificado.Id, txtAlumnoModificarNombre.Text, txtAlumnoModificarApellido.Text, txtAlumnoModificarLegajo.Text, txtAlumnoModificarDNI.Text));

            Close();
        }

        private void frmAlumnoModificar_Load(object sender, EventArgs e)
        {
            txtAlumnoModificarNombre.Text = AlumnoModificado.Nombre;

            txtAlumnoModificarApellido.Text = AlumnoModificado.Apellido;

            txtAlumnoModificarLegajo.Text = AlumnoModificado.Legajo;

            txtAlumnoModificarDNI.Text = AlumnoModificado.Dni;
        }
    }
}
