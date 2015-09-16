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

namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    public partial class frmUsuarioBuscar : Form
    {
        public string nombreUsuario;

        Usuario usuarioBuscado;

        internal Usuario UsuarioBuscado
        {
            get { return usuarioBuscado; }
            set { usuarioBuscado = value; }
        }

        public frmUsuarioBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuarioBuscar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtBuscarUsuarioNombre, lblUsuarioBuscarNombreError)) error = false;

            if (error)
            {
                loadUsuarioBuscar();
            }

        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtUsuarioBuscarNombre"))
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

            string query = string.Format("where nombre LIKE '%{0}%'", txtBuscarUsuarioNombre.Text);

            dgvUsuarioBuscar.DataSource = Usuario.Select();

            DataGridViewButtonColumn columnaSeleccionar = new DataGridViewButtonColumn();

            columnaSeleccionar.Name = "Seleccionar";

            dgvUsuarioBuscar.Columns.Add(columnaSeleccionar);

            dgvUsuarioBuscar.Columns["Id"].Visible = false;
                       
            dgvUsuarioBuscar.Columns["Tipo"].Visible = false;

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

                frmUsuarioModificar usuarioModificar = new frmUsuarioModificar();

                usuarioModificar.UsuarioModificado = new Usuario(dgvUsuarioBuscar.CurrentRow.Cells[0].Value.ToString(),
                                                              dgvUsuarioBuscar.CurrentRow.Cells[1].Value.ToString(),
                                                              dgvUsuarioBuscar.CurrentRow.Cells[2].Value.ToString(),
                                                              dgvUsuarioBuscar.CurrentRow.Cells[3].Value.ToString());

                usuarioModificar.ShowDialog(this);

                lblUsuarioBuscarError.Text = "USUARIO MODIFICADO CON EXITO";

                loadUsuarioBuscar();
            }

            if ((e.ColumnIndex == dgvUsuarioBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                Usuario.Delete(new Usuario(dgvUsuarioBuscar.CurrentRow.Cells[0].Value.ToString()));
                
                lblUsuarioBuscarError.Text = "USUARIO ELIMINADO CON EXITO";

                loadUsuarioBuscar();
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
