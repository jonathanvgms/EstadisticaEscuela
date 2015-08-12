namespace EstadisticasEscuelaFrontEnd.Asistencia
{
    partial class frmAsistenciaNuevo
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
            this.lblAsistenciaBuscarPresente = new System.Windows.Forms.Label();
            this.lblAsintenciaBuscarFecha = new System.Windows.Forms.Label();
            this.txtAsistenciaBuscarPresente = new System.Windows.Forms.TextBox();
            this.txtAsistenciaBucarFecha = new System.Windows.Forms.TextBox();
            this.btnAsistenciaBuscarCancelar = new System.Windows.Forms.Button();
            this.btnAsistenciaBuscarAceptar = new System.Windows.Forms.Button();
            this.lblAsistenciaBuscarLimpiar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsistenciaBuscarPresente
            // 
            this.lblAsistenciaBuscarPresente.AutoSize = true;
            this.lblAsistenciaBuscarPresente.Location = new System.Drawing.Point(27, 31);
            this.lblAsistenciaBuscarPresente.Name = "lblAsistenciaBuscarPresente";
            this.lblAsistenciaBuscarPresente.Size = new System.Drawing.Size(49, 13);
            this.lblAsistenciaBuscarPresente.TabIndex = 0;
            this.lblAsistenciaBuscarPresente.Text = "Presente";
            // 
            // lblAsintenciaBuscarFecha
            // 
            this.lblAsintenciaBuscarFecha.AutoSize = true;
            this.lblAsintenciaBuscarFecha.Location = new System.Drawing.Point(27, 79);
            this.lblAsintenciaBuscarFecha.Name = "lblAsintenciaBuscarFecha";
            this.lblAsintenciaBuscarFecha.Size = new System.Drawing.Size(37, 13);
            this.lblAsintenciaBuscarFecha.TabIndex = 1;
            this.lblAsintenciaBuscarFecha.Text = "Fecha";
            // 
            // txtAsistenciaBuscarPresente
            // 
            this.txtAsistenciaBuscarPresente.Location = new System.Drawing.Point(245, 31);
            this.txtAsistenciaBuscarPresente.Name = "txtAsistenciaBuscarPresente";
            this.txtAsistenciaBuscarPresente.Size = new System.Drawing.Size(100, 20);
            this.txtAsistenciaBuscarPresente.TabIndex = 2;
            // 
            // txtAsistenciaBucarFecha
            // 
            this.txtAsistenciaBucarFecha.Location = new System.Drawing.Point(245, 76);
            this.txtAsistenciaBucarFecha.Name = "txtAsistenciaBucarFecha";
            this.txtAsistenciaBucarFecha.Size = new System.Drawing.Size(100, 20);
            this.txtAsistenciaBucarFecha.TabIndex = 3;
            // 
            // btnAsistenciaBuscarCancelar
            // 
            this.btnAsistenciaBuscarCancelar.Location = new System.Drawing.Point(379, 230);
            this.btnAsistenciaBuscarCancelar.Name = "btnAsistenciaBuscarCancelar";
            this.btnAsistenciaBuscarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarCancelar.TabIndex = 4;
            this.btnAsistenciaBuscarCancelar.Text = "Cancelar";
            this.btnAsistenciaBuscarCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAsistenciaBuscarAceptar
            // 
            this.btnAsistenciaBuscarAceptar.Location = new System.Drawing.Point(298, 230);
            this.btnAsistenciaBuscarAceptar.Name = "btnAsistenciaBuscarAceptar";
            this.btnAsistenciaBuscarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaBuscarAceptar.TabIndex = 5;
            this.btnAsistenciaBuscarAceptar.Text = "Aceptar";
            this.btnAsistenciaBuscarAceptar.UseVisualStyleBackColor = true;
            // 
            // lblAsistenciaBuscarLimpiar
            // 
            this.lblAsistenciaBuscarLimpiar.Location = new System.Drawing.Point(28, 230);
            this.lblAsistenciaBuscarLimpiar.Name = "lblAsistenciaBuscarLimpiar";
            this.lblAsistenciaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.lblAsistenciaBuscarLimpiar.TabIndex = 6;
            this.lblAsistenciaBuscarLimpiar.Text = "Limpiar";
            this.lblAsistenciaBuscarLimpiar.UseVisualStyleBackColor = true;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.lblAsistenciaBuscarPresente);
            this.Datos.Controls.Add(this.lblAsintenciaBuscarFecha);
            this.Datos.Controls.Add(this.txtAsistenciaBuscarPresente);
            this.Datos.Controls.Add(this.txtAsistenciaBucarFecha);
            this.Datos.Location = new System.Drawing.Point(28, 31);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(381, 130);
            this.Datos.TabIndex = 7;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // frmAsistenciaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 265);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.lblAsistenciaBuscarLimpiar);
            this.Controls.Add(this.btnAsistenciaBuscarAceptar);
            this.Controls.Add(this.btnAsistenciaBuscarCancelar);
            this.Name = "frmAsistenciaNuevo";
            this.Text = "AsistenciaNuevo";
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAsistenciaBuscarPresente;
        private System.Windows.Forms.Label lblAsintenciaBuscarFecha;
        private System.Windows.Forms.TextBox txtAsistenciaBuscarPresente;
        private System.Windows.Forms.TextBox txtAsistenciaBucarFecha;
        private System.Windows.Forms.Button btnAsistenciaBuscarCancelar;
        private System.Windows.Forms.Button btnAsistenciaBuscarAceptar;
        private System.Windows.Forms.Button lblAsistenciaBuscarLimpiar;
        private System.Windows.Forms.GroupBox Datos;
    }
}