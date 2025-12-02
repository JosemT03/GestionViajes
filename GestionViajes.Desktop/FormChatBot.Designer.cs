namespace GestionViajes.Desktop
{
    partial class FormChatBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatBot));
            rtbChat = new RichTextBox();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            picIA = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picIA).BeginInit();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.DimGray;
            rtbChat.BorderStyle = BorderStyle.None;
            rtbChat.Font = new Font("Segoe UI", 10F);
            rtbChat.ForeColor = Color.White;
            rtbChat.Location = new Point(12, 130);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(445, 186);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // txtMensaje
            // 
            txtMensaje.BackColor = Color.White;
            txtMensaje.BorderStyle = BorderStyle.FixedSingle;
            txtMensaje.Font = new Font("Segoe UI", 9.5F);
            txtMensaje.ForeColor = Color.Black;
            txtMensaje.Location = new Point(12, 322);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.PlaceholderText = "Escribi tu Pregunta...";
            txtMensaje.Size = new Size(445, 24);
            txtMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.LightGray;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 9.5F);
            btnEnviar.Location = new Point(136, 378);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(217, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // picIA
            // 
            picIA.Image = (Image)resources.GetObject("picIA.Image");
            picIA.Location = new Point(12, 12);
            picIA.Name = "picIA";
            picIA.Size = new Size(100, 91);
            picIA.SizeMode = PictureBoxSizeMode.Zoom;
            picIA.TabIndex = 3;
            picIA.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 38);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 4;
            label1.Text = "Chat Bot";
            // 
            // FormChatBot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(469, 450);
            Controls.Add(label1);
            Controls.Add(picIA);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(rtbChat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChatBot";
            Text = "Chat Bot";
            Load += FormChatBot_Load;
            ((System.ComponentModel.ISupportInitialize)picIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private TextBox txtMensaje;
        private Button btnEnviar;
        private PictureBox picIA;
        private Label label1;
    }
}