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
    public partial class BuscarCurso : Form
    {
        public BuscarCurso()
        {
            InitializeComponent();
        }

        private void btnBuscarCursoBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "";

            if (!txtBuscarCursoAnio.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarCursoAnio.Text))
                {
                    cadena += "El campo Anio tiene valores incorrectos.\n";
                }
            }
            
            if (!txtBuscarCursoDivision.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarCursoDivision.Text))
                {
                    cadena += "El campo Division tiene valores incorrectos.\n";
                }
            }
            
            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }
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
    }
}
