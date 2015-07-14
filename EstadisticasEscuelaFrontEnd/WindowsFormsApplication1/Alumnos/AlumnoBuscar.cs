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
    public partial class AlumnoBuscar : Form
    {
        public AlumnoBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscarAlumnoBuscar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtAlumnoBuscarNombre, lblAlumnoBuscarNombreError)) error = false;

            if (!checkData(txtAlumnoBuscarApellido, lblAlumnoBuscarApellidoError)) error = false;

            if (error)
            {
                loadAlumnoBuscar();
            }
        }

        private void btnBuscarAlumnoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarAlumnoLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoBuscarNombre.Clear();

            txtAlumnoBuscarApellido.Clear();
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
                if (textBox.Name.Equals("txtAlumnoBuscarNombre") || textBox.Name.Equals("txtAlumnoBuscarApellido"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valores Incorrectos";

                        return false;
                    }
                }
            }
            
            return true;
        }

        private void AlumnoBuscar_Load(object sender, EventArgs e)
        {
            this.cmbBuscarAlumnoEspecialidad.Items.Add("Computacion");

            this.cmbBuscarAlumnoEspecialidad.Items.Add("Electronica");

            this.cmbBuscarAlumnoEspecialidad.Items.Add("Electricidad");

            this.cmbBuscarAlumnoTurno.Items.Add("Mañana");

            this.cmbBuscarAlumnoTurno.Items.Add("Tarde");

            this.cmbBuscarAlumnoTurno.Items.Add("Noche");
        }

        private void seleccionAlumno(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvAlumnoBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                //frmAlumnoModificar alumnoModificar = new frmAlumnoModificar();

                Alumno alumnoFila = new Alumno(dgvAlumnoBuscar.CurrentRow.Cells[0].Value.ToString(),
                                               dgvAlumnoBuscar.CurrentRow.Cells[1].Value.ToString(),
                                               dgvAlumnoBuscar.CurrentRow.Cells[2].Value.ToString(),
                                               dgvAlumnoBuscar.CurrentRow.Cells[3].Value.ToString());

                //alumnoModificar.Alumno = alumnoFila;

                //alumnoModificar.ShowDialog(this);
                
                //lblBuscarAlumnoError.Text = "ALUMNO MODIFICADO CON EXITO";
                
                loadAlumnoBuscar();
            }

            if ((e.ColumnIndex == dgvAlumnoBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                Alumno.Delete(new Alumno(dgvAlumnoBuscar.CurrentRow.Cells[2].Value.ToString()));
                
                lblBuscarAlumnoError.Text = "ALUMNO ELIMINADO CON EXITO";
                
                loadAlumnoBuscar();
            }
        }

        private void loadAlumnoBuscar()
        {
            dgvAlumnoBuscar.DataSource = null;

            dgvAlumnoBuscar.Columns.Clear();

            string query = String.Format("where nombre LIKE '%{0}%' and apellido LIKE '%{1}%'", txtAlumnoBuscarNombre.Text, txtAlumnoBuscarApellido.Text);
            
            dgvAlumnoBuscar.DataSource = Alumno.Select(query);

            dgvAlumnoBuscar.Columns.RemoveAt(4);

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvAlumnoBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvAlumnoBuscar.Columns.Add(columnaEliminar);
        }
    }
}
