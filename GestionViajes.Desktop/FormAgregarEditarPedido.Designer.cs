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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEditarPedido));
            txtNumeroPedido = new TextBox();
            dtpFechaEntrega = new DateTimePicker();
            cmbEstado = new ComboBox();
            cmbChofer = new ComboBox();
            cmbVehiculo = new ComboBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbSucursal = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(122, 59);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(100, 23);
            txtNumeroPedido.TabIndex = 2;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(109, 88);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(219, 23);
            dtpFechaEntrega.TabIndex = 3;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente ", "En Curso", "Completado " });
            cmbEstado.Location = new Point(109, 126);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(132, 23);
            cmbEstado.TabIndex = 4;
            // 
            // cmbChofer
            // 
            cmbChofer.FormattingEnabled = true;
            cmbChofer.Location = new Point(109, 169);
            cmbChofer.Name = "cmbChofer";
            cmbChofer.Size = new Size(121, 23);
            cmbChofer.TabIndex = 5;
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(109, 202);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(121, 23);
            cmbVehiculo.TabIndex = 6;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.LightGray;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Location = new Point(40, 36);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(114, 35);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.LightGray;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Location = new Point(195, 36);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(114, 35);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 38);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Sucursal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 11;
            label3.Text = "Numero de Pedido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 96);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 12;
            label4.Text = "Fecha de Entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 126);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 13;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 172);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "Chofer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 205);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 15;
            label7.Text = "Vehiculo";
            // 
            // cmbSucursal
            // 
            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(109, 30);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(200, 23);
            cmbSucursal.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 19;
            label1.Text = "Agregar Pedido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbSucursal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNumeroPedido);
            groupBox1.Controls.Add(dtpFechaEntrega);
            groupBox1.Controls.Add(cmbVehiculo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(cmbChofer);
            groupBox1.Location = new Point(176, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 240);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedido";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnGuardar);
            groupBox2.Controls.Add(BtnCancelar);
            groupBox2.Location = new Point(176, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 100);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // FormAgregarEditarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(703, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarEditarPedido";
            Text = "FormAgregarEditarPedido";
            Load += FormAgregarEditarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumeroPedido;
        private DateTimePicker dtpFechaEntrega;
        private ComboBox cmbEstado;
        private ComboBox cmbChofer;
        private ComboBox cmbVehiculo;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbSucursal;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}