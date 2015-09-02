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

            Alumno.Update(new Alumno(alumnoModificado.Id, txtAlumnoModificarNombre.Text, txtAlumnoModificarApellido.Text, txtAlumnoModificarLegajo.Text, txtAlumnoModificarDNI.Text));

            bool error = true;

            if (!checkData(txtAlumnoModificarNombre, lblAlumnoModificarNombreError)) error = false;

            if (!checkData(txtAlumnoModificarApellido, lblAlumnoModificarApellidoError)) error = false;

            if (!checkData(txtAlumnoModificarDNI, lblAlumnoModificarDniError)) error = false;

            if (!checkData(txtAlumnoModificarLegajo, lblAlumnoModificarLegajoError)) error = false;

            if (error)
            {
                Alumno.Add(new Alumno(txtAlumnoModificarNombre.Text, txtAlumnoModificarApellido.Text, txtAlumnoModificarDNI.Text, txtAlumnoModificarLegajo.Text,txtAlumnoModificarIdUsuario.Text));

                lblAlumnoModificarError.Text = "ALUMNO MODIFICADO CON EXITO";

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
                if (textBox.Name.Equals("txtAlumnoNuevoNombre") || textBox.Equals("txtAlumnoNuevoApellido"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valor Incorrecto";
                        return false;
                    }
                }

                if (textBox.Name.Equals("txtAlumnoNuevoDNI") || textBox.Name.Equals("txtAlumnoNuevoLegajo"))
                {
                    if (Util.todasNumeros(textBox.Text))
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

        private void frmAlumnoModificar_Load(object sender, EventArgs e)
        {
            txtAlumnoModificarNombre.Text = AlumnoModificado.Nombre;

            txtAlumnoModificarApellido.Text = AlumnoModificado.Apellido;

            txtAlumnoModificarLegajo.Text = AlumnoModificado.Legajo;

            txtAlumnoModificarDNI.Text = AlumnoModificado.Dni;
        }
    }
}
