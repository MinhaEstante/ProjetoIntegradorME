using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoIntegradorME.User;

namespace ProjetoIntegradorME
{
    public partial class frmAlterarUsuario : Form
    {
        public frmAlterarUsuario()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        //    if (txtNovoNome.Text.Trim() == "" || txtNovoEmail.Text.Trim() == "" || txtNovaSenha.Text.Trim().Length < 6)
        //    {
        //        MessageBox.Show("Dados incorretos!");
        //        txtNovoNome.Focus();
        //    }
        //    else

        //        alterarUsuario();
        }





        //private void alterarUsuario()
        //{

        //    try
        //    {
        //        string nome = txtNovoNome.Text.Trim();
        //        string email = txtNovoEmail.Text.Trim();
        //        string senha = txtNovaSenha.Text.Trim();
        //        int idUsuarios = txtID.Text.Trim();

        //        Banco.Conectar();

        //        string atualizar = "UPDATE Usuarios SET Nome = @nome, Email = @email, Senha = @senha WHERE idUsuarios = @id;";
        //        MySqlCommand cm = new MySqlCommand(atualizar, Banco.conexao);
        //        cm.Parameters.AddWithValue("@nome", nome);
        //        cm.Parameters.AddWithValue("@email", email);
        //        cm.Parameters.AddWithValue("@senha", senha);
        //        cm.Parameters.AddWithValue("@id", idUsuarios);
        //        cm.ExecuteNonQuery();

        //        MessageBox.Show("Usuário alterado com sucesso!");

        //        txtNovoNome.Clear();
        //        txtNovoEmail.Clear();
        //        txtNovaSenha.Clear();

        //        btnAlterar.Enabled = false;

        //        Banco.Desconectar();


        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show(erro.ToString());
        //    }

        //}


        private void dadosUs(string usuario)
        {
            try
            {

                string xUser = usuario;

                Banco.Conectar();
                string selecionarUsuarios = "SELECT Nome, Email, Senha FROM Usuarios WHERE Nome = @usuario;";
                MySqlCommand cmd = new MySqlCommand(selecionarUsuarios, Banco.conexao);
                cmd.Parameters.AddWithValue("@usuario", xUser);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtEmailAtual.Text = dr["Email"].ToString();
                    txtNomeAtual.Text = dr["Nome"].ToString();
                    txtSenhaAtual.Text = dr["Senha"].ToString();

                }


                Banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void frmAlterarUsuario_Load(object sender, EventArgs e)
        {
            dadosUs(Global.usuario);
        }

    }
}
