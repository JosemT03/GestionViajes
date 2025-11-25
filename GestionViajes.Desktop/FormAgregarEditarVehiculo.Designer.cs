namespace GestionViajes.Desktop
{
    partial class FormAgregarEditarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEditarVehiculo));
            label1 = new Label();
            txtPatente = new TextBox();
            label2 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtModelo = new TextBox();
            label4 = new Label();
            nudAnio = new NumericUpDown();
            chkDisponible = new CheckBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            nudKilometraje = new NumericUpDown();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometraje).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente:";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(141, 22);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 68);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(141, 60);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(141, 98);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 147);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Año:";
            // 
            // nudAnio
            // 
            nudAnio.Location = new Point(141, 139);
            nudAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(120, 23);
            nudAnio.TabIndex = 7;
            nudAnio.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(62, 220);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(82, 19);
            chkDisponible.TabIndex = 8;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.LightGray;
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Location = new Point(55, 46);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(114, 35);
            BtnGuardar.TabIndex = 9;
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
            BtnCancelar.Location = new Point(223, 46);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(114, 35);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // nudKilometraje
            // 
            nudKilometraje.Location = new Point(141, 178);
            nudKilometraje.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nudKilometraje.Name = "nudKilometraje";
            nudKilometraje.Size = new Size(120, 23);
            nudKilometraje.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 186);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 12;
            label5.Text = "Kilometraje";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Controls.Add(nudKilometraje);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(chkDisponible);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudAnio);
            groupBox1.Location = new Point(175, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 258);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vehiculo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnGuardar);
            groupBox2.Controls.Add(BtnCancelar);
            groupBox2.Location = new Point(175, 332);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 100);
            groupBox2.TabIndex = 14;
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
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(253, 20);
            label6.Name = "label6";
            label6.Size = new Size(183, 30);
            label6.TabIndex = 16;
            label6.Text = "Agregar Vehiculo";
            // 
            // FormAgregarEditarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarEditarVehiculo";
            Text = "FormAgregarEditarVehiculo";
            Load += FormAgregarEditarVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometraje).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPatente;
        private Label label2;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtModelo;
        private Label label4;
        private NumericUpDown nudAnio;
        private CheckBox chkDisponible;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private NumericUpDown nudKilometraje;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label6;
    }
}