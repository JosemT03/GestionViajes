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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehiculos));
            dgvVehiculos = new DataGridView();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnCerrar = new Button();
            BtnRefrescar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Dock = DockStyle.Top;
            dgvVehiculos.Location = new Point(0, 0);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.Size = new Size(800, 241);
            dgvVehiculos.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.LightGray;
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Location = new Point(19, 22);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(127, 35);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar Vehículo";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.LightGray;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Location = new Point(19, 63);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(127, 35);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar Vehículo";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.LightGray;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Location = new Point(19, 104);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(127, 35);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar Vehículo";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.BackColor = Color.LightGray;
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Location = new Point(197, 145);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(127, 35);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // BtnRefrescar
            // 
            BtnRefrescar.BackColor = Color.LightGray;
            BtnRefrescar.Cursor = Cursors.Hand;
            BtnRefrescar.FlatAppearance.BorderSize = 0;
            BtnRefrescar.FlatStyle = FlatStyle.Flat;
            BtnRefrescar.Location = new Point(19, 145);
            BtnRefrescar.Name = "BtnRefrescar";
            BtnRefrescar.Size = new Size(127, 35);
            BtnRefrescar.TabIndex = 5;
            BtnRefrescar.Text = "Refrescar";
            BtnRefrescar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(580, 337);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(524, 285);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 7;
            label1.Text = "Gestion de Vehiculos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnAgregar);
            groupBox1.Controls.Add(BtnEditar);
            groupBox1.Controls.Add(BtnEliminar);
            groupBox1.Controls.Add(BtnCerrar);
            groupBox1.Controls.Add(BtnRefrescar);
            groupBox1.Location = new Point(10, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 191);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // FormVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVehiculos";
            Text = "FormVehiculos";
            Load += FormVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVehiculos;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnCerrar;
        private Button BtnRefrescar;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
    }
}