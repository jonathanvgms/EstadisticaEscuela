namespace EstadisticasEscuelaFrontEnd.Cursos
{
    partial class frmCursoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursoNuevo));
            this.btnfrmCursoLimpiar = new System.Windows.Forms.Button();
            this.btnfrmCursoCancelar = new System.Windows.Forms.Button();
            this.btnfrmCursoAceptar = new System.Windows.Forms.Button();
            this.lblfrmCurso = new System.Windows.Forms.Label();
            this.lblfrmCursoDivision = new System.Windows.Forms.Label();
            this.txtCursoNuevoAnio = new System.Windows.Forms.TextBox();
            this.txtCursoNuevoDivision = new System.Windows.Forms.TextBox();
            this.lblCursoNuevoTurno = new System.Windows.Forms.Label();
            this.lblCursoNuevoEspecialidad = new System.Windows.Forms.Label();
            this.cmbCursoNuevoTurno = new System.Windows.Forms.ComboBox();
            this.cmbCursoNuevoEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblCusoNuevoAnioError = new System.Windows.Forms.Label();
            this.lblCursoNuevoDivisionError = new System.Windows.Forms.Label();
            this.lblCursoNuevoMensaje = new System.Windows.Forms.Label();
            this.lblCursoNuevoTurnoError = new System.Windows.Forms.Label();
            this.lblCursoNuevoEspecialidadError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfrmCursoLimpiar
            // 
            this.btnfrmCursoLimpiar.Location = new System.Drawing.Point(42, 264);
            this.btnfrmCursoLimpiar.Name = "btnfrmCursoLimpiar";
            this.btnfrmCursoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmCursoLimpiar.TabIndex = 0;
            this.btnfrmCursoLimpiar.Text = "Limpiar";
            this.btnfrmCursoLimpiar.UseVisualStyleBackColor = true;
            this.btnfrmCursoLimpiar.Click += new System.EventHandler(this.btnfrmCursoLimpiar_Click);
            // 
            // btnfrmCursoCancelar
            // 
            this.btnfrmCursoCancelar.Location = new System.Drawing.Point(422, 264);
            this.btnfrmCursoCancelar.Name = "btnfrmCursoCancelar";
            this.btnfrmCursoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmCursoCancelar.TabIndex = 1;
            this.btnfrmCursoCancelar.Text = "Cancelar";
            this.btnfrmCursoCancelar.UseVisualStyleBackColor = true;
            this.btnfrmCursoCancelar.Click += new System.EventHandler(this.btnfrmCursoCancelar_Click);
            // 
            // btnfrmCursoAceptar
            // 
            this.btnfrmCursoAceptar.Location = new System.Drawing.Point(325, 264);
            this.btnfrmCursoAceptar.Name = "btnfrmCursoAceptar";
            this.btnfrmCursoAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmCursoAceptar.TabIndex = 2;
            this.btnfrmCursoAceptar.Text = "Aceptar";
            this.btnfrmCursoAceptar.UseVisualStyleBackColor = true;
            this.btnfrmCursoAceptar.Click += new System.EventHandler(this.btnfrmCursoAceptar_Click);
            // 
            // lblfrmCurso
            // 
            this.lblfrmCurso.AutoSize = true;
            this.lblfrmCurso.Location = new System.Drawing.Point(39, 54);
            this.lblfrmCurso.Name = "lblfrmCurso";
            this.lblfrmCurso.Size = new System.Drawing.Size(28, 13);
            this.lblfrmCurso.TabIndex = 3;
            this.lblfrmCurso.Text = "Anio";
            // 
            // lblfrmCursoDivision
            // 
            this.lblfrmCursoDivision.AutoSize = true;
            this.lblfrmCursoDivision.Location = new System.Drawing.Point(39, 97);
            this.lblfrmCursoDivision.Name = "lblfrmCursoDivision";
            this.lblfrmCursoDivision.Size = new System.Drawing.Size(44, 13);
            this.lblfrmCursoDivision.TabIndex = 4;
            this.lblfrmCursoDivision.Text = "Division";
            // 
            // txtCursoNuevoAnio
            // 
            this.txtCursoNuevoAnio.Location = new System.Drawing.Point(173, 54);
            this.txtCursoNuevoAnio.Name = "txtCursoNuevoAnio";
            this.txtCursoNuevoAnio.Size = new System.Drawing.Size(100, 20);
            this.txtCursoNuevoAnio.TabIndex = 5;
            // 
            // txtCursoNuevoDivision
            // 
            this.txtCursoNuevoDivision.Location = new System.Drawing.Point(173, 93);
            this.txtCursoNuevoDivision.Name = "txtCursoNuevoDivision";
            this.txtCursoNuevoDivision.Size = new System.Drawing.Size(100, 20);
            this.txtCursoNuevoDivision.TabIndex = 6;
            // 
            // lblCursoNuevoTurno
            // 
            this.lblCursoNuevoTurno.AutoSize = true;
            this.lblCursoNuevoTurno.Location = new System.Drawing.Point(39, 139);
            this.lblCursoNuevoTurno.Name = "lblCursoNuevoTurno";
            this.lblCursoNuevoTurno.Size = new System.Drawing.Size(35, 13);
            this.lblCursoNuevoTurno.TabIndex = 7;
            this.lblCursoNuevoTurno.Text = "Turno";
            // 
            // lblCursoNuevoEspecialidad
            // 
            this.lblCursoNuevoEspecialidad.AutoSize = true;
            this.lblCursoNuevoEspecialidad.Location = new System.Drawing.Point(39, 178);
            this.lblCursoNuevoEspecialidad.Name = "lblCursoNuevoEspecialidad";
            this.lblCursoNuevoEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblCursoNuevoEspecialidad.TabIndex = 8;
            this.lblCursoNuevoEspecialidad.Text = "Especialidad";
            // 
            // cmbCursoNuevoTurno
            // 
            this.cmbCursoNuevoTurno.FormattingEnabled = true;
            this.cmbCursoNuevoTurno.Location = new System.Drawing.Point(173, 134);
            this.cmbCursoNuevoTurno.Name = "cmbCursoNuevoTurno";
            this.cmbCursoNuevoTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbCursoNuevoTurno.TabIndex = 9;
            // 
            // cmbCursoNuevoEspecialidad
            // 
            this.cmbCursoNuevoEspecialidad.FormattingEnabled = true;
            this.cmbCursoNuevoEspecialidad.Location = new System.Drawing.Point(173, 173);
            this.cmbCursoNuevoEspecialidad.Name = "cmbCursoNuevoEspecialidad";
            this.cmbCursoNuevoEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCursoNuevoEspecialidad.TabIndex = 10;
            // 
            // lblCusoNuevoAnioError
            // 
            this.lblCusoNuevoAnioError.AutoSize = true;
            this.lblCusoNuevoAnioError.Location = new System.Drawing.Point(308, 57);
            this.lblCusoNuevoAnioError.Name = "lblCusoNuevoAnioError";
            this.lblCusoNuevoAnioError.Size = new System.Drawing.Size(0, 13);
            this.lblCusoNuevoAnioError.TabIndex = 11;
            // 
            // lblCursoNuevoDivisionError
            // 
            this.lblCursoNuevoDivisionError.AutoSize = true;
            this.lblCursoNuevoDivisionError.Location = new System.Drawing.Point(308, 97);
            this.lblCursoNuevoDivisionError.Name = "lblCursoNuevoDivisionError";
            this.lblCursoNuevoDivisionError.Size = new System.Drawing.Size(0, 13);
            this.lblCursoNuevoDivisionError.TabIndex = 12;
            // 
            // lblCursoNuevoMensaje
            // 
            this.lblCursoNuevoMensaje.AutoSize = true;
            this.lblCursoNuevoMensaje.Location = new System.Drawing.Point(39, 222);
            this.lblCursoNuevoMensaje.Name = "lblCursoNuevoMensaje";
            this.lblCursoNuevoMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblCursoNuevoMensaje.TabIndex = 13;
            // 
            // lblCursoNuevoTurnoError
            // 
            this.lblCursoNuevoTurnoError.AutoSize = true;
            this.lblCursoNuevoTurnoError.Location = new System.Drawing.Point(308, 137);
            this.lblCursoNuevoTurnoError.Name = "lblCursoNuevoTurnoError";
            this.lblCursoNuevoTurnoError.Size = new System.Drawing.Size(0, 13);
            this.lblCursoNuevoTurnoError.TabIndex = 14;
            // 
            // lblCursoNuevoEspecialidadError
            // 
            this.lblCursoNuevoEspecialidadError.AutoSize = true;
            this.lblCursoNuevoEspecialidadError.Location = new System.Drawing.Point(308, 181);
            this.lblCursoNuevoEspecialidadError.Name = "lblCursoNuevoEspecialidadError";
            this.lblCursoNuevoEspecialidadError.Size = new System.Drawing.Size(0, 13);
            this.lblCursoNuevoEspecialidadError.TabIndex = 15;
            // 
            // frmCursoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 308);
            this.Controls.Add(this.lblCursoNuevoEspecialidadError);
            this.Controls.Add(this.lblCursoNuevoTurnoError);
            this.Controls.Add(this.lblCursoNuevoMensaje);
            this.Controls.Add(this.lblCursoNuevoDivisionError);
            this.Controls.Add(this.lblCusoNuevoAnioError);
            this.Controls.Add(this.cmbCursoNuevoEspecialidad);
            this.Controls.Add(this.cmbCursoNuevoTurno);
            this.Controls.Add(this.lblCursoNuevoEspecialidad);
            this.Controls.Add(this.lblCursoNuevoTurno);
            this.Controls.Add(this.txtCursoNuevoDivision);
            this.Controls.Add(this.txtCursoNuevoAnio);
            this.Controls.Add(this.lblfrmCursoDivision);
            this.Controls.Add(this.lblfrmCurso);
            this.Controls.Add(this.btnfrmCursoAceptar);
            this.Controls.Add(this.btnfrmCursoCancelar);
            this.Controls.Add(this.btnfrmCursoLimpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCursoNuevo";
            this.Text = "CURSO NUEVO";
            this.Load += new System.EventHandler(this.frmCursoNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfrmCursoLimpiar;
        private System.Windows.Forms.Button btnfrmCursoCancelar;
        private System.Windows.Forms.Button btnfrmCursoAceptar;
        private System.Windows.Forms.Label lblfrmCurso;
        private System.Windows.Forms.Label lblfrmCursoDivision;
        private System.Windows.Forms.TextBox txtCursoNuevoAnio;
        private System.Windows.Forms.TextBox txtCursoNuevoDivision;
        private System.Windows.Forms.Label lblCursoNuevoTurno;
        private System.Windows.Forms.Label lblCursoNuevoEspecialidad;
        private System.Windows.Forms.ComboBox cmbCursoNuevoTurno;
        private System.Windows.Forms.ComboBox cmbCursoNuevoEspecialidad;
        private System.Windows.Forms.Label lblCusoNuevoAnioError;
        private System.Windows.Forms.Label lblCursoNuevoDivisionError;
        private System.Windows.Forms.Label lblCursoNuevoMensaje;
        private System.Windows.Forms.Label lblCursoNuevoTurnoError;
        private System.Windows.Forms.Label lblCursoNuevoEspecialidadError;
    }
}