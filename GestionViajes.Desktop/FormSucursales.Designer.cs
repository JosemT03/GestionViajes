namespace GestionViajes.Desktop
{
    partial class FormSucursales
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
            dgvSucursales = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            SuspendLayout();
            // 
            // dgvSucursales
            // 
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Location = new Point(12, 12);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.Size = new Size(460, 200);
            dgvSucursales.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 230);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 25);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(128, 230);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 25);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(244, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 25);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(372, 230);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 25);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormSucursales
            // 
            ClientSize = new Size(695, 569);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvSucursales);
            Name = "FormSucursales";
            Text = "Gestionar Sucursales";
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvSucursales;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
