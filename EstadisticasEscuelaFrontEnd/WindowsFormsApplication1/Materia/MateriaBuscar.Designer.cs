namespace EstadisticasEscuelaFrontEnd.Materias
{
    partial class frmMateriaBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaBuscar));
            this.FiltroDeBusqueda = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMateriaBuscarMateriaError = new System.Windows.Forms.Label();
            this.txtMateriaBuscarMateria = new System.Windows.Forms.TextBox();
            this.lblMateriaBucarMateria = new System.Windows.Forms.Label();
            this.btnMateriaBuscarLimpiar = new System.Windows.Forms.Button();
            this.btnMateriaBuscarBuscar = new System.Windows.Forms.Button();
            this.btnMateriaBucarCancelar = new System.Windows.Forms.Button();
            this.dgvMateriaBuscar = new System.Windows.Forms.DataGridView();
            this.FiltroDeBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroDeBusqueda
            // 
            this.FiltroDeBusqueda.Controls.Add(this.textBox1);
            this.FiltroDeBusqueda.Controls.Add(this.label1);
            this.FiltroDeBusqueda.Controls.Add(this.txtMateriaBuscarMateria);
            this.FiltroDeBusqueda.Controls.Add(this.lblMateriaBucarMateria);
            this.FiltroDeBusqueda.Location = new System.Drawing.Point(12, 12);
            this.FiltroDeBusqueda.Name = "FiltroDeBusqueda";
            this.FiltroDeBusqueda.Size = new System.Drawing.Size(454, 111);
            this.FiltroDeBusqueda.TabIndex = 0;
            this.FiltroDeBusqueda.TabStop = false;
            this.FiltroDeBusqueda.Text = "Filtro de Busqueda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // lblMateriaBuscarMateriaError
            // 
            this.lblMateriaBuscarMateriaError.AutoSize = true;
            this.lblMateriaBuscarMateriaError.Location = new System.Drawing.Point(116, 134);
            this.lblMateriaBuscarMateriaError.Name = "lblMateriaBuscarMateriaError";
            this.lblMateriaBuscarMateriaError.Size = new System.Drawing.Size(0, 13);
            this.lblMateriaBuscarMateriaError.TabIndex = 2;
            // 
            // txtMateriaBuscarMateria
            // 
            this.txtMateriaBuscarMateria.Location = new System.Drawing.Point(107, 73);
            this.txtMateriaBuscarMateria.Name = "txtMateriaBuscarMateria";
            this.txtMateriaBuscarMateria.Size = new System.Drawing.Size(169, 20);
            this.txtMateriaBuscarMateria.TabIndex = 1;
            // 
            // lblMateriaBucarMateria
            // 
            this.lblMateriaBucarMateria.AutoSize = true;
            this.lblMateriaBucarMateria.Location = new System.Drawing.Point(19, 76);
            this.lblMateriaBucarMateria.Name = "lblMateriaBucarMateria";
            this.lblMateriaBucarMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaBucarMateria.TabIndex = 0;
            this.lblMateriaBucarMateria.Text = "Materia";
            // 
            // btnMateriaBuscarLimpiar
            // 
            this.btnMateriaBuscarLimpiar.Location = new System.Drawing.Point(12, 129);
            this.btnMateriaBuscarLimpiar.Name = "btnMateriaBuscarLimpiar";
            this.btnMateriaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaBuscarLimpiar.TabIndex = 1;
            this.btnMateriaBuscarLimpiar.Text = "Limpiar";
            this.btnMateriaBuscarLimpiar.UseVisualStyleBackColor = true;
            this.btnMateriaBuscarLimpiar.Click += new System.EventHandler(this.btnMateriaBuscarLimpiar_Click);
            // 
            // btnMateriaBuscarBuscar
            // 
            this.btnMateriaBuscarBuscar.Location = new System.Drawing.Point(391, 129);
            this.btnMateriaBuscarBuscar.Name = "btnMateriaBuscarBuscar";
            this.btnMateriaBuscarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaBuscarBuscar.TabIndex = 2;
            this.btnMateriaBuscarBuscar.Text = "Buscar";
            this.btnMateriaBuscarBuscar.UseVisualStyleBackColor = true;
            this.btnMateriaBuscarBuscar.Click += new System.EventHandler(this.btnMateriaBuscarBuscar_Click);
            // 
            // btnMateriaBucarCancelar
            // 
            this.btnMateriaBucarCancelar.Location = new System.Drawing.Point(391, 551);
            this.btnMateriaBucarCancelar.Name = "btnMateriaBucarCancelar";
            this.btnMateriaBucarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaBucarCancelar.TabIndex = 3;
            this.btnMateriaBucarCancelar.Text = "Salir";
            this.btnMateriaBucarCancelar.UseVisualStyleBackColor = true;
            this.btnMateriaBucarCancelar.Click += new System.EventHandler(this.btnMateriaBucarCancelar_Click);
            // 
            // dgvMateriaBuscar
            // 
            this.dgvMateriaBuscar.AllowUserToAddRows = false;
            this.dgvMateriaBuscar.AllowUserToDeleteRows = false;
            this.dgvMateriaBuscar.AllowUserToResizeColumns = false;
            this.dgvMateriaBuscar.AllowUserToResizeRows = false;
            this.dgvMateriaBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMateriaBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMateriaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaBuscar.Location = new System.Drawing.Point(12, 158);
            this.dgvMateriaBuscar.Name = "dgvMateriaBuscar";
            this.dgvMateriaBuscar.Size = new System.Drawing.Size(454, 387);
            this.dgvMateriaBuscar.TabIndex = 4;
            this.dgvMateriaBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionMateria);
            // 
            // frmMateriaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 579);
            this.Controls.Add(this.dgvMateriaBuscar);
            this.Controls.Add(this.btnMateriaBucarCancelar);
            this.Controls.Add(this.lblMateriaBuscarMateriaError);
            this.Controls.Add(this.btnMateriaBuscarBuscar);
            this.Controls.Add(this.btnMateriaBuscarLimpiar);
            this.Controls.Add(this.FiltroDeBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMateriaBuscar";
            this.Text = "Buscar Materia";
            this.FiltroDeBusqueda.ResumeLayout(false);
            this.FiltroDeBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltroDeBusqueda;
        private System.Windows.Forms.TextBox txtMateriaBuscarMateria;
        private System.Windows.Forms.Label lblMateriaBucarMateria;
        private System.Windows.Forms.Button btnMateriaBuscarLimpiar;
        private System.Windows.Forms.Button btnMateriaBuscarBuscar;
        private System.Windows.Forms.Button btnMateriaBucarCancelar;
        private System.Windows.Forms.DataGridView dgvMateriaBuscar;
        private System.Windows.Forms.Label lblMateriaBuscarMateriaError;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}