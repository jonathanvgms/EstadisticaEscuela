using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Database;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class AlumnoBuscar : Form
    {
        public AlumnoBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscarAlumnoBuscar_Click(object sender, EventArgs e)
        {
            /*
            string cadena = "";
            
            if (!txtBuscarAlumnoNombre.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarAlumnoNombre.Text))
                {
                    cadena += "El campo Nombre tiene valores incorrectos.\n";
                }
            }
           
            if (!txtBuscarAlumnoApellido.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarAlumnoApellido.Text))
                {
                    cadena += "El campo Apellido tiene valores incorrectos.\n";
                }
            }
           
            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }
             */
            
            dgvAlumnoBuscar.DataSource = Alumno.Select();

            dgvAlumnoBuscar.Columns.RemoveAt(4);

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvAlumnoBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();
                        
            columnaEliminar.Name = "Eliminar";
            
            dgvAlumnoBuscar.Columns.Add(columnaEliminar);
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
