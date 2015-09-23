using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Dominio;
using EstadisticasEscuelaFrontEnd.Materias;
using EstadisticasEscuelaFrontEnd.Modelo;
using EstadisticasEscuelaFrontEnd.Alumnos;

namespace EstadisticasEscuelaFrontEnd.Cursos
{
    public partial class frmCursoNuevo : Form
    {
        EestadisticasEscuelaEntities context;

        private Curso _cursoModificado;

        internal Curso CursoModificado
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

            if (!checkdata(cmbCursoNuevoTurno,cmbCursoNuevoEspecialidad,lblCursoNuevoTurnoError,lblCursoNuevoEspecialidadError)) error = false;

            if (!checkData(txtCursoNuevoAnio, lblCusoNuevoAnioError)) error = false;

            if (!checkData(txtCursoNuevoDivision, lblCursoNuevoDivisionError)) error = false;

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


        private bool checkdata(ComboBox comboTurno, ComboBox ComboEspecialidad, Label label, Label label2)
        {
            label.Text = "";

            if (ComboEspecialidad.SelectedIndex < 0 && comboTurno.SelectedIndex < 0)
            {
                label.Text = "Seleccione Turno";

                label2.Text = "Seleccione Especialidad";
                return false;
            }
            else
            {
                if (ComboEspecialidad.SelectedIndex < 0)
                {
                    label.Text = "Seleccione Especialidad";

                    return false;

                }
                if (comboTurno.SelectedIndex < 0)
                {
                    label2.Text = "Seleccione Turno";

                    return false;

                }
            }
            return true;
        }
    
         

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtCursoNuevoAnio") || textBox.Name.Equals("txtCursoNuevoDivision"))
                {
                    if (!Util.todasNumeros(textBox.Text))
                    {
                        label.Text = "Valor Incorrecto";

                        return false;
                    }
                }

                if (textBox.Name.Equals("txtCursoNuevoAnio") || textBox.Name.Equals("txtCursoNuevoDivision"))
                {
                    if (!Util.todasNumeros(textBox.Text))
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

            return true;
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
