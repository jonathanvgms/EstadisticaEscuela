using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Rol
{
    public partial class frmRolBuscar : Form
    {
        EstadisticasEscuelaEntities context;

        private rol rolseleccionado;

        public rol Rolseleccionado
        {
            get { return rolseleccionado; }
            set { rolseleccionado = value; }
        }
        public frmRolBuscar()
        {
            InitializeComponent();

            context = new EstadisticasEscuelaEntities();
        }

        private void btnRolBuscarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadRolBuscar()
        {
            dgvRolBuscar.DataSource = null;

            dgvRolBuscar.Columns.Clear();
            /*
             * falta resolver la consulta dinamica incluyendo el texbox  
             */

            dgvRolBuscar.DataSource = context.rol.Where(x => x.Rol1 == true).ToList();

            dgvRolBuscar.Columns["Id"].Visible = false;

            dgvRolBuscar.Columns["Usuario"].Visible = false;

            dgvRolBuscar.Columns["Rol"].Visible = false;

            dgvRolBuscar.Columns["Cursos"].Visible = false;

            dgvRolBuscar.Columns["Materias"].Visible = false;

            dgvRolBuscar.Columns["Alumnos"].Visible = false;

            dgvRolBuscar.Columns["Asistencias"].Visible = false;

            dgvRolBuscar.Columns["Notas"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvRolBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvRolBuscar.Columns.Add(columnaEliminar);
        }

        private void seleccionRol(object sender,DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvRolBuscar.Columns["Seleccionar"].Index) && (e.ColumnIndex >= -1))
            {
                MessageBox.Show("Rol Seleccionado");
            }

            //if (e.ColumnIndex == dgvRolBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            //{
            //    frmRolBuscar rolBuscar = new frmRolBuscar();
   
            //    int 
            //}
        }

        

        private void btnRolBuscarAceptar_Click(object sender, EventArgs e)
        {

        }

       
    }
}
