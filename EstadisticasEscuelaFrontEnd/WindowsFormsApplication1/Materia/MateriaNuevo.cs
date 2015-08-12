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

namespace EstadisticasEscuelaFrontEnd.Materia
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

        private bool checkData(TextBox texbox, Label label)
        {
            label.Text = "";

            if (!texbox.Text.Equals(""))
            {
                if (texbox.Name.Equals("txtMateriaNuevoMateria"))
                {
                    if (!Util.todasLetras(texbox.Text))
                    {
                        label.Text = "Vacio";

                        return false;
                    }
                }
            }
            else
            {
                label.Text = "Valor Incorrecto";

                return false;
            }
            return true;
        }
    }
}
