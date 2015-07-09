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
                dgvAlumnoBuscar.DataSource = null;

                dgvAlumnoBuscar.Columns.Clear();
                
                dgvAlumnoBuscar.DataSource = Alumno.Select();

                dgvAlumnoBuscar.Columns.RemoveAt(4);

                DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

                columnaModificar.Name = "Modificar";

                dgvAlumnoBuscar.Columns.Add(columnaModificar);

                DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

                columnaEliminar.Name = "Eliminar";

                dgvAlumnoBuscar.Columns.Add(columnaEliminar);
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
    }
}
