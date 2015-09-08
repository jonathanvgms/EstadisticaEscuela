namespace EstadisticasEscuelaFrontEnd.Notas
{
    partial class NotaBuscar
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
            this.btnNotaBuscarBuscar = new System.Windows.Forms.Button();
            this.btnNotaBuscarLimpiar = new System.Windows.Forms.Button();
            this.lblNotaBuscarAlumno = new System.Windows.Forms.Label();
            this.txtNotaBuscarAlumno = new System.Windows.Forms.TextBox();
            this.lblNotaBuscarCurso = new System.Windows.Forms.Label();
            this.btnNotaBuscarSalir = new System.Windows.Forms.Button();
            this.dgvNotaBuscar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNotaBuscarAlumnoBuscar = new System.Windows.Forms.Button();
            this.btnNotaBuscarCursoBuscar = new System.Windows.Forms.Button();
            this.txtNotaBuscarCurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaBuscar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotaBuscarBuscar
            // 
            this.btnNotaBuscarBuscar.Location = new System.Drawing.Point(534, 128);
            this.btnNotaBuscarBuscar.Name = "btnNotaBuscarBuscar";
            this.btnNotaBuscarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnNotaBuscarBuscar.TabIndex = 0;
            this.btnNotaBuscarBuscar.Text = "Buscar";
            this.btnNotaBuscarBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNotaBuscarLimpiar
            // 
            this.btnNotaBuscarLimpiar.Location = new System.Drawing.Point(12, 128);
            this.btnNotaBuscarLimpiar.Name = "btnNotaBuscarLimpiar";
            this.btnNotaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnNotaBuscarLimpiar.TabIndex = 1;
            this.btnNotaBuscarLimpiar.Text = "Limpiar";
            this.btnNotaBuscarLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNotaBuscarAlumno
            // 
            this.lblNotaBuscarAlumno.AutoSize = true;
            this.lblNotaBuscarAlumno.Location = new System.Drawing.Point(57, 55);
            this.lblNotaBuscarAlumno.Name = "lblNotaBuscarAlumno";
            this.lblNotaBuscarAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblNotaBuscarAlumno.TabIndex = 2;
            this.lblNotaBuscarAlumno.Text = "Alumno";
            // 
            // txtNotaBuscarAlumno
            // 
            this.txtNotaBuscarAlumno.Enabled = false;
            this.txtNotaBuscarAlumno.Location = new System.Drawing.Point(137, 52);
            this.txtNotaBuscarAlumno.Name = "txtNotaBuscarAlumno";
            this.txtNotaBuscarAlumno.ReadOnly = true;
            this.txtNotaBuscarAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtNotaBuscarAlumno.TabIndex = 3;
            // 
            // lblNotaBuscarCurso
            // 
            this.lblNotaBuscarCurso.AutoSize = true;
            this.lblNotaBuscarCurso.Location = new System.Drawing.Point(57, 16);
            this.lblNotaBuscarCurso.Name = "lblNotaBuscarCurso";
            this.lblNotaBuscarCurso.Size = new System.Drawing.Size(34, 13);
            this.lblNotaBuscarCurso.TabIndex = 4;
            this.lblNotaBuscarCurso.Text = "Curso";
            // 
            // btnNotaBuscarSalir
            // 
            this.btnNotaBuscarSalir.Location = new System.Drawing.Point(534, 465);
            this.btnNotaBuscarSalir.Name = "btnNotaBuscarSalir";
            this.btnNotaBuscarSalir.Size = new System.Drawing.Size(75, 23);
            this.btnNotaBuscarSalir.TabIndex = 5;
            this.btnNotaBuscarSalir.Text = "Salir";
            this.btnNotaBuscarSalir.UseVisualStyleBackColor = true;
            // 
            // dgvNotaBuscar
            // 
            this.dgvNotaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaBuscar.Location = new System.Drawing.Point(12, 157);
            this.dgvNotaBuscar.Name = "dgvNotaBuscar";
            this.dgvNotaBuscar.Size = new System.Drawing.Size(605, 293);
            this.dgvNotaBuscar.TabIndex = 6;
            this.dgvNotaBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotaBuscar_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotaBuscarAlumnoBuscar);
            this.groupBox1.Controls.Add(this.btnNotaBuscarCursoBuscar);
            this.groupBox1.Controls.Add(this.txtNotaBuscarCurso);
            this.groupBox1.Controls.Add(this.lblNotaBuscarCurso);
            this.groupBox1.Controls.Add(this.lblNotaBuscarAlumno);
            this.groupBox1.Controls.Add(this.txtNotaBuscarAlumno);
            this.groupBox1.Location = new System.Drawing.Point(4, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnNotaBuscarAlumnoBuscar
            // 
            this.btnNotaBuscarAlumnoBuscar.Location = new System.Drawing.Point(257, 55);
            this.btnNotaBuscarAlumnoBuscar.Name = "btnNotaBuscarAlumnoBuscar";
            this.btnNotaBuscarAlumnoBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnNotaBuscarAlumnoBuscar.TabIndex = 7;
            this.btnNotaBuscarAlumnoBuscar.Text = "Buscar";
            this.btnNotaBuscarAlumnoBuscar.UseVisualStyleBackColor = true;
            this.btnNotaBuscarAlumnoBuscar.Click += new System.EventHandler(this.btnNotaBuscarAlumnoBuscar_Click);
            // 
            // btnNotaBuscarCursoBuscar
            // 
            this.btnNotaBuscarCursoBuscar.Location = new System.Drawing.Point(257, 19);
            this.btnNotaBuscarCursoBuscar.Name = "btnNotaBuscarCursoBuscar";
            this.btnNotaBuscarCursoBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnNotaBuscarCursoBuscar.TabIndex = 6;
            this.btnNotaBuscarCursoBuscar.Text = "Buscar";
            this.btnNotaBuscarCursoBuscar.UseVisualStyleBackColor = true;
            this.btnNotaBuscarCursoBuscar.Click += new System.EventHandler(this.btnNotaBuscarCursoBuscar_Click);
            // 
            // txtNotaBuscarCurso
            // 
            this.txtNotaBuscarCurso.Enabled = false;
            this.txtNotaBuscarCurso.Location = new System.Drawing.Point(137, 16);
            this.txtNotaBuscarCurso.Name = "txtNotaBuscarCurso";
            this.txtNotaBuscarCurso.ReadOnly = true;
            this.txtNotaBuscarCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNotaBuscarCurso.TabIndex = 5;
            // 
            // NotaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNotaBuscar);
            this.Controls.Add(this.btnNotaBuscarSalir);
            this.Controls.Add(this.btnNotaBuscarBuscar);
            this.Controls.Add(this.btnNotaBuscarLimpiar);
            this.Name = "NotaBuscar";
            this.Text = "NotaBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaBuscar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotaBuscarBuscar;
        private System.Windows.Forms.Button btnNotaBuscarLimpiar;
        private System.Windows.Forms.Label lblNotaBuscarAlumno;
        private System.Windows.Forms.TextBox txtNotaBuscarAlumno;
        private System.Windows.Forms.Label lblNotaBuscarCurso;
        private System.Windows.Forms.Button btnNotaBuscarSalir;
        private System.Windows.Forms.DataGridView dgvNotaBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNotaBuscarAlumnoBuscar;
        private System.Windows.Forms.Button btnNotaBuscarCursoBuscar;
        private System.Windows.Forms.TextBox txtNotaBuscarCurso;
    }
}