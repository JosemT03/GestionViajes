namespace GestionViajes.Desktop
{
    partial class FormAgregarEditarPedido
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
            txtProvincia = new TextBox();
            txtSucursal = new TextBox();
            txtNumeroPedido = new TextBox();
            dtpFechaEntrega = new DateTimePicker();
            cmbEstado = new ComboBox();
            cmbChofer = new ComboBox();
            cmbVehiculo = new ComboBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(108, 20);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(100, 23);
            txtProvincia.TabIndex = 0;
            // 
            // txtSucursal
            // 
            txtSucursal.Location = new Point(103, 76);
            txtSucursal.Name = "txtSucursal";
            txtSucursal.Size = new Size(100, 23);
            txtSucursal.TabIndex = 1;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(141, 127);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(100, 23);
            txtNumeroPedido.TabIndex = 2;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(128, 167);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(219, 23);
            dtpFechaEntrega.TabIndex = 3;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente ", "En Curso", "Completado " });
            cmbEstado.Location = new Point(92, 214);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(132, 23);
            cmbEstado.TabIndex = 4;
            // 
            // cmbChofer
            // 
            cmbChofer.FormattingEnabled = true;
            cmbChofer.Location = new Point(92, 260);
            cmbChofer.Name = "cmbChofer";
            cmbChofer.Size = new Size(121, 23);
            cmbChofer.TabIndex = 5;
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(101, 302);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(121, 23);
            cmbVehiculo.TabIndex = 6;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(379, 347);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(492, 347);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 28);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Provincia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Sucursal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 135);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 11;
            label3.Text = "Numero de Pedido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 173);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 12;
            label4.Text = "Fecha de Entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 222);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 13;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 268);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "Chofer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 310);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 15;
            label7.Text = "Vehiculo";
            // 
            // FormAgregarEditarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(cmbVehiculo);
            Controls.Add(cmbChofer);
            Controls.Add(cmbEstado);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(txtNumeroPedido);
            Controls.Add(txtSucursal);
            Controls.Add(txtProvincia);
            Name = "FormAgregarEditarPedido";
            Text = "FormAgregarEditarPedido";
            Load += FormAgregarEditarPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProvincia;
        private TextBox txtSucursal;
        private TextBox txtNumeroPedido;
        private DateTimePicker dtpFechaEntrega;
        private ComboBox cmbEstado;
        private ComboBox cmbChofer;
        private ComboBox cmbVehiculo;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}