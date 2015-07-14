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
        Alumno alumno;

        internal Alumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }

        public frmAlumnoModificar()
        {
            InitializeComponent();
        }

        private void frmAlumnoModificar_Load(object sender, EventArgs e)
        {
            txtAlumnoModificarNombre.Text = Alumno.Nombre;

            txtAlumnoModificarApellido.Text = Alumno.Apellido;

            txtAlumnoModificarLegajo.Text = Alumno.Legajo;

            txtAlumnoModificarDni.Text = Alumno.Dni;
        }

        private void btnAlumnoModificarLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoModificarNombre.Clear();

            txtAlumnoModificarApellido.Clear();

            txtAlumnoModificarLegajo.Clear();

            txtAlumnoModificarDni.Clear();
        }

        private void btnAlumnoModificarAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
