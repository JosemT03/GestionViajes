namespace GestionViajes.Desktop
{
    partial class FormHistorialViajes
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
            cmbFiltroTipo = new ComboBox();
            cmbOpciones = new ComboBox();
            dtpMes = new DateTimePicker();
            btnBuscar = new Button();
            dgvHistorial = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // cmbFiltroTipo
            // 
            cmbFiltroTipo.FormattingEnabled = true;
            cmbFiltroTipo.Items.AddRange(new object[] { "Chofer", "Vehiculo", "Mes" });
            cmbFiltroTipo.Location = new Point(168, 43);
            cmbFiltroTipo.Name = "cmbFiltroTipo";
            cmbFiltroTipo.Size = new Size(121, 23);
            cmbFiltroTipo.TabIndex = 0;
            // 
            // cmbOpciones
            // 
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(172, 111);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(121, 23);
            cmbOpciones.TabIndex = 1;
            // 
            // dtpMes
            // 
            dtpMes.Location = new Point(182, 179);
            dtpMes.Name = "dtpMes";
            dtpMes.Size = new Size(200, 23);
            dtpMes.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(58, 288);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(172, 268);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(464, 150);
            dgvHistorial.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 43);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 113);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Opciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 178);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(478, 187);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormHistorialViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHistorial);
            Controls.Add(btnBuscar);
            Controls.Add(dtpMes);
            Controls.Add(cmbOpciones);
            Controls.Add(cmbFiltroTipo);
            Name = "FormHistorialViajes";
            Text = "FormHistorialViajes";
            Load += FormHistorialViajes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFiltroTipo;
        private ComboBox cmbOpciones;
        private DateTimePicker dtpMes;
        private Button btnBuscar;
        private DataGridView dgvHistorial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCerrar;
    }
}