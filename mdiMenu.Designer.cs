namespace ProjetoIntegradorME
{
    partial class mdiMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMenu));
            toolStrip = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripUsuario = new ToolStripButton();
            toolStripLendo = new ToolStripButton();
            toolStripLidos = new ToolStripButton();
            toolStripProxLeituras = new ToolStripButton();
            toolStripSair = new ToolStripButton();
            toolStripSobre = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buscas1 = new Buscas();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblProxLeituras = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblLendo = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            toolStrip.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.AutoSize = false;
            toolStrip.BackColor = Color.FromArgb(100, 63, 49);
            toolStrip.Dock = DockStyle.Left;
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripSeparator2, toolStripUsuario, toolStripLendo, toolStripLidos, toolStripProxLeituras, toolStripSair, toolStripSobre });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(64, 670);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(62, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(62, 6);
            // 
            // toolStripUsuario
            // 
            toolStripUsuario.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripUsuario.Image = (Image)resources.GetObject("toolStripUsuario.Image");
            toolStripUsuario.ImageTransparentColor = Color.Magenta;
            toolStripUsuario.Name = "toolStripUsuario";
            toolStripUsuario.Size = new Size(62, 20);
            toolStripUsuario.Text = "toolStripButton1";
            toolStripUsuario.Click += toolStripUsuario_Click;
            // 
            // toolStripLendo
            // 
            toolStripLendo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLendo.Image = (Image)resources.GetObject("toolStripLendo.Image");
            toolStripLendo.ImageTransparentColor = Color.Magenta;
            toolStripLendo.Name = "toolStripLendo";
            toolStripLendo.Size = new Size(62, 20);
            toolStripLendo.Text = "toolStripButton1";
            toolStripLendo.Click += toolStripLendo_Click;
            // 
            // toolStripLidos
            // 
            toolStripLidos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLidos.Image = (Image)resources.GetObject("toolStripLidos.Image");
            toolStripLidos.ImageTransparentColor = Color.Magenta;
            toolStripLidos.Name = "toolStripLidos";
            toolStripLidos.Size = new Size(62, 20);
            toolStripLidos.Text = "toolStripButton1";
            toolStripLidos.Click += toolStripLidos_Click;
            // 
            // toolStripProxLeituras
            // 
            toolStripProxLeituras.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripProxLeituras.Image = (Image)resources.GetObject("toolStripProxLeituras.Image");
            toolStripProxLeituras.ImageTransparentColor = Color.Magenta;
            toolStripProxLeituras.Name = "toolStripProxLeituras";
            toolStripProxLeituras.Size = new Size(62, 20);
            toolStripProxLeituras.Text = "toolStripButton1";
            toolStripProxLeituras.Click += toolStripProxLeituras_Click;
            // 
            // toolStripSair
            // 
            toolStripSair.Alignment = ToolStripItemAlignment.Right;
            toolStripSair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSair.Image = (Image)resources.GetObject("toolStripSair.Image");
            toolStripSair.ImageTransparentColor = Color.Magenta;
            toolStripSair.Name = "toolStripSair";
            toolStripSair.Size = new Size(62, 20);
            toolStripSair.Text = "toolStripButton2";
            toolStripSair.Click += toolStripSair_Click;
            // 
            // toolStripSobre
            // 
            toolStripSobre.Alignment = ToolStripItemAlignment.Right;
            toolStripSobre.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSobre.Image = (Image)resources.GetObject("toolStripSobre.Image");
            toolStripSobre.ImageTransparentColor = Color.Magenta;
            toolStripSobre.Name = "toolStripSobre";
            toolStripSobre.Size = new Size(62, 20);
            toolStripSobre.Text = "toolStripButton1";
            toolStripSobre.Click += toolStripSobre_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.Transparent;
            statusStrip.Location = new Point(64, 648);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1187, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buscas1);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(lblProxLeituras);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblLendo);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(64, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 619);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(549, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // buscas1
            // 
            buscas1.BackColor = Color.AntiqueWhite;
            buscas1.Location = new Point(577, -14);
            buscas1.Name = "buscas1";
            buscas1.Size = new Size(610, 619);
            buscas1.TabIndex = 22;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(39, 246);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 126);
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(333, 423);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 126);
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(333, 107);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 126);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // lblProxLeituras
            // 
            lblProxLeituras.AutoSize = true;
            lblProxLeituras.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProxLeituras.Location = new Point(39, 400);
            lblProxLeituras.Name = "lblProxLeituras";
            lblProxLeituras.Size = new Size(134, 20);
            lblProxLeituras.TabIndex = 13;
            lblProxLeituras.Text = "Próximas Leituras";
            lblProxLeituras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(189, 423);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 126);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(39, 423);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 126);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // lblLendo
            // 
            lblLendo.AutoSize = true;
            lblLendo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLendo.Location = new Point(39, 84);
            lblLendo.Name = "lblLendo";
            lblLendo.Size = new Size(52, 20);
            lblLendo.TabIndex = 6;
            lblLendo.Text = "Lendo";
            lblLendo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(189, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 126);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(39, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 126);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(100, 63, 49);
            label1.Location = new Point(64, 0);
            label1.Name = "label1";
            label1.Size = new Size(1187, 27);
            label1.TabIndex = 6;
            // 
            // mdiMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(1251, 670);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "mdiMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += mdiMenu_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripButton toolStripUsuario;
        private ToolStripButton toolStripSair;
        private ToolStripButton toolStripLendo;
        private ToolStripButton toolStripLidos;
        private ToolStripButton toolStripProxLeituras;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblLendo;
        private PictureBox pictureBox3;
        private Label lblProxLeituras;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private ToolStripButton toolStripSobre;
        private Label label1;
        private PictureBox pictureBox8;
        private Buscas buscas1;
        private PictureBox pictureBox1;
    }
}



