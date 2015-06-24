using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    public partial class fmrBuscarUsuario : Form
    {
        public fmrBuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuarioBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "";

            if (!txtBuscarUsuarioNombre.Text.Equals(""))
            {
                if (!Util.todasLetras(this.txtBuscarUsuarioNombre.Text))
                {
                    cadena += "El campo Nombre tiene valores incorrectos.\n";
                }
            }

            if (!cadena.Equals(""))
            {
                MessageBox.Show(cadena);
            }
        }

        private void btnBuscarUsuarioSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarUsuarioLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarUsuarioNombre.Clear();
            
        }
    }
}
