namespace EstadisticasEscuelaFrontEnd.Cursos
{
    partial class frmBuscarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCurso));
            this.btnBuscarCursoLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarCursoSalir = new System.Windows.Forms.Button();
            this.lblBuscarCursoAnio = new System.Windows.Forms.Label();
            this.lblBuscarCursoDivision = new System.Windows.Forms.Label();
            this.txtCursoBuscarAnio = new System.Windows.Forms.TextBox();
            this.txtCursoBuscarDivision = new System.Windows.Forms.TextBox();
            this.btnBuscarCursoBuscar = new System.Windows.Forms.Button();
            this.dgvCursoBuscar = new System.Windows.Forms.DataGridView();
            this.lblBuscarCursoAnioError = new System.Windows.Forms.Label();
            this.lblBuscarCursoDivisionError = new System.Windows.Forms.Label();
            this.cmbBuscarCursoTurno = new System.Windows.Forms.ComboBox();
            this.cmbBuscarCursoEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblCursoBuscarError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursoBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCursoLimpiar
            // 
            this.btnBuscarCursoLimpiar.Location = new System.Drawing.Point(12, 555);
            this.btnBuscarCursoLimpiar.Name = "btnBuscarCursoLimpiar";
            this.btnBuscarCursoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCursoLimpiar.TabIndex = 0;
            this.btnBuscarCursoLimpiar.Text = "Limpiar";
            this.btnBuscarCursoLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCursoSalir
            // 
            this.btnBuscarCursoSalir.Location = new System.Drawing.Point(704, 555);
            this.btnBuscarCursoSalir.Name = "btnBuscarCursoSalir";
            this.btnBuscarCursoSalir.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCursoSalir.TabIndex = 1;
            this.btnBuscarCursoSalir.Text = "Salir";
            this.btnBuscarCursoSalir.UseVisualStyleBackColor = true;
            this.btnBuscarCursoSalir.Click += new System.EventHandler(this.btnBuscarCursoSalir_Click);
            // 
            // lblBuscarCursoAnio
            // 
            this.lblBuscarCursoAnio.AutoSize = true;
            this.lblBuscarCursoAnio.Location = new System.Drawing.Point(12, 15);
            this.lblBuscarCursoAnio.Name = "lblBuscarCursoAnio";
            this.lblBuscarCursoAnio.Size = new System.Drawing.Size(26, 13);
            this.lblBuscarCursoAnio.TabIndex = 2;
            this.lblBuscarCursoAnio.Text = "Año";
            // 
            // lblBuscarCursoDivision
            // 
            this.lblBuscarCursoDivision.AutoSize = true;
            this.lblBuscarCursoDivision.Location = new System.Drawing.Point(12, 55);
            this.lblBuscarCursoDivision.Name = "lblBuscarCursoDivision";
            this.lblBuscarCursoDivision.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarCursoDivision.TabIndex = 3;
            this.lblBuscarCursoDivision.Text = "Division";
            // 
            // txtCursoBuscarAnio
            // 
            this.txtCursoBuscarAnio.Location = new System.Drawing.Point(85, 12);
            this.txtCursoBuscarAnio.Name = "txtCursoBuscarAnio";
            this.txtCursoBuscarAnio.Size = new System.Drawing.Size(203, 20);
            this.txtCursoBuscarAnio.TabIndex = 4;
            // 
            // txtCursoBuscarDivision
            // 
            this.txtCursoBuscarDivision.Location = new System.Drawing.Point(85, 52);
            this.txtCursoBuscarDivision.Name = "txtCursoBuscarDivision";
            this.txtCursoBuscarDivision.Size = new System.Drawing.Size(203, 20);
            this.txtCursoBuscarDivision.TabIndex = 5;
            // 
            // btnBuscarCursoBuscar
            // 
            this.btnBuscarCursoBuscar.Location = new System.Drawing.Point(704, 50);
            this.btnBuscarCursoBuscar.Name = "btnBuscarCursoBuscar";
            this.btnBuscarCursoBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCursoBuscar.TabIndex = 6;
            this.btnBuscarCursoBuscar.Text = "Buscar";
            this.btnBuscarCursoBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarCursoBuscar.Click += new System.EventHandler(this.btnBuscarCursoBuscar_Click);
            // 
            // dgvCursoBuscar
            // 
            this.dgvCursoBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursoBuscar.Location = new System.Drawing.Point(12, 89);
            this.dgvCursoBuscar.Name = "dgvCursoBuscar";
            this.dgvCursoBuscar.Size = new System.Drawing.Size(767, 441);
            this.dgvCursoBuscar.TabIndex = 7;
            this.dgvCursoBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionCurso);
            // 
            // lblBuscarCursoAnioError
            // 
            this.lblBuscarCursoAnioError.AutoSize = true;
            this.lblBuscarCursoAnioError.Location = new System.Drawing.Point(329, 9);
            this.lblBuscarCursoAnioError.Name = "lblBuscarCursoAnioError";
            this.lblBuscarCursoAnioError.Size = new System.Drawing.Size(0, 13);
            this.lblBuscarCursoAnioError.TabIndex = 8;
            // 
            // lblBuscarCursoDivisionError
            // 
            this.lblBuscarCursoDivisionError.AutoSize = true;
            this.lblBuscarCursoDivisionError.Location = new System.Drawing.Point(329, 55);
            this.lblBuscarCursoDivisionError.Name = "lblBuscarCursoDivisionError";
            this.lblBuscarCursoDivisionError.Size = new System.Drawing.Size(0, 13);
            this.lblBuscarCursoDivisionError.TabIndex = 9;
            // 
            // cmbBuscarCursoTurno
            // 
            this.cmbBuscarCursoTurno.FormattingEnabled = true;
            this.cmbBuscarCursoTurno.Location = new System.Drawing.Point(443, 11);
            this.cmbBuscarCursoTurno.Name = "cmbBuscarCursoTurno";
            this.cmbBuscarCursoTurno.Size = new System.Drawing.Size(203, 21);
            this.cmbBuscarCursoTurno.TabIndex = 10;
            // 
            // cmbBuscarCursoEspecialidad
            // 
            this.cmbBuscarCursoEspecialidad.FormattingEnabled = true;
            this.cmbBuscarCursoEspecialidad.Location = new System.Drawing.Point(443, 52);
            this.cmbBuscarCursoEspecialidad.Name = "cmbBuscarCursoEspecialidad";
            this.cmbBuscarCursoEspecialidad.Size = new System.Drawing.Size(203, 21);
            this.cmbBuscarCursoEspecialidad.TabIndex = 11;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(353, 15);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 12;
            this.lblTurno.Text = "Turno";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(353, 55);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 13;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblCursoBuscarError
            // 
            this.lblCursoBuscarError.AutoSize = true;
            this.lblCursoBuscarError.Location = new System.Drawing.Point(12, 536);
            this.lblCursoBuscarError.Name = "lblCursoBuscarError";
            this.lblCursoBuscarError.Size = new System.Drawing.Size(0, 13);
            this.lblCursoBuscarError.TabIndex = 14;
            // 
            // frmBuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 590);
            this.Controls.Add(this.lblCursoBuscarError);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbBuscarCursoEspecialidad);
            this.Controls.Add(this.cmbBuscarCursoTurno);
            this.Controls.Add(this.lblBuscarCursoDivisionError);
            this.Controls.Add(this.lblBuscarCursoAnioError);
            this.Controls.Add(this.dgvCursoBuscar);
            this.Controls.Add(this.btnBuscarCursoBuscar);
            this.Controls.Add(this.txtCursoBuscarDivision);
            this.Controls.Add(this.txtCursoBuscarAnio);
            this.Controls.Add(this.lblBuscarCursoDivision);
            this.Controls.Add(this.lblBuscarCursoAnio);
            this.Controls.Add(this.btnBuscarCursoSalir);
            this.Controls.Add(this.btnBuscarCursoLimpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR CURSO";
            this.Load += new System.EventHandler(this.frmBuscarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursoBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCursoLimpiar;
        private System.Windows.Forms.Button btnBuscarCursoSalir;
        private System.Windows.Forms.Label lblBuscarCursoAnio;
        private System.Windows.Forms.Label lblBuscarCursoDivision;
        private System.Windows.Forms.TextBox txtCursoBuscarAnio;
        private System.Windows.Forms.TextBox txtCursoBuscarDivision;
        private System.Windows.Forms.Button btnBuscarCursoBuscar;
        private System.Windows.Forms.DataGridView dgvCursoBuscar;
        private System.Windows.Forms.Label lblBuscarCursoAnioError;
        private System.Windows.Forms.Label lblBuscarCursoDivisionError;
        private System.Windows.Forms.ComboBox cmbBuscarCursoTurno;
        private System.Windows.Forms.ComboBox cmbBuscarCursoEspecialidad;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCursoBuscarError;
    }
}