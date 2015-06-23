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

namespace EstadisticasEscuelaFrontEnd
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();

            FormLogin login = new FormLogin();
            
            login.ShowDialog(this);

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
    }
}
