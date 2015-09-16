using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Alumnos;
using EstadisticasEscuelaFrontEnd.Cursos;

namespace EstadisticasEscuelaFrontEnd.Notas
{
    public partial class NotaNuevo : Form
    {
        public NotaNuevo()
        {
            InitializeComponent();
        }

        private void btnNotaNuevoAlumnoBuscar_Click(object sender, EventArgs e)
        {
            frmAlumnoBuscar unAlumnoBuscar = new frmAlumnoBuscar();
            unAlumnoBuscar.ShowDialog(this);

        }

        private void btnNotaNuevoBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCurso unBuscarCurso = new frmBuscarCurso();
            unBuscarCurso.ShowDialog(this);
        }

        private void btnNotaNuevoLimpiar_Click(object sender, EventArgs e)
        {
            txtNotaNuevoNota1erTrim.Clear();
            txtNotaNuevoNota2doTrim.Clear();
            txtNotaNuevoNota3erTrim.Clear();
            txtNotaNuevoNotaDefinitiva.Clear();
            txtNotaNuevoNotaFinal.Clear();
            txtNotaNuevoAlumno.Clear();
            txtNotaNuevoCurso.Clear();
        }
        
     

       
       

        
    }
}
