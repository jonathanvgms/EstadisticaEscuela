namespace EstadisticasEscuelaFrontEnd.Rol
{
    partial class frmRolBuscar
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
            this.dgvRolBuscar = new System.Windows.Forms.DataGridView();
            this.btnRolBuscarBuscar = new System.Windows.Forms.Button();
            this.btnRolBuscarAceptar = new System.Windows.Forms.Button();
            this.btnRolBuscarCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRolBuscarNombre = new System.Windows.Forms.TextBox();
            this.lblRolBuscarNombre = new System.Windows.Forms.Label();
            this.btnRolBuscarLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolBuscar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRolBuscar
            // 
            this.dgvRolBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolBuscar.Location = new System.Drawing.Point(12, 148);
            this.dgvRolBuscar.Name = "dgvRolBuscar";
            this.dgvRolBuscar.Size = new System.Drawing.Size(625, 307);
            this.dgvRolBuscar.TabIndex = 0;
            this.dgvRolBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionRol);
            // 
            // btnRolBuscarBuscar
            // 
            this.btnRolBuscarBuscar.Location = new System.Drawing.Point(258, 29);
            this.btnRolBuscarBuscar.Name = "btnRolBuscarBuscar";
            this.btnRolBuscarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnRolBuscarBuscar.TabIndex = 1;
            this.btnRolBuscarBuscar.Text = "Buscar";
            this.btnRolBuscarBuscar.UseVisualStyleBackColor = true;
            // 
            // btnRolBuscarAceptar
            // 
            this.btnRolBuscarAceptar.Location = new System.Drawing.Point(562, 119);
            this.btnRolBuscarAceptar.Name = "btnRolBuscarAceptar";
            this.btnRolBuscarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnRolBuscarAceptar.TabIndex = 2;
            this.btnRolBuscarAceptar.Text = "Aceptar";
            this.btnRolBuscarAceptar.UseVisualStyleBackColor = true;
            this.btnRolBuscarAceptar.Click += new System.EventHandler(this.btnRolBuscarAceptar_Click);
            // 
            // btnRolBuscarCancelar
            // 
            this.btnRolBuscarCancelar.Location = new System.Drawing.Point(12, 461);
            this.btnRolBuscarCancelar.Name = "btnRolBuscarCancelar";
            this.btnRolBuscarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnRolBuscarCancelar.TabIndex = 3;
            this.btnRolBuscarCancelar.Text = "Cancelar";
            this.btnRolBuscarCancelar.UseVisualStyleBackColor = true;
            this.btnRolBuscarCancelar.Click += new System.EventHandler(this.btnRolBuscarCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRolBuscarNombre);
            this.groupBox1.Controls.Add(this.lblRolBuscarNombre);
            this.groupBox1.Controls.Add(this.btnRolBuscarBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busqueda";
            // 
            // txtRolBuscarNombre
            // 
            this.txtRolBuscarNombre.Location = new System.Drawing.Point(57, 32);
            this.txtRolBuscarNombre.Name = "txtRolBuscarNombre";
            this.txtRolBuscarNombre.Size = new System.Drawing.Size(192, 20);
            this.txtRolBuscarNombre.TabIndex = 3;
            // 
            // lblRolBuscarNombre
            // 
            this.lblRolBuscarNombre.AutoSize = true;
            this.lblRolBuscarNombre.Location = new System.Drawing.Point(7, 32);
            this.lblRolBuscarNombre.Name = "lblRolBuscarNombre";
            this.lblRolBuscarNombre.Size = new System.Drawing.Size(44, 13);
            this.lblRolBuscarNombre.TabIndex = 2;
            this.lblRolBuscarNombre.Text = "Nombre";
            // 
            // btnRolBuscarLimpiar
            // 
            this.btnRolBuscarLimpiar.Location = new System.Drawing.Point(12, 119);
            this.btnRolBuscarLimpiar.Name = "btnRolBuscarLimpiar";
            this.btnRolBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnRolBuscarLimpiar.TabIndex = 5;
            this.btnRolBuscarLimpiar.Text = "Limpiar";
            this.btnRolBuscarLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmRolBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 495);
            this.Controls.Add(this.btnRolBuscarLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRolBuscarCancelar);
            this.Controls.Add(this.btnRolBuscarAceptar);
            this.Controls.Add(this.dgvRolBuscar);
            this.Name = "frmRolBuscar";
            this.Text = "RolBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolBuscar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRolBuscar;
        private System.Windows.Forms.Button btnRolBuscarBuscar;
        private System.Windows.Forms.Button btnRolBuscarAceptar;
        private System.Windows.Forms.Button btnRolBuscarCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRolBuscarNombre;
        private System.Windows.Forms.Label lblRolBuscarNombre;
        private System.Windows.Forms.Button btnRolBuscarLimpiar;
    }
}