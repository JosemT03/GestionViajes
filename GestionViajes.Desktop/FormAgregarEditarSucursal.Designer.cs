namespace GestionViajes.Desktop
{
    partial class FormAgregarEditarSucursal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbProvincia = new ComboBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de Sucursal";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(40, 110);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 25);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(160, 110);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 25);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Location = new Point(42, 72);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(198, 23);
            cmbProvincia.TabIndex = 4;
            // 
            // FormAgregarEditarSucursal
            // 
            ClientSize = new Size(580, 297);
            Controls.Add(cmbProvincia);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "FormAgregarEditarSucursal";
            Text = "Sucursal";
            Load += FormAgregarEditarSucursal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private ComboBox cmbProvincia;
    }
}
