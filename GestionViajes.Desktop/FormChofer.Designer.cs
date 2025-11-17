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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChofer));
            lblTitulo = new Label();
            dgvPedidosChofer = new DataGridView();
            btnActualizarEstado = new Button();
            cbNuevoEstado = new ComboBox();
            btnRefrescar = new Button();
            btnCerrarSesion = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosChofer).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(294, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(204, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pedidos Asignados ";
            // 
            // dgvPedidosChofer
            // 
            dgvPedidosChofer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidosChofer.Location = new Point(6, 22);
            dgvPedidosChofer.Name = "dgvPedidosChofer";
            dgvPedidosChofer.Size = new Size(546, 247);
            dgvPedidosChofer.TabIndex = 1;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.BackColor = Color.LightGray;
            btnActualizarEstado.Cursor = Cursors.Hand;
            btnActualizarEstado.FlatAppearance.BorderSize = 0;
            btnActualizarEstado.FlatStyle = FlatStyle.Flat;
            btnActualizarEstado.Location = new Point(37, 35);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(114, 35);
            btnActualizarEstado.TabIndex = 2;
            btnActualizarEstado.Text = "Cambiar Estado";
            btnActualizarEstado.UseVisualStyleBackColor = false;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // cbNuevoEstado
            // 
            cbNuevoEstado.FormattingEnabled = true;
            cbNuevoEstado.Location = new Point(37, 88);
            cbNuevoEstado.Name = "cbNuevoEstado";
            cbNuevoEstado.Size = new Size(114, 23);
            cbNuevoEstado.TabIndex = 3;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.LightGray;
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Location = new Point(37, 137);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(114, 35);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Recargar Pedidos";
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.LightGray;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(37, 218);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(114, 35);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPedidosChofer);
            groupBox1.Location = new Point(230, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 275);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRefrescar);
            groupBox2.Controls.Add(btnActualizarEstado);
            groupBox2.Controls.Add(cbNuevoEstado);
            groupBox2.Controls.Add(btnCerrarSesion);
            groupBox2.Location = new Point(12, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 275);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormChofer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChofer";
            Text = "FormChofer";
            ((System.ComponentModel.ISupportInitialize)dgvPedidosChofer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvPedidosChofer;
        private Button btnActualizarEstado;
        private ComboBox cbNuevoEstado;
        private Button btnRefrescar;
        private Button btnCerrarSesion;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}