namespace GestionViajes.Desktop
{
    partial class FormInformeEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformeEstadistico));
            lblTitulo = new Label();
            dgvEstadisticas = new DataGridView();
            btnGenerar = new Button();
            btnExportar = new Button();
            dtpFiltroMes = new DateTimePicker();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(220, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(333, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Informe Estadístico de Pedidos";
            // 
            // dgvEstadisticas
            // 
            dgvEstadisticas.AllowUserToAddRows = false;
            dgvEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadisticas.Location = new Point(21, 22);
            dgvEstadisticas.Name = "dgvEstadisticas";
            dgvEstadisticas.ReadOnly = true;
            dgvEstadisticas.Size = new Size(721, 250);
            dgvEstadisticas.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.LightGray;
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Location = new Point(21, 31);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(143, 37);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar estadísticas";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.LightGray;
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Location = new Point(200, 31);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(134, 37);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar a PDF";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // dtpFiltroMes
            // 
            dtpFiltroMes.CustomFormat = "MM/yyyy";
            dtpFiltroMes.Format = DateTimePickerFormat.Custom;
            dtpFiltroMes.Location = new Point(383, 34);
            dtpFiltroMes.Name = "dtpFiltroMes";
            dtpFiltroMes.ShowUpDown = true;
            dtpFiltroMes.Size = new Size(100, 23);
            dtpFiltroMes.TabIndex = 4;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightGray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(550, 34);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(134, 37);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEstadisticas);
            groupBox1.Location = new Point(20, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 274);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExportar);
            groupBox2.Controls.Add(btnGenerar);
            groupBox2.Controls.Add(btnCerrar);
            groupBox2.Controls.Add(dtpFiltroMes);
            groupBox2.Location = new Point(20, 396);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(748, 100);
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
            // FormInformeEstadistico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 510);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInformeEstadistico";
            Text = "FormInformeEstadistico";
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvEstadisticas;
        private Button btnGenerar;
        private Button btnExportar;
        private DateTimePicker dtpFiltroMes;
        private Button btnCerrar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}