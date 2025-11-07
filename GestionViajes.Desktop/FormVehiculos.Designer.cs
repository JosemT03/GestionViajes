namespace GestionViajes.Desktop
{
    partial class FormVehiculos
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
            dgvVehiculos = new DataGridView();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Dock = DockStyle.Top;
            dgvVehiculos.Location = new Point(0, 0);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.Size = new Size(800, 150);
            dgvVehiculos.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(34, 173);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(139, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar Vehículo";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(235, 173);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(127, 23);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar Vehículo";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(45, 226);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(128, 23);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar Vehículo";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(236, 229);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(126, 23);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // FormVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(dgvVehiculos);
            Name = "FormVehiculos";
            Text = "FormVehiculos";
            Load += FormVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVehiculos;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnCerrar;
    }
}