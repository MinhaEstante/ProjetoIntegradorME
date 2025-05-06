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

namespace ProjetoIntegradorME
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void inserirUsuario()
        {

            try
            {

                Banco.Conectar();
                string inserir = "INSERT INTO Usuarios (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha);";
                MySqlCommand cmd = new MySqlCommand(inserir, connection: Banco.conexao);
                cmd.Parameters.AddWithValue("@Nome", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Senha", txtSenha.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado com sucesso!");

                txtUsuario.Clear();
                txtEmail.Clear();
                txtSenha.Clear();

                Banco.Desconectar();

                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim().Length < 6)
            {
                MessageBox.Show("Usuario ou Senha incorretos!");
                txtUsuario.Focus();
            }
            else
            {
                inserirUsuario();
            }
        }
    }
}
