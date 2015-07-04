namespace EstadisticasEscuelaFrontEnd.Login
{
    partial class FormLogin
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
            this.btnLoginOk = new System.Windows.Forms.Button();
            this.txtLoginNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblLoginContrasenia = new System.Windows.Forms.Label();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginOk
            // 
            this.btnLoginOk.Location = new System.Drawing.Point(216, 170);
            this.btnLoginOk.Name = "btnLoginOk";
            this.btnLoginOk.Size = new System.Drawing.Size(75, 23);
            this.btnLoginOk.TabIndex = 0;
            this.btnLoginOk.Text = "Aceptar";
            this.btnLoginOk.UseVisualStyleBackColor = true;
            this.btnLoginOk.Click += new System.EventHandler(this.btnLoginOk_Click);
            // 
            // txtLoginNo
            // 
            this.txtLoginNo.Location = new System.Drawing.Point(309, 170);
            this.txtLoginNo.Name = "txtLoginNo";
            this.txtLoginNo.Size = new System.Drawing.Size(75, 23);
            this.txtLoginNo.TabIndex = 1;
            this.txtLoginNo.Text = "Cancelar";
            this.txtLoginNo.UseVisualStyleBackColor = true;
            this.txtLoginNo.Click += new System.EventHandler(this.txtLoginNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(155, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(193, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Location = new System.Drawing.Point(365, 43);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblLoginUsuario.TabIndex = 7;
            // 
            // lblLoginContrasenia
            // 
            this.lblLoginContrasenia.AutoSize = true;
            this.lblLoginContrasenia.Location = new System.Drawing.Point(365, 81);
            this.lblLoginContrasenia.Name = "lblLoginContrasenia";
            this.lblLoginContrasenia.Size = new System.Drawing.Size(0, 13);
            this.lblLoginContrasenia.TabIndex = 8;
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Location = new System.Drawing.Point(152, 122);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(0, 13);
            this.lblLoginError.TabIndex = 9;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLoginOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(422, 205);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.lblLoginContrasenia);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginNo);
            this.Controls.Add(this.btnLoginOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PresionarTecla);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginOk;
        private System.Windows.Forms.Button txtLoginNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label lblLoginContrasenia;
        private System.Windows.Forms.Label lblLoginError;
    }
}