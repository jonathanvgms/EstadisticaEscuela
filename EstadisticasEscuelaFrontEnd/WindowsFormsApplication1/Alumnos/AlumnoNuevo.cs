using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoNuevo : Form
    {
        public frmAlumnoNuevo()
        {
            InitializeComponent();
        }

        private void btnAlumnoNuevo_Click(object sender, EventArgs e)
        {
            string cadena = "";

            if (!txtAlumnoNuevoNombre.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtAlumnoNuevoNombre.Text))
                {
                    cadena += "El campo Nombre tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo Nombre está vacio.\n";
            }

            /*if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }*/

            if(!txtAlumnoNuevoApellido.Text.Equals(""))
            {
             if (!Util.todasLetras(this.txtAlumnoNuevoApellido.Text))
                {
                    cadena += "El campo Apellido tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo Apellido está vacio.\n";
            }

            /*if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }
             * */



            if(!txtAlumnoNuevoDNI.Text.Equals(""))
            {
                if (!Util.todasNumeros(this.txtAlumnoNuevoDNI.Text))
                {
                    cadena += "El campo DNI tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo DNI está vacio.\n";
            }

            /*
            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }
             * */


            if(!txtAlumnoNuevoLegajo.Text.Equals(""))
            {
                if (!Util.todasNumeros(this.txtAlumnoNuevoLegajo.Text))
                {
                    cadena += "El campo Legajo tiene valores incorrectos.\n";
                }
            }
            else
            {
                cadena = cadena + "El campo Legajo está vacio.\n";
            }

            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }



        }

        private void btnAlumnoNuevoLimpiar_Click(object sender, EventArgs e)
        {

            txtAlumnoNuevoNombre.Clear();
            txtAlumnoNuevoApellido.Clear();
            txtAlumnoNuevoLegajo.Clear();
            txtAlumnoNuevoDNI.Clear();
        }

        private void btnAlumnoNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
