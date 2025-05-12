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
            cbxProcura = new ComboBox();
            txtInfoBox = new TextBox();
            rbtnBuscar = new RadioButton();
            rbtnSelecionarID = new RadioButton();
            lblBusca = new Label();
            resultsListBox = new CheckedListBox();
            lblBuscas = new Label();
            txtBuscas = new TextBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lstAvaliac = new ListBox();
            btnAvaliar = new Button();
            cboAvaliar = new ComboBox();
            SuspendLayout();
            // 
            // cbxProcura
            // 
            cbxProcura.BackColor = Color.White;
            cbxProcura.FormattingEnabled = true;
            cbxProcura.Location = new Point(147, 68);
            cbxProcura.Name = "cbxProcura";
            cbxProcura.Size = new Size(121, 23);
            cbxProcura.TabIndex = 37;
            cbxProcura.Visible = false;
            // 
            // txtInfoBox
            // 
            txtInfoBox.Location = new Point(36, 95);
            txtInfoBox.Name = "txtInfoBox";
            txtInfoBox.Size = new Size(189, 23);
            txtInfoBox.TabIndex = 36;
            txtInfoBox.Visible = false;
            // 
            // rbtnBuscar
            // 
            rbtnBuscar.AutoSize = true;
            rbtnBuscar.Location = new Point(198, 43);
            rbtnBuscar.Name = "rbtnBuscar";
            rbtnBuscar.Size = new Size(60, 19);
            rbtnBuscar.TabIndex = 35;
            rbtnBuscar.TabStop = true;
            rbtnBuscar.Text = "Buscar";
            rbtnBuscar.UseVisualStyleBackColor = true;
            rbtnBuscar.Visible = false;
            // 
            // rbtnSelecionarID
            // 
            rbtnSelecionarID.AutoSize = true;
            rbtnSelecionarID.Location = new Point(175, 18);
            rbtnSelecionarID.Name = "rbtnSelecionarID";
            rbtnSelecionarID.Size = new Size(93, 19);
            rbtnSelecionarID.TabIndex = 34;
            rbtnSelecionarID.TabStop = true;
            rbtnSelecionarID.Text = "Selecionar ID";
            rbtnSelecionarID.UseVisualStyleBackColor = true;
            rbtnSelecionarID.Visible = false;
            // 
            // lblBusca
            // 
            lblBusca.AutoSize = true;
            lblBusca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBusca.Location = new Point(86, 0);
            lblBusca.Name = "lblBusca";
            lblBusca.Size = new Size(39, 15);
            lblBusca.TabIndex = 33;
            lblBusca.Text = "Busca";
            lblBusca.Visible = false;
            // 
            // resultsListBox
            // 
            resultsListBox.BackColor = Color.AntiqueWhite;
            resultsListBox.FormattingEnabled = true;
            resultsListBox.Location = new Point(36, 18);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(133, 94);
            resultsListBox.TabIndex = 31;
            resultsListBox.Visible = false;
            resultsListBox.SelectedIndexChanged += resultsListBox_SelectedIndexChanged;
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
            txtBuscas.Location = new Point(434, 118);
            txtBuscas.Multiline = true;
            txtBuscas.Name = "txtBuscas";
            txtBuscas.ScrollBars = ScrollBars.Vertical;
            txtBuscas.Size = new Size(284, 424);
            txtBuscas.TabIndex = 29;
            txtBuscas.TextChanged += txtBuscas_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(491, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(76, 23);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(283, 57);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(189, 23);
            txtBuscar.TabIndex = 27;
            // 
            // lstAvaliac
            // 
            lstAvaliac.FormattingEnabled = true;
            lstAvaliac.ItemHeight = 15;
            lstAvaliac.Location = new Point(37, 118);
            lstAvaliac.Name = "lstAvaliac";
            lstAvaliac.Size = new Size(391, 424);
            lstAvaliac.TabIndex = 38;
            // 
            // btnAvaliar
            // 
            btnAvaliar.Location = new Point(163, 548);
            btnAvaliar.Name = "btnAvaliar";
            btnAvaliar.Size = new Size(76, 23);
            btnAvaliar.TabIndex = 39;
            btnAvaliar.Text = "Avaliar";
            btnAvaliar.UseVisualStyleBackColor = true;
            // 
            // cboAvaliar
            // 
            cboAvaliar.BackColor = Color.White;
            cboAvaliar.FormattingEnabled = true;
            cboAvaliar.Items.AddRange(new object[] { "PÉSSIMO", "RUIM", "MEDIANO", "BOM", "ÓTIMO" });
            cboAvaliar.Location = new Point(36, 549);
            cboAvaliar.Name = "cboAvaliar";
            cboAvaliar.Size = new Size(121, 23);
            cboAvaliar.TabIndex = 40;
            // 
            // Buscas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(cboAvaliar);
            Controls.Add(btnAvaliar);
            Controls.Add(lstAvaliac);
            Controls.Add(cbxProcura);
            Controls.Add(txtInfoBox);
            Controls.Add(rbtnBuscar);
            Controls.Add(rbtnSelecionarID);
            Controls.Add(lblBusca);
            Controls.Add(resultsListBox);
            Controls.Add(lblBuscas);
            Controls.Add(txtBuscas);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Name = "Buscas";
            Size = new Size(770, 609);
            Load += Buscas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbxProcura;
        private TextBox txtInfoBox;
        private RadioButton rbtnBuscar;
        private RadioButton rbtnSelecionarID;
        private Label lblBusca;
        private CheckedListBox resultsListBox;
        private Label lblBuscas;
        private TextBox txtBuscas;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
        private ListBox lstAvaliac;
        private Button btnAvaliar;
        private ComboBox cboAvaliar;
    }
}
