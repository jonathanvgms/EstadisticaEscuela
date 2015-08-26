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
            /*txtCursoModificarAnio.Text = CursoModificado.Anio;

            txtCursoModificarDivision.Text = CursoModificado.Division;
             * */

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

            
            bool error = true;

            if (!checkData(txtCursoModificarAnio, lblCursoModificarAnioError)) error = false;

            MessageBox.Show(error.ToString());

            if (!checkData(txtCursoModificarDivision, lblCursoModificarDivisionError)) error = false;
            MessageBox.Show(error.ToString());

            if (!checkData(cmbCursoModificarTurno,cmbCursoModificarEspecialidad, lblCursoModificarTurnoError)) error = false;
            MessageBox.Show(error.ToString());
            if (error)
            {
                //Curso.Add(new Curso(txtCursoModificarAnio.Text, txtCursoModificarDivision.Text, cmbCursoModificarTurno.Text.ToString(), cmbCursoModificarEspecialidad.Text.ToString()));

                Curso.Update(new Curso(cursoModificado.Id, txtCursoModificarAnio.Text, txtCursoModificarDivision.Text, cmbCursoModificarTurno.Text.ToString(), cmbCursoModificarEspecialidad.Text.ToString()));

                lblModificarUsuarioError.Text="CURSO MODIFICADO CON  EXITO";

            }
        }
        private bool checkData(ComboBox comboA, ComboBox comboB, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0 && comboB.SelectedIndex < 0)
            {
                label.Text = "Seleccione Año y turno";
            }
            else
            {
                if (comboA.SelectedIndex < 0)
                {
                    label.Text = "Seleccione division";

                    return false;
                }

                if (comboB.SelectedIndex < 0)
                {
                    label.Text += "Seleccione curso";

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
                if (textBox.Name.Equals("txtCursoModificarAnio") || textBox.Equals("txtCursoModificarDivision"))
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



    }
}
