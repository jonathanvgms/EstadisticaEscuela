namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    partial class frmAlumnoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnoNuevo));
            this.btnAlumnoNuevo = new System.Windows.Forms.Button();
            this.btnAlumnoNuevoLimpiar = new System.Windows.Forms.Button();
            this.btnAlumnoNuevoCancelar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.lblAlumnoNuevoDescripcionError = new System.Windows.Forms.Label();
            this.lblAlumnoNuevoDescripcion = new System.Windows.Forms.Label();
            this.txtAlumnoNuevoDescripcion = new System.Windows.Forms.TextBox();
            this.lblAlumnoNuevoUsuarioError = new System.Windows.Forms.Label();
            this.txtAlumnoNuevoUsuario = new System.Windows.Forms.TextBox();
            this.btnAlumnoNuevoCrearUsuario = new System.Windows.Forms.Button();
            this.lblAlumnoNuevoUsuario = new System.Windows.Forms.Label();
            this.txtAlumnoNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblAlumnoNuevoNombre = new System.Windows.Forms.Label();
            this.txtAlumnoNuevoApellido = new System.Windows.Forms.TextBox();
            this.txtAlumnoNuevoLegajo = new System.Windows.Forms.TextBox();
            this.lblAlumnoNuevoDniError = new System.Windows.Forms.Label();
            this.lblAlumnoNuevoLegajoError = new System.Windows.Forms.Label();
            this.lblAlumnoNuevoApellido = new System.Windows.Forms.Label();
            this.lblAlumnoNuevoApellidoError = new System.Windows.Forms.Label();
            this.lblAlumnoNuevoLegajo = new System.Windows.Forms.Label();
            this.lblAlumnoNuevoNombreError = new System.Windows.Forms.Label();
            this.lblAlumnoNuevoDNI = new System.Windows.Forms.Label();
            this.txtAlumnoNuevoDNI = new System.Windows.Forms.TextBox();
            this.lblAlumnoNuevoError = new System.Windows.Forms.Label();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlumnoNuevo
            // 
            this.btnAlumnoNuevo.Location = new System.Drawing.Point(533, 387);
            this.btnAlumnoNuevo.Name = "btnAlumnoNuevo";
            this.btnAlumnoNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnoNuevo.TabIndex = 1;
            this.btnAlumnoNuevo.Text = "Aceptar";
            this.btnAlumnoNuevo.UseVisualStyleBackColor = true;
            this.btnAlumnoNuevo.Click += new System.EventHandler(this.btnAlumnoNuevo_Click);
            // 
            // btnAlumnoNuevoLimpiar
            // 
            this.btnAlumnoNuevoLimpiar.Location = new System.Drawing.Point(12, 387);
            this.btnAlumnoNuevoLimpiar.Name = "btnAlumnoNuevoLimpiar";
            this.btnAlumnoNuevoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnoNuevoLimpiar.TabIndex = 2;
            this.btnAlumnoNuevoLimpiar.Text = "Limpiar";
            this.btnAlumnoNuevoLimpiar.UseVisualStyleBackColor = true;
            this.btnAlumnoNuevoLimpiar.Click += new System.EventHandler(this.btnAlumnoNuevoLimpiar_Click);
            // 
            // btnAlumnoNuevoCancelar
            // 
            this.btnAlumnoNuevoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlumnoNuevoCancelar.Location = new System.Drawing.Point(614, 387);
            this.btnAlumnoNuevoCancelar.Name = "btnAlumnoNuevoCancelar";
            this.btnAlumnoNuevoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnoNuevoCancelar.TabIndex = 3;
            this.btnAlumnoNuevoCancelar.Text = "Cancelar";
            this.btnAlumnoNuevoCancelar.UseVisualStyleBackColor = true;
            this.btnAlumnoNuevoCancelar.Click += new System.EventHandler(this.btnAlumnoNuevoCancelar_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.lblAlumnoNuevoDescripcionError);
            this.Datos.Controls.Add(this.lblAlumnoNuevoDescripcion);
            this.Datos.Controls.Add(this.txtAlumnoNuevoDescripcion);
            this.Datos.Controls.Add(this.lblAlumnoNuevoUsuarioError);
            this.Datos.Controls.Add(this.txtAlumnoNuevoUsuario);
            this.Datos.Controls.Add(this.btnAlumnoNuevoCrearUsuario);
            this.Datos.Controls.Add(this.lblAlumnoNuevoUsuario);
            this.Datos.Controls.Add(this.txtAlumnoNuevoNombre);
            this.Datos.Controls.Add(this.lblAlumnoNuevoNombre);
            this.Datos.Controls.Add(this.txtAlumnoNuevoApellido);
            this.Datos.Controls.Add(this.txtAlumnoNuevoLegajo);
            this.Datos.Controls.Add(this.lblAlumnoNuevoDniError);
            this.Datos.Controls.Add(this.lblAlumnoNuevoLegajoError);
            this.Datos.Controls.Add(this.lblAlumnoNuevoApellido);
            this.Datos.Controls.Add(this.lblAlumnoNuevoApellidoError);
            this.Datos.Controls.Add(this.lblAlumnoNuevoLegajo);
            this.Datos.Controls.Add(this.lblAlumnoNuevoNombreError);
            this.Datos.Controls.Add(this.lblAlumnoNuevoDNI);
            this.Datos.Controls.Add(this.txtAlumnoNuevoDNI);
            this.Datos.Location = new System.Drawing.Point(12, 12);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(677, 369);
            this.Datos.TabIndex = 27;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // lblAlumnoNuevoDescripcionError
            // 
            this.lblAlumnoNuevoDescripcionError.AutoSize = true;
            this.lblAlumnoNuevoDescripcionError.Location = new System.Drawing.Point(755, 29);
            this.lblAlumnoNuevoDescripcionError.Name = "lblAlumnoNuevoDescripcionError";
            this.lblAlumnoNuevoDescripcionError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoNuevoDescripcionError.TabIndex = 33;
            // 
            // lblAlumnoNuevoDescripcion
            // 
            this.lblAlumnoNuevoDescripcion.AutoSize = true;
            this.lblAlumnoNuevoDescripcion.Location = new System.Drawing.Point(26, 226);
            this.lblAlumnoNuevoDescripcion.Name = "lblAlumnoNuevoDescripcion";
            this.lblAlumnoNuevoDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblAlumnoNuevoDescripcion.TabIndex = 32;
            this.lblAlumnoNuevoDescripcion.Text = "Descripcion";
            // 
            // txtAlumnoNuevoDescripcion
            // 
            this.txtAlumnoNuevoDescripcion.Location = new System.Drawing.Point(125, 223);
            this.txtAlumnoNuevoDescripcion.Multiline = true;
            this.txtAlumnoNuevoDescripcion.Name = "txtAlumnoNuevoDescripcion";
            this.txtAlumnoNuevoDescripcion.Size = new System.Drawing.Size(539, 127);
            this.txtAlumnoNuevoDescripcion.TabIndex = 28;
            // 
            // lblAlumnoNuevoUsuarioError
            // 
            this.lblAlumnoNuevoUsuarioError.AutoSize = true;
            this.lblAlumnoNuevoUsuarioError.Location = new System.Drawing.Point(454, 174);
            this.lblAlumnoNuevoUsuarioError.Name = "lblAlumnoNuevoUsuarioError";
            this.lblAlumnoNuevoUsuarioError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoNuevoUsuarioError.TabIndex = 31;
            // 
            // txtAlumnoNuevoUsuario
            // 
            this.txtAlumnoNuevoUsuario.Location = new System.Drawing.Point(128, 174);
            this.txtAlumnoNuevoUsuario.Name = "txtAlumnoNuevoUsuario";
            this.txtAlumnoNuevoUsuario.ReadOnly = true;
            this.txtAlumnoNuevoUsuario.Size = new System.Drawing.Size(209, 20);
            this.txtAlumnoNuevoUsuario.TabIndex = 29;
            // 
            // btnAlumnoNuevoCrearUsuario
            // 
            this.btnAlumnoNuevoCrearUsuario.Location = new System.Drawing.Point(366, 172);
            this.btnAlumnoNuevoCrearUsuario.Name = "btnAlumnoNuevoCrearUsuario";
            this.btnAlumnoNuevoCrearUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnoNuevoCrearUsuario.TabIndex = 30;
            this.btnAlumnoNuevoCrearUsuario.Text = "Buscar Usuario";
            this.btnAlumnoNuevoCrearUsuario.UseVisualStyleBackColor = true;
            this.btnAlumnoNuevoCrearUsuario.Click += new System.EventHandler(this.btnAlumnoNuevoBuscarUsuario_Click);
            // 
            // lblAlumnoNuevoUsuario
            // 
            this.lblAlumnoNuevoUsuario.AutoSize = true;
            this.lblAlumnoNuevoUsuario.Location = new System.Drawing.Point(26, 177);
            this.lblAlumnoNuevoUsuario.Name = "lblAlumnoNuevoUsuario";
            this.lblAlumnoNuevoUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblAlumnoNuevoUsuario.TabIndex = 28;
            this.lblAlumnoNuevoUsuario.Text = "Usuario";
            // 
            // txtAlumnoNuevoNombre
            // 
            this.txtAlumnoNuevoNombre.Location = new System.Drawing.Point(128, 26);
            this.txtAlumnoNuevoNombre.Name = "txtAlumnoNuevoNombre";
            this.txtAlumnoNuevoNombre.Size = new System.Drawing.Size(209, 20);
            this.txtAlumnoNuevoNombre.TabIndex = 4;
            // 
            // lblAlumnoNuevoNombre
            // 
            this.lblAlumnoNuevoNombre.AutoSize = true;
            this.lblAlumnoNuevoNombre.Location = new System.Drawing.Point(26, 29);
            this.lblAlumnoNuevoNombre.Name = "lblAlumnoNuevoNombre";
            this.lblAlumnoNuevoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblAlumnoNuevoNombre.TabIndex = 0;
            this.lblAlumnoNuevoNombre.Text = "Nombre";
            // 
            // txtAlumnoNuevoApellido
            // 
            this.txtAlumnoNuevoApellido.Location = new System.Drawing.Point(128, 63);
            this.txtAlumnoNuevoApellido.Name = "txtAlumnoNuevoApellido";
            this.txtAlumnoNuevoApellido.Size = new System.Drawing.Size(209, 20);
            this.txtAlumnoNuevoApellido.TabIndex = 5;
            // 
            // txtAlumnoNuevoLegajo
            // 
            this.txtAlumnoNuevoLegajo.Location = new System.Drawing.Point(128, 96);
            this.txtAlumnoNuevoLegajo.Name = "txtAlumnoNuevoLegajo";
            this.txtAlumnoNuevoLegajo.Size = new System.Drawing.Size(209, 20);
            this.txtAlumnoNuevoLegajo.TabIndex = 6;
            // 
            // lblAlumnoNuevoDniError
            // 
            this.lblAlumnoNuevoDniError.AutoSize = true;
            this.lblAlumnoNuevoDniError.Location = new System.Drawing.Point(363, 141);
            this.lblAlumnoNuevoDniError.Name = "lblAlumnoNuevoDniError";
            this.lblAlumnoNuevoDniError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoNuevoDniError.TabIndex = 20;
            // 
            // lblAlumnoNuevoLegajoError
            // 
            this.lblAlumnoNuevoLegajoError.AutoSize = true;
            this.lblAlumnoNuevoLegajoError.Location = new System.Drawing.Point(363, 99);
            this.lblAlumnoNuevoLegajoError.Name = "lblAlumnoNuevoLegajoError";
            this.lblAlumnoNuevoLegajoError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoNuevoLegajoError.TabIndex = 19;
            // 
            // lblAlumnoNuevoApellido
            // 
            this.lblAlumnoNuevoApellido.AutoSize = true;
            this.lblAlumnoNuevoApellido.Location = new System.Drawing.Point(27, 66);
            this.lblAlumnoNuevoApellido.Name = "lblAlumnoNuevoApellido";
            this.lblAlumnoNuevoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblAlumnoNuevoApellido.TabIndex = 7;
            this.lblAlumnoNuevoApellido.Text = "Apellido";
            // 
            // lblAlumnoNuevoApellidoError
            // 
            this.lblAlumnoNuevoApellidoError.AutoSize = true;
            this.lblAlumnoNuevoApellidoError.Location = new System.Drawing.Point(363, 66);
            this.lblAlumnoNuevoApellidoError.Name = "lblAlumnoNuevoApellidoError";
            this.lblAlumnoNuevoApellidoError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoNuevoApellidoError.TabIndex = 18;
            // 
            // lblAlumnoNuevoLegajo
            // 
            this.lblAlumnoNuevoLegajo.AutoSize = true;
            this.lblAlumnoNuevoLegajo.Location = new System.Drawing.Point(27, 99);
            this.lblAlumnoNuevoLegajo.Name = "lblAlumnoNuevoLegajo";
            this.lblAlumnoNuevoLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblAlumnoNuevoLegajo.TabIndex = 8;
            this.lblAlumnoNuevoLegajo.Text = "Legajo";
            // 
            // lblAlumnoNuevoNombreError
            // 
            this.lblAlumnoNuevoNombreError.AutoSize = true;
            this.lblAlumnoNuevoNombreError.Location = new System.Drawing.Point(363, 29);
            this.lblAlumnoNuevoNombreError.Name = "lblAlumnoNuevoNombreError";
            this.lblAlumnoNuevoNombreError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoNuevoNombreError.TabIndex = 17;
            // 
            // lblAlumnoNuevoDNI
            // 
            this.lblAlumnoNuevoDNI.AutoSize = true;
            this.lblAlumnoNuevoDNI.Location = new System.Drawing.Point(27, 141);
            this.lblAlumnoNuevoDNI.Name = "lblAlumnoNuevoDNI";
            this.lblAlumnoNuevoDNI.Size = new System.Drawing.Size(26, 13);
            this.lblAlumnoNuevoDNI.TabIndex = 9;
            this.lblAlumnoNuevoDNI.Text = "DNI";
            // 
            // txtAlumnoNuevoDNI
            // 
            this.txtAlumnoNuevoDNI.Location = new System.Drawing.Point(128, 134);
            this.txtAlumnoNuevoDNI.Name = "txtAlumnoNuevoDNI";
            this.txtAlumnoNuevoDNI.Size = new System.Drawing.Size(209, 20);
            this.txtAlumnoNuevoDNI.TabIndex = 10;
            // 
            // lblAlumnoNuevoError
            // 
            this.lblAlumnoNuevoError.AutoSize = true;
            this.lblAlumnoNuevoError.Location = new System.Drawing.Point(98, 392);
            this.lblAlumnoNuevoError.Name = "lblAlumnoNuevoError";
            this.lblAlumnoNuevoError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoNuevoError.TabIndex = 28;
            // 
            // frmAlumnoNuevo
            // 
            this.AcceptButton = this.btnAlumnoNuevo;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnAlumnoNuevoCancelar;
            this.ClientSize = new System.Drawing.Size(699, 416);
            this.Controls.Add(this.lblAlumnoNuevoError);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.btnAlumnoNuevo);
            this.Controls.Add(this.btnAlumnoNuevoLimpiar);
            this.Controls.Add(this.btnAlumnoNuevoCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumnoNuevo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Alumno";
            this.Load += new System.EventHandler(this.frmAlumnoNuevo_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlumnoNuevo;
        private System.Windows.Forms.Button btnAlumnoNuevoLimpiar;
        private System.Windows.Forms.Button btnAlumnoNuevoCancelar;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label lblAlumnoNuevoDescripcion;
        private System.Windows.Forms.TextBox txtAlumnoNuevoDescripcion;
        private System.Windows.Forms.Label lblAlumnoNuevoUsuarioError;
        private System.Windows.Forms.TextBox txtAlumnoNuevoUsuario;
        private System.Windows.Forms.Button btnAlumnoNuevoCrearUsuario;
        private System.Windows.Forms.Label lblAlumnoNuevoUsuario;
        private System.Windows.Forms.TextBox txtAlumnoNuevoNombre;
        private System.Windows.Forms.Label lblAlumnoNuevoNombre;
        private System.Windows.Forms.TextBox txtAlumnoNuevoApellido;
        private System.Windows.Forms.TextBox txtAlumnoNuevoLegajo;
        private System.Windows.Forms.Label lblAlumnoNuevoDniError;
        private System.Windows.Forms.Label lblAlumnoNuevoLegajoError;
        private System.Windows.Forms.Label lblAlumnoNuevoApellido;
        private System.Windows.Forms.Label lblAlumnoNuevoApellidoError;
        private System.Windows.Forms.Label lblAlumnoNuevoLegajo;
        private System.Windows.Forms.Label lblAlumnoNuevoNombreError;
        private System.Windows.Forms.Label lblAlumnoNuevoDNI;
        private System.Windows.Forms.TextBox txtAlumnoNuevoDNI;
        private System.Windows.Forms.Label lblAlumnoNuevoError;
        private System.Windows.Forms.Label lblAlumnoNuevoDescripcionError;
    }
}