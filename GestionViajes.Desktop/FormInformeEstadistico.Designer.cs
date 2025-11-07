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
            lblTitulo = new Label();
            dgvEstadisticas = new DataGridView();
            btnGenerar = new Button();
            btnExportar = new Button();
            dtpFiltroMes = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(315, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Informe Estadístico de Pedidos";
            // 
            // dgvEstadisticas
            // 
            dgvEstadisticas.AllowUserToAddRows = false;
            dgvEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadisticas.Location = new Point(20, 60);
            dgvEstadisticas.Name = "dgvEstadisticas";
            dgvEstadisticas.ReadOnly = true;
            dgvEstadisticas.Size = new Size(700, 250);
            dgvEstadisticas.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(20, 330);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(150, 30);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar estadísticas";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(190, 330);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(150, 30);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar a PDF";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dtpFiltroMes
            // 
            dtpFiltroMes.CustomFormat = "MM/yyyy";
            dtpFiltroMes.Format = DateTimePickerFormat.Custom;
            dtpFiltroMes.Location = new Point(380, 330);
            dtpFiltroMes.Name = "dtpFiltroMes";
            dtpFiltroMes.ShowUpDown = true;
            dtpFiltroMes.Size = new Size(100, 23);
            dtpFiltroMes.TabIndex = 4;
            // 
            // FormInformeEstadistico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFiltroMes);
            Controls.Add(btnExportar);
            Controls.Add(btnGenerar);
            Controls.Add(dgvEstadisticas);
            Controls.Add(lblTitulo);
            Name = "FormInformeEstadistico";
            Text = "FormInformeEstadistico";
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvEstadisticas;
        private Button btnGenerar;
        private Button btnExportar;
        private DateTimePicker dtpFiltroMes;
    }
}