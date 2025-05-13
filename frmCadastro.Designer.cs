namespace ProjetoIntegradorME
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            pcbMiniEstante = new PictureBox();
            txtUsuario = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            lblUsuario = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblDescSenha = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbMiniEstante).BeginInit();
            SuspendLayout();
            // 
            // pcbMiniEstante
            // 
            pcbMiniEstante.BackgroundImage = (Image)resources.GetObject("pcbMiniEstante.BackgroundImage");
            pcbMiniEstante.BackgroundImageLayout = ImageLayout.Zoom;
            pcbMiniEstante.Location = new Point(94, 12);
            pcbMiniEstante.Name = "pcbMiniEstante";
            pcbMiniEstante.Size = new Size(154, 90);
            pcbMiniEstante.TabIndex = 0;
            pcbMiniEstante.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(94, 134);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(94, 250);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(154, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadastrar.Location = new Point(126, 340);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(89, 29);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(255, 128, 0);
            lblUsuario.Location = new Point(94, 116);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(154, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Nome do Usuário";
            lblUsuario.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(255, 128, 0);
            lblEmail.Location = new Point(94, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(154, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(255, 128, 0);
            lblSenha.Location = new Point(94, 232);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(154, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDescSenha
            // 
            lblDescSenha.BackColor = Color.AntiqueWhite;
            lblDescSenha.Font = new Font("Segoe UI", 9F);
            lblDescSenha.ForeColor = Color.FromArgb(192, 0, 0);
            lblDescSenha.Location = new Point(94, 276);
            lblDescSenha.Name = "lblDescSenha";
            lblDescSenha.Size = new Size(160, 44);
            lblDescSenha.TabIndex = 8;
            lblDescSenha.Text = "A senha deve ter no mínimo              6 caracteres.";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(340, 381);
            Controls.Add(lblDescSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblUsuario);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtUsuario);
            Controls.Add(pcbMiniEstante);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pcbMiniEstante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbMiniEstante;
        private TextBox txtUsuario;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private Label lblUsuario;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblDescSenha;
    }
}