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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblAsistenciaNuevoPresentismoError = new System.Windows.Forms.Label();
            this.rbtAsistenciaNuevoAusente = new System.Windows.Forms.RadioButton();
            this.rbtAsistenciaNuevoPresente = new System.Windows.Forms.RadioButton();
            this.lblAsistenicaNuevoError = new System.Windows.Forms.Label();
            this.lblAsistenciaNuevoFechaError = new System.Windows.Forms.Label();
            this.lblAsistenciaNuevoPresentismo = new System.Windows.Forms.Label();
            this.lblAsistenicaNuevoGuardadoConExito = new System.Windows.Forms.Label();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsintenciaNuevoFecha
            // 
            this.lblAsintenciaNuevoFecha.AutoSize = true;
            this.lblAsintenciaNuevoFecha.Location = new System.Drawing.Point(21, 57);
            this.lblAsintenciaNuevoFecha.Name = "lblAsintenciaNuevoFecha";
            this.lblAsintenciaNuevoFecha.Size = new System.Drawing.Size(37, 13);
            this.lblAsintenciaNuevoFecha.TabIndex = 1;
            this.lblAsintenciaNuevoFecha.Text = "Fecha";
            // 
            // txtAsistenciaNuevoFecha
            // 
            this.txtAsistenciaNuevoFecha.Location = new System.Drawing.Point(106, 54);
            this.txtAsistenciaNuevoFecha.Name = "txtAsistenciaNuevoFecha";
            this.txtAsistenciaNuevoFecha.ReadOnly = true;
            this.txtAsistenciaNuevoFecha.Size = new System.Drawing.Size(210, 20);
            this.txtAsistenciaNuevoFecha.TabIndex = 3;
            // 
            // btnAsistenciaBuscarCancelar
            // 
            this.btnAsistenciaBuscarCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAsistenciaBuscarCancelar.Location = new System.Drawing.Point(507, 350);
            this.btnAsistenciaBuscarCancelar.Name = "btnAsistenciaBuscarCancelar";
            this.btnAsistenciaBuscarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarCancelar.TabIndex = 4;
            this.btnAsistenciaBuscarCancelar.Text = "Cancelar";
            this.btnAsistenciaBuscarCancelar.UseVisualStyleBackColor = true;
            this.btnAsistenciaBuscarCancelar.Click += new System.EventHandler(this.btnAsistenciaBuscarCancelar_Click);
            // 
            // btnAsistenciaBuscarAceptar
            // 
            this.btnAsistenciaBuscarAceptar.Location = new System.Drawing.Point(426, 350);
            this.btnAsistenciaBuscarAceptar.Name = "btnAsistenciaBuscarAceptar";
            this.btnAsistenciaBuscarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarAceptar.TabIndex = 5;
            this.btnAsistenciaBuscarAceptar.Text = "Aceptar";
            this.btnAsistenciaBuscarAceptar.UseVisualStyleBackColor = true;
            this.btnAsistenciaBuscarAceptar.Click += new System.EventHandler(this.btnAsistenciaBuscarAceptar_Click);
            // 
            // lblAsistenciaBuscarLimpiar
            // 
            this.lblAsistenciaBuscarLimpiar.Location = new System.Drawing.Point(3, 350);
            this.lblAsistenciaBuscarLimpiar.Name = "lblAsistenciaBuscarLimpiar";
            this.lblAsistenciaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.lblAsistenciaBuscarLimpiar.TabIndex = 6;
            this.lblAsistenciaBuscarLimpiar.Text = "Limpiar";
            this.lblAsistenciaBuscarLimpiar.UseVisualStyleBackColor = true;
            this.lblAsistenciaBuscarLimpiar.Click += new System.EventHandler(this.lblAsistenciaBuscarLimpiar_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.monthCalendar1);
            this.Datos.Controls.Add(this.lblAsistenciaNuevoPresentismoError);
            this.Datos.Controls.Add(this.rbtAsistenciaNuevoAusente);
            this.Datos.Controls.Add(this.rbtAsistenciaNuevoPresente);
            this.Datos.Controls.Add(this.lblAsistenicaNuevoError);
            this.Datos.Controls.Add(this.lblAsistenciaNuevoFechaError);
            this.Datos.Controls.Add(this.lblAsistenciaNuevoPresentismo);
            this.Datos.Controls.Add(this.lblAsintenciaNuevoFecha);
            this.Datos.Controls.Add(this.txtAsistenciaNuevoFecha);
            this.Datos.Location = new System.Drawing.Point(3, 12);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(579, 332);
            this.Datos.TabIndex = 7;
            this.Datos.TabStop = false;
            this.Datos.Tag = "Fecha";
            this.Datos.Text = "Datos";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(338, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            // 
            // lblAsistenciaNuevoPresentismoError
            // 
            this.lblAsistenciaNuevoPresentismoError.AutoSize = true;
            this.lblAsistenciaNuevoPresentismoError.Location = new System.Drawing.Point(269, 76);
            this.lblAsistenciaNuevoPresentismoError.Name = "lblAsistenciaNuevoPresentismoError";
            this.lblAsistenciaNuevoPresentismoError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaNuevoPresentismoError.TabIndex = 19;
            // 
            // rbtAsistenciaNuevoAusente
            // 
            this.rbtAsistenciaNuevoAusente.AutoSize = true;
            this.rbtAsistenciaNuevoAusente.Location = new System.Drawing.Point(106, 145);
            this.rbtAsistenciaNuevoAusente.Name = "rbtAsistenciaNuevoAusente";
            this.rbtAsistenciaNuevoAusente.Size = new System.Drawing.Size(64, 17);
            this.rbtAsistenciaNuevoAusente.TabIndex = 18;
            this.rbtAsistenciaNuevoAusente.TabStop = true;
            this.rbtAsistenciaNuevoAusente.Text = "Ausente";
            this.rbtAsistenciaNuevoAusente.UseVisualStyleBackColor = true;
            // 
            // rbtAsistenciaNuevoPresente
            // 
            this.rbtAsistenciaNuevoPresente.AutoSize = true;
            this.rbtAsistenciaNuevoPresente.Location = new System.Drawing.Point(106, 115);
            this.rbtAsistenciaNuevoPresente.Name = "rbtAsistenciaNuevoPresente";
            this.rbtAsistenciaNuevoPresente.Size = new System.Drawing.Size(67, 17);
            this.rbtAsistenciaNuevoPresente.TabIndex = 17;
            this.rbtAsistenciaNuevoPresente.TabStop = true;
            this.rbtAsistenciaNuevoPresente.Text = "Presente";
            this.rbtAsistenciaNuevoPresente.UseVisualStyleBackColor = true;
            // 
            // lblAsistenicaNuevoError
            // 
            this.lblAsistenicaNuevoError.AutoSize = true;
            this.lblAsistenicaNuevoError.Location = new System.Drawing.Point(230, 76);
            this.lblAsistenicaNuevoError.Name = "lblAsistenicaNuevoError";
            this.lblAsistenicaNuevoError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenicaNuevoError.TabIndex = 16;
            // 
            // lblAsistenciaNuevoFechaError
            // 
            this.lblAsistenciaNuevoFechaError.AutoSize = true;
            this.lblAsistenciaNuevoFechaError.Location = new System.Drawing.Point(230, 38);
            this.lblAsistenciaNuevoFechaError.Name = "lblAsistenciaNuevoFechaError";
            this.lblAsistenciaNuevoFechaError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaNuevoFechaError.TabIndex = 15;
            // 
            // lblAsistenciaNuevoPresentismo
            // 
            this.lblAsistenciaNuevoPresentismo.AutoSize = true;
            this.lblAsistenciaNuevoPresentismo.Location = new System.Drawing.Point(21, 119);
            this.lblAsistenciaNuevoPresentismo.Name = "lblAsistenciaNuevoPresentismo";
            this.lblAsistenciaNuevoPresentismo.Size = new System.Drawing.Size(64, 13);
            this.lblAsistenciaNuevoPresentismo.TabIndex = 10;
            this.lblAsistenciaNuevoPresentismo.Text = "Presentismo";
            // 
            // lblAsistenicaNuevoGuardadoConExito
            // 
            this.lblAsistenicaNuevoGuardadoConExito.AutoSize = true;
            this.lblAsistenicaNuevoGuardadoConExito.Location = new System.Drawing.Point(18, 318);
            this.lblAsistenicaNuevoGuardadoConExito.Name = "lblAsistenicaNuevoGuardadoConExito";
            this.lblAsistenicaNuevoGuardadoConExito.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenicaNuevoGuardadoConExito.TabIndex = 8;
            // 
            // frmAsistenciaNuevo
            // 
            this.AcceptButton = this.btnAsistenciaBuscarAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAsistenciaBuscarCancelar;
            this.ClientSize = new System.Drawing.Size(588, 380);
            this.Controls.Add(this.lblAsistenicaNuevoGuardadoConExito);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.lblAsistenciaBuscarLimpiar);
            this.Controls.Add(this.btnAsistenciaBuscarAceptar);
            this.Controls.Add(this.btnAsistenciaBuscarCancelar);
            this.Name = "frmAsistenciaNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asistencia Nuevo";
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
        private System.Windows.Forms.Label lblAsistenicaNuevoError;
        private System.Windows.Forms.Label lblAsistenciaNuevoFechaError;
        private System.Windows.Forms.Label lblAsistenciaNuevoPresentismo;
        private System.Windows.Forms.Label lblAsistenicaNuevoGuardadoConExito;
        private System.Windows.Forms.RadioButton rbtAsistenciaNuevoAusente;
        private System.Windows.Forms.RadioButton rbtAsistenciaNuevoPresente;
        private System.Windows.Forms.Label lblAsistenciaNuevoPresentismoError;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}