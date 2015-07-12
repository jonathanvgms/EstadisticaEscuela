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
    }
}
