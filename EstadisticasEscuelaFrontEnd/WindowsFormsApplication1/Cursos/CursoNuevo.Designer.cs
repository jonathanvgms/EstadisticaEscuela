namespace EstadisticasEscuelaFrontEnd.Cursos
{
    partial class CursoNuevo
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
            this.btnfrmCursoLimpiar = new System.Windows.Forms.Button();
            this.btnfrmCursoCancelar = new System.Windows.Forms.Button();
            this.btnfrmCursoAceptar = new System.Windows.Forms.Button();
            this.lblfrmCurso = new System.Windows.Forms.Label();
            this.lblfrmCursoDivision = new System.Windows.Forms.Label();
            this.txtfrmCursoAnio = new System.Windows.Forms.TextBox();
            this.txtfrmCursoDivision = new System.Windows.Forms.TextBox();
            this.lblfrmCursoTurno = new System.Windows.Forms.Label();
            this.lblfrmCursoEspecialidad = new System.Windows.Forms.Label();
            this.lblfrmCursoNuevoError = new System.Windows.Forms.Label();
            this.cmbfrmCursoTurno = new System.Windows.Forms.ComboBox();
            this.cmbfrmCursoEspecialidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnfrmCursoLimpiar
            // 
            this.btnfrmCursoLimpiar.Location = new System.Drawing.Point(13, 224);
            this.btnfrmCursoLimpiar.Name = "btnfrmCursoLimpiar";
            this.btnfrmCursoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmCursoLimpiar.TabIndex = 0;
            this.btnfrmCursoLimpiar.Text = "Limpiar";
            this.btnfrmCursoLimpiar.UseVisualStyleBackColor = true;
            this.btnfrmCursoLimpiar.Click += new System.EventHandler(this.btnfrmCursoLimpiar_Click);
            // 
            // btnfrmCursoCancelar
            // 
            this.btnfrmCursoCancelar.Location = new System.Drawing.Point(134, 224);
            this.btnfrmCursoCancelar.Name = "btnfrmCursoCancelar";
            this.btnfrmCursoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnfrmCursoCancelar.TabIndex = 1;
            this.btnfrmCursoCancelar.Text = "Cancelar";
            this.btnfrmCursoCancelar.UseVisualStyleBackColor = true;
            this.btnfrmCursoCancelar.Click += new System.EventHandler(this.btnfrmCursoCancelar_Click);
            // 
            // btnfrmCursoAceptar
            // 
            this.btnfrmCursoAceptar.Location = new System.Drawing.Point(253, 227);
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
            this.lblfrmCurso.Location = new System.Drawing.Point(24, 50);
            this.lblfrmCurso.Name = "lblfrmCurso";
            this.lblfrmCurso.Size = new System.Drawing.Size(28, 13);
            this.lblfrmCurso.TabIndex = 3;
            this.lblfrmCurso.Text = "Anio";
            // 
            // lblfrmCursoDivision
            // 
            this.lblfrmCursoDivision.AutoSize = true;
            this.lblfrmCursoDivision.Location = new System.Drawing.Point(24, 88);
            this.lblfrmCursoDivision.Name = "lblfrmCursoDivision";
            this.lblfrmCursoDivision.Size = new System.Drawing.Size(44, 13);
            this.lblfrmCursoDivision.TabIndex = 4;
            this.lblfrmCursoDivision.Text = "Division";
            // 
            // txtfrmCursoAnio
            // 
            this.txtfrmCursoAnio.Location = new System.Drawing.Point(194, 50);
            this.txtfrmCursoAnio.Name = "txtfrmCursoAnio";
            this.txtfrmCursoAnio.Size = new System.Drawing.Size(100, 20);
            this.txtfrmCursoAnio.TabIndex = 5;
            // 
            // txtfrmCursoDivision
            // 
            this.txtfrmCursoDivision.Location = new System.Drawing.Point(194, 81);
            this.txtfrmCursoDivision.Name = "txtfrmCursoDivision";
            this.txtfrmCursoDivision.Size = new System.Drawing.Size(100, 20);
            this.txtfrmCursoDivision.TabIndex = 6;
            // 
            // lblfrmCursoTurno
            // 
            this.lblfrmCursoTurno.AutoSize = true;
            this.lblfrmCursoTurno.Location = new System.Drawing.Point(24, 121);
            this.lblfrmCursoTurno.Name = "lblfrmCursoTurno";
            this.lblfrmCursoTurno.Size = new System.Drawing.Size(35, 13);
            this.lblfrmCursoTurno.TabIndex = 7;
            this.lblfrmCursoTurno.Text = "Turno";
            // 
            // lblfrmCursoEspecialidad
            // 
            this.lblfrmCursoEspecialidad.AutoSize = true;
            this.lblfrmCursoEspecialidad.Location = new System.Drawing.Point(24, 159);
            this.lblfrmCursoEspecialidad.Name = "lblfrmCursoEspecialidad";
            this.lblfrmCursoEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblfrmCursoEspecialidad.TabIndex = 8;
            this.lblfrmCursoEspecialidad.Text = "Especialidad";
            // 
            // lblfrmCursoNuevoError
            // 
            this.lblfrmCursoNuevoError.AutoSize = true;
            this.lblfrmCursoNuevoError.Location = new System.Drawing.Point(24, 188);
            this.lblfrmCursoNuevoError.Name = "lblfrmCursoNuevoError";
            this.lblfrmCursoNuevoError.Size = new System.Drawing.Size(0, 13);
            this.lblfrmCursoNuevoError.TabIndex = 11;
            // 
            // cmbfrmCursoTurno
            // 
            this.cmbfrmCursoTurno.FormattingEnabled = true;
            this.cmbfrmCursoTurno.Location = new System.Drawing.Point(194, 118);
            this.cmbfrmCursoTurno.Name = "cmbfrmCursoTurno";
            this.cmbfrmCursoTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbfrmCursoTurno.TabIndex = 12;
            // 
            // cmbfrmCursoEspecialidad
            // 
            this.cmbfrmCursoEspecialidad.FormattingEnabled = true;
            this.cmbfrmCursoEspecialidad.Location = new System.Drawing.Point(194, 156);
            this.cmbfrmCursoEspecialidad.Name = "cmbfrmCursoEspecialidad";
            this.cmbfrmCursoEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbfrmCursoEspecialidad.TabIndex = 13;
            // 
            // CursoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.cmbfrmCursoEspecialidad);
            this.Controls.Add(this.cmbfrmCursoTurno);
            this.Controls.Add(this.lblfrmCursoNuevoError);
            this.Controls.Add(this.lblfrmCursoEspecialidad);
            this.Controls.Add(this.lblfrmCursoTurno);
            this.Controls.Add(this.txtfrmCursoDivision);
            this.Controls.Add(this.txtfrmCursoAnio);
            this.Controls.Add(this.lblfrmCursoDivision);
            this.Controls.Add(this.lblfrmCurso);
            this.Controls.Add(this.btnfrmCursoAceptar);
            this.Controls.Add(this.btnfrmCursoCancelar);
            this.Controls.Add(this.btnfrmCursoLimpiar);
            this.Name = "CursoNuevo";
            this.Text = "frmCurso";
            this.Load += new System.EventHandler(this.CursoNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfrmCursoLimpiar;
        private System.Windows.Forms.Button btnfrmCursoCancelar;
        private System.Windows.Forms.Button btnfrmCursoAceptar;
        private System.Windows.Forms.Label lblfrmCurso;
        private System.Windows.Forms.Label lblfrmCursoDivision;
        private System.Windows.Forms.TextBox txtfrmCursoAnio;
        private System.Windows.Forms.TextBox txtfrmCursoDivision;
        private System.Windows.Forms.Label lblfrmCursoTurno;
        private System.Windows.Forms.Label lblfrmCursoEspecialidad;
        private System.Windows.Forms.Label lblfrmCursoNuevoError;
        private System.Windows.Forms.ComboBox cmbfrmCursoTurno;
        private System.Windows.Forms.ComboBox cmbfrmCursoEspecialidad;
    }
}