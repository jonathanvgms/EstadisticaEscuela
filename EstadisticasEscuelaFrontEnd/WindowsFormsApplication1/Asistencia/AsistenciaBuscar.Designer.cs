namespace EstadisticasEscuelaFrontEnd.Asistencia
{
    partial class frmAsistenciaBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistenciaBuscar));
            this.lblASistenciaBuscarFecha = new System.Windows.Forms.Label();
            this.txtAsistenciaBuscarFecha = new System.Windows.Forms.TextBox();
            this.dgvAsistenciaBucar = new System.Windows.Forms.DataGridView();
            this.btnAsistenciaBuscarLimpiar = new System.Windows.Forms.Button();
            this.btnAsistenciaBuscarBuscar = new System.Windows.Forms.Button();
            this.btnAsistenciaBuscarCancelar = new System.Windows.Forms.Button();
            this.FiltroDeBusqueda = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAsistenciaBuscarBuscarCurso = new System.Windows.Forms.Button();
            this.lblAsistenciaBuscarFechaEtiqueta = new System.Windows.Forms.Label();
            this.txtAsistenciaBuscar = new System.Windows.Forms.TextBox();
            this.lblAsistenciaBuscarFechaError = new System.Windows.Forms.Label();
            this.lblAsistenciaBuscarPresenteError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaBucar)).BeginInit();
            this.FiltroDeBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblASistenciaBuscarFecha
            // 
            this.lblASistenciaBuscarFecha.AutoSize = true;
            this.lblASistenciaBuscarFecha.Location = new System.Drawing.Point(6, 88);
            this.lblASistenciaBuscarFecha.Name = "lblASistenciaBuscarFecha";
            this.lblASistenciaBuscarFecha.Size = new System.Drawing.Size(34, 13);
            this.lblASistenciaBuscarFecha.TabIndex = 1;
            this.lblASistenciaBuscarFecha.Text = "Curso";
            // 
            // txtAsistenciaBuscarFecha
            // 
            this.txtAsistenciaBuscarFecha.Enabled = false;
            this.txtAsistenciaBuscarFecha.Location = new System.Drawing.Point(49, 88);
            this.txtAsistenciaBuscarFecha.Name = "txtAsistenciaBuscarFecha";
            this.txtAsistenciaBuscarFecha.ReadOnly = true;
            this.txtAsistenciaBuscarFecha.Size = new System.Drawing.Size(187, 20);
            this.txtAsistenciaBuscarFecha.TabIndex = 3;
            // 
            // dgvAsistenciaBucar
            // 
            this.dgvAsistenciaBucar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaBucar.Location = new System.Drawing.Point(10, 225);
            this.dgvAsistenciaBucar.Name = "dgvAsistenciaBucar";
            this.dgvAsistenciaBucar.Size = new System.Drawing.Size(674, 317);
            this.dgvAsistenciaBucar.TabIndex = 4;
            this.dgvAsistenciaBucar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistenciaBucar_CellContentClick);
            // 
            // btnAsistenciaBuscarLimpiar
            // 
            this.btnAsistenciaBuscarLimpiar.Location = new System.Drawing.Point(591, 31);
            this.btnAsistenciaBuscarLimpiar.Name = "btnAsistenciaBuscarLimpiar";
            this.btnAsistenciaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarLimpiar.TabIndex = 5;
            this.btnAsistenciaBuscarLimpiar.Text = "Limpiar";
            this.btnAsistenciaBuscarLimpiar.UseVisualStyleBackColor = true;
            this.btnAsistenciaBuscarLimpiar.Click += new System.EventHandler(this.btnAsistenciaBuscarLimpiar_Click);
            // 
            // btnAsistenciaBuscarBuscar
            // 
            this.btnAsistenciaBuscarBuscar.Location = new System.Drawing.Point(591, 163);
            this.btnAsistenciaBuscarBuscar.Name = "btnAsistenciaBuscarBuscar";
            this.btnAsistenciaBuscarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarBuscar.TabIndex = 6;
            this.btnAsistenciaBuscarBuscar.Text = "Buscar";
            this.btnAsistenciaBuscarBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAsistenciaBuscarCancelar
            // 
            this.btnAsistenciaBuscarCancelar.Location = new System.Drawing.Point(609, 548);
            this.btnAsistenciaBuscarCancelar.Name = "btnAsistenciaBuscarCancelar";
            this.btnAsistenciaBuscarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarCancelar.TabIndex = 7;
            this.btnAsistenciaBuscarCancelar.Text = "Salir";
            this.btnAsistenciaBuscarCancelar.UseVisualStyleBackColor = true;
            this.btnAsistenciaBuscarCancelar.Click += new System.EventHandler(this.btnAsistenciaBuscarCancelar_Click);
            // 
            // FiltroDeBusqueda
            // 
            this.FiltroDeBusqueda.Controls.Add(this.monthCalendar1);
            this.FiltroDeBusqueda.Controls.Add(this.btnAsistenciaBuscarBuscarCurso);
            this.FiltroDeBusqueda.Controls.Add(this.lblAsistenciaBuscarFechaEtiqueta);
            this.FiltroDeBusqueda.Controls.Add(this.btnAsistenciaBuscarLimpiar);
            this.FiltroDeBusqueda.Controls.Add(this.txtAsistenciaBuscar);
            this.FiltroDeBusqueda.Controls.Add(this.btnAsistenciaBuscarBuscar);
            this.FiltroDeBusqueda.Controls.Add(this.lblAsistenciaBuscarFechaError);
            this.FiltroDeBusqueda.Controls.Add(this.lblAsistenciaBuscarPresenteError);
            this.FiltroDeBusqueda.Controls.Add(this.lblASistenciaBuscarFecha);
            this.FiltroDeBusqueda.Controls.Add(this.txtAsistenciaBuscarFecha);
            this.FiltroDeBusqueda.Location = new System.Drawing.Point(12, 12);
            this.FiltroDeBusqueda.Name = "FiltroDeBusqueda";
            this.FiltroDeBusqueda.Size = new System.Drawing.Size(672, 207);
            this.FiltroDeBusqueda.TabIndex = 8;
            this.FiltroDeBusqueda.TabStop = false;
            this.FiltroDeBusqueda.Text = "Filtro de Busqueda";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(308, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // btnAsistenciaBuscarBuscarCurso
            // 
            this.btnAsistenciaBuscarBuscarCurso.Location = new System.Drawing.Point(141, 114);
            this.btnAsistenciaBuscarBuscarCurso.Name = "btnAsistenciaBuscarBuscarCurso";
            this.btnAsistenciaBuscarBuscarCurso.Size = new System.Drawing.Size(95, 23);
            this.btnAsistenciaBuscarBuscarCurso.TabIndex = 14;
            this.btnAsistenciaBuscarBuscarCurso.Text = "Buscar Curso";
            this.btnAsistenciaBuscarBuscarCurso.UseVisualStyleBackColor = true;
            this.btnAsistenciaBuscarBuscarCurso.Click += new System.EventHandler(this.btnAsistenciaBuscarBuscarCurso_Click);
            // 
            // lblAsistenciaBuscarFechaEtiqueta
            // 
            this.lblAsistenciaBuscarFechaEtiqueta.AutoSize = true;
            this.lblAsistenciaBuscarFechaEtiqueta.Location = new System.Drawing.Point(6, 33);
            this.lblAsistenciaBuscarFechaEtiqueta.Name = "lblAsistenciaBuscarFechaEtiqueta";
            this.lblAsistenciaBuscarFechaEtiqueta.Size = new System.Drawing.Size(37, 13);
            this.lblAsistenciaBuscarFechaEtiqueta.TabIndex = 11;
            this.lblAsistenciaBuscarFechaEtiqueta.Text = "Fecha";
            // 
            // txtAsistenciaBuscar
            // 
            this.txtAsistenciaBuscar.Enabled = false;
            this.txtAsistenciaBuscar.Location = new System.Drawing.Point(49, 33);
            this.txtAsistenciaBuscar.Name = "txtAsistenciaBuscar";
            this.txtAsistenciaBuscar.ReadOnly = true;
            this.txtAsistenciaBuscar.Size = new System.Drawing.Size(187, 20);
            this.txtAsistenciaBuscar.TabIndex = 12;
            // 
            // lblAsistenciaBuscarFechaError
            // 
            this.lblAsistenciaBuscarFechaError.AutoSize = true;
            this.lblAsistenciaBuscarFechaError.Location = new System.Drawing.Point(251, 36);
            this.lblAsistenciaBuscarFechaError.Name = "lblAsistenciaBuscarFechaError";
            this.lblAsistenciaBuscarFechaError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaBuscarFechaError.TabIndex = 8;
            // 
            // lblAsistenciaBuscarPresenteError
            // 
            this.lblAsistenciaBuscarPresenteError.AutoSize = true;
            this.lblAsistenciaBuscarPresenteError.Location = new System.Drawing.Point(731, 22);
            this.lblAsistenciaBuscarPresenteError.Name = "lblAsistenciaBuscarPresenteError";
            this.lblAsistenciaBuscarPresenteError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaBuscarPresenteError.TabIndex = 7;
            // 
            // frmAsistenciaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 572);
            this.Controls.Add(this.FiltroDeBusqueda);
            this.Controls.Add(this.btnAsistenciaBuscarCancelar);
            this.Controls.Add(this.dgvAsistenciaBucar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsistenciaBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AsistenciaBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaBucar)).EndInit();
            this.FiltroDeBusqueda.ResumeLayout(false);
            this.FiltroDeBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblASistenciaBuscarFecha;
        private System.Windows.Forms.TextBox txtAsistenciaBuscarFecha;
        private System.Windows.Forms.DataGridView dgvAsistenciaBucar;
        private System.Windows.Forms.Button btnAsistenciaBuscarLimpiar;
        private System.Windows.Forms.Button btnAsistenciaBuscarBuscar;
        private System.Windows.Forms.Button btnAsistenciaBuscarCancelar;
        private System.Windows.Forms.GroupBox FiltroDeBusqueda;
        private System.Windows.Forms.Label lblAsistenciaBuscarFechaError;
        private System.Windows.Forms.Label lblAsistenciaBuscarPresenteError;
        private System.Windows.Forms.Label lblAsistenciaBuscarFechaEtiqueta;
        private System.Windows.Forms.TextBox txtAsistenciaBuscar;
        private System.Windows.Forms.Button btnAsistenciaBuscarBuscarCurso;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}