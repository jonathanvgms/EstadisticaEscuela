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
        public frmUsuarioBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuarioBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "";

            if (!txtBuscarUsuarioNombre.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarUsuarioNombre.Text))
                {
                    cadena += "El campo Nombre tiene valores incorrectos.\n";
                }
            }

            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
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

            string query = string.Format("where nombre LIKE '%{0}%'", txtBuscarUsuarioNombre);

            dgvUsuarioBuscar.DataSource = Usuario.Select(query);

            dgvUsuarioBuscar.Columns["Id"].Visible = false;

            dgvUsuarioBuscar.Columns["Tipo"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvUsuarioBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvUsuarioBuscar.Columns.Add(columnaEliminar);
                
        }
    }
}
