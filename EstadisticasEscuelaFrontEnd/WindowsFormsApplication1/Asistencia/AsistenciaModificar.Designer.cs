namespace EstadisticasEscuelaFrontEnd.Cursos
{
    partial class frmAsistenciaModificar
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
            this.lblAsistenciaPresenteNuevo = new System.Windows.Forms.Label();
            this.lblAsistenciaFechaNuevo = new System.Windows.Forms.Label();
            this.txtAsistenciaModificarPresente = new System.Windows.Forms.TextBox();
            this.txtAsistenciaModificarFacha = new System.Windows.Forms.TextBox();
            this.btnAsistenciaModificarLimpiar = new System.Windows.Forms.Button();
            this.btnAsistenciaModificarAcepar = new System.Windows.Forms.Button();
            this.btnAsistenciaModificarCancelar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.lblAsistenciaModificarFechaError = new System.Windows.Forms.Label();
            this.lblAsistenciaModificarPresenteError = new System.Windows.Forms.Label();
            this.lblAsistenciaModificarMensajeError = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsistenciaPresenteNuevo
            // 
            this.lblAsistenciaPresenteNuevo.AutoSize = true;
            this.lblAsistenciaPresenteNuevo.Location = new System.Drawing.Point(36, 29);
            this.lblAsistenciaPresenteNuevo.Name = "lblAsistenciaPresenteNuevo";
            this.lblAsistenciaPresenteNuevo.Size = new System.Drawing.Size(49, 13);
            this.lblAsistenciaPresenteNuevo.TabIndex = 0;
            this.lblAsistenciaPresenteNuevo.Text = "Presente";
            // 
            // lblAsistenciaFechaNuevo
            // 
            this.lblAsistenciaFechaNuevo.AutoSize = true;
            this.lblAsistenciaFechaNuevo.Location = new System.Drawing.Point(36, 85);
            this.lblAsistenciaFechaNuevo.Name = "lblAsistenciaFechaNuevo";
            this.lblAsistenciaFechaNuevo.Size = new System.Drawing.Size(37, 13);
            this.lblAsistenciaFechaNuevo.TabIndex = 1;
            this.lblAsistenciaFechaNuevo.Text = "Fecha";
            // 
            // txtAsistenciaModificarPresente
            // 
            this.txtAsistenciaModificarPresente.Location = new System.Drawing.Point(141, 26);
            this.txtAsistenciaModificarPresente.Name = "txtAsistenciaModificarPresente";
            this.txtAsistenciaModificarPresente.Size = new System.Drawing.Size(131, 20);
            this.txtAsistenciaModificarPresente.TabIndex = 2;
            // 
            // txtAsistenciaModificarFacha
            // 
            this.txtAsistenciaModificarFacha.Location = new System.Drawing.Point(153, 199);
            this.txtAsistenciaModificarFacha.Name = "txtAsistenciaModificarFacha";
            this.txtAsistenciaModificarFacha.Size = new System.Drawing.Size(131, 20);
            this.txtAsistenciaModificarFacha.TabIndex = 3;
            // 
            // btnAsistenciaModificarLimpiar
            // 
            this.btnAsistenciaModificarLimpiar.Location = new System.Drawing.Point(10, 249);
            this.btnAsistenciaModificarLimpiar.Name = "btnAsistenciaModificarLimpiar";
            this.btnAsistenciaModificarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaModificarLimpiar.TabIndex = 4;
            this.btnAsistenciaModificarLimpiar.Text = "Limpiar";
            this.btnAsistenciaModificarLimpiar.UseVisualStyleBackColor = true;
            this.btnAsistenciaModificarLimpiar.Click += new System.EventHandler(this.btnAsistenciaModificarLimpiar_Click);
            // 
            // btnAsistenciaModificarAcepar
            // 
            this.btnAsistenciaModificarAcepar.Location = new System.Drawing.Point(287, 249);
            this.btnAsistenciaModificarAcepar.Name = "btnAsistenciaModificarAcepar";
            this.btnAsistenciaModificarAcepar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaModificarAcepar.TabIndex = 5;
            this.btnAsistenciaModificarAcepar.Text = "Aceptar";
            this.btnAsistenciaModificarAcepar.UseVisualStyleBackColor = true;
            // 
            // btnAsistenciaModificarCancelar
            // 
            this.btnAsistenciaModificarCancelar.Location = new System.Drawing.Point(409, 249);
            this.btnAsistenciaModificarCancelar.Name = "btnAsistenciaModificarCancelar";
            this.btnAsistenciaModificarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAsistenciaModificarCancelar.TabIndex = 6;
            this.btnAsistenciaModificarCancelar.Text = "Cancelar";
            this.btnAsistenciaModificarCancelar.UseVisualStyleBackColor = true;
            this.btnAsistenciaModificarCancelar.Click += new System.EventHandler(this.btnAsistenciaModificarCancelar_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.dateTimePicker1);
            this.Datos.Controls.Add(this.lblAsistenciaModificarFechaError);
            this.Datos.Controls.Add(this.lblAsistenciaModificarPresenteError);
            this.Datos.Controls.Add(this.lblAsistenciaPresenteNuevo);
            this.Datos.Controls.Add(this.lblAsistenciaFechaNuevo);
            this.Datos.Controls.Add(this.txtAsistenciaModificarPresente);
            this.Datos.Location = new System.Drawing.Point(12, 27);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(470, 159);
            this.Datos.TabIndex = 7;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // lblAsistenciaModificarFechaError
            // 
            this.lblAsistenciaModificarFechaError.AutoSize = true;
            this.lblAsistenciaModificarFechaError.Location = new System.Drawing.Point(303, 91);
            this.lblAsistenciaModificarFechaError.Name = "lblAsistenciaModificarFechaError";
            this.lblAsistenciaModificarFechaError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaModificarFechaError.TabIndex = 5;
            // 
            // lblAsistenciaModificarPresenteError
            // 
            this.lblAsistenciaModificarPresenteError.AutoSize = true;
            this.lblAsistenciaModificarPresenteError.Location = new System.Drawing.Point(300, 35);
            this.lblAsistenciaModificarPresenteError.Name = "lblAsistenciaModificarPresenteError";
            this.lblAsistenciaModificarPresenteError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaModificarPresenteError.TabIndex = 4;
            // 
            // lblAsistenciaModificarMensajeError
            // 
            this.lblAsistenciaModificarMensajeError.AutoSize = true;
            this.lblAsistenciaModificarMensajeError.Location = new System.Drawing.Point(51, 206);
            this.lblAsistenciaModificarMensajeError.Name = "lblAsistenciaModificarMensajeError";
            this.lblAsistenciaModificarMensajeError.Size = new System.Drawing.Size(0, 13);
            this.lblAsistenciaModificarMensajeError.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // frmAsistenciaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 306);
            this.Controls.Add(this.lblAsistenciaModificarMensajeError);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.btnAsistenciaModificarCancelar);
            this.Controls.Add(this.btnAsistenciaModificarAcepar);
            this.Controls.Add(this.btnAsistenciaModificarLimpiar);
            this.Controls.Add(this.txtAsistenciaModificarFacha);
            this.Name = "frmAsistenciaModificar";
            this.Text = "AsistenciaModificar";
            this.Load += new System.EventHandler(this.frmAsistenciaModificar_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsistenciaPresenteNuevo;
        private System.Windows.Forms.Label lblAsistenciaFechaNuevo;
        private System.Windows.Forms.TextBox txtAsistenciaModificarPresente;
        private System.Windows.Forms.TextBox txtAsistenciaModificarFacha;
        private System.Windows.Forms.Button btnAsistenciaModificarLimpiar;
        private System.Windows.Forms.Button btnAsistenciaModificarAcepar;
        private System.Windows.Forms.Button btnAsistenciaModificarCancelar;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label lblAsistenciaModificarFechaError;
        private System.Windows.Forms.Label lblAsistenciaModificarPresenteError;
        private System.Windows.Forms.Label lblAsistenciaModificarMensajeError;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}