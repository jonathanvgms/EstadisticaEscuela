using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Cursos
{
    public partial class frmCursoNuevo : Form
    {
        public frmCursoNuevo()
        {
            InitializeComponent();
        }

        private void btnfrmCursoAceptar_Click(object sender, EventArgs e)
        {
            /*string cadena = "";

            if (!txtfrmCursoAnio.Text.Equals(""))
            {
                if (!Util.todasNumeros(this.txtfrmCursoAnio.Text))
                {
                    cadena += "El campo Anio tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo Anio está vacio.\n";
            }


            if (!txtfrmCursoDivision.Text.Equals(""))
            {
                if (!Util.todasNumeros(this.txtfrmCursoDivision.Text))
                {
                    cadena += "El campo Division tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo Division está vacio.\n";
            }

            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }*/

            bool error = true;

            if (!checkdata(cmbCursoNuevoTurno,cmbCursoNuevoEspecialidad,lblCursoNuevoEspecialidadError)) error = false;

            //if (!checkData(txtCursoNuevoAnio, lblCusoNuevoAnioError)) error = false;

            //if (!checkData(txtCursoNuevoDivision, lblCursoNuevoDivisionError)) error = false;

            //Falta Verificar que el Curso existe en la Base de Datos

            if (error)
            {
                Dominio.Curso.Add(new Dominio.Curso(txtCursoNuevoAnio.Text,txtCursoNuevoDivision.Text,cmbCursoNuevoTurno.SelectedIndex.ToString(),cmbCursoNuevoEspecialidad.SelectedIndex.ToString()));

                lblCursoNuevoMensaje.Text = "CURSO GUARDADO CON EXITO";
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

        private bool checkdata(ComboBox comboTurno, ComboBox ComboEspecialidad, Label label)
        {
            label.Text = "";

            if (ComboEspecialidad.SelectedIndex < 0 && comboTurno.SelectedIndex < 0)
            {
                label.Text = "Seleccione Turno y Especialidad";
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
                    label.Text = "Seleccione Turno";

                    return false;

                }
            }
                return true;
          }

        private bool checkData(TextBox texBox, Label label)
        {
            label.Text = "";

            if (!texBox.Text.Equals(""))
            {
                if (texBox.Name.Equals("txtCursoNuevoAnio") || texBox.Name.Equals("txtCursoNuevoDivision"))
                {
                    if (!Util.todasNumeros(texBox.Text))
                    {
                        label.Text = "VALOR INCORRECTO";

                        return false;
                    }
                }
            }
            else
            {
                label.Text = "VACIO";

                return false;
            }
                return true;
            }
        
        
    }
}
