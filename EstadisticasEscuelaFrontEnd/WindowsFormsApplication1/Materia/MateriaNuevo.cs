using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd;
using EstadisticasEscuelaFrontEnd.Database;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Materias
{
    public partial class frmMateriaNuevo : Form
    {
        public frmMateriaNuevo()
        {
            InitializeComponent();
        }

        private void btnMateriaNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMateriaBuscarLimpiar_Click(object sender, EventArgs e)
        {
            txtMateriaNuevoMateria.Clear();

            lblMateriaNuevoVacio.Text = "";

            lblMateriaNuevoError.Text = "";
        }

        private void btnMateriaNuevoAceptar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtMateriaNuevoMateria, lblMateriaNuevoVacio)) error = false;

            //falta verificar que el alumno existe en la base de datos

            if (error)
            {
                Dominio.Materia.Add(new Dominio.Materia(txtMateriaNuevoMateria.Text));
                
                lblMateriaNuevoError.Text = "MATERIA GUARDADA CON EXITO";
            }
        }

        private bool checkData(TextBox texBox, Label label)
        {
            label.Text = "";

            if (!texBox.Text.Equals(""))
            {
                if (texBox.Name.Equals("txtMateriaNuevoMateria"))
                {
                    if (!Util.todasLetras(texBox.Text))
                    {
                        label.Text = "Valor incorrecto";

                        return false;
                    }
                }
            }

            else
            {
                label.Text = "Vacio";

                return false;
            }
            return true;
        }

        private void frmMateriaNuevo_Load(object sender, EventArgs e)
        {
            this.cmbMateriaNuevaEspecialidad.Items.Add("Computacion");

            this.cmbMateriaNuevaEspecialidad.Items.Add("Electronica");

            this.cmbMateriaNuevaEspecialidad.Items.Add("Electricidad");

            this.cmbMateriaNuevaEspecialidad.Items.Add("Ciclo Basico");

            this.cmbMateriaNuevaTurno.Items.Add("Mañana");

            this.cmbMateriaNuevaTurno.Items.Add("Tarde");

            this.cmbMateriaNuevaTurno.Items.Add("Noche");
        }
    }
}
