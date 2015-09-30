namespace EstadisticasEscuelaFrontEnd.Nota
{
    partial class frmAsignarNota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAsignarNotaMateria = new System.Windows.Forms.Label();
            this.lblAsignarNotaCurso = new System.Windows.Forms.Label();
            this.txtAsignarNotaMateria = new System.Windows.Forms.TextBox();
            this.txtAsignarNotaCurso = new System.Windows.Forms.TextBox();
            this.btnAsignarNotaBuscarMateria = new System.Windows.Forms.Button();
            this.btnAsignarNotaBuscarCurso = new System.Windows.Forms.Button();
            this.dgvAsignarNota = new System.Windows.Forms.DataGridView();
            this.clnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAsignarNotaLimpiar = new System.Windows.Forms.Button();
            this.btnAsignarNotaCancelar = new System.Windows.Forms.Button();
            this.btnAsignarNotaAceptar = new System.Windows.Forms.Button();
            this.gpbxDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignarNota)).BeginInit();
            this.gpbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsignarNotaMateria
            // 
            this.lblAsignarNotaMateria.AutoSize = true;
            this.lblAsignarNotaMateria.Location = new System.Drawing.Point(53, 42);
            this.lblAsignarNotaMateria.Name = "lblAsignarNotaMateria";
            this.lblAsignarNotaMateria.Size = new System.Drawing.Size(42, 13);
            this.lblAsignarNotaMateria.TabIndex = 0;
            this.lblAsignarNotaMateria.Text = "Materia";
            // 
            // lblAsignarNotaCurso
            // 
            this.lblAsignarNotaCurso.AutoSize = true;
            this.lblAsignarNotaCurso.Location = new System.Drawing.Point(545, 44);
            this.lblAsignarNotaCurso.Name = "lblAsignarNotaCurso";
            this.lblAsignarNotaCurso.Size = new System.Drawing.Size(34, 13);
            this.lblAsignarNotaCurso.TabIndex = 1;
            this.lblAsignarNotaCurso.Text = "Curso";
            // 
            // txtAsignarNotaMateria
            // 
            this.txtAsignarNotaMateria.Location = new System.Drawing.Point(117, 39);
            this.txtAsignarNotaMateria.Name = "txtAsignarNotaMateria";
            this.txtAsignarNotaMateria.Size = new System.Drawing.Size(182, 20);
            this.txtAsignarNotaMateria.TabIndex = 3;
            // 
            // txtAsignarNotaCurso
            // 
            this.txtAsignarNotaCurso.Location = new System.Drawing.Point(605, 40);
            this.txtAsignarNotaCurso.Name = "txtAsignarNotaCurso";
            this.txtAsignarNotaCurso.Size = new System.Drawing.Size(182, 20);
            this.txtAsignarNotaCurso.TabIndex = 4;
            // 
            // btnAsignarNotaBuscarMateria
            // 
            this.btnAsignarNotaBuscarMateria.Location = new System.Drawing.Point(324, 37);
            this.btnAsignarNotaBuscarMateria.Name = "btnAsignarNotaBuscarMateria";
            this.btnAsignarNotaBuscarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarNotaBuscarMateria.TabIndex = 6;
            this.btnAsignarNotaBuscarMateria.Text = "Buscar";
            this.btnAsignarNotaBuscarMateria.UseVisualStyleBackColor = true;
            this.btnAsignarNotaBuscarMateria.Click += new System.EventHandler(this.btnModificarNotaBuscarMateria_Click);
            // 
            // btnAsignarNotaBuscarCurso
            // 
            this.btnAsignarNotaBuscarCurso.Location = new System.Drawing.Point(811, 39);
            this.btnAsignarNotaBuscarCurso.Name = "btnAsignarNotaBuscarCurso";
            this.btnAsignarNotaBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarNotaBuscarCurso.TabIndex = 7;
            this.btnAsignarNotaBuscarCurso.Text = "Buscar";
            this.btnAsignarNotaBuscarCurso.UseVisualStyleBackColor = true;
            this.btnAsignarNotaBuscarCurso.Click += new System.EventHandler(this.btnModificarNotaBuscarCurso_Click);
            // 
            // dgvAsignarNota
            // 
            this.dgvAsignarNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignarNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNombre,
            this.column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvAsignarNota.Location = new System.Drawing.Point(3, 145);
            this.dgvAsignarNota.Name = "dgvAsignarNota";
            this.dgvAsignarNota.Size = new System.Drawing.Size(1043, 294);
            this.dgvAsignarNota.TabIndex = 5;
            // 
            // clnNombre
            // 
            this.clnNombre.HeaderText = "Nombre";
            this.clnNombre.Name = "clnNombre";
            // 
            // column9
            // 
            this.column9.HeaderText = "Apellido";
            this.column9.Name = "column9";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nota 1er Trimestre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nota 2do Trimestre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nota 3er Trimestre";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nota Defenitiva";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nota Final";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ausente";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Modificar";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Eliminar";
            this.Column8.Name = "Column8";
            // 
            // btnAsignarNotaLimpiar
            // 
            this.btnAsignarNotaLimpiar.Location = new System.Drawing.Point(32, 445);
            this.btnAsignarNotaLimpiar.Name = "btnAsignarNotaLimpiar";
            this.btnAsignarNotaLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarNotaLimpiar.TabIndex = 8;
            this.btnAsignarNotaLimpiar.Text = "Limpiar";
            this.btnAsignarNotaLimpiar.UseVisualStyleBackColor = true;
            this.btnAsignarNotaLimpiar.Click += new System.EventHandler(this.btnModificarNotaLimpiar_Click);
            // 
            // btnAsignarNotaCancelar
            // 
            this.btnAsignarNotaCancelar.Location = new System.Drawing.Point(971, 445);
            this.btnAsignarNotaCancelar.Name = "btnAsignarNotaCancelar";
            this.btnAsignarNotaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarNotaCancelar.TabIndex = 9;
            this.btnAsignarNotaCancelar.Text = "Cancelar";
            this.btnAsignarNotaCancelar.UseVisualStyleBackColor = true;
            this.btnAsignarNotaCancelar.Click += new System.EventHandler(this.btnAsignarNotaCancelar_Click);
            // 
            // btnAsignarNotaAceptar
            // 
            this.btnAsignarNotaAceptar.Location = new System.Drawing.Point(863, 445);
            this.btnAsignarNotaAceptar.Name = "btnAsignarNotaAceptar";
            this.btnAsignarNotaAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarNotaAceptar.TabIndex = 10;
            this.btnAsignarNotaAceptar.Text = "Aceptar";
            this.btnAsignarNotaAceptar.UseVisualStyleBackColor = true;
            // 
            // gpbxDatos
            // 
            this.gpbxDatos.Controls.Add(this.txtAsignarNotaMateria);
            this.gpbxDatos.Controls.Add(this.lblAsignarNotaMateria);
            this.gpbxDatos.Controls.Add(this.lblAsignarNotaCurso);
            this.gpbxDatos.Controls.Add(this.txtAsignarNotaCurso);
            this.gpbxDatos.Controls.Add(this.btnAsignarNotaBuscarCurso);
            this.gpbxDatos.Controls.Add(this.btnAsignarNotaBuscarMateria);
            this.gpbxDatos.Location = new System.Drawing.Point(12, 33);
            this.gpbxDatos.Name = "gpbxDatos";
            this.gpbxDatos.Size = new System.Drawing.Size(1025, 90);
            this.gpbxDatos.TabIndex = 11;
            this.gpbxDatos.TabStop = false;
            this.gpbxDatos.Text = "Datos";
            // 
            // frmAsignarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 480);
            this.Controls.Add(this.gpbxDatos);
            this.Controls.Add(this.btnAsignarNotaAceptar);
            this.Controls.Add(this.btnAsignarNotaCancelar);
            this.Controls.Add(this.btnAsignarNotaLimpiar);
            this.Controls.Add(this.dgvAsignarNota);
            this.Name = "frmAsignarNota";
            this.Text = "Asignar Nota";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignarNota)).EndInit();
            this.gpbxDatos.ResumeLayout(false);
            this.gpbxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAsignarNotaMateria;
        private System.Windows.Forms.Label lblAsignarNotaCurso;
        private System.Windows.Forms.TextBox txtAsignarNotaMateria;
        private System.Windows.Forms.TextBox txtAsignarNotaCurso;
        private System.Windows.Forms.Button btnAsignarNotaBuscarMateria;
        private System.Windows.Forms.Button btnAsignarNotaBuscarCurso;
        private System.Windows.Forms.DataGridView dgvAsignarNota;
        private System.Windows.Forms.Button btnAsignarNotaLimpiar;
        private System.Windows.Forms.Button btnAsignarNotaCancelar;
        private System.Windows.Forms.Button btnAsignarNotaAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.GroupBox gpbxDatos;
    }
}