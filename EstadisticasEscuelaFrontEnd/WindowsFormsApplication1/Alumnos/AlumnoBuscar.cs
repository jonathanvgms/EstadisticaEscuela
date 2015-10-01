using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoBuscar : Form
    {
        EstadisticasEscuelaEntities context;
        
        private alumno alumnoseleccionado;

        public alumno Alumnoseleccionado
        {
            get { return alumnoseleccionado; }
            set { alumnoseleccionado = value; }
        }
        public frmAlumnoBuscar()
        {
            InitializeComponent();

            context = new EstadisticasEscuelaEntities();
        }

        private void btnBuscarAlumnoBuscar_Click(object sender, EventArgs e)
        {
            bool error = true;
            /*
             * falta validar los campos del filtro de busqueda
             */ 
            if (error)
            {
                loadAlumnoBuscar();
            }
        }

        private void btnBuscarAlumnoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarAlumnoLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoBuscarNombre.Clear();

            txtAlumnoBuscarApellido.Clear();

            txtAlumnoBuscarDni.Clear();

            txtAlumnoBuscarLegajo.Clear();
        }
        
        private void seleccionAlumno(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvAlumnoBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                frmAlumnoNuevo alumnoModificar = new frmAlumnoNuevo();

                //creo un alumnoModificado
                AlumnoModificado alumno = new AlumnoModificado();

                //convierto el idAlumno a int
                int idAlumno = Convert.ToInt32(dgvAlumnoBuscar.CurrentRow.Cells[0].Value.ToString());

                //traigo el nombre de usuario del alumno
                alumno.NombreUsuario = context.alumno.Where(x => x.Id == idAlumno).FirstOrDefault().usuario.Nombre;

                //traigo el objeto alumno de la base de datos
                alumno.AlumnoMod = context.alumno.Where(x => x.Id == idAlumno).ToList().FirstOrDefault();

                //le asigno el objeto al form AlumnoNuevo
                alumnoModificar.Alum = alumno;
                
                //le paso el contexto actual a "Alumno Modificar"
                alumno.Context = context;

                //con este campo avisa al AlumnoNuevo que el formulario es para modificar
                alumnoModificar.estado = false;

                alumnoModificar.ShowDialog(this);
                
                loadAlumnoBuscar();
            }

            if ((e.ColumnIndex == dgvAlumnoBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                int idAlumno = Convert.ToInt32(dgvAlumnoBuscar.CurrentRow.Cells[0].Value.ToString());

                try
                {
                    alumno alumnoEliminado = context.alumno.Where(x => x.Id == idAlumno).ToList().FirstOrDefault();

                    alumnoEliminado.Habilitado = false;

                    context.SaveChanges();

                    MessageBox.Show("ALUMNO ELIMINADO CON EXITO");

                    loadAlumnoBuscar();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void loadAlumnoBuscar()
        {
            dgvAlumnoBuscar.DataSource = null;

            dgvAlumnoBuscar.Columns.Clear();

            /*
             * falta resolver la consulta dinamica incluyendo todos los textbox
             */

            dgvAlumnoBuscar.DataSource = context.alumno.Where(x => x.Habilitado == true).ToList();

            dgvAlumnoBuscar.Columns["Id"].Visible = false;

            dgvAlumnoBuscar.Columns["Habilitado"].Visible = false;

            dgvAlumnoBuscar.Columns["IdUsuario"].Visible = false;

            dgvAlumnoBuscar.Columns["Alumno_X_Curso"].Visible = false;

            dgvAlumnoBuscar.Columns["usuario"].Visible = false;

            dgvAlumnoBuscar.Columns["Nota"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvAlumnoBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvAlumnoBuscar.Columns.Add(columnaEliminar); 
        }
    }
}
