namespace EstadisticasEscuelaFrontEnd.Cursos
{
    partial class BuscarCurso
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCursoLimpiar
            // 
            this.btnBuscarCursoLimpiar.Location = new System.Drawing.Point(57, 496);
            this.btnBuscarCursoLimpiar.Name = "btnBuscarCursoLimpiar";
            this.btnBuscarCursoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCursoLimpiar.TabIndex = 0;
            this.btnBuscarCursoLimpiar.Text = "Limpiar";
            this.btnBuscarCursoLimpiar.UseVisualStyleBackColor = true;
            this.btnBuscarCursoLimpiar.Click += new System.EventHandler(this.btnBuscarCursoLimpiar_Click);
            // 
            // btnBuscarCursoSalir
            // 
            this.btnBuscarCursoSalir.Location = new System.Drawing.Point(676, 496);
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
            this.lblBuscarCursoAnio.Location = new System.Drawing.Point(54, 32);
            this.lblBuscarCursoAnio.Name = "lblBuscarCursoAnio";
            this.lblBuscarCursoAnio.Size = new System.Drawing.Size(28, 13);
            this.lblBuscarCursoAnio.TabIndex = 2;
            this.lblBuscarCursoAnio.Text = "Anio";
            // 
            // lblBuscarCursoDivision
            // 
            this.lblBuscarCursoDivision.AutoSize = true;
            this.lblBuscarCursoDivision.Location = new System.Drawing.Point(54, 82);
            this.lblBuscarCursoDivision.Name = "lblBuscarCursoDivision";
            this.lblBuscarCursoDivision.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarCursoDivision.TabIndex = 3;
            this.lblBuscarCursoDivision.Text = "Division";
            // 
            // txtBuscarCursoAnio
            // 
            this.txtBuscarCursoAnio.Location = new System.Drawing.Point(196, 32);
            this.txtBuscarCursoAnio.Name = "txtBuscarCursoAnio";
            this.txtBuscarCursoAnio.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCursoAnio.TabIndex = 4;
            // 
            // txtBuscarCursoDivision
            // 
            this.txtBuscarCursoDivision.Location = new System.Drawing.Point(196, 79);
            this.txtBuscarCursoDivision.Name = "txtBuscarCursoDivision";
            this.txtBuscarCursoDivision.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCursoDivision.TabIndex = 5;
            // 
            // btnBuscarCursoBuscar
            // 
            this.btnBuscarCursoBuscar.Location = new System.Drawing.Point(676, 79);
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
            this.dataGridView1.Location = new System.Drawing.Point(57, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 340);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarCursoBuscar);
            this.Controls.Add(this.txtBuscarCursoDivision);
            this.Controls.Add(this.txtBuscarCursoAnio);
            this.Controls.Add(this.lblBuscarCursoDivision);
            this.Controls.Add(this.lblBuscarCursoAnio);
            this.Controls.Add(this.btnBuscarCursoSalir);
            this.Controls.Add(this.btnBuscarCursoLimpiar);
            this.Name = "BuscarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCurso";
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
    }
}