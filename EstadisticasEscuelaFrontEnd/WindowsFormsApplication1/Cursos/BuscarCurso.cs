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
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = Curso.Select();

            dataGridView1.Columns.RemoveAt(4);
        }

        private void btnBuscarCursoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCursoLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarCursoAnio.Clear();
            txtBuscarCursoDivision.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBuscarCursoAnio_Click(object sender, EventArgs e)
        {

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
    }
}
