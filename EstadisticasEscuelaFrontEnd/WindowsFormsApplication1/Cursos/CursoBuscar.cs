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

namespace EstadisticasEscuelaFrontEnd.Cursos
{
    public partial class frmBuscarCurso : Form
    {
        public frmBuscarCurso()
        {
            InitializeComponent();
        }

        private void btnBuscarCursoBuscar_Click(object sender, EventArgs e)
        {       
            dgvCursoBuscar.DataSource = null;

            //string query = String.Format("where curso = {0} and division = {1}", txtCursoBuscarAnio.Text, txtCursoBuscarDivision.Text);f

            dgvCursoBuscar.DataSource = Curso.Select();

            dgvCursoBuscar.Columns[0].Visible = false;

            dgvCursoBuscar.Columns[5].Visible = false;

            dgvCursoBuscar.Columns[3].Name = "Turno";

            dgvCursoBuscar.Columns[4].Name = "Especialidad";

        }

        private void btnBuscarCursoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCursoLimpiar_Click(object sender, EventArgs e)
        {
            txtCursoBuscarAnio.Clear();

            txtCursoBuscarDivision.Clear();
        }

        private void BuscarCurso_Load(object sender, EventArgs e)
        {
            this.cmbBuscarCursoEspecialidad.Items.Add("Computacion");
            
            this.cmbBuscarCursoEspecialidad.Items.Add("Electronica");
            
            this.cmbBuscarCursoEspecialidad.Items.Add("Electricidad");

            this.cmbBuscarCursoEspecialidad.SelectedIndex = 0;
            
            this.cmbBuscarCursoTurno.Items.Add("Mañana");
            
            this.cmbBuscarCursoTurno.Items.Add("Tarde");
            
            this.cmbBuscarCursoTurno.Items.Add("Noche");

            this.cmbBuscarCursoTurno.SelectedIndex = 0;
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtAlumnoNuevoNombre") || textBox.Name.Equals("txtAlumnoNuevoApellido"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valores Incorrectos";

                        return false;
                    }
                }

                if (textBox.Name.Equals("txtAlumnoNuevoDNI") || textBox.Name.Equals("txtAlumnoNuevoLegajo"))
                {
                    if (!Util.todasNumeros(textBox.Text))
                    {
                        label.Text = "Valores Incorrectos";

                        return false;
                    }
                }
            }
            
            return true;
        }

        private void loadCursoBuscar()
        {
            dgvCursoBuscar.DataSource = null;

            dgvCursoBuscar.Columns.Clear();

            string query = string.Format("where anio LIKE '%(0)%' and division LIKE '%{1}%'", txtCursoBuscarAnio, txtCursoBuscarDivision);

            dgvCursoBuscar.DataSource = Curso.Select(query);

            dgvCursoBuscar.Columns["Id"].Visible = false;

            dgvCursoBuscar.Columns["Id"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvCursoBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvCursoBuscar.Columns.Add(columnaEliminar);
        }
    }
}
