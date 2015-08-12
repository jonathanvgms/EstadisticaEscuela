using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Asistencia
{
    public partial class frmAsistenciaBuscar : Form
    {
        public frmAsistenciaBuscar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            txtAsistenciaBuscarPresente.Text = "";
            lblAsistenciaBuscarFechaError.Text = "";
            lblAsistenciaBuscarPresenteError.Text = "";
        }

    }
}
