using MySql.Data.MySqlClient;

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

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text.Trim() != "" && txtSenha.Text.Trim() != "")
            {
                //função de autenticar no banco (validar on BD)
                Banco.Conectar();

                //string comando sql 
                string selecionar = "SELECT Email, Senha FROM Usuarios WHERE Email = @email AND Senha = @senha;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    mdiMenu sistema = new mdiMenu();
                    sistema.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Falha de autenticação!!!");
                    txtEmail.Focus();
                }


            }
            else
            {
                MessageBox.Show("Email e Senha são obrigatórios!");
                txtEmail.Focus();
            }

        }
    }
}
