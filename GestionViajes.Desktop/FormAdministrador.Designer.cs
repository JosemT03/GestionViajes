namespace GestionViajes.Desktop
{
    partial class FormAdministrador
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
            lblBienvenida = new Label();
            btnCerrarSesion = new Button();
            btnGestionarUsuarios = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(22, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(66, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(22, 389);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(154, 23);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnGestionarUsuarios
            // 
            btnGestionarUsuarios.Location = new Point(22, 149);
            btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            btnGestionarUsuarios.Size = new Size(203, 23);
            btnGestionarUsuarios.TabIndex = 2;
            btnGestionarUsuarios.Text = "Gestionar Usuarios";
            btnGestionarUsuarios.UseVisualStyleBackColor = true;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionarUsuarios);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblBienvenida);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            Load += FormAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnCerrarSesion;
        private Button btnGestionarUsuarios;
    }
}