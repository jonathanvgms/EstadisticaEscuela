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

            dgvCursoBuscar.Columns["Id"].Visible = false;

            dgvCursoBuscar.Columns["Tipo"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvCursoBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvCursoBuscar.Columns.Add(columnaEliminar);
            
             


            /*
            dgvCursoBuscar.Columns[0].Visible = false;

            dgvCursoBuscar.Columns[5].Visible = false;

            dgvCursoBuscar.Columns[3].Name = "Turno";

            dgvCursoBuscar.Columns[4].Name = "Especialidad"*/

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
            
        }

        private void seleccionCurso(object sender, DataGridViewCellEventArgs e)
        {
            /*
            frmCursoModificar a = new frmCursoModificar();
            a.ShowDialog(this);
             * */
            if ((e.ColumnIndex == dgvCursoBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                frmCursoModificar cursoModificar = new frmCursoModificar();

                cursoModificar.CursoModificado = new Curso(dgvCursoBuscar.CurrentRow.Cells[0].Value.ToString(),
                                                              dgvCursoBuscar.CurrentRow.Cells[1].Value.ToString(),
                                                              dgvCursoBuscar.CurrentRow.Cells[2].Value.ToString(),
                                                              dgvCursoBuscar.CurrentRow.Cells[3].Value.ToString(),
                                                              dgvCursoBuscar.CurrentRow.Cells[4].Value.ToString());

                cursoModificar.ShowDialog(this);

                lblCursoBuscarError.Text = "CURSO MODIFICADO CON EXITO";

                loadCursoBuscar();
            }

            if ((e.ColumnIndex == dgvCursoBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                Curso.Delete(new Curso(dgvCursoBuscar.CurrentRow.Cells[0].Value.ToString()));

                lblCursoBuscarError.Text = "CURSO ELIMINADO CON EXITO";

                loadCursoBuscar();
            }
        }

        private void frmBuscarCurso_Load(object sender, EventArgs e)
        {
            this.cmbBuscarCursoTurno.Items.Add("Mañana");
            this.cmbBuscarCursoTurno.Items.Add("Tarde");
            this.cmbBuscarCursoTurno.Items.Add("Noche");
            this.cmbBuscarCursoEspecialidad.Items.Add("Computacion");
            this.cmbBuscarCursoEspecialidad.Items.Add("Electronica");
            this.cmbBuscarCursoEspecialidad.Items.Add("Electrica");
            this.cmbBuscarCursoEspecialidad.Items.Add("Ciclo Basico");
        }
    }
}
