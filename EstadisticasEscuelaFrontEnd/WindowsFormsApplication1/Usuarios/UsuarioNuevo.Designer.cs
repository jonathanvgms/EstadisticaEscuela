namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    partial class frmUsuarioNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioNuevo));
            this.btnUsuarioNuevoAceptar = new System.Windows.Forms.Button();
            this.btnUsuarioNuevoCancelar = new System.Windows.Forms.Button();
            this.lblUsuarioUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioContrasenia = new System.Windows.Forms.Label();
            this.txtUsuarioNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuarioNuevoContrasenia = new System.Windows.Forms.TextBox();
            this.btnUsuarioNuevoLimpiar = new System.Windows.Forms.Button();
            this.lblUsuarioNuevoTipodeUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsuarioNuevoContraseniaError = new System.Windows.Forms.Label();
            this.lblUsuarioNuevoUsuarioError = new System.Windows.Forms.Label();
            this.lblUsuarioNuevoError = new System.Windows.Forms.Label();
            this.lsbUsuarioNuevoTipo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarioNuevoAceptar
            // 
            this.btnUsuarioNuevoAceptar.Location = new System.Drawing.Point(354, 256);
            this.btnUsuarioNuevoAceptar.Name = "btnUsuarioNuevoAceptar";
            this.btnUsuarioNuevoAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioNuevoAceptar.TabIndex = 0;
            this.btnUsuarioNuevoAceptar.Text = "Aceptar";
            this.btnUsuarioNuevoAceptar.UseVisualStyleBackColor = true;
            this.btnUsuarioNuevoAceptar.Click += new System.EventHandler(this.btnUsuarioNuevoAceptar_Click);
            // 
            // btnUsuarioNuevoCancelar
            // 
            this.btnUsuarioNuevoCancelar.Location = new System.Drawing.Point(435, 256);
            this.btnUsuarioNuevoCancelar.Name = "btnUsuarioNuevoCancelar";
            this.btnUsuarioNuevoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioNuevoCancelar.TabIndex = 1;
            this.btnUsuarioNuevoCancelar.Text = "Cancelar";
            this.btnUsuarioNuevoCancelar.UseVisualStyleBackColor = true;
            this.btnUsuarioNuevoCancelar.Click += new System.EventHandler(this.btnUsuarioNuevoCancelar_Click);
            // 
            // lblUsuarioUsuario
            // 
            this.lblUsuarioUsuario.AutoSize = true;
            this.lblUsuarioUsuario.Location = new System.Drawing.Point(74, 22);
            this.lblUsuarioUsuario.Name = "lblUsuarioUsuario";
            this.lblUsuarioUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioUsuario.TabIndex = 2;
            this.lblUsuarioUsuario.Text = "Usuario";
            // 
            // lblUsuarioContrasenia
            // 
            this.lblUsuarioContrasenia.AutoSize = true;
            this.lblUsuarioContrasenia.Location = new System.Drawing.Point(74, 58);
            this.lblUsuarioContrasenia.Name = "lblUsuarioContrasenia";
            this.lblUsuarioContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblUsuarioContrasenia.TabIndex = 3;
            this.lblUsuarioContrasenia.Text = "Contraseña";
            // 
            // txtUsuarioNuevoUsuario
            // 
            this.txtUsuarioNuevoUsuario.Location = new System.Drawing.Point(203, 19);
            this.txtUsuarioNuevoUsuario.Name = "txtUsuarioNuevoUsuario";
            this.txtUsuarioNuevoUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtUsuarioNuevoUsuario.TabIndex = 5;
            // 
            // txtUsuarioNuevoContrasenia
            // 
            this.txtUsuarioNuevoContrasenia.Location = new System.Drawing.Point(203, 55);
            this.txtUsuarioNuevoContrasenia.Name = "txtUsuarioNuevoContrasenia";
            this.txtUsuarioNuevoContrasenia.Size = new System.Drawing.Size(181, 20);
            this.txtUsuarioNuevoContrasenia.TabIndex = 6;
            // 
            // btnUsuarioNuevoLimpiar
            // 
            this.btnUsuarioNuevoLimpiar.Location = new System.Drawing.Point(12, 256);
            this.btnUsuarioNuevoLimpiar.Name = "btnUsuarioNuevoLimpiar";
            this.btnUsuarioNuevoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioNuevoLimpiar.TabIndex = 7;
            this.btnUsuarioNuevoLimpiar.Text = "Limpiar";
            this.btnUsuarioNuevoLimpiar.UseVisualStyleBackColor = true;
            this.btnUsuarioNuevoLimpiar.Click += new System.EventHandler(this.btnUsuarioNuevoLimpiar_Click);
            // 
            // lblUsuarioNuevoTipodeUsuario
            // 
            this.lblUsuarioNuevoTipodeUsuario.AutoSize = true;
            this.lblUsuarioNuevoTipodeUsuario.Location = new System.Drawing.Point(74, 95);
            this.lblUsuarioNuevoTipodeUsuario.Name = "lblUsuarioNuevoTipodeUsuario";
            this.lblUsuarioNuevoTipodeUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblUsuarioNuevoTipodeUsuario.TabIndex = 9;
            this.lblUsuarioNuevoTipodeUsuario.Text = "Tipo de Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbUsuarioNuevoTipo);
            this.groupBox1.Controls.Add(this.lblUsuarioNuevoContraseniaError);
            this.groupBox1.Controls.Add(this.lblUsuarioNuevoUsuarioError);
            this.groupBox1.Controls.Add(this.txtUsuarioNuevoUsuario);
            this.groupBox1.Controls.Add(this.lblUsuarioNuevoTipodeUsuario);
            this.groupBox1.Controls.Add(this.lblUsuarioUsuario);
            this.groupBox1.Controls.Add(this.lblUsuarioContrasenia);
            this.groupBox1.Controls.Add(this.txtUsuarioNuevoContrasenia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 238);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lblUsuarioNuevoContraseniaError
            // 
            this.lblUsuarioNuevoContraseniaError.AutoSize = true;
            this.lblUsuarioNuevoContraseniaError.Location = new System.Drawing.Point(390, 73);
            this.lblUsuarioNuevoContraseniaError.Name = "lblUsuarioNuevoContraseniaError";
            this.lblUsuarioNuevoContraseniaError.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioNuevoContraseniaError.TabIndex = 11;
            // 
            // lblUsuarioNuevoUsuarioError
            // 
            this.lblUsuarioNuevoUsuarioError.AutoSize = true;
            this.lblUsuarioNuevoUsuarioError.Location = new System.Drawing.Point(390, 30);
            this.lblUsuarioNuevoUsuarioError.Name = "lblUsuarioNuevoUsuarioError";
            this.lblUsuarioNuevoUsuarioError.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioNuevoUsuarioError.TabIndex = 10;
            // 
            // lblUsuarioNuevoError
            // 
            this.lblUsuarioNuevoError.AutoSize = true;
            this.lblUsuarioNuevoError.Location = new System.Drawing.Point(12, 203);
            this.lblUsuarioNuevoError.Name = "lblUsuarioNuevoError";
            this.lblUsuarioNuevoError.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioNuevoError.TabIndex = 11;
            // 
            // lsbUsuarioNuevoTipo
            // 
            this.lsbUsuarioNuevoTipo.FormattingEnabled = true;
            this.lsbUsuarioNuevoTipo.Items.AddRange(new object[] {
            "Docente",
            "Alumno",
            "Preceptor",
            "Secretario",
            "Admintrador"});
            this.lsbUsuarioNuevoTipo.Location = new System.Drawing.Point(203, 95);
            this.lsbUsuarioNuevoTipo.Name = "lsbUsuarioNuevoTipo";
            this.lsbUsuarioNuevoTipo.Size = new System.Drawing.Size(181, 121);
            this.lsbUsuarioNuevoTipo.TabIndex = 12;
            // 
            // frmUsuarioNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 290);
            this.Controls.Add(this.lblUsuarioNuevoError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUsuarioNuevoLimpiar);
            this.Controls.Add(this.btnUsuarioNuevoCancelar);
            this.Controls.Add(this.btnUsuarioNuevoAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarioNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario Nuevo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarioNuevoAceptar;
        private System.Windows.Forms.Button btnUsuarioNuevoCancelar;
        private System.Windows.Forms.Label lblUsuarioUsuario;
        private System.Windows.Forms.Label lblUsuarioContrasenia;
        private System.Windows.Forms.TextBox txtUsuarioNuevoUsuario;
        private System.Windows.Forms.TextBox txtUsuarioNuevoContrasenia;
        private System.Windows.Forms.Button btnUsuarioNuevoLimpiar;
        private System.Windows.Forms.Label lblUsuarioNuevoTipodeUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsuarioNuevoContraseniaError;
        private System.Windows.Forms.Label lblUsuarioNuevoUsuarioError;
        private System.Windows.Forms.Label lblUsuarioNuevoError;
        private System.Windows.Forms.ListBox lsbUsuarioNuevoTipo;
    }
}