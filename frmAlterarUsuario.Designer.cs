namespace ProjetoIntegradorME
{
    partial class frmAlterarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarUsuario));
            pictureBox1 = new PictureBox();
            btnAlterar = new Button();
            txtNovoNome = new TextBox();
            txtNovoEmail = new TextBox();
            txtNovaSenha = new TextBox();
            pictureBox2 = new PictureBox();
            lblNovoNome = new Label();
            lblNovoEmail = new Label();
            lblNovaSenha = new Label();
            txtSenhaAtual = new TextBox();
            lblSenhaAtual = new Label();
            txtEmailAtual = new TextBox();
            lblEmailAtual = new Label();
            txtNomeAtual = new TextBox();
            lblNomeAtual = new Label();
            lblID = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(100, 63, 49);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 28);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterar.Location = new Point(126, 587);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtNovoNome
            // 
            txtNovoNome.Location = new Point(70, 237);
            txtNovoNome.Name = "txtNovoNome";
            txtNovoNome.Size = new Size(196, 23);
            txtNovoNome.TabIndex = 5;
            // 
            // txtNovoEmail
            // 
            txtNovoEmail.Location = new Point(70, 371);
            txtNovoEmail.Name = "txtNovoEmail";
            txtNovoEmail.Size = new Size(196, 23);
            txtNovoEmail.TabIndex = 6;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(70, 508);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(196, 23);
            txtNovaSenha.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(108, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 91);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblNovoNome
            // 
            lblNovoNome.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNovoNome.ForeColor = Color.Maroon;
            lblNovoNome.Location = new Point(70, 219);
            lblNovoNome.Name = "lblNovoNome";
            lblNovoNome.Size = new Size(196, 15);
            lblNovoNome.TabIndex = 9;
            lblNovoNome.Text = "Novo Nome do Usuário";
            lblNovoNome.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblNovoEmail
            // 
            lblNovoEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNovoEmail.ForeColor = Color.Maroon;
            lblNovoEmail.Location = new Point(70, 353);
            lblNovoEmail.Name = "lblNovoEmail";
            lblNovoEmail.Size = new Size(196, 15);
            lblNovoEmail.TabIndex = 10;
            lblNovoEmail.Text = "Novo Email";
            lblNovoEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNovaSenha.ForeColor = Color.Maroon;
            lblNovaSenha.Location = new Point(70, 490);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(196, 15);
            lblNovaSenha.TabIndex = 11;
            lblNovaSenha.Text = "Nova Senha";
            lblNovaSenha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Enabled = false;
            txtSenhaAtual.Location = new Point(70, 464);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Size = new Size(196, 23);
            txtSenhaAtual.TabIndex = 12;
            // 
            // lblSenhaAtual
            // 
            lblSenhaAtual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSenhaAtual.ForeColor = Color.FromArgb(255, 128, 0);
            lblSenhaAtual.Location = new Point(70, 446);
            lblSenhaAtual.Name = "lblSenhaAtual";
            lblSenhaAtual.Size = new Size(196, 15);
            lblSenhaAtual.TabIndex = 13;
            lblSenhaAtual.Text = "Senha Atual";
            lblSenhaAtual.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtEmailAtual
            // 
            txtEmailAtual.Enabled = false;
            txtEmailAtual.Location = new Point(70, 327);
            txtEmailAtual.Name = "txtEmailAtual";
            txtEmailAtual.Size = new Size(196, 23);
            txtEmailAtual.TabIndex = 14;
            // 
            // lblEmailAtual
            // 
            lblEmailAtual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmailAtual.ForeColor = Color.FromArgb(255, 128, 0);
            lblEmailAtual.Location = new Point(70, 309);
            lblEmailAtual.Name = "lblEmailAtual";
            lblEmailAtual.Size = new Size(196, 15);
            lblEmailAtual.TabIndex = 15;
            lblEmailAtual.Text = "Email Atual";
            lblEmailAtual.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtNomeAtual
            // 
            txtNomeAtual.Enabled = false;
            txtNomeAtual.Location = new Point(70, 193);
            txtNomeAtual.Name = "txtNomeAtual";
            txtNomeAtual.Size = new Size(196, 23);
            txtNomeAtual.TabIndex = 16;
            // 
            // lblNomeAtual
            // 
            lblNomeAtual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNomeAtual.ForeColor = Color.FromArgb(255, 128, 0);
            lblNomeAtual.Location = new Point(70, 175);
            lblNomeAtual.Name = "lblNomeAtual";
            lblNomeAtual.Size = new Size(196, 15);
            lblNomeAtual.TabIndex = 17;
            lblNomeAtual.Text = "Nome de Usuário Atual";
            lblNomeAtual.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblID
            // 
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblID.ForeColor = Color.FromArgb(255, 128, 0);
            lblID.Location = new Point(90, 135);
            lblID.Name = "lblID";
            lblID.Size = new Size(40, 15);
            lblID.TabIndex = 19;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(120, 131);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 20;
            // 
            // frmAlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(333, 622);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(lblNomeAtual);
            Controls.Add(txtNomeAtual);
            Controls.Add(lblEmailAtual);
            Controls.Add(txtEmailAtual);
            Controls.Add(lblSenhaAtual);
            Controls.Add(txtSenhaAtual);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblNovoEmail);
            Controls.Add(lblNovoNome);
            Controls.Add(pictureBox2);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtNovoEmail);
            Controls.Add(txtNovoNome);
            Controls.Add(btnAlterar);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAlterarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Usuario";
            Load += frmAlterarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAlterar;
        private TextBox txtNovoNome;
        private TextBox txtNovoEmail;
        private TextBox txtNovaSenha;
        private PictureBox pictureBox2;
        private Label lblNovoNome;
        private Label lblNovoEmail;
        private Label lblNovaSenha;
        private TextBox txtSenhaAtual;
        private Label lblSenhaAtual;
        private TextBox txtEmailAtual;
        private Label lblEmailAtual;
        private TextBox txtNomeAtual;
        private Label lblNomeAtual;
        private Label lblID;
        private TextBox txtID;
    }
}