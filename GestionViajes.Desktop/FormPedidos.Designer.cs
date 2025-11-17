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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            dgvPedidos = new DataGridView();
            BtnAgregarPedido = new Button();
            BtnEditarPedido = new Button();
            BtnEliminarPedido = new Button();
            BtnCerrar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(6, 22);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(529, 232);
            dgvPedidos.TabIndex = 0;
            // 
            // BtnAgregarPedido
            // 
            BtnAgregarPedido.BackColor = Color.LightGray;
            BtnAgregarPedido.Cursor = Cursors.Hand;
            BtnAgregarPedido.FlatAppearance.BorderSize = 0;
            BtnAgregarPedido.FlatStyle = FlatStyle.Flat;
            BtnAgregarPedido.Location = new Point(23, 32);
            BtnAgregarPedido.Name = "BtnAgregarPedido";
            BtnAgregarPedido.Size = new Size(114, 35);
            BtnAgregarPedido.TabIndex = 1;
            BtnAgregarPedido.Text = "Agregar Pedido";
            BtnAgregarPedido.UseVisualStyleBackColor = false;
            BtnAgregarPedido.Click += BtnAgregarPedido_Click;
            // 
            // BtnEditarPedido
            // 
            BtnEditarPedido.BackColor = Color.LightGray;
            BtnEditarPedido.Cursor = Cursors.Hand;
            BtnEditarPedido.FlatAppearance.BorderSize = 0;
            BtnEditarPedido.FlatStyle = FlatStyle.Flat;
            BtnEditarPedido.Location = new Point(23, 114);
            BtnEditarPedido.Name = "BtnEditarPedido";
            BtnEditarPedido.Size = new Size(114, 35);
            BtnEditarPedido.TabIndex = 2;
            BtnEditarPedido.Text = "Editar Pedido";
            BtnEditarPedido.UseVisualStyleBackColor = false;
            BtnEditarPedido.Click += BtnEditarPedido_Click;
            // 
            // BtnEliminarPedido
            // 
            BtnEliminarPedido.BackColor = Color.LightGray;
            BtnEliminarPedido.Cursor = Cursors.Hand;
            BtnEliminarPedido.FlatAppearance.BorderSize = 0;
            BtnEliminarPedido.FlatStyle = FlatStyle.Flat;
            BtnEliminarPedido.Location = new Point(23, 73);
            BtnEliminarPedido.Name = "BtnEliminarPedido";
            BtnEliminarPedido.Size = new Size(114, 35);
            BtnEliminarPedido.TabIndex = 3;
            BtnEliminarPedido.Text = "Eliminar Pedido";
            BtnEliminarPedido.UseVisualStyleBackColor = false;
            BtnEliminarPedido.Click += BtnEliminarPedido_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.BackColor = Color.LightGray;
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Location = new Point(23, 201);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(114, 35);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(318, 46);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 6;
            label1.Text = "Gestion de Pedidos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnAgregarPedido);
            groupBox1.Controls.Add(BtnEliminarPedido);
            groupBox1.Controls.Add(BtnEditarPedido);
            groupBox1.Controls.Add(BtnCerrar);
            groupBox1.Location = new Point(30, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 248);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPedidos);
            groupBox2.Location = new Point(247, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 260);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pedidos";
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedidos;
        private Button BtnAgregarPedido;
        private Button BtnEditarPedido;
        private Button BtnEliminarPedido;
        private Button BtnCerrar;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}