namespace ProjetoIntegradorME
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pcbMinhaEstante = new PictureBox();
            btnCriarConta = new Button();
            lblCriarConta = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblEmail = new Label();
            lblSenha = new Label();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbMinhaEstante).BeginInit();
            SuspendLayout();
            // 
            // pcbMinhaEstante
            // 
            pcbMinhaEstante.BackgroundImage = (Image)resources.GetObject("pcbMinhaEstante.BackgroundImage");
            pcbMinhaEstante.BackgroundImageLayout = ImageLayout.Zoom;
            pcbMinhaEstante.Location = new Point(12, 33);
            pcbMinhaEstante.Name = "pcbMinhaEstante";
            pcbMinhaEstante.Size = new Size(193, 231);
            pcbMinhaEstante.TabIndex = 1;
            pcbMinhaEstante.TabStop = false;
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(130, 310);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(75, 23);
            btnCriarConta.TabIndex = 2;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // lblCriarConta
            // 
            lblCriarConta.AutoSize = true;
            lblCriarConta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCriarConta.ForeColor = Color.FromArgb(192, 0, 0);
            lblCriarConta.Location = new Point(116, 292);
            lblCriarConta.Name = "lblCriarConta";
            lblCriarConta.Size = new Size(105, 15);
            lblCriarConta.TabIndex = 3;
            lblCriarConta.Text = "Não possui conta?";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(211, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(211, 194);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(255, 128, 0);
            lblEmail.Location = new Point(211, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(255, 128, 0);
            lblSenha.Location = new Point(211, 176);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(225, 231);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(340, 355);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblCriarConta);
            Controls.Add(btnCriarConta);
            Controls.Add(pcbMinhaEstante);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pcbMinhaEstante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbMinhaEstante;
        private Button btnCriarConta;
        private Label lblCriarConta;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblEmail;
        private Label lblSenha;
        private Button btnEntrar;
    }
}
