using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Materias;
using EstadisticasEscuelaFrontEnd.Modelo;
using EstadisticasEscuelaFrontEnd.Alumnos;

namespace EstadisticasEscuelaFrontEnd.Cursos
{
    public partial class frmCursoNuevo : Form
    {
        EstadisticasEscuelaEntities context;

        private curso _cursoModificado;

        internal curso CursoModificado
        {
            get { return _cursoModificado; }
            set { _cursoModificado = value; }
        }

        public frmCursoNuevo()
        {
            InitializeComponent();
        }

        private void btnfrmCursoAceptar_Click(object sender, EventArgs e)
        {

            bool error = true;

            //Falta Verificar que el Curso existe en la Base de Datos

            if (error)
            {
                try
                {

                    context.curso.Add(new curso { Anio = int.Parse(txtCursoNuevoAnio.Text), Division = int.Parse(txtCursoNuevoDivision.Text),        });

                    context.SaveChanges();

                    lblCursoNuevoMensaje.Text = "CURSO GUARDADO CON EXITO";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

            }


        }

        private void btnfrmCursoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnfrmCursoLimpiar_Click(object sender, EventArgs e)
        {
             txtCursoNuevoAnio.Clear();
             txtCursoNuevoDivision.Clear();

        }

        private void frmCursoNuevo_Load(object sender, EventArgs e)
        {
            this.cmbCursoNuevoTurno.Items.Add("Mañana");
            this.cmbCursoNuevoTurno.Items.Add("Tarde");
            this.cmbCursoNuevoTurno.Items.Add("Noche");
            this.cmbCursoNuevoEspecialidad.Items.Add("Computacion");
            this.cmbCursoNuevoEspecialidad.Items.Add("Electronica");
            this.cmbCursoNuevoEspecialidad.Items.Add("Electrica");
            this.cmbCursoNuevoEspecialidad.Items.Add("Ciclo Basico");
        }
        
        private void btnCursoNuevoAgregarMateria_Click(object sender, EventArgs e)
        {
            frmMateriaNuevo unfrmMateriaNuevo = new frmMateriaNuevo();
            unfrmMateriaNuevo.Show();
        }

        private void btnCursoNuevoAgregarAlumno_Click(object sender, EventArgs e)
        {

            frmAlumnoBuscar unfrmAlumnoBuscar = new frmAlumnoBuscar();
            unfrmAlumnoBuscar.Show();

        }
    }
}
