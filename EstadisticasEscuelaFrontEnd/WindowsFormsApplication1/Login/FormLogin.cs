using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Login
{
    public partial class frmFormLogin : Form
    {
        public frmFormLogin()
        {
            InitializeComponent();
        }

        /*
         * Cierra el form de Login
         */ 
        private void txtLoginNo_Click(object sender, EventArgs e)
        {
            Close();
            System.Windows.Forms.Application.Exit();
        }
        
        private void btnLoginOk_Click(object sender, EventArgs e)
        {
            /*
             * Se debe validad que el usuario existe, si es asi que su contraseña 
             * es la que dice ser, verificar errores si no existe usuario, o campo vacio
             * o campo incorrecto.
             */
            
            if (txtUsername.Text.Equals(""))
            {
                lblLoginUsuario.Text = "Vacio";
            }

            if (txtPassword.Text.Equals(""))
            {
                lblLoginContrasenia.Text = "Vacio";
            }
        }

        private void PresionarTecla(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToUInt32(e.KeyChar) == 27)
            {
                Close();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
