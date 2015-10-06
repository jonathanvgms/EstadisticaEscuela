using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstadisticasEscuelaFrontEnd.Rol
{
    public partial class frmRolNuevo : Form
    {
        public frmRolNuevo()
        {
            InitializeComponent();
        }

        private void btnRolNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnRolNuevoDesmarcar_Click(object sender, EventArgs e)
        {
            //while (clbRolNuevo.CheckedIndices.Count>0)
            for (int i = 0; i < clbRolNuevo.Items.Count; i++)
            {
                clbRolNuevo.SetItemChecked(i, false);
            }
            //{
            //    clbRolNuevo.SetItemChecked(clbRolNuevo.CheckedIndices[0], false);
            //}
            txtRolNuevoNombre.Clear();
        }
            
        private bool checkData(TextBox textbox, Label label)
        {
            label.Text = "";

            if (!textbox.Text.Equals(""))
            {
                if (textbox.Name.Equals("txtRolNuevoNombre"))
                {
                    //if (!Util.todasLetras(textbox.Text)
                    //{
                    //    label.Text = "Valor Incorrecto";

                    //    return false;
                    //}
                    
                }
            }
                else
                {
                    label.Text = "Vacio";

                    return false;
                }

                return true;
        }
        

        private void btnRolNuevoAceptar_Click(object sender, EventArgs e)
        {
            //Se Borra Dominio cambia la verificacion de datos
            //bool error = true;

            
        } 
    }
}
