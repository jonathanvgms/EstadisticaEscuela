using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Materias
{
    public partial class frmMateriaBuscar : Form
    {
        EstadisticasEscuelaEntities context;
        public frmMateriaBuscar()
        {
            InitializeComponent();

            context = new EstadisticasEscuelaEntities();
        }

        private void btnMateriaBuscarBuscar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (error)
            {
                loadMateriaBuscar();
            }
        }

        private void loadMateriaBuscar()
        {
            dgvMateriaBuscar.DataSource = null;

            dgvMateriaBuscar.Columns.Clear();

            dgvMateriaBuscar.DataSource = context.materia.ToList();
            /*try
            {
                dgvMateriaBuscar.DataSource = context.materia.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
            dgvMateriaBuscar.Columns["Id"].Visible = false;

            dgvMateriaBuscar.Columns["Materia_x_Curso"].Visible = false;
            
            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvMateriaBuscar.Columns.Add(columnaModificar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();

            columnaEliminar.Name = "Eliminar";

            dgvMateriaBuscar.Columns.Add(columnaEliminar);
        }

        private void btnMateriaBucarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMateriaBuscarLimpiar_Click(object sender, EventArgs e)
        {
           // txtMateriaBuscarMateria.Text = "";
           // lblMateriaBuscarMateriaError.Text = "";
            
        }

        private void seleccionMateria(object sender, DataGridViewCellEventArgs e)
        {           
            if ((e.ColumnIndex == dgvMateriaBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                frmMateriaNuevo materiaModificar = new frmMateriaNuevo();

                int idMateria = Convert.ToInt32(dgvMateriaBuscar.CurrentRow.Cells[0].Value.ToString());

                materia materiaModificada = context.materia.Where(x => x.Id == idMateria).ToList().FirstOrDefault();

                materiaModificar.MateriaModificada = materiaModificada;

                materiaModificar.estado = false;

                materiaModificar.ShowDialog(this);

                lblMateriaBuscarMateriaError.Text = "MATERIA MODIFICADA CON EXITO";

                loadMateriaBuscar();
            }

            if ((e.ColumnIndex == dgvMateriaBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                int idMateria = Convert.ToInt32(dgvMateriaBuscar.CurrentRow.Cells[0].Value.ToString());

                try
                {
                    materia materiaEliminada = context.materia.Where(x => x.Id == idMateria).ToList().FirstOrDefault();

                    context.materia.Remove(materiaEliminada);

                    context.SaveChanges();

                    lblMateriaBuscarMateriaError.Text = "MATERIA ELIMINADA CON EXITO";
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

                loadMateriaBuscar();
                /*Materia.Delete(new Materia(dgvMateriaBuscar.CurrentRow.Cells[0].Value.ToString()));

                lblMateriaBuscarMateriaError.Text = "MATERIA ELIMINADA CON EXITO";

                loadMateriaBuscar();*/
            }
        }
    }
}
