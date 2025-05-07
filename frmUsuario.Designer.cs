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
            btnVoltar = new Button();
            pictureBox1 = new PictureBox();
            lblPerfil = new Label();
            picboxFotoUsuario = new PictureBox();
            btnAlterar = new Button();
            btnDeletar = new Button();
            txtNomeUsuario = new TextBox();
            txtEmailUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxFotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
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
            picboxFotoUsuario.Location = new Point(100, 48);
            picboxFotoUsuario.Name = "picboxFotoUsuario";
            picboxFotoUsuario.Size = new Size(100, 97);
            picboxFotoUsuario.TabIndex = 4;
            picboxFotoUsuario.TabStop = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(-1, 93);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(-1, 122);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Enabled = false;
            txtNomeUsuario.Location = new Point(100, 151);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(100, 23);
            txtNomeUsuario.TabIndex = 7;
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Enabled = false;
            txtEmailUsuario.Location = new Point(66, 231);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.Size = new Size(169, 23);
            txtEmailUsuario.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(206, 48);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 9;
            label1.Text = "foto do usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(28, 177);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 10;
            label2.Text = "nome do usuario (desativado mas aparecendo)";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(30, 257);
            label3.Name = "label3";
            label3.Size = new Size(253, 15);
            label3.TabIndex = 11;
            label3.Text = "email do usuario (desativado mas aparecendo)";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(306, 353);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmailUsuario);
            Controls.Add(txtNomeUsuario);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(picboxFotoUsuario);
            Controls.Add(lblPerfil);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltar);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuário";
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
        private Button btnDeletar;
        private TextBox txtNomeUsuario;
        private TextBox txtEmailUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}