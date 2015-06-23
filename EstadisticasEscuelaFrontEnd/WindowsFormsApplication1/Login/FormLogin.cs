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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Cerrar formulario
        /*
         * Cierra el form de Login
         */ 
        private void txtLoginNo_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void btnLoginOk_Click(object sender, EventArgs e)
        {
            /*
             * Se debe validad que el usuario existe, si es asi que su contraseña 
             * es la que dice ser, verificar errores si no existe usuario, o campo vacio
             * o campo incorrecto.
             */ 
            Close();
        }
    }
}
