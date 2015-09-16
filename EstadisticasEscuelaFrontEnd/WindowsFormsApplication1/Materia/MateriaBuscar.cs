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

namespace EstadisticasEscuelaFrontEnd.Materias
{
    public partial class frmMateriaBuscar : Form
    {
        EestadisticasEscuelaEntities context;
        public frmMateriaBuscar()
        {
            InitializeComponent();

            context = new EestadisticasEscuelaEntities();
        }

        private void btnMateriaBuscarBuscar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtMateriaBuscarMateria, lblMateriaBucarMateria)) error = false;

            if (error)
            {
                loadMateriaBuscar();
            }
        }
        
        /*private bool checkData(ComboBox comboA, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0 )
            {
                label.Text = "Seleccione Turno";

                return false;
            }

            return true;
        }
         */

        private bool checkData(TextBox textbox, Label label)
        {
            //label.Text = "";

            if (!textbox.Text.Equals(""))
            {
                if (textbox.Name.Equals("txtMateriaBuscarMateria"))
                {
                    if (!Util.todasLetras(textbox.Text))
                    {
                        label.Text = "Valor Incorrecto";

                        return false;

                    }
                }
            }

            return true;
        }

        private void loadMateriaBuscar()
        {
            dgvMateriaBuscar.DataSource = null;

            dgvMateriaBuscar.Columns.Clear();

            string query = String.Format("where materia LIKE '%{0}%'", txtMateriaBuscarMateria.Text);

            dgvMateriaBuscar.DataSource = Dominio.Materia.Select();

            dgvMateriaBuscar.Columns["Id"].Visible = false;

            dgvMateriaBuscar.Columns["Tipo"].Visible = false;

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
                
                materiaModificar.MateriaModificada = new Materia(dgvMateriaBuscar.CurrentRow.Cells[0].Value.ToString(),
                                                                 dgvMateriaBuscar.CurrentRow.Cells[1].Value.ToString());
                


                materiaModificar.ShowDialog(this);

                lblMateriaBuscarMateriaError.Text = "MATERIA MODIFICADA CON EXITO";
              
                loadMateriaBuscar();
            }

            if ((e.ColumnIndex == dgvMateriaBuscar.Columns["Eliminar"].Index) && (e.ColumnIndex >= -1))
            {
                Materia.Delete(new Materia(dgvMateriaBuscar.CurrentRow.Cells[0].Value.ToString()));

                lblMateriaBuscarMateriaError.Text = "MATERIA ELIMINADA CON EXITO";

                loadMateriaBuscar();
            }
        }
    }
}
