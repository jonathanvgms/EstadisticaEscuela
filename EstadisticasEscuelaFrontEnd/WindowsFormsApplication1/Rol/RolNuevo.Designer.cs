namespace EstadisticasEscuelaFrontEnd.Rol
{
    partial class frmRolNuevo
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
            this.btnRolNuevoAceptar = new System.Windows.Forms.Button();
            this.btnRolNuevoDesmarcar = new System.Windows.Forms.Button();
            this.btnRolNuevoCancelar = new System.Windows.Forms.Button();
            this.clbRolNuevo = new System.Windows.Forms.CheckedListBox();
            this.lblSeleccioneRol = new System.Windows.Forms.Label();
            this.gpbDatosRol = new System.Windows.Forms.GroupBox();
            this.txtRolNuevoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRolNuevoNombreError = new System.Windows.Forms.Label();
            this.gpbDatosRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRolNuevoAceptar
            // 
            this.btnRolNuevoAceptar.Location = new System.Drawing.Point(280, 205);
            this.btnRolNuevoAceptar.Name = "btnRolNuevoAceptar";
            this.btnRolNuevoAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnRolNuevoAceptar.TabIndex = 0;
            this.btnRolNuevoAceptar.Text = "Aceptar";
            this.btnRolNuevoAceptar.UseVisualStyleBackColor = true;
            this.btnRolNuevoAceptar.Click += new System.EventHandler(this.btnRolNuevoAceptar_Click);
            // 
            // btnRolNuevoDesmarcar
            // 
            this.btnRolNuevoDesmarcar.Location = new System.Drawing.Point(148, 205);
            this.btnRolNuevoDesmarcar.Name = "btnRolNuevoDesmarcar";
            this.btnRolNuevoDesmarcar.Size = new System.Drawing.Size(75, 23);
            this.btnRolNuevoDesmarcar.TabIndex = 1;
            this.btnRolNuevoDesmarcar.Text = "Desmarcar";
            this.btnRolNuevoDesmarcar.UseVisualStyleBackColor = true;
            this.btnRolNuevoDesmarcar.Click += new System.EventHandler(this.btnRolNuevoDesmarcar_Click);
            // 
            // btnRolNuevoCancelar
            // 
            this.btnRolNuevoCancelar.Location = new System.Drawing.Point(12, 205);
            this.btnRolNuevoCancelar.Name = "btnRolNuevoCancelar";
            this.btnRolNuevoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnRolNuevoCancelar.TabIndex = 2;
            this.btnRolNuevoCancelar.Text = "Cancelar";
            this.btnRolNuevoCancelar.UseVisualStyleBackColor = true;
            this.btnRolNuevoCancelar.Click += new System.EventHandler(this.btnRolNuevoCancelar_Click);
            // 
            // clbRolNuevo
            // 
            this.clbRolNuevo.FormattingEnabled = true;
            this.clbRolNuevo.Items.AddRange(new object[] {
            "Usuario",
            "Rol",
            "Cursos",
            "Materias",
            "Alumnos",
            "Asistencias",
            "Notas"});
            this.clbRolNuevo.Location = new System.Drawing.Point(147, 62);
            this.clbRolNuevo.Name = "clbRolNuevo";
            this.clbRolNuevo.Size = new System.Drawing.Size(105, 109);
            this.clbRolNuevo.TabIndex = 3;
            // 
            // lblSeleccioneRol
            // 
            this.lblSeleccioneRol.AutoSize = true;
            this.lblSeleccioneRol.Location = new System.Drawing.Point(41, 62);
            this.lblSeleccioneRol.Name = "lblSeleccioneRol";
            this.lblSeleccioneRol.Size = new System.Drawing.Size(82, 13);
            this.lblSeleccioneRol.TabIndex = 5;
            this.lblSeleccioneRol.Text = "Seleccione Rol:";
            // 
            // gpbDatosRol
            // 
            this.gpbDatosRol.Controls.Add(this.lblRolNuevoNombreError);
            this.gpbDatosRol.Controls.Add(this.label1);
            this.gpbDatosRol.Controls.Add(this.txtRolNuevoNombre);
            this.gpbDatosRol.Controls.Add(this.lblSeleccioneRol);
            this.gpbDatosRol.Controls.Add(this.clbRolNuevo);
            this.gpbDatosRol.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosRol.Name = "gpbDatosRol";
            this.gpbDatosRol.Size = new System.Drawing.Size(343, 177);
            this.gpbDatosRol.TabIndex = 4;
            this.gpbDatosRol.TabStop = false;
            this.gpbDatosRol.Text = "Datos Rol";
            // 
            // txtRolNuevoNombre
            // 
            this.txtRolNuevoNombre.Location = new System.Drawing.Point(67, 19);
            this.txtRolNuevoNombre.Name = "txtRolNuevoNombre";
            this.txtRolNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtRolNuevoNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // lblRolNuevoNombreError
            // 
            this.lblRolNuevoNombreError.AutoSize = true;
            this.lblRolNuevoNombreError.Location = new System.Drawing.Point(185, 22);
            this.lblRolNuevoNombreError.Name = "lblRolNuevoNombreError";
            this.lblRolNuevoNombreError.Size = new System.Drawing.Size(0, 13);
            this.lblRolNuevoNombreError.TabIndex = 8;
            // 
            // frmRolNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 245);
            this.Controls.Add(this.gpbDatosRol);
            this.Controls.Add(this.btnRolNuevoCancelar);
            this.Controls.Add(this.btnRolNuevoDesmarcar);
            this.Controls.Add(this.btnRolNuevoAceptar);
            this.Name = "frmRolNuevo";
            this.Text = "RolNuevo";
            this.gpbDatosRol.ResumeLayout(false);
            this.gpbDatosRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRolNuevoAceptar;
        private System.Windows.Forms.Button btnRolNuevoDesmarcar;
        private System.Windows.Forms.Button btnRolNuevoCancelar;
        private System.Windows.Forms.CheckedListBox clbRolNuevo;
        private System.Windows.Forms.Label lblSeleccioneRol;
        private System.Windows.Forms.GroupBox gpbDatosRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRolNuevoNombre;
        private System.Windows.Forms.Label lblRolNuevoNombreError;
    }
}