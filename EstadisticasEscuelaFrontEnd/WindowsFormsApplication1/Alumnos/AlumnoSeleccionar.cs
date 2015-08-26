using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Database;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class AlumnoSeleccionar : Form
    {
        public AlumnoSeleccionar()
        {
            InitializeComponent();
        }

        private void btnAlumnoSeleccionarSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlumnoSeleccionarLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoSeleccionarApellido.Text = "";
            cmbAlumnoSeleccionarEspecialidad.Text = "";
            txtAlumnoSeleccionarNombre.Text = "";
            cmbAlumnoSeleccionarTurno.Text = "";
        }

        private void btnAlumnoSeleccionarSeleccionar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtAlumnoSeleccionarNombre, lblAlumnoSeleccionarError)) error = false;

            if (!checkData(txtAlumnoSeleccionarApellido, lblAlumnoSeleccionarError)) error = false;

            if (error)
            {
                
            }

        }

        private bool checkData(ComboBox comboA, ComboBox comboB, Label label)
        {
            label.Text = "";
            if (comboA.SelectedIndex < 0 && comboB.SelectedIndex < 9)
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
                    label.Text = "Seleccione División";

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
                if (textBox.Name.Equals(""))
                {
                    if (textBox.Name.Equals("txtAlumnoSeleccionarNombre") || textBox.Name.Equals("txtAlumnoSeleccionarApellido"))
                    {
                        if (Util.todasLetras(textBox.Text))
                        {
                            label.Text = "VALORES INCORRECTOS";

                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void AlumnoSeleccionar_Load(object sender, EventArgs e)
        {
            this.cmbAlumnoSeleccionarEspecialidad.Items.Add("Computacion");

            this.cmbAlumnoSeleccionarEspecialidad.Items.Add("Electronica");

            this.cmbAlumnoSeleccionarEspecialidad.Items.Add("Electricidad");

            this.cmbAlumnoSeleccionarTurno.Items.Add("Mañana");

            this.cmbAlumnoSeleccionarTurno.Items.Add("Tarde");

            this.cmbAlumnoSeleccionarTurno.Items.Add("Noche");
        }

        private void loadAlumnoSeleccionar()
        {
            dgvAlumnoSeleccionar.DataSource = null;

            dgvAlumnoSeleccionar.Columns.Clear();

            string query = string.Format("where nombre LIKE '%{0}%' ", txtAlumnoSeleccionarNombre.Text, txtAlumnoSeleccionarApellido.Text);

            dgvAlumnoSeleccionar.DataSource = Alumno.Select(query);

            dgvAlumnoSeleccionar.Columns["Id"].Visible = false;

            dgvAlumnoSeleccionar.Columns["Tipo"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            dgvAlumnoSeleccionar.Name = "Modificar";

            dgvAlumnoSeleccionar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            dgvAlumnoSeleccionar.Name = "Eliminar";

            dgvAlumnoSeleccionar.Columns.Add(columnaEliminar);
        }

        private void seleccionAlumno(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvAlumnoSeleccionar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                //frmAlumnoModificar alumno
            }
        }
    }
}
