namespace EstadisticasEscuelaFrontEnd.Materias
{
    partial class frmMateriaNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaNuevo));
            this.btnMateriaNuevoCancelar = new System.Windows.Forms.Button();
            this.btnMateriaNuevoAceptar = new System.Windows.Forms.Button();
            this.btnMateriaBuscarLimpiar = new System.Windows.Forms.Button();
            this.lblMateriaNuevoMateria = new System.Windows.Forms.Label();
            this.txtMateriaNuevoMateria = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.lblMateriaNuevoVacio = new System.Windows.Forms.Label();
            this.lblMateriaNuevoError = new System.Windows.Forms.Label();
            this.lblMateriaNuevoTurno = new System.Windows.Forms.Label();
            this.lblMateriaNuevaEspecialidad = new System.Windows.Forms.Label();
            this.cmbMateriaNuevaTurno = new System.Windows.Forms.ComboBox();
            this.cmbMateriaNuevaEspecialidad = new System.Windows.Forms.ComboBox();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMateriaNuevoCancelar
            // 
            this.btnMateriaNuevoCancelar.Location = new System.Drawing.Point(392, 211);
            this.btnMateriaNuevoCancelar.Name = "btnMateriaNuevoCancelar";
            this.btnMateriaNuevoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaNuevoCancelar.TabIndex = 0;
            this.btnMateriaNuevoCancelar.Text = "Cancelar";
            this.btnMateriaNuevoCancelar.UseVisualStyleBackColor = true;
            this.btnMateriaNuevoCancelar.Click += new System.EventHandler(this.btnMateriaNuevoCancelar_Click);
            // 
            // btnMateriaNuevoAceptar
            // 
            this.btnMateriaNuevoAceptar.Location = new System.Drawing.Point(294, 211);
            this.btnMateriaNuevoAceptar.Name = "btnMateriaNuevoAceptar";
            this.btnMateriaNuevoAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaNuevoAceptar.TabIndex = 1;
            this.btnMateriaNuevoAceptar.Text = "Aceptar";
            this.btnMateriaNuevoAceptar.UseVisualStyleBackColor = true;
            this.btnMateriaNuevoAceptar.Click += new System.EventHandler(this.btnMateriaNuevoAceptar_Click);
            // 
            // btnMateriaBuscarLimpiar
            // 
            this.btnMateriaBuscarLimpiar.Location = new System.Drawing.Point(14, 211);
            this.btnMateriaBuscarLimpiar.Name = "btnMateriaBuscarLimpiar";
            this.btnMateriaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaBuscarLimpiar.TabIndex = 2;
            this.btnMateriaBuscarLimpiar.Text = "Limpiar";
            this.btnMateriaBuscarLimpiar.UseVisualStyleBackColor = true;
            this.btnMateriaBuscarLimpiar.Click += new System.EventHandler(this.btnMateriaBuscarLimpiar_Click);
            // 
            // lblMateriaNuevoMateria
            // 
            this.lblMateriaNuevoMateria.AutoSize = true;
            this.lblMateriaNuevoMateria.Location = new System.Drawing.Point(34, 33);
            this.lblMateriaNuevoMateria.Name = "lblMateriaNuevoMateria";
            this.lblMateriaNuevoMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaNuevoMateria.TabIndex = 3;
            this.lblMateriaNuevoMateria.Text = "Materia";
            // 
            // txtMateriaNuevoMateria
            // 
            this.txtMateriaNuevoMateria.Location = new System.Drawing.Point(133, 30);
            this.txtMateriaNuevoMateria.Name = "txtMateriaNuevoMateria";
            this.txtMateriaNuevoMateria.Size = new System.Drawing.Size(147, 20);
            this.txtMateriaNuevoMateria.TabIndex = 4;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.cmbMateriaNuevaEspecialidad);
            this.Datos.Controls.Add(this.cmbMateriaNuevaTurno);
            this.Datos.Controls.Add(this.lblMateriaNuevaEspecialidad);
            this.Datos.Controls.Add(this.lblMateriaNuevoTurno);
            this.Datos.Controls.Add(this.lblMateriaNuevoVacio);
            this.Datos.Controls.Add(this.lblMateriaNuevoMateria);
            this.Datos.Controls.Add(this.txtMateriaNuevoMateria);
            this.Datos.Location = new System.Drawing.Point(14, 12);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(448, 132);
            this.Datos.TabIndex = 5;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // lblMateriaNuevoVacio
            // 
            this.lblMateriaNuevoVacio.AutoSize = true;
            this.lblMateriaNuevoVacio.Location = new System.Drawing.Point(298, 37);
            this.lblMateriaNuevoVacio.Name = "lblMateriaNuevoVacio";
            this.lblMateriaNuevoVacio.Size = new System.Drawing.Size(0, 13);
            this.lblMateriaNuevoVacio.TabIndex = 5;
            // 
            // lblMateriaNuevoError
            // 
            this.lblMateriaNuevoError.AutoSize = true;
            this.lblMateriaNuevoError.Location = new System.Drawing.Point(48, 195);
            this.lblMateriaNuevoError.Name = "lblMateriaNuevoError";
            this.lblMateriaNuevoError.Size = new System.Drawing.Size(0, 13);
            this.lblMateriaNuevoError.TabIndex = 6;
            // 
            // lblMateriaNuevoTurno
            // 
            this.lblMateriaNuevoTurno.AutoSize = true;
            this.lblMateriaNuevoTurno.Location = new System.Drawing.Point(37, 68);
            this.lblMateriaNuevoTurno.Name = "lblMateriaNuevoTurno";
            this.lblMateriaNuevoTurno.Size = new System.Drawing.Size(35, 13);
            this.lblMateriaNuevoTurno.TabIndex = 6;
            this.lblMateriaNuevoTurno.Text = "Turno";
            // 
            // lblMateriaNuevaEspecialidad
            // 
            this.lblMateriaNuevaEspecialidad.AutoSize = true;
            this.lblMateriaNuevaEspecialidad.Location = new System.Drawing.Point(34, 104);
            this.lblMateriaNuevaEspecialidad.Name = "lblMateriaNuevaEspecialidad";
            this.lblMateriaNuevaEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblMateriaNuevaEspecialidad.TabIndex = 7;
            this.lblMateriaNuevaEspecialidad.Text = "Especialidad";
            // 
            // cmbMateriaNuevaTurno
            // 
            this.cmbMateriaNuevaTurno.FormattingEnabled = true;
            this.cmbMateriaNuevaTurno.Location = new System.Drawing.Point(133, 60);
            this.cmbMateriaNuevaTurno.Name = "cmbMateriaNuevaTurno";
            this.cmbMateriaNuevaTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbMateriaNuevaTurno.TabIndex = 8;
            // 
            // cmbMateriaNuevaEspecialidad
            // 
            this.cmbMateriaNuevaEspecialidad.FormattingEnabled = true;
            this.cmbMateriaNuevaEspecialidad.Location = new System.Drawing.Point(133, 96);
            this.cmbMateriaNuevaEspecialidad.Name = "cmbMateriaNuevaEspecialidad";
            this.cmbMateriaNuevaEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbMateriaNuevaEspecialidad.TabIndex = 9;
            // 
            // frmMateriaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 246);
            this.Controls.Add(this.lblMateriaNuevoError);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.btnMateriaBuscarLimpiar);
            this.Controls.Add(this.btnMateriaNuevoAceptar);
            this.Controls.Add(this.btnMateriaNuevoCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMateriaNuevo";
            this.Text = "Materia Nuevo";
            this.Load += new System.EventHandler(this.frmMateriaNuevo_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMateriaNuevoCancelar;
        private System.Windows.Forms.Button btnMateriaNuevoAceptar;
        private System.Windows.Forms.Button btnMateriaBuscarLimpiar;
        private System.Windows.Forms.Label lblMateriaNuevoMateria;
        private System.Windows.Forms.TextBox txtMateriaNuevoMateria;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label lblMateriaNuevoError;
        private System.Windows.Forms.Label lblMateriaNuevoVacio;
        private System.Windows.Forms.ComboBox cmbMateriaNuevaEspecialidad;
        private System.Windows.Forms.ComboBox cmbMateriaNuevaTurno;
        private System.Windows.Forms.Label lblMateriaNuevaEspecialidad;
        private System.Windows.Forms.Label lblMateriaNuevoTurno;
    }
}