namespace EstadisticasEscuelaFrontEnd.Asistencia
{
    partial class frmAsistenciaNuevo
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
            this.lblAsintenciaNuevoFecha = new System.Windows.Forms.Label();
            this.txtAsistenciaNuevoFecha = new System.Windows.Forms.TextBox();
            this.btnAsistenciaBuscarCancelar = new System.Windows.Forms.Button();
            this.btnAsistenciaBuscarAceptar = new System.Windows.Forms.Button();
            this.lblAsistenciaBuscarLimpiar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.rbtAsistenciaNuevoAusente = new System.Windows.Forms.RadioButton();
            this.rbtAsistenciaNuevoPresente = new System.Windows.Forms.RadioButton();
            this.lblAsistenicaNuevoError = new System.Windows.Forms.Label();
            this.lblAsistenciaNuevoFechaError = new System.Windows.Forms.Label();
            this.lblAsistenciaNuevoPresentismo = new System.Windows.Forms.Label();
            this.btnAsisntenciaNuevoBuscarCurso = new System.Windows.Forms.Button();
            this.btnAsistenciaNuevoBuscarAlumno = new System.Windows.Forms.Button();
            this.txtAsistneciaNuevoCurso = new System.Windows.Forms.TextBox();
            this.txtAsisnteciaNuevoAlumno = new System.Windows.Forms.TextBox();
            this.lblAsistenciaNuevoCurso = new System.Windows.Forms.Label();
            this.lblAsistenciaNuevoAlumno = new System.Windows.Forms.Label();
            this.lblAsistenicaNuevoGuardadoConExito = new System.Windows.Forms.Label();
            this.lblAsistenciaNuevoPresentismoError = new System.Windows.Forms.Label();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsintenciaNuevoFecha
            // 
            this.lblAsintenciaNuevoFecha.AutoSize = true;
            this.lblAsintenciaNuevoFecha.Location = new System.Drawing.Point(27, 72);
            this.lblAsintenciaNuevoFecha.Name = "lblAsintenciaNuevoFecha";
            this.lblAsintenciaNuevoFecha.Size = new System.Drawing.Size(37, 13);
            this.lblAsintenciaNuevoFecha.TabIndex = 1;
            this.lblAsintenciaNuevoFecha.Text = "Fecha";
            // 
            // txtAsistenciaNuevoFecha
            // 
            this.txtAsistenciaNuevoFecha.Location = new System.Drawing.Point(114, 69);
            this.txtAsistenciaNuevoFecha.Name = "txtAsistenciaNuevoFecha";
            this.txtAsistenciaNuevoFecha.Size = new System.Drawing.Size(100, 20);
            this.txtAsistenciaNuevoFecha.TabIndex = 3;
            // 
            // btnAsistenciaBuscarCancelar
            // 
            this.btnAsistenciaBuscarCancelar.Location = new System.Drawing.Point(405, 348);
            this.btnAsistenciaBuscarCancelar.Name = "btnAsistenciaBuscarCancelar";
            this.btnAsistenciaBuscarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarCancelar.TabIndex = 4;
            this.btnAsistenciaBuscarCancelar.Text = "Cancelar";
            this.btnAsistenciaBuscarCancelar.UseVisualStyleBackColor = true;
            this.btnAsistenciaBuscarCancelar.Click += new System.EventHandler(this.btnAsistenciaBuscarCancelar_Click);
            // 
            // btnAsistenciaBuscarAceptar
            // 
            this.btnAsistenciaBuscarAceptar.Location = new System.Drawing.Point(324, 348);
            this.btnAsistenciaBuscarAceptar.Name = "btnAsistenciaBuscarAceptar";
            this.btnAsistenciaBuscarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarAceptar.TabIndex = 5;
            this.btnAsistenciaBuscarAceptar.Text = "Aceptar";
            this.btnAsistenciaBuscarAceptar.UseVisualStyleBackColor = true;
            this.btnAsistenciaBuscarAceptar.Click += new System.EventHandler(this.btnAsistenciaBuscarAceptar_Click);
            // 
            // lblAsistenciaBuscarLimpiar
            // 
            this.lblAsistenciaBuscarLimpiar.Location = new System.Drawing.Point(12, 348);
            this.lblAsistenciaBuscarLimpiar.Name = "lblAsistenciaBuscarLimpiar";
            this.lblAsistenciaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.lblAsistenciaBuscarLimpiar.TabIndex = 6;
            this.lblAsistenciaBuscarLimpiar.Text = "Limpiar";
            this.lblAsistenciaBuscarLimpiar.UseVisualStyleBackColor = true;
            this.lblAsistenciaBuscarLimpiar.Click += new System.EventHandler(this.lblAsistenciaBuscarLimpiar_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.lblAsistenciaNuevoPresentismoError);
            this.Datos.Controls.Add(this.rbtAsistenciaNuevoAusente);
            this.Datos.Controls.Add(this.rbtAsistenciaNuevoPresente);
            this.Datos.Controls.Add(this.lblAsistenicaNuevoError);
            this.Datos.Controls.Add(this.lblAsistenciaNuevoFechaError);
            this.Datos.Controls.Add(this.lblAsistenciaNuevoPresentismo);
            this.Datos.Controls.Add(this.btnAsisntenciaNuevoBuscarCurso);
            this.Datos.Controls.Add(this.btnAsistenciaNuevoBuscarAlumno);
            this.Datos.Controls.Add(this.txtAsistneciaNuevoCurso);
            this.Datos.Controls.Add(this.txtAsisnteciaNuevoAlumno);
            this.Datos.Controls.Add(this.lblAsistenciaNuevoCurso);
            this.Datos.Controls.Add(this.lblAsistenciaNuevoAlumno);
            this.Datos.Controls.Add(this.lblAsintenciaNuevoFecha);
            this.Datos.Controls.Add(this.txtAsistenciaNuevoFecha);
            this.Datos.Location = new System.Drawing.Point(12, 31);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(468, 284);
            this.Datos.TabIndex = 7;
            this.Datos.TabStop = false;
            this.Datos.Tag = "Fecha";
            this.Datos.Text = "Datos";
            this.Datos.Enter += new System.EventHandler(this.Datos_Enter);
            // 
            // rbtAsistenciaNuevoAusente
            // 
            this.rbtAsistenciaNuevoAusente.AutoSize = true;
            this.rbtAsistenciaNuevoAusente.Location = new System.Drawing.Point(204, 106);
            this.rbtAsistenciaNuevoAusente.Name = "rbtAsistenciaNuevoAusente";
            this.rbtAsistenciaNuevoAusente.Size = new System.Drawing.Size(64, 17);
            this.rbtAsistenciaNuevoAusente.TabIndex = 18;
            this.rbtAsistenciaNuevoAusente.TabStop = true;
            this.rbtAsistenciaNuevoAusente.Text = "Ausente";
            this.rbtAsistenciaNuevoAusente.UseVisualStyleBackColor = true;
            this.rbtAsistenciaNuevoAusente.CheckedChanged += new System.EventHandler(this.rbtAsistenciaNuevoAusente_CheckedChanged);
            // 
            // rbtAsistenciaNuevoPresente
            // 
            this.rbtAsistenciaNuevoPresente.AutoSize = true;
            this.rbtAsistenciaNuevoPresente.Location = new System.Drawing.Point(112, 106);
            this.rbtAsistenciaNuevoPresente.Name = "rbtAsistenciaNuevoPresente";
            this.rbtAsistenciaNuevoPresente.Size = new System.Drawing.Size(67, 17);
            this.rbtAsistenciaNuevoPresente.TabIndex = 17;
            this.rbtAsistenciaNuevoPresente.TabStop = true;
            this.rbtAsistenciaNuevoPresente.Text = "Presente";
            this.rbtAsistenciaNuevoPresente.UseVisualStyleBackColor = true;
            this.rbtAsistenciaNuevoPresente.CheckedChanged += new System.EventHandler(this.rbtAsistenciaNuevoPresente_CheckedChanged);
            // 
            // lblAsistenicaNuevoError
            // 
            this.lblAsistenicaNuevoError.AutoSize = true;
            this.lblAsistenicaNuevoError.Location = new System.Drawing.Point(236, 110);
            this.lblAsistenicaNuevoError.Name = "lblAsistenicaNuevoError";
            this.lblAsistenicaNuevoError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenicaNuevoError.TabIndex = 16;
            // 
            // lblAsistenciaNuevoFechaError
            // 
            this.lblAsistenciaNuevoFechaError.AutoSize = true;
            this.lblAsistenciaNuevoFechaError.Location = new System.Drawing.Point(236, 72);
            this.lblAsistenciaNuevoFechaError.Name = "lblAsistenciaNuevoFechaError";
            this.lblAsistenciaNuevoFechaError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaNuevoFechaError.TabIndex = 15;
            // 
            // lblAsistenciaNuevoPresentismo
            // 
            this.lblAsistenciaNuevoPresentismo.AutoSize = true;
            this.lblAsistenciaNuevoPresentismo.Location = new System.Drawing.Point(27, 110);
            this.lblAsistenciaNuevoPresentismo.Name = "lblAsistenciaNuevoPresentismo";
            this.lblAsistenciaNuevoPresentismo.Size = new System.Drawing.Size(64, 13);
            this.lblAsistenciaNuevoPresentismo.TabIndex = 10;
            this.lblAsistenciaNuevoPresentismo.Text = "Presentismo";
            // 
            // btnAsisntenciaNuevoBuscarCurso
            // 
            this.btnAsisntenciaNuevoBuscarCurso.Location = new System.Drawing.Point(239, 187);
            this.btnAsisntenciaNuevoBuscarCurso.Name = "btnAsisntenciaNuevoBuscarCurso";
            this.btnAsisntenciaNuevoBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnAsisntenciaNuevoBuscarCurso.TabIndex = 9;
            this.btnAsisntenciaNuevoBuscarCurso.Text = "Buscar";
            this.btnAsisntenciaNuevoBuscarCurso.UseVisualStyleBackColor = true;
            this.btnAsisntenciaNuevoBuscarCurso.Click += new System.EventHandler(this.btnAsisntenciaNuevoBuscarCurso_Click);
            // 
            // btnAsistenciaNuevoBuscarAlumno
            // 
            this.btnAsistenciaNuevoBuscarAlumno.Location = new System.Drawing.Point(239, 150);
            this.btnAsistenciaNuevoBuscarAlumno.Name = "btnAsistenciaNuevoBuscarAlumno";
            this.btnAsistenciaNuevoBuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaNuevoBuscarAlumno.TabIndex = 8;
            this.btnAsistenciaNuevoBuscarAlumno.Text = "Buscar";
            this.btnAsistenciaNuevoBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnAsistenciaNuevoBuscarAlumno.Click += new System.EventHandler(this.btnAsistenciaNuevoBuscarAlumno_Click);
            // 
            // txtAsistneciaNuevoCurso
            // 
            this.txtAsistneciaNuevoCurso.Location = new System.Drawing.Point(112, 184);
            this.txtAsistneciaNuevoCurso.Name = "txtAsistneciaNuevoCurso";
            this.txtAsistneciaNuevoCurso.Size = new System.Drawing.Size(100, 20);
            this.txtAsistneciaNuevoCurso.TabIndex = 7;
            // 
            // txtAsisnteciaNuevoAlumno
            // 
            this.txtAsisnteciaNuevoAlumno.Location = new System.Drawing.Point(112, 147);
            this.txtAsisnteciaNuevoAlumno.Name = "txtAsisnteciaNuevoAlumno";
            this.txtAsisnteciaNuevoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtAsisnteciaNuevoAlumno.TabIndex = 6;
            // 
            // lblAsistenciaNuevoCurso
            // 
            this.lblAsistenciaNuevoCurso.AutoSize = true;
            this.lblAsistenciaNuevoCurso.Location = new System.Drawing.Point(28, 187);
            this.lblAsistenciaNuevoCurso.Name = "lblAsistenciaNuevoCurso";
            this.lblAsistenciaNuevoCurso.Size = new System.Drawing.Size(34, 13);
            this.lblAsistenciaNuevoCurso.TabIndex = 5;
            this.lblAsistenciaNuevoCurso.Text = "Curso";
            // 
            // lblAsistenciaNuevoAlumno
            // 
            this.lblAsistenciaNuevoAlumno.AutoSize = true;
            this.lblAsistenciaNuevoAlumno.Location = new System.Drawing.Point(27, 150);
            this.lblAsistenciaNuevoAlumno.Name = "lblAsistenciaNuevoAlumno";
            this.lblAsistenciaNuevoAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAsistenciaNuevoAlumno.TabIndex = 4;
            this.lblAsistenciaNuevoAlumno.Text = "Alumno";
            this.lblAsistenciaNuevoAlumno.Click += new System.EventHandler(this.lblAsistenciaNuevoAlumno_Click);
            // 
            // lblAsistenicaNuevoGuardadoConExito
            // 
            this.lblAsistenicaNuevoGuardadoConExito.AutoSize = true;
            this.lblAsistenicaNuevoGuardadoConExito.Location = new System.Drawing.Point(18, 318);
            this.lblAsistenicaNuevoGuardadoConExito.Name = "lblAsistenicaNuevoGuardadoConExito";
            this.lblAsistenicaNuevoGuardadoConExito.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenicaNuevoGuardadoConExito.TabIndex = 8;
            // 
            // lblAsistenciaNuevoPresentismoError
            // 
            this.lblAsistenciaNuevoPresentismoError.AutoSize = true;
            this.lblAsistenciaNuevoPresentismoError.Location = new System.Drawing.Point(275, 110);
            this.lblAsistenciaNuevoPresentismoError.Name = "lblAsistenciaNuevoPresentismoError";
            this.lblAsistenciaNuevoPresentismoError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaNuevoPresentismoError.TabIndex = 19;
            // 
            // frmAsistenciaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 383);
            this.Controls.Add(this.lblAsistenicaNuevoGuardadoConExito);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.lblAsistenciaBuscarLimpiar);
            this.Controls.Add(this.btnAsistenciaBuscarAceptar);
            this.Controls.Add(this.btnAsistenciaBuscarCancelar);
            this.Name = "frmAsistenciaNuevo";
            this.Text = "AsistenciaNuevo";
            this.Load += new System.EventHandler(this.frmAsistenciaNuevo_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsintenciaNuevoFecha;
        private System.Windows.Forms.TextBox txtAsistenciaNuevoFecha;
        private System.Windows.Forms.Button btnAsistenciaBuscarCancelar;
        private System.Windows.Forms.Button btnAsistenciaBuscarAceptar;
        private System.Windows.Forms.Button lblAsistenciaBuscarLimpiar;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Button btnAsisntenciaNuevoBuscarCurso;
        private System.Windows.Forms.Button btnAsistenciaNuevoBuscarAlumno;
        private System.Windows.Forms.TextBox txtAsistneciaNuevoCurso;
        private System.Windows.Forms.TextBox txtAsisnteciaNuevoAlumno;
        private System.Windows.Forms.Label lblAsistenciaNuevoCurso;
        private System.Windows.Forms.Label lblAsistenciaNuevoAlumno;
        private System.Windows.Forms.Label lblAsistenicaNuevoError;
        private System.Windows.Forms.Label lblAsistenciaNuevoFechaError;
        private System.Windows.Forms.Label lblAsistenciaNuevoPresentismo;
        private System.Windows.Forms.Label lblAsistenicaNuevoGuardadoConExito;
        private System.Windows.Forms.RadioButton rbtAsistenciaNuevoAusente;
        private System.Windows.Forms.RadioButton rbtAsistenciaNuevoPresente;
        private System.Windows.Forms.Label lblAsistenciaNuevoPresentismoError;
    }
}