using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Materias
{
    public partial class frmMateriaModificar : Form
    {
        public frmMateriaModificar()
        {
            InitializeComponent();
        }

        private Dominio.Materia materiaModificada;

        internal Dominio.Materia MateriaModificada
        {
            get { return MateriaModificada;}
            set { materiaModificada = value; }
        }
    

        private void btnMateriaModificarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMateriaModificarLimpiar_Click(object sender, EventArgs e)
        {
            txtMateriaModificarMateria.Text = "";
            lblMateriaModificarMateriaError.Text = "";
        }

        private void btnMateriaModificarAceptar_Click(object sender, EventArgs e)
        {
            Dominio.Materia.Update(new Dominio.Materia(materiaModificada.Id, txtMateriaModificarMateria.Text));

            bool error = true;

            if (!checkData(txtMateriaModificarMateria, lblMateriaModificarMateriaError)) error = false;

            if (error)
            {
               Dominio.Materia.Add(new Dominio.Materia(txtMateriaModificarMateria.Text));
                lblMateriaModificarMateriaError.Text = "MATERIA MODIFICADA CON EXITO";
            }
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtMateriaModificarMateria"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valor Incorrecto";
                        return false;
                    }
                }

            }
            else
            {
                label.Text = "Vacio";

                return false;
            }

            return false;
        }

        private void lblMateriaModificarMateriaError_Click(object sender, EventArgs e)
        {

        }
    }
}
