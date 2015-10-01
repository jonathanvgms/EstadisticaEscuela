using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd;
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Alumnos;


namespace EstadisticasEscuelaFrontEnd.Asistencia
{
    public partial class frmAsistenciaNuevo : Form
    {
        public frmAsistenciaNuevo()
        {
            InitializeComponent();
        }

        private void lblAsistenciaBuscarLimpiar_Click(object sender, EventArgs e)
        {
            txtAsistenciaNuevoFecha.Clear();

            //txtAsistenciaNuevoPresentismo.Clear();
        }

        private void btnAsistenciaBuscarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAsistenciaBuscarAceptar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (error)
            {

                //Dominio.Asistencia.Add(new Dominio.Asistencia(txtAsistneciaNuevoCurso.Text.ToString(),txtAsistenciaNuevoFecha.Text.ToString(),txtAsistenciaNuevoPresentismo.Text.ToString(),txtAsisnteciaNuevoAlumno.Text.ToString()));
            }
            if (!rbtAsistenciaNuevoAusente.Checked && !rbtAsistenciaNuevoPresente.Checked)
            {
                lblAsistenciaNuevoPresentismoError.Text = "Marcar una de las opciones";
            }
        }

        private void btnAsistenciaNuevoBuscarAlumno_Click(object sender, EventArgs e)
        {
            frmAlumnoBuscar alumnoBuscar = new frmAlumnoBuscar();

            alumnoBuscar.ShowDialog(this);
        }

        private void btnAsisntenciaNuevoBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCurso unFrmCursoBuscar = new frmBuscarCurso();
            unFrmCursoBuscar.ShowDialog(this);
        }

        private void frmAsistenciaNuevo_Load(object sender, EventArgs e)
        {
            rbtAsistenciaNuevoAusente.Checked = false;
            rbtAsistenciaNuevoPresente.Checked = false;

            if (rbtAsistenciaNuevoAusente.Checked)
            {
                //El radio esta marcado
                TrueFalse(rbtAsistenciaNuevoAusente);
            }
            else
            {
                //El radio esta sin marcar
                TrueFalse(rbtAsistenciaNuevoPresente);
            }
            
        }

        private string TrueFalse(RadioButton a)
        {
            if (a.Checked)
            {
                return (1).ToString();
            }
            return (0).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
