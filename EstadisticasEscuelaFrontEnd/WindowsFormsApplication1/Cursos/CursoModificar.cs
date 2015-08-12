using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Cursos
{
    public partial class frmCursoModificar : Form
    {
        public frmCursoModificar()
        {
            InitializeComponent();
        }

        private Curso cursoModificado;

        internal Curso CursoModificado
        {
            get { return cursoModificado; }
            set { cursoModificado = value; }
        }

        private void frmCursoModificar_Load(object sender, EventArgs e)
        {
            txtCursoModificarAnio.Text = CursoModificado.Anio;

            txtCursoModificarDivision.Text = CursoModificado.Division;

            this.cmbCursoModificarTurno.Items.Add("Mañana");

            this.cmbCursoModificarTurno.Items.Add("Tarde");

            this.cmbCursoModificarTurno.Items.Add("Noche");

            this.cmbCursoModificarTurno.SelectedIndex = 0;

            this.cmbCursoModificarEspecialidad.Items.Add("Computacion");

            this.cmbCursoModificarEspecialidad.Items.Add("Electronica");

            this.cmbCursoModificarEspecialidad.Items.Add("Electrica");

            this.cmbCursoModificarEspecialidad.Items.Add("Ciclo Basico");

            this.cmbCursoModificarEspecialidad.SelectedIndex = 0;
        }

        private void btnCursoModificarLimpiar_Click(object sender, EventArgs e)
        {
            txtCursoModificarAnio.Clear();

            txtCursoModificarDivision.Clear();
        }

        private void btnCursoModificarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCursoModificarAceptar_Click(object sender, EventArgs e)
        {
            // falta verificar que los datos sean correctos y completos

            Curso.Update(new Curso(cursoModificado.Id, txtCursoModificarAnio.Text, txtCursoModificarDivision.Text, cmbCursoModificarTurno.Text, cmbCursoModificarEspecialidad.Text));

            Close();
        }


    }
}
