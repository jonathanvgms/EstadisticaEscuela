namespace EstadisticasEscuelaFrontEnd.Materias
{
    partial class frmMateriaModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaModificar));
            this.Datos = new System.Windows.Forms.GroupBox();
            this.lblMateriaModificarMateriaError = new System.Windows.Forms.Label();
            this.txtMateriaModificarMateria = new System.Windows.Forms.TextBox();
            this.lblMateriaModificarMateria = new System.Windows.Forms.Label();
            this.btnMateriaModificarLimpiar = new System.Windows.Forms.Button();
            this.btnMateriaModificarCancelar = new System.Windows.Forms.Button();
            this.btnMateriaModificarAceptar = new System.Windows.Forms.Button();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.lblMateriaModificarMateriaError);
            this.Datos.Controls.Add(this.txtMateriaModificarMateria);
            this.Datos.Controls.Add(this.lblMateriaModificarMateria);
            this.Datos.Location = new System.Drawing.Point(12, 27);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(453, 108);
            this.Datos.TabIndex = 0;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // lblMateriaModificarMateriaError
            // 
            this.lblMateriaModificarMateriaError.AutoSize = true;
            this.lblMateriaModificarMateriaError.Location = new System.Drawing.Point(208, 43);
            this.lblMateriaModificarMateriaError.Name = "lblMateriaModificarMateriaError";
            this.lblMateriaModificarMateriaError.Size = new System.Drawing.Size(0, 13);
            this.lblMateriaModificarMateriaError.TabIndex = 2;
            this.lblMateriaModificarMateriaError.Click += new System.EventHandler(this.lblMateriaModificarMateriaError_Click);
            // 
            // txtMateriaModificarMateria
            // 
            this.txtMateriaModificarMateria.Location = new System.Drawing.Point(101, 37);
            this.txtMateriaModificarMateria.Name = "txtMateriaModificarMateria";
            this.txtMateriaModificarMateria.Size = new System.Drawing.Size(121, 20);
            this.txtMateriaModificarMateria.TabIndex = 1;
            // 
            // lblMateriaModificarMateria
            // 
            this.lblMateriaModificarMateria.AutoSize = true;
            this.lblMateriaModificarMateria.Location = new System.Drawing.Point(24, 43);
            this.lblMateriaModificarMateria.Name = "lblMateriaModificarMateria";
            this.lblMateriaModificarMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaModificarMateria.TabIndex = 0;
            this.lblMateriaModificarMateria.Text = "Materia";
            // 
            // btnMateriaModificarLimpiar
            // 
            this.btnMateriaModificarLimpiar.Location = new System.Drawing.Point(12, 167);
            this.btnMateriaModificarLimpiar.Name = "btnMateriaModificarLimpiar";
            this.btnMateriaModificarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaModificarLimpiar.TabIndex = 1;
            this.btnMateriaModificarLimpiar.Text = "Limpiar";
            this.btnMateriaModificarLimpiar.UseVisualStyleBackColor = true;
            this.btnMateriaModificarLimpiar.Click += new System.EventHandler(this.btnMateriaModificarLimpiar_Click);
            // 
            // btnMateriaModificarCancelar
            // 
            this.btnMateriaModificarCancelar.Location = new System.Drawing.Point(390, 167);
            this.btnMateriaModificarCancelar.Name = "btnMateriaModificarCancelar";
            this.btnMateriaModificarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaModificarCancelar.TabIndex = 2;
            this.btnMateriaModificarCancelar.Text = "Cancelar";
            this.btnMateriaModificarCancelar.UseVisualStyleBackColor = true;
            this.btnMateriaModificarCancelar.Click += new System.EventHandler(this.btnMateriaModificarCancelar_Click);
            // 
            // btnMateriaModificarAceptar
            // 
            this.btnMateriaModificarAceptar.Location = new System.Drawing.Point(299, 167);
            this.btnMateriaModificarAceptar.Name = "btnMateriaModificarAceptar";
            this.btnMateriaModificarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaModificarAceptar.TabIndex = 3;
            this.btnMateriaModificarAceptar.Text = "Aceptar";
            this.btnMateriaModificarAceptar.UseVisualStyleBackColor = true;
            this.btnMateriaModificarAceptar.Click += new System.EventHandler(this.btnMateriaModificarAceptar_Click);
            // 
            // frmMateriaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 218);
            this.Controls.Add(this.btnMateriaModificarAceptar);
            this.Controls.Add(this.btnMateriaModificarCancelar);
            this.Controls.Add(this.btnMateriaModificarLimpiar);
            this.Controls.Add(this.Datos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMateriaModificar";
            this.Text = "MateriaModificar";
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.TextBox txtMateriaModificarMateria;
        private System.Windows.Forms.Label lblMateriaModificarMateria;
        private System.Windows.Forms.Button btnMateriaModificarLimpiar;
        private System.Windows.Forms.Button btnMateriaModificarCancelar;
        private System.Windows.Forms.Button btnMateriaModificarAceptar;
        private System.Windows.Forms.Label lblMateriaModificarMateriaError;
    }
}