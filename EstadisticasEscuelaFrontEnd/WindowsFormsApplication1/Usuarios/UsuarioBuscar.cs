using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    public partial class frmUsuarioBuscar : Form
    {
        public string nombreUsuario;

        usuario usuarioBuscado;

        EstadisticasEscuelaEntities context;

        internal usuario UsuarioBuscado
        {
            get { return usuarioBuscado; }
            set { usuarioBuscado = value; }
        }

        public frmUsuarioBuscar()
        {
            InitializeComponent();
            context = new EstadisticasEscuelaEntities();
        }

        private void btnBuscarUsuarioBuscar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (error)
            {
                loadUsuarioBuscar();
            }

        }

        private void btnBuscarUsuarioSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarUsuarioLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarUsuarioNombre.Clear();
        }

        private void loadUsuarioBuscar()
        {
            dgvUsuarioBuscar.DataSource = null;

            dgvUsuarioBuscar.Columns.Clear();

            //dgvUsuarioBuscar.DataSource = Usuario.Select();
            try
            {
                dgvUsuarioBuscar.DataSource = context.usuario.Where(x => x.Habilitado == true).ToList();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            

            DataGridViewButtonColumn columnaSeleccionar = new DataGridViewButtonColumn();

            columnaSeleccionar.Name = "Seleccionar";

            dgvUsuarioBuscar.Columns.Add(columnaSeleccionar);

            dgvUsuarioBuscar.Columns["Id"].Visible = false;

            dgvUsuarioBuscar.Columns["Contrasenia"].Visible = false;

            dgvUsuarioBuscar.Columns["Rol"].Visible = false;

            dgvUsuarioBuscar.Columns["Alumno"].Visible = false;

            dgvUsuarioBuscar.Columns["docente"].Visible = false;
                       

            dgvUsuarioBuscar.Columns["IdRol"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvUsuarioBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvUsuarioBuscar.Columns.Add(columnaEliminar);
        }

        private void seleccionUsuario(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvUsuarioBuscar.Columns["Seleccionar"].Index) && (e.ColumnIndex >= -1))
            {
                nombreUsuario = dgvUsuarioBuscar.CurrentRow.Cells[1].Value.ToString();

                
                MessageBox.Show("Usuario Seleccionado");
            }

            if ((e.ColumnIndex == dgvUsuarioBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {

                frmUsuarioNuevo usuarioModificar = new frmUsuarioNuevo();
                /*
                usuarioModificar.UsuarioModificado = new usuario(dgvUsuarioBuscar.CurrentRow.Cells[0].Value.ToString(),
                                                              dgvUsuarioBuscar.CurrentRow.Cells[1].Value.ToString(),
                                                              dgvUsuarioBuscar.CurrentRow.Cells[2].Value.ToString(),
                                                              dgvUsuarioBuscar.CurrentRow.Cells[3].Value.ToString());

                usuarioModificar.ShowDialog(this);

                lblUsuarioBuscarError.Text = "USUARIO MODIFICADO CON EXITO";

                loadUsuarioBuscar();
                 * */



                //convierto el idAlumno a int
                int idUsuario = Convert.ToInt32(dgvUsuarioBuscar.CurrentRow.Cells[0].Value.ToString());
                
                //traigo el objeto alumno de la base de datos
                usuario usuarioModificado = context.usuario.Where(x => x.Id == idUsuario).ToList().FirstOrDefault();

                //le asigno el objeto al form AlumnoNuevo
                usuarioModificar.UsuarioModificado = usuarioModificado;
                
                //con este campo avisa al AlumnoNuevo que el formulario es para modificar
                usuarioModificar.estado = false;

                usuarioModificar.ShowDialog(this);

                lblUsuarioBuscarError.Text = "USUARIO MODIFICADO CON EXITO";

                loadUsuarioBuscar();
            }

            if ((e.ColumnIndex == dgvUsuarioBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                int idUsuario = Convert.ToInt32(dgvUsuarioBuscar.CurrentRow.Cells[0].Value.ToString());

                try
                {
                    usuario usuarioEliminado = context.usuario.Where(x => x.Id == idUsuario).ToList().FirstOrDefault();

                    usuarioEliminado.Habilitado = false;

                    context.SaveChanges();

                    lblUsuarioBuscarError.Text = "USUARIO ELIMINADO CON EXITO";

                    loadUsuarioBuscar();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

            }
            /*
            if ((e.ColumnIndex == dgvUsuarioBuscar.Columns["Nombre"].Index) && (e.ColumnIndex >= -1))
            {
                usuarioBuscado = new Usuario(dgvUsuarioBuscar.CurrentRow.Cells[0].Value.ToString(), dgvUsuarioBuscar.CurrentRow.Cells[1].Value.ToString(),
                dgvUsuarioBuscar.CurrentRow.Cells[2].Value.ToString(), dgvUsuarioBuscar.CurrentRow.Cells[3].Value.ToString() , dgvUsuarioBuscar.CurrentRow.Cells[4].Value.ToString());
            }
             */
        }
    }
}
