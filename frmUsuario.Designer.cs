namespace ProjetoIntegradorME
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            btnVoltar = new Button();
            pictureBox1 = new PictureBox();
            lblPerfil = new Label();
            picboxFotoUsuario = new PictureBox();
            btnAlterar = new Button();
            txtNomeUsuario = new TextBox();
            txtEmailUsuario = new TextBox();
            lblUsuario = new Label();
            lblEmail = new Label();
            btnFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxFotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVoltar.Location = new Point(110, 324);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(100, 63, 49);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 28);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblPerfil
            // 
            lblPerfil.BackColor = Color.FromArgb(100, 63, 49);
            lblPerfil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPerfil.ForeColor = SystemColors.ActiveCaptionText;
            lblPerfil.Location = new Point(100, 3);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(100, 23);
            lblPerfil.TabIndex = 3;
            lblPerfil.Text = "PERFIL";
            lblPerfil.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picboxFotoUsuario
            // 
            picboxFotoUsuario.BackgroundImage = (Image)resources.GetObject("picboxFotoUsuario.BackgroundImage");
            picboxFotoUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            picboxFotoUsuario.Location = new Point(100, 55);
            picboxFotoUsuario.Name = "picboxFotoUsuario";
            picboxFotoUsuario.Size = new Size(107, 107);
            picboxFotoUsuario.TabIndex = 4;
            picboxFotoUsuario.TabStop = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterar.Location = new Point(12, 32);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 41);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar Perfil";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Enabled = false;
            txtNomeUsuario.Location = new Point(100, 192);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(100, 23);
            txtNomeUsuario.TabIndex = 7;
            txtNomeUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Enabled = false;
            txtEmailUsuario.Location = new Point(66, 255);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.Size = new Size(169, 23);
            txtEmailUsuario.TabIndex = 8;
            txtEmailUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(255, 128, 0);
            lblUsuario.Location = new Point(66, 174);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(169, 15);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Nome do Usuário";
            lblUsuario.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(255, 128, 0);
            lblEmail.Location = new Point(66, 237);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(169, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnFoto
            // 
            btnFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFoto.Location = new Point(12, 79);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(75, 41);
            btnFoto.TabIndex = 14;
            btnFoto.Text = "Alterar foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(306, 353);
            Controls.Add(btnFoto);
            Controls.Add(lblEmail);
            Controls.Add(lblUsuario);
            Controls.Add(txtEmailUsuario);
            Controls.Add(txtNomeUsuario);
            Controls.Add(btnAlterar);
            Controls.Add(picboxFotoUsuario);
            Controls.Add(lblPerfil);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuário";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxFotoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private PictureBox pictureBox1;
        private Label lblPerfil;
        private PictureBox picboxFotoUsuario;
        private Button btnAlterar;
        private TextBox txtNomeUsuario;
        private TextBox txtEmailUsuario;
        private Label lblUsuario;
        private Label lblEmail;
        private Button btnFoto;
    }
}