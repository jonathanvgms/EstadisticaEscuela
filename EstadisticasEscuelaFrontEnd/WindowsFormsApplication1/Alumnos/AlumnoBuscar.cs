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
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoBuscar : Form
    {
        EestadisticasEscuelaEntities context;

        public frmAlumnoBuscar()
        {
            InitializeComponent();

            context = new EestadisticasEscuelaEntities();
        }

        private void btnBuscarAlumnoBuscar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtAlumnoBuscarNombre, lblAlumnoBuscarNombreError)) error = false;

            if (!checkData(txtAlumnoBuscarApellido, lblAlumnoBuscarApellidoError)) error = false;

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
        }

        private bool checkData(ComboBox comboA, ComboBox comboB, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0 && comboB.SelectedIndex < 0)
            {
                label.Text = "Seleccione Curso y División";
            }
            else
            {
                if (comboA.SelectedIndex < 0)
                {
                    label.Text = "Seleccione Curso";

                    return false;
                }

                if (comboB.SelectedIndex < 0)
                {
                    label.Text += "Seleccione División";

                    return false;
                }
            }

            return true;
        }

        private bool checkData(ComboBox combo, Label label)
        {
            label.Text = "";

            if (combo.SelectedIndex < 0)
            {
                label.Text = "Seleccione Especialidad";

                return false;
            }

            return true;
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtAlumnoBuscarNombre") || textBox.Name.Equals("txtAlumnoBuscarApellido"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valores Incorrectos";

                        return false;
                    }
                }
            }
            
            return true;
        }
        
        private void seleccionAlumno(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvAlumnoBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                frmAlumnoNuevo alumnoModificar = new frmAlumnoNuevo();

                //convierto el idAlumno a int
                int idAlumno = Convert.ToInt32(dgvAlumnoBuscar.CurrentRow.Cells[0].Value.ToString());

                //traigo el nombre de usuario del alumno
                string nombreUsuario = context.alumno.Where(x => x.Id == idAlumno).FirstOrDefault().usuario.Nombre;

                //traigo el objeto alumno de la base de datos
                alumno alumnoModificado = context.alumno.Where(x => x.Id == idAlumno).ToList().FirstOrDefault();

                //le asigno el objeto al form AlumnoNuevo
                alumnoModificar.AlumnoModificado = alumnoModificado;

                //le asigno el nombre de usuario del alumno al form AlumnoNuevo
                alumnoModificar.NombreUsuario = nombreUsuario;

                //con este campo avisa al AlumnoNuevo que el formulario es para modificar
                alumnoModificar.estado = false;

                alumnoModificar.ShowDialog(this);

                lblBuscarAlumnoError.Text = "ALUMNO MODIFICADO CON EXITO";
                
                loadAlumnoBuscar();
            }

            if ((e.ColumnIndex == dgvAlumnoBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                //Alumno.Delete(new Alumno(dgvAlumnoBuscar.CurrentRow.Cells[0].Value.ToString()));

                int idAlumno = Convert.ToInt32(dgvAlumnoBuscar.CurrentRow.Cells[0].Value.ToString());

                try
                {
                    alumno alumnoEliminado = context.alumno.Where(x => x.Id == idAlumno).ToList().FirstOrDefault();

                    alumnoEliminado.Habilitado = false;

                    context.SaveChanges();

                    lblBuscarAlumnoError.Text = "ALUMNO ELIMINADO CON EXITO";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                
                loadAlumnoBuscar();
            }
        }

        private void loadAlumnoBuscar()
        {
            dgvAlumnoBuscar.DataSource = null;

            dgvAlumnoBuscar.Columns.Clear();

            /*
             * falta resolver la consulta dinamica incluyendo todos los textbox
             */

            //string query = String.Format("where nombre LIKE '%{0}%' and apellido LIKE '%{1}%'", txtAlumnoBuscarNombre.Text, txtAlumnoBuscarApellido.Text);

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
