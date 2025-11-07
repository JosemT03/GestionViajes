namespace GestionViajes.Desktop
{
    partial class FormAgregarEditarChofer
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
            label1 = new Label();
            txtNombreCompleto = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            chkDisponible = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtDNI = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(95, 40);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(100, 23);
            txtNombreCompleto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 104);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(95, 96);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(52, 183);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(82, 19);
            chkDisponible.TabIndex = 4;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(177, 179);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(177, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(95, 138);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 146);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 9;
            label3.Text = "DNI";
            // 
            // FormAgregarEditarChofer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtDNI);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkDisponible);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label1);
            Name = "FormAgregarEditarChofer";
            Text = "FormAgregarEditarChofer";
            Load += FormAgregarEditarChofer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCompleto;
        private Label label2;
        private TextBox txtTelefono;
        private CheckBox chkDisponible;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtDNI;
        private Label label3;
    }
}