namespace ProjetoIntegradorME
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            //abrir formulário cadastro-criar conta

            frmCadastro frmNovaConta = new frmCadastro();
            frmNovaConta.ShowDialog();

        }
    }
}
