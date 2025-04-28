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
            statusStrip = new StatusStrip();
            toolTip = new ToolTip(components);
            toolStripUsuario = new ToolStripButton();
            toolStripSair = new ToolStripButton();
            toolStripLendo = new ToolStripButton();
            toolStripLidos = new ToolStripButton();
            toolStripDesejos = new ToolStripButton();
            toolStrip.SuspendLayout();
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
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripSeparator2, toolStripUsuario, toolStripLendo, toolStripLidos, toolStripDesejos, toolStripSair });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(24, 499);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(21, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(21, 6);
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(24, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(713, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripUsuario
            // 
            toolStripUsuario.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripUsuario.Image = (Image)resources.GetObject("toolStripUsuario.Image");
            toolStripUsuario.ImageTransparentColor = Color.Magenta;
            toolStripUsuario.Name = "toolStripUsuario";
            toolStripUsuario.Size = new Size(21, 20);
            toolStripUsuario.Text = "toolStripButton1";
            // 
            // toolStripSair
            // 
            toolStripSair.Alignment = ToolStripItemAlignment.Right;
            toolStripSair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSair.Image = (Image)resources.GetObject("toolStripSair.Image");
            toolStripSair.ImageTransparentColor = Color.Magenta;
            toolStripSair.Name = "toolStripSair";
            toolStripSair.Size = new Size(21, 20);
            toolStripSair.Text = "toolStripButton2";
            // 
            // toolStripLendo
            // 
            toolStripLendo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLendo.Image = (Image)resources.GetObject("toolStripLendo.Image");
            toolStripLendo.ImageTransparentColor = Color.Magenta;
            toolStripLendo.Name = "toolStripLendo";
            toolStripLendo.Size = new Size(21, 20);
            toolStripLendo.Text = "toolStripButton1";
            // 
            // toolStripLidos
            // 
            toolStripLidos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLidos.Image = (Image)resources.GetObject("toolStripLidos.Image");
            toolStripLidos.ImageTransparentColor = Color.Magenta;
            toolStripLidos.Name = "toolStripLidos";
            toolStripLidos.Size = new Size(21, 20);
            toolStripLidos.Text = "toolStripButton1";
            // 
            // toolStripDesejos
            // 
            toolStripDesejos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDesejos.Image = (Image)resources.GetObject("toolStripDesejos.Image");
            toolStripDesejos.ImageTransparentColor = Color.Magenta;
            toolStripDesejos.Name = "toolStripDesejos";
            toolStripDesejos.Size = new Size(21, 20);
            toolStripDesejos.Text = "toolStripButton1";
            // 
            // mdiMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(737, 523);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "mdiMenu";
            Text = "mdiMenu";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
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
        private ToolStripButton toolStripDesejos;
    }
}



