namespace GestionViajes.Desktop
{
    partial class FormAdministrador
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            lblBienvenida = new Label();
            btnCerrarSesion = new Button();
            btnGestionarUsuarios = new Button();
            btnGestionarChoferes = new Button();
            btnGestionarVehiculos = new Button();
            BtnPedidos = new Button();
            BtnHistorial = new Button();
            btnInformeEstadistico = new Button();
            btnSucursales = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.ControlText;
            lblBienvenida.Location = new Point(30, 131);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(110, 25);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido:";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.LightGray;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(30, 643);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(219, 45);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnGestionarUsuarios
            // 
            btnGestionarUsuarios.BackColor = Color.LightGray;
            btnGestionarUsuarios.Cursor = Cursors.Hand;
            btnGestionarUsuarios.FlatAppearance.BorderSize = 0;
            btnGestionarUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestionarUsuarios.Location = new Point(30, 244);
            btnGestionarUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            btnGestionarUsuarios.Size = new Size(219, 45);
            btnGestionarUsuarios.TabIndex = 2;
            btnGestionarUsuarios.Text = "Gestionar Usuarios";
            btnGestionarUsuarios.UseVisualStyleBackColor = false;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            // 
            // btnGestionarChoferes
            // 
            btnGestionarChoferes.BackColor = Color.LightGray;
            btnGestionarChoferes.Cursor = Cursors.Hand;
            btnGestionarChoferes.FlatAppearance.BorderSize = 0;
            btnGestionarChoferes.FlatStyle = FlatStyle.Flat;
            btnGestionarChoferes.Location = new Point(30, 297);
            btnGestionarChoferes.Margin = new Padding(3, 4, 3, 4);
            btnGestionarChoferes.Name = "btnGestionarChoferes";
            btnGestionarChoferes.Size = new Size(219, 45);
            btnGestionarChoferes.TabIndex = 3;
            btnGestionarChoferes.Text = "Gestionar Choferes";
            btnGestionarChoferes.UseVisualStyleBackColor = false;
            btnGestionarChoferes.Click += btnGestionarChoferes_Click;
            // 
            // btnGestionarVehiculos
            // 
            btnGestionarVehiculos.BackColor = Color.LightGray;
            btnGestionarVehiculos.Cursor = Cursors.Hand;
            btnGestionarVehiculos.FlatAppearance.BorderSize = 0;
            btnGestionarVehiculos.FlatStyle = FlatStyle.Flat;
            btnGestionarVehiculos.Font = new Font("Segoe UI", 10F);
            btnGestionarVehiculos.Location = new Point(30, 509);
            btnGestionarVehiculos.Margin = new Padding(3, 4, 3, 4);
            btnGestionarVehiculos.Name = "btnGestionarVehiculos";
            btnGestionarVehiculos.Size = new Size(219, 45);
            btnGestionarVehiculos.TabIndex = 4;
            btnGestionarVehiculos.Text = "Gestionar Vehículos";
            btnGestionarVehiculos.UseVisualStyleBackColor = false;
            btnGestionarVehiculos.Click += btnGestionarVehiculos_Click;
            // 
            // BtnPedidos
            // 
            BtnPedidos.BackColor = Color.LightGray;
            BtnPedidos.Cursor = Cursors.Hand;
            BtnPedidos.FlatAppearance.BorderSize = 0;
            BtnPedidos.FlatStyle = FlatStyle.Flat;
            BtnPedidos.Location = new Point(30, 349);
            BtnPedidos.Margin = new Padding(3, 4, 3, 4);
            BtnPedidos.Name = "BtnPedidos";
            BtnPedidos.Size = new Size(219, 45);
            BtnPedidos.TabIndex = 5;
            BtnPedidos.Text = "Gestionar Pedido";
            BtnPedidos.UseVisualStyleBackColor = false;
            BtnPedidos.Click += BtnPedidos_Click;
            // 
            // BtnHistorial
            // 
            BtnHistorial.BackColor = Color.LightGray;
            BtnHistorial.Cursor = Cursors.Hand;
            BtnHistorial.FlatAppearance.BorderSize = 0;
            BtnHistorial.FlatStyle = FlatStyle.Flat;
            BtnHistorial.ForeColor = Color.Black;
            BtnHistorial.Location = new Point(30, 191);
            BtnHistorial.Margin = new Padding(3, 4, 3, 4);
            BtnHistorial.Name = "BtnHistorial";
            BtnHistorial.Size = new Size(219, 45);
            BtnHistorial.TabIndex = 6;
            BtnHistorial.Text = "Historial";
            BtnHistorial.UseVisualStyleBackColor = false;
            BtnHistorial.Click += BtnHistorial_Click;
            // 
            // btnInformeEstadistico
            // 
            btnInformeEstadistico.BackColor = Color.LightGray;
            btnInformeEstadistico.Cursor = Cursors.Hand;
            btnInformeEstadistico.FlatAppearance.BorderSize = 0;
            btnInformeEstadistico.FlatStyle = FlatStyle.Flat;
            btnInformeEstadistico.Location = new Point(30, 403);
            btnInformeEstadistico.Margin = new Padding(3, 4, 3, 4);
            btnInformeEstadistico.Name = "btnInformeEstadistico";
            btnInformeEstadistico.Size = new Size(219, 45);
            btnInformeEstadistico.TabIndex = 7;
            btnInformeEstadistico.Text = "Informe Estadístico";
            btnInformeEstadistico.UseVisualStyleBackColor = false;
            btnInformeEstadistico.Click += btnInformeEstadistico_Click;
            // 
            // btnSucursales
            // 
            btnSucursales.BackColor = Color.LightGray;
            btnSucursales.Cursor = Cursors.Hand;
            btnSucursales.FlatAppearance.BorderSize = 0;
            btnSucursales.FlatStyle = FlatStyle.Flat;
            btnSucursales.Location = new Point(30, 456);
            btnSucursales.Margin = new Padding(3, 4, 3, 4);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(219, 45);
            btnSucursales.TabIndex = 8;
            btnSucursales.Text = "Gestionar Sucursales";
            btnSucursales.UseVisualStyleBackColor = false;
            btnSucursales.Click += btnSucursales_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(482, 572);
            label1.TabIndex = 10;
            label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(283, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 513);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manual de Administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(211, 47);
            label2.Name = "label2";
            label2.Size = new Size(244, 30);
            label2.TabIndex = 11;
            label2.Text = "Panel de Administrador";
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(780, 716);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSucursales);
            Controls.Add(btnInformeEstadistico);
            Controls.Add(BtnHistorial);
            Controls.Add(BtnPedidos);
            Controls.Add(btnGestionarVehiculos);
            Controls.Add(btnGestionarChoferes);
            Controls.Add(btnGestionarUsuarios);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblBienvenida);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdministrador";
            Text = "Panel de Administrador";
            Load += FormAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnCerrarSesion;
        private Button btnGestionarUsuarios;
        private Button btnGestionarChoferes;
        private Button btnGestionarVehiculos;
        private Button BtnPedidos;
        private Button BtnHistorial;
        private Button btnInformeEstadistico;
        private Button btnSucursales;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
    }
}
