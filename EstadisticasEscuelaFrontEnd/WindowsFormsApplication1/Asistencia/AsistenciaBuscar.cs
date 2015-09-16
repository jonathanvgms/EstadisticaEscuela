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
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Asistencia;

namespace EstadisticasEscuelaFrontEnd.Asistencia
{
    public partial class frmAsistenciaBuscar : Form
    {
        public frmAsistenciaBuscar()
        {
            InitializeComponent();
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtAsistenciaBuscarPresente") || textBox.Name.Equals("txtAsistenciaBuscarFecha"))
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

        private void btnAsistenciaBuscarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAsistenciaBuscarLimpiar_Click(object sender, EventArgs e)
        {
            txtAsistenciaBuscarFecha.Text = "";

            lblAsistenciaBuscarFechaError.Text = "";

            lblAsistenciaBuscarPresenteError.Text = "";
        }

        private void btnAsistenciaBuscarBuscar_Click(object sender, EventArgs e)
        {
            //bool error = true;

            //if (!checkData(txtAsistenciaBuscarFecha, lblAsistenciaBuscarFechaError)) error = false;

            //if (!checkData(txtAsistenciaBuscarPresente, lblAsistenciaBuscarPresenteError)) error = false;
            /*
            if (error)
            {
                loadAsistencia
            }*/
        }

        private void loadAsistenciaBuscar()
        {
            dgvAsistenciaBucar.DataSource = null;

            dgvAsistenciaBucar.Columns.Clear();

            //string query = string.Format("where 
        }

        private void btnAsistenciaBuscarBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCurso unBuscarCurso = new frmBuscarCurso();
            unBuscarCurso.ShowDialog(this);
        }

        private void dgvAsistenciaBucar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvAsistenciaBucar.Columns ["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                
            }
        }
    }
}
