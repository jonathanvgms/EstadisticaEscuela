namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    partial class frmUsuario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnfrmUsuarioAceptar = new System.Windows.Forms.Button();
            this.btnfrmUsuarioCancelar = new System.Windows.Forms.Button();
            this.lblfrmUsuarioUsuario = new System.Windows.Forms.Label();
            this.lblfrmUsuarioContrasenia = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnfrmUsuarioLimpiar = new System.Windows.Forms.Button();
            this.cmbUsuarioTipodeUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuarioTipodeUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfrmUsuarioAceptar
            // 
            this.btnfrmUsuarioAceptar.Location = new System.Drawing.Point(170, 204);
            this.btnfrmUsuarioAceptar.Name = "btnfrmUsuarioAceptar";
            this.btnfrmUsuarioAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmUsuarioAceptar.TabIndex = 0;
            this.btnfrmUsuarioAceptar.Text = "Aceptar";
            this.btnfrmUsuarioAceptar.UseVisualStyleBackColor = true;
            this.btnfrmUsuarioAceptar.Click += new System.EventHandler(this.btnfrmUsuarioAceptar_Click);
            // 
            // btnfrmUsuarioCancelar
            // 
            this.btnfrmUsuarioCancelar.Location = new System.Drawing.Point(328, 204);
            this.btnfrmUsuarioCancelar.Name = "btnfrmUsuarioCancelar";
            this.btnfrmUsuarioCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmUsuarioCancelar.TabIndex = 1;
            this.btnfrmUsuarioCancelar.Text = "Cancelar";
            this.btnfrmUsuarioCancelar.UseVisualStyleBackColor = true;
            this.btnfrmUsuarioCancelar.Click += new System.EventHandler(this.btnfrmUsuarioCancelar_Click);
            // 
            // lblfrmUsuarioUsuario
            // 
            this.lblfrmUsuarioUsuario.AutoSize = true;
            this.lblfrmUsuarioUsuario.Location = new System.Drawing.Point(79, 62);
            this.lblfrmUsuarioUsuario.Name = "lblfrmUsuarioUsuario";
            this.lblfrmUsuarioUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblfrmUsuarioUsuario.TabIndex = 2;
            this.lblfrmUsuarioUsuario.Text = "Usuario";
            // 
            // lblfrmUsuarioContrasenia
            // 
            this.lblfrmUsuarioContrasenia.AutoSize = true;
            this.lblfrmUsuarioContrasenia.Location = new System.Drawing.Point(79, 101);
            this.lblfrmUsuarioContrasenia.Name = "lblfrmUsuarioContrasenia";
            this.lblfrmUsuarioContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblfrmUsuarioContrasenia.TabIndex = 3;
            this.lblfrmUsuarioContrasenia.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(240, 62);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(240, 101);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(121, 20);
            this.txtContrasenia.TabIndex = 6;
            // 
            // btnfrmUsuarioLimpiar
            // 
            this.btnfrmUsuarioLimpiar.Location = new System.Drawing.Point(23, 204);
            this.btnfrmUsuarioLimpiar.Name = "btnfrmUsuarioLimpiar";
            this.btnfrmUsuarioLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmUsuarioLimpiar.TabIndex = 7;
            this.btnfrmUsuarioLimpiar.Text = "Limpiar";
            this.btnfrmUsuarioLimpiar.UseVisualStyleBackColor = true;
            this.btnfrmUsuarioLimpiar.Click += new System.EventHandler(this.btnfrmUsuarioLimpiar_Click);
            // 
            // cmbUsuarioTipodeUsuario
            // 
            this.cmbUsuarioTipodeUsuario.FormattingEnabled = true;
            this.cmbUsuarioTipodeUsuario.Location = new System.Drawing.Point(240, 144);
            this.cmbUsuarioTipodeUsuario.Name = "cmbUsuarioTipodeUsuario";
            this.cmbUsuarioTipodeUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarioTipodeUsuario.TabIndex = 8;
            this.cmbUsuarioTipodeUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblUsuarioTipodeUsuario
            // 
            this.lblUsuarioTipodeUsuario.AutoSize = true;
            this.lblUsuarioTipodeUsuario.Location = new System.Drawing.Point(79, 144);
            this.lblUsuarioTipodeUsuario.Name = "lblUsuarioTipodeUsuario";
            this.lblUsuarioTipodeUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblUsuarioTipodeUsuario.TabIndex = 9;
            this.lblUsuarioTipodeUsuario.Text = "Tipo de Usuario";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.lblUsuarioTipodeUsuario);
            this.Controls.Add(this.cmbUsuarioTipodeUsuario);
            this.Controls.Add(this.btnfrmUsuarioLimpiar);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblfrmUsuarioContrasenia);
            this.Controls.Add(this.lblfrmUsuarioUsuario);
            this.Controls.Add(this.btnfrmUsuarioCancelar);
            this.Controls.Add(this.btnfrmUsuarioAceptar);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfrmUsuarioAceptar;
        private System.Windows.Forms.Button btnfrmUsuarioCancelar;
        private System.Windows.Forms.Label lblfrmUsuarioUsuario;
        private System.Windows.Forms.Label lblfrmUsuarioContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnfrmUsuarioLimpiar;
        private System.Windows.Forms.ComboBox cmbUsuarioTipodeUsuario;
        private System.Windows.Forms.Label lblUsuarioTipodeUsuario;
    }
}