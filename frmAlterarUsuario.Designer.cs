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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            lblNovoNome = new Label();
            lblNovoEmail = new Label();
            lblNovaSenha = new Label();
            btnDeletar = new Button();
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
            pictureBox1.Size = new Size(316, 28);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 9F);
            btnAlterar.Location = new Point(102, 335);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(87, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 91);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblNovoNome
            // 
            lblNovoNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNovoNome.ForeColor = Color.FromArgb(255, 128, 0);
            lblNovoNome.Location = new Point(61, 153);
            lblNovoNome.Name = "lblNovoNome";
            lblNovoNome.Size = new Size(170, 15);
            lblNovoNome.TabIndex = 9;
            lblNovoNome.Text = "Novo Nome do Usuário";
            lblNovoNome.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblNovoEmail
            // 
            lblNovoEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNovoEmail.ForeColor = Color.FromArgb(255, 128, 0);
            lblNovoEmail.Location = new Point(66, 215);
            lblNovoEmail.Name = "lblNovoEmail";
            lblNovoEmail.Size = new Size(154, 15);
            lblNovoEmail.TabIndex = 10;
            lblNovoEmail.Text = "Novo Email";
            lblNovoEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNovaSenha.ForeColor = Color.FromArgb(255, 128, 0);
            lblNovaSenha.Location = new Point(70, 278);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(154, 15);
            lblNovaSenha.TabIndex = 11;
            lblNovaSenha.Text = "Nova Senha";
            lblNovaSenha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(102, 373);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 12;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // frmAlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(300, 402);
            Controls.Add(btnDeletar);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblNovoEmail);
            Controls.Add(lblNovoNome);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAlterar);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "frmAlterarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAlterarUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAlterar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox2;
        private Label lblNovoNome;
        private Label lblNovoEmail;
        private Label lblNovaSenha;
        private Button btnDeletar;
    }
}