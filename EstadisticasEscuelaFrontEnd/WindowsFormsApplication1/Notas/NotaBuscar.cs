using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Alumnos;

namespace EstadisticasEscuelaFrontEnd.Notas
{
    public partial class NotaBuscar : Form
    {
        public NotaBuscar()
        {
            InitializeComponent();
        }

       

        private void btnNotaBuscarCursoBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCurso unCursoBuscar = new frmBuscarCurso();
            unCursoBuscar.ShowDialog(this);
        }

        private void btnNotaBuscarAlumnoBuscar_Click(object sender, EventArgs e)
        {
            frmAlumnoBuscar unAlumnoBuscar = new frmAlumnoBuscar();
            unAlumnoBuscar.ShowDialog(this);
        }

        private void dgvNotaBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if((e.ColumnIndex == dgvNotaBuscar.Columns["Modificar"].Index) && (e.ColumnIndex >= -1))
            {
                NotaBuscar notaModificar = new NotaBuscar();
                string no

        }

       
      
    }
}
