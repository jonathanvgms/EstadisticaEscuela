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

namespace EstadisticasEscuelaFrontEnd.Materia
{
    public partial class frmMateriaBuscar : Form
    {
        public frmMateriaBuscar()
        {
            InitializeComponent();
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

        private bool checkData(ComboBox comboA, ComboBox comboB, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0 && comboB.SelectedIndex < 0)
            {
                label.Text = "Seleccion Materia";

                return false;
            }
            return true;
        }

        private bool checkData(TextBox textbox, Label label)
        {
            label.Text = "";

            if (!textbox.Text.Equals(""))
            {
                if (textbox.Name.Equals("txtMateriaBuscarMateria"))
                {
                    if (Util.todasLetras(textbox.Text))
                    {
                        label.Text = "Valores Incorrectos";

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

            dgvMateriaBuscar.DataSource = Dominio.Materia.Select(query);

            dgvMateriaBuscar.Columns["Id"].Visible = false;

            dgvMateriaBuscar.Columns["Tipo"].Visible = false;

            DataGridViewButtonColumn columnaModificar = new DataGridViewButtonColumn();

            columnaModificar.Name = "Modificar";

            dgvMateriaBuscar.Columns.Add(columnaModificar);

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
            txtMateriaBuscarMateria.Text = "";
            lblMateriaBuscarMateriaError.Text = "";
        }
    }
}
