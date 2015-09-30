using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Materias;
using EstadisticasEscuelaFrontEnd.Cursos;

namespace EstadisticasEscuelaFrontEnd.Nota
{
    public partial class frmAsignarNota : Form
    {
        public frmAsignarNota()
        {
            InitializeComponent();
        }

        private void btnModificarNotaBuscarMateria_Click(object sender, EventArgs e)
        {
            frmMateriaBuscar unafrmmateriaBuscar = new frmMateriaBuscar();
            unafrmmateriaBuscar.ShowDialog(this);
            
        }

        private void btnModificarNotaBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCurso unfrmBuscarCurso = new frmBuscarCurso();
            unfrmBuscarCurso.ShowDialog(this);
        }

        private void btnModificarNotaLimpiar_Click(object sender, EventArgs e)
        {
            txtAsignarNotaCurso.Clear();
            txtAsignarNotaMateria.Clear();
        }

        private void btnAsignarNotaCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

     
     
       
    
      
     

      
        
    }
}
