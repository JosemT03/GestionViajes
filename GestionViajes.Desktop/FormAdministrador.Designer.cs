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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnGestionarChoferes = new System.Windows.Forms.Button();
            this.btnGestionarVehiculos = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.BtnHistorial = new System.Windows.Forms.Button();
            this.btnInformeEstadistico = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(22, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(69, 15);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido:";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(22, 389);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(154, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(28, 138);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(203, 23);
            this.btnGestionarUsuarios.TabIndex = 2;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnGestionarChoferes
            // 
            this.btnGestionarChoferes.Location = new System.Drawing.Point(28, 202);
            this.btnGestionarChoferes.Name = "btnGestionarChoferes";
            this.btnGestionarChoferes.Size = new System.Drawing.Size(194, 23);
            this.btnGestionarChoferes.TabIndex = 3;
            this.btnGestionarChoferes.Text = "Gestionar Choferes";
            this.btnGestionarChoferes.UseVisualStyleBackColor = true;
            this.btnGestionarChoferes.Click += new System.EventHandler(this.btnGestionarChoferes_Click);
            // 
            // btnGestionarVehiculos
            // 
            this.btnGestionarVehiculos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGestionarVehiculos.Location = new System.Drawing.Point(28, 265);
            this.btnGestionarVehiculos.Name = "btnGestionarVehiculos";
            this.btnGestionarVehiculos.Size = new System.Drawing.Size(188, 40);
            this.btnGestionarVehiculos.TabIndex = 4;
            this.btnGestionarVehiculos.Text = "Gestionar Vehículos";
            this.btnGestionarVehiculos.UseVisualStyleBackColor = true;
            this.btnGestionarVehiculos.Click += new System.EventHandler(this.btnGestionarVehiculos_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Location = new System.Drawing.Point(39, 330);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(177, 23);
            this.BtnPedidos.TabIndex = 5;
            this.BtnPedidos.Text = "Gestionar Pedido";
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.Location = new System.Drawing.Point(39, 79);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(143, 23);
            this.BtnHistorial.TabIndex = 6;
            this.BtnHistorial.Text = "Historial";
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // btnInformeEstadistico
            // 
            this.btnInformeEstadistico.Location = new System.Drawing.Point(355, 85);
            this.btnInformeEstadistico.Name = "btnInformeEstadistico";
            this.btnInformeEstadistico.Size = new System.Drawing.Size(157, 23);
            this.btnInformeEstadistico.TabIndex = 7;
            this.btnInformeEstadistico.Text = "Informe Estadístico";
            this.btnInformeEstadistico.UseVisualStyleBackColor = true;
            this.btnInformeEstadistico.Click += new System.EventHandler(this.btnInformeEstadistico_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.Location = new System.Drawing.Point(356, 148);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(150, 30);
            this.btnSucursales.TabIndex = 8;
            this.btnSucursales.Text = "Gestionar Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = true;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSucursales);
            this.Controls.Add(this.btnInformeEstadistico);
            this.Controls.Add(this.BtnHistorial);
            this.Controls.Add(this.BtnPedidos);
            this.Controls.Add(this.btnGestionarVehiculos);
            this.Controls.Add(this.btnGestionarChoferes);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FormAdministrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
