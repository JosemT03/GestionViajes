namespace GestionViajes.Desktop
{
    partial class FormPedidos
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
            dgvPedidos = new DataGridView();
            BtnAgregarPedido = new Button();
            BtnEditarPedido = new Button();
            BtnEliminarPedido = new Button();
            BtnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(35, 20);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(240, 150);
            dgvPedidos.TabIndex = 0;
            // 
            // BtnAgregarPedido
            // 
            BtnAgregarPedido.Location = new Point(44, 197);
            BtnAgregarPedido.Name = "BtnAgregarPedido";
            BtnAgregarPedido.Size = new Size(139, 23);
            BtnAgregarPedido.TabIndex = 1;
            BtnAgregarPedido.Text = "Agregar Pedido";
            BtnAgregarPedido.UseVisualStyleBackColor = true;
            BtnAgregarPedido.Click += BtnAgregarPedido_Click;
            // 
            // BtnEditarPedido
            // 
            BtnEditarPedido.Location = new Point(223, 197);
            BtnEditarPedido.Name = "BtnEditarPedido";
            BtnEditarPedido.Size = new Size(120, 23);
            BtnEditarPedido.TabIndex = 2;
            BtnEditarPedido.Text = "Editar Pedido";
            BtnEditarPedido.UseVisualStyleBackColor = true;
            BtnEditarPedido.Click += BtnEditarPedido_Click;
            // 
            // BtnEliminarPedido
            // 
            BtnEliminarPedido.Location = new Point(44, 258);
            BtnEliminarPedido.Name = "BtnEliminarPedido";
            BtnEliminarPedido.Size = new Size(139, 23);
            BtnEliminarPedido.TabIndex = 3;
            BtnEliminarPedido.Text = "Eliminar Pedido";
            BtnEliminarPedido.UseVisualStyleBackColor = true;
            BtnEliminarPedido.Click += BtnEliminarPedido_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(226, 258);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(117, 23);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnEliminarPedido);
            Controls.Add(BtnEditarPedido);
            Controls.Add(BtnAgregarPedido);
            Controls.Add(dgvPedidos);
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPedidos;
        private Button BtnAgregarPedido;
        private Button BtnEditarPedido;
        private Button BtnEliminarPedido;
        private Button BtnCerrar;
    }
}