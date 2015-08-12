using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Login;
using EstadisticasEscuelaFrontEnd.Alumnos;
using EstadisticasEscuelaFrontEnd.Usuarios;
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Database;
using EstadisticasEscuelaFrontEnd.Materia;
using EstadisticasEscuelaFrontEnd.Asistencia;


namespace EstadisticasEscuelaFrontEnd
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();

            frmFormLogin login = new frmFormLogin();
            
            login.ShowDialog(this);

            //Objeto.ConectionString("win2012-01", "3306", "estadisticasescuela", "root", "Lujho12");
            //Objeto.ConectionString("win2012-01", "3306", "escuela", "alumno67", "saramoya");
            Objeto.ConectionString("win2012-01", "3306", "estadisticasescuela", "alumno67", "saramoya");
        }

        private void adsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnoNuevo unfrmAlumnoNuevo=new frmAlumnoNuevo();
            unfrmAlumnoNuevo.ShowDialog(this);
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioNuevo unfrmUsuario = new UsuarioNuevo();
            unfrmUsuario.ShowDialog(this);
        }

        private void dasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursoNuevo unfrmCurso= new frmCursoNuevo();
            unfrmCurso.ShowDialog(this);
        }

        private void dasdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnoBuscar buscarAlumno = new frmAlumnoBuscar();
            buscarAlumno.ShowDialog(this);
        }

        private void adasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarCurso buscarCurso = new frmBuscarCurso();
            buscarCurso.ShowDialog(this);
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioBuscar buscarUsuario = new frmUsuarioBuscar();
            buscarUsuario.ShowDialog(this);
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMateriaNuevo unfrmMateriaNuevo = new frmMateriaNuevo();
            unfrmMateriaNuevo.ShowDialog(this);
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMateriaBuscar unfrmMateriaBuscar = new frmMateriaBuscar();
            unfrmMateriaBuscar.ShowDialog(this);
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAsistenciaNuevo unfrmAsistenciaNuevo = new frmAsistenciaNuevo();
            unfrmAsistenciaNuevo.ShowDialog(this);
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAsistenciaBuscar unfrmAsistenciaBuscar = new frmAsistenciaBuscar();
            unfrmAsistenciaBuscar.ShowDialog(this);
        }

       
    }
}
