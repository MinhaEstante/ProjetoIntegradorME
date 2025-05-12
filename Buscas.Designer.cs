namespace ProjetoIntegradorME
{
    partial class Buscas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblProcurar = new Label();
            cbxProcura = new ComboBox();
            txtInfoBox = new TextBox();
            rbtnBuscar = new RadioButton();
            rbtnSelecionarID = new RadioButton();
            lblBusca = new Label();
            lblCtg = new Label();
            resultsListBox = new CheckedListBox();
            lblBuscas = new Label();
            txtBuscas = new TextBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            SuspendLayout();
            // 
            // lblProcurar
            // 
            lblProcurar.AutoSize = true;
            lblProcurar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProcurar.Location = new Point(160, 361);
            lblProcurar.Name = "lblProcurar";
            lblProcurar.Size = new Size(80, 15);
            lblProcurar.TabIndex = 38;
            lblProcurar.Text = "Procurar por:";
            // 
            // cbxProcura
            // 
            cbxProcura.BackColor = Color.FromArgb(100, 63, 49);
            cbxProcura.FormattingEnabled = true;
            cbxProcura.Location = new Point(144, 379);
            cbxProcura.Name = "cbxProcura";
            cbxProcura.Size = new Size(121, 23);
            cbxProcura.TabIndex = 37;
            // 
            // txtInfoBox
            // 
            txtInfoBox.Location = new Point(233, 59);
            txtInfoBox.Name = "txtInfoBox";
            txtInfoBox.Size = new Size(270, 23);
            txtInfoBox.TabIndex = 36;
            // 
            // rbtnBuscar
            // 
            rbtnBuscar.AutoSize = true;
            rbtnBuscar.Location = new Point(204, 280);
            rbtnBuscar.Name = "rbtnBuscar";
            rbtnBuscar.Size = new Size(60, 19);
            rbtnBuscar.TabIndex = 35;
            rbtnBuscar.TabStop = true;
            rbtnBuscar.Text = "Buscar";
            rbtnBuscar.UseVisualStyleBackColor = true;
            // 
            // rbtnSelecionarID
            // 
            rbtnSelecionarID.AutoSize = true;
            rbtnSelecionarID.Location = new Point(171, 305);
            rbtnSelecionarID.Name = "rbtnSelecionarID";
            rbtnSelecionarID.Size = new Size(93, 19);
            rbtnSelecionarID.TabIndex = 34;
            rbtnSelecionarID.TabStop = true;
            rbtnSelecionarID.Text = "Selecionar ID";
            rbtnSelecionarID.UseVisualStyleBackColor = true;
            // 
            // lblBusca
            // 
            lblBusca.AutoSize = true;
            lblBusca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBusca.Location = new Point(181, 162);
            lblBusca.Name = "lblBusca";
            lblBusca.Size = new Size(39, 15);
            lblBusca.TabIndex = 33;
            lblBusca.Text = "Busca";
            // 
            // lblCtg
            // 
            lblCtg.AutoSize = true;
            lblCtg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCtg.Location = new Point(160, 147);
            lblCtg.Name = "lblCtg";
            lblCtg.Size = new Size(85, 15);
            lblCtg.TabIndex = 32;
            lblCtg.Text = "Categorias de ";
            // 
            // resultsListBox
            // 
            resultsListBox.BackColor = Color.AntiqueWhite;
            resultsListBox.FormattingEnabled = true;
            resultsListBox.Location = new Point(144, 180);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(120, 94);
            resultsListBox.TabIndex = 31;
            // 
            // lblBuscas
            // 
            lblBuscas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscas.Location = new Point(322, 97);
            lblBuscas.Name = "lblBuscas";
            lblBuscas.Size = new Size(181, 15);
            lblBuscas.TabIndex = 30;
            lblBuscas.Text = "Buscas";
            lblBuscas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscas
            // 
            txtBuscas.Cursor = Cursors.IBeam;
            txtBuscas.Location = new Point(283, 115);
            txtBuscas.Multiline = true;
            txtBuscas.Name = "txtBuscas";
            txtBuscas.ScrollBars = ScrollBars.Vertical;
            txtBuscas.Size = new Size(284, 464);
            txtBuscas.TabIndex = 29;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(509, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(314, 30);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(189, 23);
            txtBuscar.TabIndex = 27;
            // 
            // Buscas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(lblProcurar);
            Controls.Add(cbxProcura);
            Controls.Add(txtInfoBox);
            Controls.Add(rbtnBuscar);
            Controls.Add(rbtnSelecionarID);
            Controls.Add(lblBusca);
            Controls.Add(lblCtg);
            Controls.Add(resultsListBox);
            Controls.Add(lblBuscas);
            Controls.Add(txtBuscas);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Name = "Buscas";
            Size = new Size(602, 609);
            Load += Buscas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProcurar;
        private ComboBox cbxProcura;
        private TextBox txtInfoBox;
        private RadioButton rbtnBuscar;
        private RadioButton rbtnSelecionarID;
        private Label lblBusca;
        private Label lblCtg;
        private CheckedListBox resultsListBox;
        private Label lblBuscas;
        private TextBox txtBuscas;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
    }
}
