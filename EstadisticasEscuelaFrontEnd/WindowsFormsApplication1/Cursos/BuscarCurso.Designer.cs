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
            this.btnBuscarCursoLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarCursoSalir = new System.Windows.Forms.Button();
            this.lblBuscarCursoAnio = new System.Windows.Forms.Label();
            this.lblBuscarCursoDivision = new System.Windows.Forms.Label();
            this.txtBuscarCursoAnio = new System.Windows.Forms.TextBox();
            this.txtBuscarCursoDivision = new System.Windows.Forms.TextBox();
            this.btnBuscarCursoBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBuscarCursoAnioError = new System.Windows.Forms.Label();
            this.lblBuscarCursoDivisionError = new System.Windows.Forms.Label();
            this.cmbBuscarCursoTurno = new System.Windows.Forms.ComboBox();
            this.cmbBuscarCursoEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCursoLimpiar
            // 
            this.btnBuscarCursoLimpiar.Location = new System.Drawing.Point(2, 548);
            this.btnBuscarCursoLimpiar.Name = "btnBuscarCursoLimpiar";
            this.btnBuscarCursoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCursoLimpiar.TabIndex = 0;
            this.btnBuscarCursoLimpiar.Text = "Limpiar";
            this.btnBuscarCursoLimpiar.UseVisualStyleBackColor = true;
            this.btnBuscarCursoLimpiar.Click += new System.EventHandler(this.btnBuscarCursoLimpiar_Click);
            // 
            // btnBuscarCursoSalir
            // 
            this.btnBuscarCursoSalir.Location = new System.Drawing.Point(704, 548);
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
            this.lblBuscarCursoAnio.Size = new System.Drawing.Size(28, 13);
            this.lblBuscarCursoAnio.TabIndex = 2;
            this.lblBuscarCursoAnio.Text = "Anio";
            this.lblBuscarCursoAnio.Click += new System.EventHandler(this.lblBuscarCursoAnio_Click);
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
            // txtBuscarCursoAnio
            // 
            this.txtBuscarCursoAnio.Location = new System.Drawing.Point(126, 12);
            this.txtBuscarCursoAnio.Name = "txtBuscarCursoAnio";
            this.txtBuscarCursoAnio.Size = new System.Drawing.Size(170, 20);
            this.txtBuscarCursoAnio.TabIndex = 4;
            // 
            // txtBuscarCursoDivision
            // 
            this.txtBuscarCursoDivision.Location = new System.Drawing.Point(126, 52);
            this.txtBuscarCursoDivision.Name = "txtBuscarCursoDivision";
            this.txtBuscarCursoDivision.Size = new System.Drawing.Size(170, 20);
            this.txtBuscarCursoDivision.TabIndex = 5;
            // 
            // btnBuscarCursoBuscar
            // 
            this.btnBuscarCursoBuscar.Location = new System.Drawing.Point(704, 55);
            this.btnBuscarCursoBuscar.Name = "btnBuscarCursoBuscar";
            this.btnBuscarCursoBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCursoBuscar.TabIndex = 6;
            this.btnBuscarCursoBuscar.Text = "Buscar";
            this.btnBuscarCursoBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarCursoBuscar.Click += new System.EventHandler(this.btnBuscarCursoBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 441);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.cmbBuscarCursoTurno.Location = new System.Drawing.Point(514, 6);
            this.cmbBuscarCursoTurno.Name = "cmbBuscarCursoTurno";
            this.cmbBuscarCursoTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarCursoTurno.TabIndex = 10;
            // 
            // cmbBuscarCursoEspecialidad
            // 
            this.cmbBuscarCursoEspecialidad.FormattingEnabled = true;
            this.cmbBuscarCursoEspecialidad.Location = new System.Drawing.Point(514, 47);
            this.cmbBuscarCursoEspecialidad.Name = "cmbBuscarCursoEspecialidad";
            this.cmbBuscarCursoEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarCursoEspecialidad.TabIndex = 11;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(430, 14);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 12;
            this.lblTurno.Text = "Turno";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(433, 47);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 13;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // frmBuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 571);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbBuscarCursoEspecialidad);
            this.Controls.Add(this.cmbBuscarCursoTurno);
            this.Controls.Add(this.lblBuscarCursoDivisionError);
            this.Controls.Add(this.lblBuscarCursoAnioError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarCursoBuscar);
            this.Controls.Add(this.txtBuscarCursoDivision);
            this.Controls.Add(this.txtBuscarCursoAnio);
            this.Controls.Add(this.lblBuscarCursoDivision);
            this.Controls.Add(this.lblBuscarCursoAnio);
            this.Controls.Add(this.btnBuscarCursoSalir);
            this.Controls.Add(this.btnBuscarCursoLimpiar);
            this.Name = "frmBuscarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCurso";
            this.Load += new System.EventHandler(this.BuscarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCursoLimpiar;
        private System.Windows.Forms.Button btnBuscarCursoSalir;
        private System.Windows.Forms.Label lblBuscarCursoAnio;
        private System.Windows.Forms.Label lblBuscarCursoDivision;
        private System.Windows.Forms.TextBox txtBuscarCursoAnio;
        private System.Windows.Forms.TextBox txtBuscarCursoDivision;
        private System.Windows.Forms.Button btnBuscarCursoBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBuscarCursoAnioError;
        private System.Windows.Forms.Label lblBuscarCursoDivisionError;
        private System.Windows.Forms.ComboBox cmbBuscarCursoTurno;
        private System.Windows.Forms.ComboBox cmbBuscarCursoEspecialidad;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}