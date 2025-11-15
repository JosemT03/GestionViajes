namespace GestionViajes.Desktop
{
    partial class FormChofer
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
            lblTitulo = new Label();
            dgvPedidosChofer = new DataGridView();
            btnActualizarEstado = new Button();
            cbNuevoEstado = new ComboBox();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosChofer).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(56, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(127, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mis pedidos asignados";
            // 
            // dgvPedidosChofer
            // 
            dgvPedidosChofer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidosChofer.Location = new Point(209, 42);
            dgvPedidosChofer.Name = "dgvPedidosChofer";
            dgvPedidosChofer.Size = new Size(438, 150);
            dgvPedidosChofer.TabIndex = 1;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.Location = new Point(56, 222);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(127, 23);
            btnActualizarEstado.TabIndex = 2;
            btnActualizarEstado.Text = "Cambiar Estado";
            btnActualizarEstado.UseVisualStyleBackColor = true;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // cbNuevoEstado
            // 
            cbNuevoEstado.FormattingEnabled = true;
            cbNuevoEstado.Location = new Point(63, 272);
            cbNuevoEstado.Name = "cbNuevoEstado";
            cbNuevoEstado.Size = new Size(121, 23);
            cbNuevoEstado.TabIndex = 3;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(67, 321);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(116, 23);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Recargar Pedidos";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // FormChofer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefrescar);
            Controls.Add(cbNuevoEstado);
            Controls.Add(btnActualizarEstado);
            Controls.Add(dgvPedidosChofer);
            Controls.Add(lblTitulo);
            Name = "FormChofer";
            Text = "FormChofer";
            ((System.ComponentModel.ISupportInitialize)dgvPedidosChofer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvPedidosChofer;
        private Button btnActualizarEstado;
        private ComboBox cbNuevoEstado;
        private Button btnRefrescar;
    }
}