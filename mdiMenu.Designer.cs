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
            menuStrip = new MenuStrip();
            toolStrip = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripUsuario = new ToolStripButton();
            toolStripLendo = new ToolStripButton();
            toolStripLidos = new ToolStripButton();
            toolStripProxLeituras = new ToolStripButton();
            toolStripSair = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblProxLeituras = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblLendo = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            toolStrip.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(100, 63, 49);
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.FromArgb(100, 63, 49);
            toolStrip.Dock = DockStyle.Left;
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripSeparator2, toolStripUsuario, toolStripLendo, toolStripLidos, toolStripProxLeituras, toolStripSair });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(32, 499);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(29, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(29, 6);
            // 
            // toolStripUsuario
            // 
            toolStripUsuario.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripUsuario.Image = (Image)resources.GetObject("toolStripUsuario.Image");
            toolStripUsuario.ImageTransparentColor = Color.Magenta;
            toolStripUsuario.Name = "toolStripUsuario";
            toolStripUsuario.Size = new Size(29, 20);
            toolStripUsuario.Text = "toolStripButton1";
            // 
            // toolStripLendo
            // 
            toolStripLendo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLendo.Image = (Image)resources.GetObject("toolStripLendo.Image");
            toolStripLendo.ImageTransparentColor = Color.Magenta;
            toolStripLendo.Name = "toolStripLendo";
            toolStripLendo.Size = new Size(29, 20);
            toolStripLendo.Text = "toolStripButton1";
            toolStripLendo.Click += toolStripLendo_Click;
            // 
            // toolStripLidos
            // 
            toolStripLidos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLidos.Image = (Image)resources.GetObject("toolStripLidos.Image");
            toolStripLidos.ImageTransparentColor = Color.Magenta;
            toolStripLidos.Name = "toolStripLidos";
            toolStripLidos.Size = new Size(29, 20);
            toolStripLidos.Text = "toolStripButton1";
            toolStripLidos.Click += toolStripLidos_Click;
            // 
            // toolStripProxLeituras
            // 
            toolStripProxLeituras.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripProxLeituras.Image = (Image)resources.GetObject("toolStripProxLeituras.Image");
            toolStripProxLeituras.ImageTransparentColor = Color.Magenta;
            toolStripProxLeituras.Name = "toolStripProxLeituras";
            toolStripProxLeituras.Size = new Size(29, 20);
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
            toolStripSair.Size = new Size(29, 20);
            toolStripSair.Text = "toolStripButton2";
            toolStripSair.Click += toolStripSair_Click;
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(32, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(705, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(lblProxLeituras);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblLendo);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscar);
            panel1.Location = new Point(24, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 474);
            panel1.TabIndex = 4;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(483, 308);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 126);
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(333, 308);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 126);
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(333, 113);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 126);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // lblProxLeituras
            // 
            lblProxLeituras.AutoSize = true;
            lblProxLeituras.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProxLeituras.Location = new Point(39, 276);
            lblProxLeituras.Name = "lblProxLeituras";
            lblProxLeituras.Size = new Size(134, 20);
            lblProxLeituras.TabIndex = 13;
            lblProxLeituras.Text = "Próximas Leituras";
            lblProxLeituras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(189, 308);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 126);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(39, 308);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 126);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // lblLendo
            // 
            lblLendo.AutoSize = true;
            lblLendo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLendo.Location = new Point(39, 81);
            lblLendo.Name = "lblLendo";
            lblLendo.Size = new Size(52, 20);
            lblLendo.TabIndex = 6;
            lblLendo.Text = "Lendo";
            lblLendo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(189, 113);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 126);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(39, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 126);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(310, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(623, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(463, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 23);
            txtBuscar.TabIndex = 6;
            // 
            // mdiMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(737, 523);
            Controls.Add(panel1);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "mdiMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdiMenu";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
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
        private PictureBox pictureBox1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblLendo;
        private PictureBox pictureBox3;
        private Label lblProxLeituras;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
    }
}



