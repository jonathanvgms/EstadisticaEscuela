using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Cursos
{
    public partial class frmAsistenciaModificar : Form
    {
        public frmAsistenciaModificar()
        {
            InitializeComponent();
        }

        private Dominio.Asistencia asistenciaModificado;

        internal Dominio.Asistencia AsistenciaMidificado
        {
            get { return asistenciaModificado; }
            set { asistenciaModificado = value; }
        }

        private void btnAsistenciaModificarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAsistenciaModificarLimpiar_Click(object sender, EventArgs e)
        {
            txtAsistenciaModificarFacha.Text = "";
            txtAsistenciaModificarPresente.Text = "";
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtAsisnteciaModificarPresente") || textBox.Name.Equals("txtAsistenciaModicarFecha")) 
                {
                    if (Util.todasNumeros(textBox.Text))
                    {
                        label.Text = "Valor Incorrecto";

                        return false;
                    }
                }
            }
            else
            {
                label.Text = "VACIO";

                return false;
            }

            return false;
        }

        private void frmAsistenciaModificar_Load(object sender, EventArgs e)
        {
            //txtAsistenciaModificarFacha.Text = asistenciaModificado.
            
        }
    }
}
