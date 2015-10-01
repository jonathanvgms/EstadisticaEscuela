namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    partial class frmAlumnoBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnoBuscar));
            this.lblBuscarAlumnoNombre = new System.Windows.Forms.Label();
            this.lblBuscarAlumnoApellido = new System.Windows.Forms.Label();
            this.txtAlumnoBuscarNombre = new System.Windows.Forms.TextBox();
            this.txtAlumnoBuscarApellido = new System.Windows.Forms.TextBox();
            this.btnAlumnoBuscarSalir = new System.Windows.Forms.Button();
            this.btnAlumnoBuscarBuscar = new System.Windows.Forms.Button();
            this.dgvAlumnoBuscar = new System.Windows.Forms.DataGridView();
            this.btnBuscarAlumnoLimpiar = new System.Windows.Forms.Button();
            this.lblAlumnoBuscarNombreError = new System.Windows.Forms.Label();
            this.lblAlumnoBuscarApellidoError = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlumnoBuscarLegajo = new System.Windows.Forms.TextBox();
            this.txtAlumnoBuscarDni = new System.Windows.Forms.TextBox();
            this.lblBuscarAlumnoError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoBuscar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarAlumnoNombre
            // 
            this.lblBuscarAlumnoNombre.AutoSize = true;
            this.lblBuscarAlumnoNombre.Location = new System.Drawing.Point(37, 29);
            this.lblBuscarAlumnoNombre.Name = "lblBuscarAlumnoNombre";
            this.lblBuscarAlumnoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarAlumnoNombre.TabIndex = 0;
            this.lblBuscarAlumnoNombre.Text = "Nombre";
            // 
            // lblBuscarAlumnoApellido
            // 
            this.lblBuscarAlumnoApellido.AutoSize = true;
            this.lblBuscarAlumnoApellido.Location = new System.Drawing.Point(37, 72);
            this.lblBuscarAlumnoApellido.Name = "lblBuscarAlumnoApellido";
            this.lblBuscarAlumnoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarAlumnoApellido.TabIndex = 1;
            this.lblBuscarAlumnoApellido.Text = "Apellido";
            // 
            // txtAlumnoBuscarNombre
            // 
            this.txtAlumnoBuscarNombre.Location = new System.Drawing.Point(114, 26);
            this.txtAlumnoBuscarNombre.Name = "txtAlumnoBuscarNombre";
            this.txtAlumnoBuscarNombre.Size = new System.Drawing.Size(212, 20);
            this.txtAlumnoBuscarNombre.TabIndex = 2;
            // 
            // txtAlumnoBuscarApellido
            // 
            this.txtAlumnoBuscarApellido.Location = new System.Drawing.Point(114, 65);
            this.txtAlumnoBuscarApellido.Name = "txtAlumnoBuscarApellido";
            this.txtAlumnoBuscarApellido.Size = new System.Drawing.Size(212, 20);
            this.txtAlumnoBuscarApellido.TabIndex = 3;
            // 
            // btnAlumnoBuscarSalir
            // 
            this.btnAlumnoBuscarSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlumnoBuscarSalir.Location = new System.Drawing.Point(643, 590);
            this.btnAlumnoBuscarSalir.Name = "btnAlumnoBuscarSalir";
            this.btnAlumnoBuscarSalir.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnoBuscarSalir.TabIndex = 4;
            this.btnAlumnoBuscarSalir.Text = "Salir";
            this.btnAlumnoBuscarSalir.UseVisualStyleBackColor = true;
            this.btnAlumnoBuscarSalir.Click += new System.EventHandler(this.btnBuscarAlumnoSalir_Click);
            // 
            // btnAlumnoBuscarBuscar
            // 
            this.btnAlumnoBuscarBuscar.Location = new System.Drawing.Point(643, 128);
            this.btnAlumnoBuscarBuscar.Name = "btnAlumnoBuscarBuscar";
            this.btnAlumnoBuscarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnoBuscarBuscar.TabIndex = 5;
            this.btnAlumnoBuscarBuscar.Text = "Buscar";
            this.btnAlumnoBuscarBuscar.UseVisualStyleBackColor = true;
            this.btnAlumnoBuscarBuscar.Click += new System.EventHandler(this.btnBuscarAlumnoBuscar_Click);
            // 
            // dgvAlumnoBuscar
            // 
            this.dgvAlumnoBuscar.AllowUserToAddRows = false;
            this.dgvAlumnoBuscar.AllowUserToDeleteRows = false;
            this.dgvAlumnoBuscar.AllowUserToResizeColumns = false;
            this.dgvAlumnoBuscar.AllowUserToResizeRows = false;
            this.dgvAlumnoBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlumnoBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAlumnoBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoBuscar.Location = new System.Drawing.Point(12, 157);
            this.dgvAlumnoBuscar.MultiSelect = false;
            this.dgvAlumnoBuscar.Name = "dgvAlumnoBuscar";
            this.dgvAlumnoBuscar.ReadOnly = true;
            this.dgvAlumnoBuscar.RowHeadersVisible = false;
            this.dgvAlumnoBuscar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAlumnoBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAlumnoBuscar.Size = new System.Drawing.Size(706, 427);
            this.dgvAlumnoBuscar.TabIndex = 6;
            this.dgvAlumnoBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionAlumno);
            // 
            // btnBuscarAlumnoLimpiar
            // 
            this.btnBuscarAlumnoLimpiar.Location = new System.Drawing.Point(12, 128);
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
            this.lblAlumnoBuscarNombreError.Location = new System.Drawing.Point(377, 33);
            this.lblAlumnoBuscarNombreError.Name = "lblAlumnoBuscarNombreError";
            this.lblAlumnoBuscarNombreError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoBuscarNombreError.TabIndex = 8;
            // 
            // lblAlumnoBuscarApellidoError
            // 
            this.lblAlumnoBuscarApellidoError.AutoSize = true;
            this.lblAlumnoBuscarApellidoError.Location = new System.Drawing.Point(377, 71);
            this.lblAlumnoBuscarApellidoError.Name = "lblAlumnoBuscarApellidoError";
            this.lblAlumnoBuscarApellidoError.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnoBuscarApellidoError.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(365, 68);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(39, 13);
            this.lblEspecialidad.TabIndex = 17;
            this.lblEspecialidad.Text = "Legajo";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(365, 29);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(26, 13);
            this.lblTurno.TabIndex = 16;
            this.lblTurno.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlumnoBuscarLegajo);
            this.groupBox1.Controls.Add(this.txtAlumnoBuscarDni);
            this.groupBox1.Controls.Add(this.lblBuscarAlumnoNombre);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Controls.Add(this.lblBuscarAlumnoApellido);
            this.groupBox1.Controls.Add(this.lblTurno);
            this.groupBox1.Controls.Add(this.txtAlumnoBuscarNombre);
            this.groupBox1.Controls.Add(this.txtAlumnoBuscarApellido);
            this.groupBox1.Controls.Add(this.lblAlumnoBuscarNombreError);
            this.groupBox1.Controls.Add(this.lblAlumnoBuscarApellidoError);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 110);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busqueda";
            // 
            // txtAlumnoBuscarLegajo
            // 
            this.txtAlumnoBuscarLegajo.Location = new System.Drawing.Point(453, 64);
            this.txtAlumnoBuscarLegajo.Name = "txtAlumnoBuscarLegajo";
            this.txtAlumnoBuscarLegajo.Size = new System.Drawing.Size(212, 20);
            this.txtAlumnoBuscarLegajo.TabIndex = 19;
            // 
            // txtAlumnoBuscarDni
            // 
            this.txtAlumnoBuscarDni.Location = new System.Drawing.Point(453, 26);
            this.txtAlumnoBuscarDni.Name = "txtAlumnoBuscarDni";
            this.txtAlumnoBuscarDni.Size = new System.Drawing.Size(212, 20);
            this.txtAlumnoBuscarDni.TabIndex = 18;
            // 
            // lblBuscarAlumnoError
            // 
            this.lblBuscarAlumnoError.AutoSize = true;
            this.lblBuscarAlumnoError.Location = new System.Drawing.Point(9, 610);
            this.lblBuscarAlumnoError.Name = "lblBuscarAlumnoError";
            this.lblBuscarAlumnoError.Size = new System.Drawing.Size(0, 13);
            this.lblBuscarAlumnoError.TabIndex = 19;
            // 
            // frmAlumnoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAlumnoBuscarSalir;
            this.ClientSize = new System.Drawing.Size(727, 620);
            this.Controls.Add(this.lblBuscarAlumnoError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarAlumnoLimpiar);
            this.Controls.Add(this.dgvAlumnoBuscar);
            this.Controls.Add(this.btnAlumnoBuscarBuscar);
            this.Controls.Add(this.btnAlumnoBuscarSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumnoBuscar";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoBuscar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarAlumnoNombre;
        private System.Windows.Forms.Label lblBuscarAlumnoApellido;
        private System.Windows.Forms.TextBox txtAlumnoBuscarNombre;
        private System.Windows.Forms.TextBox txtAlumnoBuscarApellido;
        private System.Windows.Forms.Button btnAlumnoBuscarSalir;
        private System.Windows.Forms.Button btnAlumnoBuscarBuscar;
        private System.Windows.Forms.DataGridView dgvAlumnoBuscar;
        private System.Windows.Forms.Button btnBuscarAlumnoLimpiar;
        private System.Windows.Forms.Label lblAlumnoBuscarNombreError;
        private System.Windows.Forms.Label lblAlumnoBuscarApellidoError;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBuscarAlumnoError;
        private System.Windows.Forms.TextBox txtAlumnoBuscarLegajo;
        private System.Windows.Forms.TextBox txtAlumnoBuscarDni;
    }
}