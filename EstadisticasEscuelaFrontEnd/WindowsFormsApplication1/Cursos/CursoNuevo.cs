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
    public partial class CursoNuevo : Form
    {
        public CursoNuevo()
        {
            InitializeComponent();
        }

        private void btnfrmCursoAceptar_Click(object sender, EventArgs e)
        {
            string cadena = "";

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
            }
            MessageBox.Show(cmbfrmCursoEspecialidad.SelectedIndex.ToString());
            MessageBox.Show(cmbfrmCursoTurno.SelectedIndex.ToString());

   //         Curso.Add(new Curso(txtfrmCursoAnio.Text, txtfrmCursoDivision.Text, cmbfrmCursoTurno.Text, cmbfrmCursoEspecialidad.Text));
            Curso.Add(new Curso(txtfrmCursoAnio.Text, txtfrmCursoDivision.Text, cmbfrmCursoTurno.SelectedIndex.ToString(), cmbfrmCursoTurno.SelectedIndex.ToString()));
            lblfrmCursoNuevoError.Text = "CURSO GUARDADO CON EXITO";
            

        }

        private void btnfrmCursoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnfrmCursoLimpiar_Click(object sender, EventArgs e)
        {
             txtfrmCursoAnio.Clear();
             txtfrmCursoDivision.Clear();
        }

        private void CursoNuevo_Load(object sender, EventArgs e)
        {
            cmbfrmCursoEspecialidad.Items.Add("Computacion");
            cmbfrmCursoEspecialidad.Items.Add("Electronica");
            cmbfrmCursoEspecialidad.Items.Add("Electricidad");
            cmbfrmCursoTurno.Items.Add("Mañana");
            cmbfrmCursoTurno.Items.Add("Tarde");
            cmbfrmCursoTurno.Items.Add("Noche");
        }
    }
}
