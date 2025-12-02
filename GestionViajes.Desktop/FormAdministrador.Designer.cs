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
            components = new System.ComponentModel.Container();
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
            label2 = new Label();
            btnChatBot = new Button();
            panelInfo = new Panel();
            lblMejorChofer = new Label();
            lblPedidosHoy = new Label();
            lblPedidosPend = new Label();
            lblChoferes = new Label();
            lblVehiculos = new Label();
            lblTituloInfo = new Label();
            timerInfo = new System.Windows.Forms.Timer(components);
            panelUsuario = new Panel();
            lblUltimoAcceso = new Label();
            lblRolUsuario = new Label();
            lblNombreUsuario = new Label();
            lblUsuarioTitulo = new Label();
            picUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInfo.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
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
            // btnChatBot
            // 
            btnChatBot.BackColor = Color.LightGray;
            btnChatBot.Cursor = Cursors.Hand;
            btnChatBot.FlatAppearance.BorderSize = 0;
            btnChatBot.FlatStyle = FlatStyle.Flat;
            btnChatBot.Location = new Point(30, 561);
            btnChatBot.Name = "btnChatBot";
            btnChatBot.Size = new Size(219, 45);
            btnChatBot.TabIndex = 13;
            btnChatBot.Text = "Asistente IA";
            btnChatBot.UseVisualStyleBackColor = false;
            btnChatBot.Click += btnChatBot_Click;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.LightGray;
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(lblMejorChofer);
            panelInfo.Controls.Add(lblPedidosHoy);
            panelInfo.Controls.Add(lblPedidosPend);
            panelInfo.Controls.Add(lblChoferes);
            panelInfo.Controls.Add(lblVehiculos);
            panelInfo.Controls.Add(lblTituloInfo);
            panelInfo.Location = new Point(285, 191);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(420, 260);
            panelInfo.TabIndex = 14;
            // 
            // lblMejorChofer
            // 
            lblMejorChofer.AutoSize = true;
            lblMejorChofer.Location = new Point(26, 159);
            lblMejorChofer.Name = "lblMejorChofer";
            lblMejorChofer.Size = new Size(99, 20);
            lblMejorChofer.TabIndex = 5;
            lblMejorChofer.Text = "Mejor Chofer:";
            // 
            // lblPedidosHoy
            // 
            lblPedidosHoy.AutoSize = true;
            lblPedidosHoy.Location = new Point(22, 132);
            lblPedidosHoy.Name = "lblPedidosHoy";
            lblPedidosHoy.Size = new Size(116, 20);
            lblPedidosHoy.TabIndex = 4;
            lblPedidosHoy.Text = "Pedidos de Hoy:";
            // 
            // lblPedidosPend
            // 
            lblPedidosPend.AutoSize = true;
            lblPedidosPend.Location = new Point(18, 105);
            lblPedidosPend.Name = "lblPedidosPend";
            lblPedidosPend.Size = new Size(141, 20);
            lblPedidosPend.TabIndex = 3;
            lblPedidosPend.Text = "Pedidos pendientes:";
            // 
            // lblChoferes
            // 
            lblChoferes.AutoSize = true;
            lblChoferes.Location = new Point(18, 77);
            lblChoferes.Name = "lblChoferes";
            lblChoferes.Size = new Size(150, 20);
            lblChoferes.TabIndex = 2;
            lblChoferes.Text = "Choferes disponibles:";
            // 
            // lblVehiculos
            // 
            lblVehiculos.AutoSize = true;
            lblVehiculos.Location = new Point(18, 49);
            lblVehiculos.Name = "lblVehiculos";
            lblVehiculos.Size = new Size(154, 20);
            lblVehiculos.TabIndex = 1;
            lblVehiculos.Text = "Vehículos disponibles:";
            // 
            // lblTituloInfo
            // 
            lblTituloInfo.AutoSize = true;
            lblTituloInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloInfo.Location = new Point(3, 7);
            lblTituloInfo.Name = "lblTituloInfo";
            lblTituloInfo.Size = new Size(250, 25);
            lblTituloInfo.TabIndex = 0;
            lblTituloInfo.Text = "Estado General del Sistema";
            // 
            // timerInfo
            // 
            timerInfo.Enabled = true;
            timerInfo.Interval = 10000;
            timerInfo.Tick += timerInfo_Tick;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.LightGray;
            panelUsuario.BorderStyle = BorderStyle.FixedSingle;
            panelUsuario.Controls.Add(lblUltimoAcceso);
            panelUsuario.Controls.Add(lblRolUsuario);
            panelUsuario.Controls.Add(lblNombreUsuario);
            panelUsuario.Controls.Add(lblUsuarioTitulo);
            panelUsuario.Controls.Add(picUsuario);
            panelUsuario.Location = new Point(285, 469);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(420, 130);
            panelUsuario.TabIndex = 15;
            // 
            // lblUltimoAcceso
            // 
            lblUltimoAcceso.AutoSize = true;
            lblUltimoAcceso.Location = new Point(128, 103);
            lblUltimoAcceso.Name = "lblUltimoAcceso";
            lblUltimoAcceso.Size = new Size(106, 20);
            lblUltimoAcceso.TabIndex = 4;
            lblUltimoAcceso.Text = "Ultimo acceso:";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Location = new Point(128, 73);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(34, 20);
            lblRolUsuario.TabIndex = 3;
            lblRolUsuario.Text = "Rol:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(128, 41);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(67, 20);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "Nombre:";
            // 
            // lblUsuarioTitulo
            // 
            lblUsuarioTitulo.AutoSize = true;
            lblUsuarioTitulo.Location = new Point(128, 11);
            lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            lblUsuarioTitulo.Size = new Size(133, 20);
            lblUsuarioTitulo.TabIndex = 1;
            lblUsuarioTitulo.Text = "Usuario conectado";
            // 
            // picUsuario
            // 
            picUsuario.BackColor = Color.Transparent;
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.Location = new Point(11, 11);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(100, 50);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 0;
            picUsuario.TabStop = false;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(780, 716);
            Controls.Add(panelUsuario);
            Controls.Add(panelInfo);
            Controls.Add(btnChatBot);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdministrador";
            Text = "Panel de Administrador";
            Load += FormAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
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
        private Label label2;
        private Button btnChatBot;
        private Panel panelInfo;
        private Label lblTituloInfo;
        private Label lblPedidosHoy;
        private Label lblPedidosPend;
        private Label lblChoferes;
        private Label lblVehiculos;
        private Label lblMejorChofer;
        private System.Windows.Forms.Timer timerInfo;
        private Panel panelUsuario;
        private PictureBox picUsuario;
        private Label lblUltimoAcceso;
        private Label lblRolUsuario;
        private Label lblNombreUsuario;
        private Label lblUsuarioTitulo;
    }
}
