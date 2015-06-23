using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class BuscarAlumno : Form
    {
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscarAlumnoBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "";

            if (!txtBuscarAlumnoNombre.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarAlumnoNombre.Text))
                {
                    cadena += "El campo Nombre tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo Nombre está vacio.\n";
            }



            if (!txtBuscarAlumnoApellido.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarAlumnoApellido.Text))
                {
                    cadena += "El campo Apellido tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo Apellido está vacio.\n";
            }
            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }
        }

        private void btnBuscarAlumnoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarAlumnoLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarAlumnoNombre.Clear();
            txtBuscarAlumnoApellido.Clear();
        }
    }
}
