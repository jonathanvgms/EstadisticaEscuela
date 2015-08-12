namespace EstadisticasEscuelaFrontEnd.Usuarios
{
    partial class frmUsuarioBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioBuscar));
            this.lblBuscarUsuarioNombre = new System.Windows.Forms.Label();
            this.txtBuscarUsuarioNombre = new System.Windows.Forms.TextBox();
            this.dgvUsuarioBuscar = new System.Windows.Forms.DataGridView();
            this.btnBuscarUsuarioBuscar = new System.Windows.Forms.Button();
            this.btnBuscarUsuarioLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarUsuarioSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarUsuarioNombre
            // 
            this.lblBuscarUsuarioNombre.AutoSize = true;
            this.lblBuscarUsuarioNombre.Location = new System.Drawing.Point(21, 35);
            this.lblBuscarUsuarioNombre.Name = "lblBuscarUsuarioNombre";
            this.lblBuscarUsuarioNombre.Size = new System.Drawing.Size(47, 13);
            this.lblBuscarUsuarioNombre.TabIndex = 0;
            this.lblBuscarUsuarioNombre.Text = "Nombre ";
            // 
            // txtBuscarUsuarioNombre
            // 
            this.txtBuscarUsuarioNombre.Location = new System.Drawing.Point(97, 35);
            this.txtBuscarUsuarioNombre.Name = "txtBuscarUsuarioNombre";
            this.txtBuscarUsuarioNombre.Size = new System.Drawing.Size(117, 20);
            this.txtBuscarUsuarioNombre.TabIndex = 2;
            // 
            // dgvUsuarioBuscar
            // 
            this.dgvUsuarioBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioBuscar.Location = new System.Drawing.Point(24, 76);
            this.dgvUsuarioBuscar.Name = "dgvUsuarioBuscar";
            this.dgvUsuarioBuscar.Size = new System.Drawing.Size(644, 290);
            this.dgvUsuarioBuscar.TabIndex = 4;
            // 
            // btnBuscarUsuarioBuscar
            // 
            this.btnBuscarUsuarioBuscar.Location = new System.Drawing.Point(593, 30);
            this.btnBuscarUsuarioBuscar.Name = "btnBuscarUsuarioBuscar";
            this.btnBuscarUsuarioBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuarioBuscar.TabIndex = 5;
            this.btnBuscarUsuarioBuscar.Text = "Buscar";
            this.btnBuscarUsuarioBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarUsuarioBuscar.Click += new System.EventHandler(this.btnBuscarUsuarioBuscar_Click);
            // 
            // btnBuscarUsuarioLimpiar
            // 
            this.btnBuscarUsuarioLimpiar.Location = new System.Drawing.Point(24, 396);
            this.btnBuscarUsuarioLimpiar.Name = "btnBuscarUsuarioLimpiar";
            this.btnBuscarUsuarioLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuarioLimpiar.TabIndex = 6;
            this.btnBuscarUsuarioLimpiar.Text = "Limpiar";
            this.btnBuscarUsuarioLimpiar.UseVisualStyleBackColor = true;
            this.btnBuscarUsuarioLimpiar.Click += new System.EventHandler(this.btnBuscarUsuarioLimpiar_Click);
            // 
            // btnBuscarUsuarioSalir
            // 
            this.btnBuscarUsuarioSalir.Location = new System.Drawing.Point(593, 396);
            this.btnBuscarUsuarioSalir.Name = "btnBuscarUsuarioSalir";
            this.btnBuscarUsuarioSalir.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuarioSalir.TabIndex = 7;
            this.btnBuscarUsuarioSalir.Text = "Cancelar";
            this.btnBuscarUsuarioSalir.UseVisualStyleBackColor = true;
            this.btnBuscarUsuarioSalir.Click += new System.EventHandler(this.btnBuscarUsuarioSalir_Click);
            // 
            // frmUsuarioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 431);
            this.Controls.Add(this.btnBuscarUsuarioSalir);
            this.Controls.Add(this.btnBuscarUsuarioLimpiar);
            this.Controls.Add(this.btnBuscarUsuarioBuscar);
            this.Controls.Add(this.dgvUsuarioBuscar);
            this.Controls.Add(this.txtBuscarUsuarioNombre);
            this.Controls.Add(this.lblBuscarUsuarioNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarioBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarUsuarioNombre;
        private System.Windows.Forms.TextBox txtBuscarUsuarioNombre;
        private System.Windows.Forms.DataGridView dgvUsuarioBuscar;
        private System.Windows.Forms.Button btnBuscarUsuarioBuscar;
        private System.Windows.Forms.Button btnBuscarUsuarioLimpiar;
        private System.Windows.Forms.Button btnBuscarUsuarioSalir;
    }
}