namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    partial class AlumnoBuscar
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
            this.lblBuscarAlumnoNombre = new System.Windows.Forms.Label();
            this.lblBuscarAlumnoApellido = new System.Windows.Forms.Label();
            this.txtAlumnoBuscarNombre = new System.Windows.Forms.TextBox();
            this.txtAlumnoBuscarApellido = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumnoSalir = new System.Windows.Forms.Button();
            this.btnBuscarAlumnoBuscar = new System.Windows.Forms.Button();
            this.dgvAlumnoBuscar = new System.Windows.Forms.DataGridView();
            this.btnBuscarAlumnoLimpiar = new System.Windows.Forms.Button();
            this.lblAlumnoBuscarNombreError = new System.Windows.Forms.Label();
            this.lblAlumnoBuscarApellidoError = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbBuscarAlumnoEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbBuscarAlumnoTurno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarAlumnoNombre
            // 
            this.lblBuscarAlumnoNombre.AutoSize = true;
            this.lblBuscarAlumnoNombre.Location = new System.Drawing.Point(12, 15);
            this.lblBuscarAlumnoNombre.Name = "lblBuscarAlumnoNombre";
            this.lblBuscarAlumnoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarAlumnoNombre.TabIndex = 0;
            this.lblBuscarAlumnoNombre.Text = "Nombre";
            // 
            // lblBuscarAlumnoApellido
            // 
            this.lblBuscarAlumnoApellido.AutoSize = true;
            this.lblBuscarAlumnoApellido.Location = new System.Drawing.Point(12, 58);
            this.lblBuscarAlumnoApellido.Name = "lblBuscarAlumnoApellido";
            this.lblBuscarAlumnoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarAlumnoApellido.TabIndex = 1;
            this.lblBuscarAlumnoApellido.Text = "Apellido";
            // 
            // txtAlumnoBuscarNombre
            // 
            this.txtAlumnoBuscarNombre.Location = new System.Drawing.Point(89, 12);
            this.txtAlumnoBuscarNombre.Name = "txtAlumnoBuscarNombre";
            this.txtAlumnoBuscarNombre.Size = new System.Drawing.Size(212, 20);
            this.txtAlumnoBuscarNombre.TabIndex = 2;
            // 
            // txtAlumnoBuscarApellido
            // 
            this.txtAlumnoBuscarApellido.Location = new System.Drawing.Point(89, 51);
            this.txtAlumnoBuscarApellido.Name = "txtAlumnoBuscarApellido";
            this.txtAlumnoBuscarApellido.Size = new System.Drawing.Size(212, 20);
            this.txtAlumnoBuscarApellido.TabIndex = 3;
            // 
            // btnBuscarAlumnoSalir
            // 
            this.btnBuscarAlumnoSalir.Location = new System.Drawing.Point(856, 552);
            this.btnBuscarAlumnoSalir.Name = "btnBuscarAlumnoSalir";
            this.btnBuscarAlumnoSalir.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumnoSalir.TabIndex = 4;
            this.btnBuscarAlumnoSalir.Text = "Salir";
            this.btnBuscarAlumnoSalir.UseVisualStyleBackColor = true;
            this.btnBuscarAlumnoSalir.Click += new System.EventHandler(this.btnBuscarAlumnoSalir_Click);
            // 
            // btnBuscarAlumnoBuscar
            // 
            this.btnBuscarAlumnoBuscar.Location = new System.Drawing.Point(855, 53);
            this.btnBuscarAlumnoBuscar.Name = "btnBuscarAlumnoBuscar";
            this.btnBuscarAlumnoBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumnoBuscar.TabIndex = 5;
            this.btnBuscarAlumnoBuscar.Text = "Buscar";
            this.btnBuscarAlumnoBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarAlumnoBuscar.Click += new System.EventHandler(this.btnBuscarAlumnoBuscar_Click);
            // 
            // dgvAlumnoBuscar
            // 
            this.dgvAlumnoBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoBuscar.Location = new System.Drawing.Point(12, 93);
            this.dgvAlumnoBuscar.Name = "dgvAlumnoBuscar";
            this.dgvAlumnoBuscar.Size = new System.Drawing.Size(919, 442);
            this.dgvAlumnoBuscar.TabIndex = 6;
            // 
            // btnBuscarAlumnoLimpiar
            // 
            this.btnBuscarAlumnoLimpiar.Location = new System.Drawing.Point(12, 552);
            this.btnBuscarAlumnoLimpiar.Name = "btnBuscarAlumnoLimpiar";
            this.btnBuscarAlumnoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumnoLimpiar.TabIndex = 7;
            this.btnBuscarAlumnoLimpiar.Text = "Limpiar";
            this.btnBuscarAlumnoLimpiar.UseVisualStyleBackColor = true;
            this.btnBuscarAlumnoLimpiar.Click += new System.EventHandler(this.btnBuscarAlumnoLimpiar_Click);
            // 
            // lblAlumnoBuscarNombreError
            // 
            this.lblAlumnoBuscarNombreError.AutoSize = true;
            this.lblAlumnoBuscarNombreError.Location = new System.Drawing.Point(352, 19);
            this.lblAlumnoBuscarNombreError.Name = "lblAlumnoBuscarNombreError";
            this.lblAlumnoBuscarNombreError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoBuscarNombreError.TabIndex = 8;
            // 
            // lblAlumnoBuscarApellidoError
            // 
            this.lblAlumnoBuscarApellidoError.AutoSize = true;
            this.lblAlumnoBuscarApellidoError.Location = new System.Drawing.Point(352, 57);
            this.lblAlumnoBuscarApellidoError.Name = "lblAlumnoBuscarApellidoError";
            this.lblAlumnoBuscarApellidoError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoBuscarApellidoError.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(352, 58);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 17;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(352, 15);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 16;
            this.lblTurno.Text = "Turno";
            // 
            // cmbBuscarAlumnoEspecialidad
            // 
            this.cmbBuscarAlumnoEspecialidad.FormattingEnabled = true;
            this.cmbBuscarAlumnoEspecialidad.Location = new System.Drawing.Point(442, 52);
            this.cmbBuscarAlumnoEspecialidad.Name = "cmbBuscarAlumnoEspecialidad";
            this.cmbBuscarAlumnoEspecialidad.Size = new System.Drawing.Size(203, 21);
            this.cmbBuscarAlumnoEspecialidad.TabIndex = 15;
            // 
            // cmbBuscarAlumnoTurno
            // 
            this.cmbBuscarAlumnoTurno.FormattingEnabled = true;
            this.cmbBuscarAlumnoTurno.Location = new System.Drawing.Point(442, 11);
            this.cmbBuscarAlumnoTurno.Name = "cmbBuscarAlumnoTurno";
            this.cmbBuscarAlumnoTurno.Size = new System.Drawing.Size(203, 21);
            this.cmbBuscarAlumnoTurno.TabIndex = 14;
            // 
            // AlumnoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 587);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbBuscarAlumnoEspecialidad);
            this.Controls.Add(this.cmbBuscarAlumnoTurno);
            this.Controls.Add(this.lblAlumnoBuscarApellidoError);
            this.Controls.Add(this.lblAlumnoBuscarNombreError);
            this.Controls.Add(this.btnBuscarAlumnoLimpiar);
            this.Controls.Add(this.dgvAlumnoBuscar);
            this.Controls.Add(this.btnBuscarAlumnoBuscar);
            this.Controls.Add(this.btnBuscarAlumnoSalir);
            this.Controls.Add(this.txtAlumnoBuscarApellido);
            this.Controls.Add(this.txtAlumnoBuscarNombre);
            this.Controls.Add(this.lblBuscarAlumnoApellido);
            this.Controls.Add(this.lblBuscarAlumnoNombre);
            this.Name = "AlumnoBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR ALUMNO";
            this.Load += new System.EventHandler(this.AlumnoBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarAlumnoNombre;
        private System.Windows.Forms.Label lblBuscarAlumnoApellido;
        private System.Windows.Forms.TextBox txtAlumnoBuscarNombre;
        private System.Windows.Forms.TextBox txtAlumnoBuscarApellido;
        private System.Windows.Forms.Button btnBuscarAlumnoSalir;
        private System.Windows.Forms.Button btnBuscarAlumnoBuscar;
        private System.Windows.Forms.DataGridView dgvAlumnoBuscar;
        private System.Windows.Forms.Button btnBuscarAlumnoLimpiar;
        private System.Windows.Forms.Label lblAlumnoBuscarNombreError;
        private System.Windows.Forms.Label lblAlumnoBuscarApellidoError;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbBuscarAlumnoEspecialidad;
        private System.Windows.Forms.ComboBox cmbBuscarAlumnoTurno;
    }
}