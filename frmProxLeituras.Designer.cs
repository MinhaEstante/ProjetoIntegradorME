namespace ProjetoIntegradorME
{
    partial class frmProxLeituras
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
            pictureBox1 = new PictureBox();
            btnVoltar = new Button();
            lblProxLtrs = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            btnAdicionarProxLtrs = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(100, 63, 49);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-8, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(846, 28);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 549);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblProxLtrs
            // 
            lblProxLtrs.AutoSize = true;
            lblProxLtrs.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblProxLtrs.Location = new Point(293, 30);
            lblProxLtrs.Name = "lblProxLtrs";
            lblProxLtrs.Size = new Size(196, 25);
            lblProxLtrs.TabIndex = 3;
            lblProxLtrs.Text = "PRÓXIMAS LEITURAS";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(62, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 149);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(62, 321);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 149);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(251, 112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(117, 149);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(251, 321);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(117, 149);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(442, 112);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(117, 149);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(442, 321);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(117, 149);
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(618, 112);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(117, 149);
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(618, 321);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(117, 149);
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // btnAdicionarProxLtrs
            // 
            btnAdicionarProxLtrs.Location = new Point(340, 549);
            btnAdicionarProxLtrs.Name = "btnAdicionarProxLtrs";
            btnAdicionarProxLtrs.Size = new Size(164, 23);
            btnAdicionarProxLtrs.TabIndex = 12;
            btnAdicionarProxLtrs.Text = "Adicionar Próximas Leituras";
            btnAdicionarProxLtrs.UseVisualStyleBackColor = true;
            // 
            // frmProxLeituras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(834, 584);
            Controls.Add(btnAdicionarProxLtrs);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblProxLtrs);
            Controls.Add(btnVoltar);
            Controls.Add(pictureBox1);
            Name = "frmProxLeituras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Próximas Leituras";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnVoltar;
        private Label lblProxLtrs;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Button btnAdicionarProxLtrs;
    }
}