namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    partial class BuscarAlumno
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
            this.txtBuscarAlumnoNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarAlumnoApellido = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumnoSalir = new System.Windows.Forms.Button();
            this.btnBuscarAlumnoBuscar = new System.Windows.Forms.Button();
            this.dgvBuscarAlumnoInfo = new System.Windows.Forms.DataGridView();
            this.btnBuscarAlumnoLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarAlumnoInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarAlumnoNombre
            // 
            this.lblBuscarAlumnoNombre.AutoSize = true;
            this.lblBuscarAlumnoNombre.Location = new System.Drawing.Point(30, 15);
            this.lblBuscarAlumnoNombre.Name = "lblBuscarAlumnoNombre";
            this.lblBuscarAlumnoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarAlumnoNombre.TabIndex = 0;
            this.lblBuscarAlumnoNombre.Text = "Nombre";
            // 
            // lblBuscarAlumnoApellido
            // 
            this.lblBuscarAlumnoApellido.AutoSize = true;
            this.lblBuscarAlumnoApellido.Location = new System.Drawing.Point(30, 59);
            this.lblBuscarAlumnoApellido.Name = "lblBuscarAlumnoApellido";
            this.lblBuscarAlumnoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarAlumnoApellido.TabIndex = 1;
            this.lblBuscarAlumnoApellido.Text = "Apellido";
            // 
            // txtBuscarAlumnoNombre
            // 
            this.txtBuscarAlumnoNombre.Location = new System.Drawing.Point(186, 12);
            this.txtBuscarAlumnoNombre.Name = "txtBuscarAlumnoNombre";
            this.txtBuscarAlumnoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarAlumnoNombre.TabIndex = 2;
            // 
            // txtBuscarAlumnoApellido
            // 
            this.txtBuscarAlumnoApellido.Location = new System.Drawing.Point(186, 56);
            this.txtBuscarAlumnoApellido.Name = "txtBuscarAlumnoApellido";
            this.txtBuscarAlumnoApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarAlumnoApellido.TabIndex = 3;
            // 
            // btnBuscarAlumnoSalir
            // 
            this.btnBuscarAlumnoSalir.Location = new System.Drawing.Point(661, 467);
            this.btnBuscarAlumnoSalir.Name = "btnBuscarAlumnoSalir";
            this.btnBuscarAlumnoSalir.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumnoSalir.TabIndex = 4;
            this.btnBuscarAlumnoSalir.Text = "Salir";
            this.btnBuscarAlumnoSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAlumnoBuscar
            // 
            this.btnBuscarAlumnoBuscar.Location = new System.Drawing.Point(661, 49);
            this.btnBuscarAlumnoBuscar.Name = "btnBuscarAlumnoBuscar";
            this.btnBuscarAlumnoBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumnoBuscar.TabIndex = 5;
            this.btnBuscarAlumnoBuscar.Text = "Buscar";
            this.btnBuscarAlumnoBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarAlumnoBuscar.Click += new System.EventHandler(this.btnBuscarAlumnoBuscar_Click);
            // 
            // dgvBuscarAlumnoInfo
            // 
            this.dgvBuscarAlumnoInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarAlumnoInfo.Location = new System.Drawing.Point(12, 82);
            this.dgvBuscarAlumnoInfo.Name = "dgvBuscarAlumnoInfo";
            this.dgvBuscarAlumnoInfo.Size = new System.Drawing.Size(724, 363);
            this.dgvBuscarAlumnoInfo.TabIndex = 6;
            // 
            // btnBuscarAlumnoLimpiar
            // 
            this.btnBuscarAlumnoLimpiar.Location = new System.Drawing.Point(13, 467);
            this.btnBuscarAlumnoLimpiar.Name = "btnBuscarAlumnoLimpiar";
            this.btnBuscarAlumnoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumnoLimpiar.TabIndex = 7;
            this.btnBuscarAlumnoLimpiar.Text = "Limpiar";
            this.btnBuscarAlumnoLimpiar.UseVisualStyleBackColor = true;
            // 
            // BuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 502);
            this.Controls.Add(this.btnBuscarAlumnoLimpiar);
            this.Controls.Add(this.dgvBuscarAlumnoInfo);
            this.Controls.Add(this.btnBuscarAlumnoBuscar);
            this.Controls.Add(this.btnBuscarAlumnoSalir);
            this.Controls.Add(this.txtBuscarAlumnoApellido);
            this.Controls.Add(this.txtBuscarAlumnoNombre);
            this.Controls.Add(this.lblBuscarAlumnoApellido);
            this.Controls.Add(this.lblBuscarAlumnoNombre);
            this.Name = "BuscarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarAlumnoInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarAlumnoNombre;
        private System.Windows.Forms.Label lblBuscarAlumnoApellido;
        private System.Windows.Forms.TextBox txtBuscarAlumnoNombre;
        private System.Windows.Forms.TextBox txtBuscarAlumnoApellido;
        private System.Windows.Forms.Button btnBuscarAlumnoSalir;
        private System.Windows.Forms.Button btnBuscarAlumnoBuscar;
        private System.Windows.Forms.DataGridView dgvBuscarAlumnoInfo;
        private System.Windows.Forms.Button btnBuscarAlumnoLimpiar;
    }
}