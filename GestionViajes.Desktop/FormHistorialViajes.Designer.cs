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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialViajes));
            cmbFiltroTipo = new ComboBox();
            cmbOpciones = new ComboBox();
            dtpMes = new DateTimePicker();
            btnBuscar = new Button();
            dgvHistorial = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCerrar = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbFiltroTipo
            // 
            cmbFiltroTipo.BackColor = SystemColors.Window;
            cmbFiltroTipo.FormattingEnabled = true;
            cmbFiltroTipo.Items.AddRange(new object[] { "Chofer", "Vehiculo", "Mes" });
            cmbFiltroTipo.Location = new Point(28, 56);
            cmbFiltroTipo.Name = "cmbFiltroTipo";
            cmbFiltroTipo.Size = new Size(152, 23);
            cmbFiltroTipo.TabIndex = 0;
            // 
            // cmbOpciones
            // 
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(28, 109);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(152, 23);
            cmbOpciones.TabIndex = 1;
            // 
            // dtpMes
            // 
            dtpMes.Location = new Point(28, 163);
            dtpMes.Name = "dtpMes";
            dtpMes.Size = new Size(152, 23);
            dtpMes.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightGray;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(44, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 35);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(6, 22);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(621, 338);
            dgvHistorial.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Filtro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Opciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 145);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightGray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(44, 76);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(114, 35);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(307, 29);
            label4.Name = "label4";
            label4.Size = new Size(180, 30);
            label4.TabIndex = 9;
            label4.Text = "Historial de Viaje";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbFiltroTipo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbOpciones);
            groupBox1.Controls.Add(dtpMes);
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 233);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(btnCerrar);
            groupBox2.Location = new Point(12, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 129);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHistorial);
            groupBox3.Location = new Point(267, 108);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(633, 366);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormHistorialViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(912, 526);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHistorialViajes";
            Text = "FormHistorialViajes";
            Load += FormHistorialViajes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
    }
}