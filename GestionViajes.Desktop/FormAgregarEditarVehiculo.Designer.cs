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
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometraje).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente:";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(104, 16);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 70);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(104, 62);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(104, 106);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 161);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Año:";
            // 
            // nudAnio
            // 
            nudAnio.Location = new Point(104, 153);
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
            chkDisponible.Location = new Point(36, 211);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(82, 19);
            chkDisponible.TabIndex = 8;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(36, 265);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 9;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(171, 265);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // nudKilometraje
            // 
            nudKilometraje.Location = new Point(400, 24);
            nudKilometraje.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nudKilometraje.Name = "nudKilometraje";
            nudKilometraje.Size = new Size(120, 23);
            nudKilometraje.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 29);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 12;
            label5.Text = "Kilometraje";
            // 
            // FormAgregarEditarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(nudKilometraje);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(chkDisponible);
            Controls.Add(nudAnio);
            Controls.Add(label4);
            Controls.Add(txtModelo);
            Controls.Add(label3);
            Controls.Add(txtMarca);
            Controls.Add(label2);
            Controls.Add(txtPatente);
            Controls.Add(label1);
            Name = "FormAgregarEditarVehiculo";
            Text = "FormAgregarEditarVehiculo";
            Load += FormAgregarEditarVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometraje).EndInit();
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
    }
}