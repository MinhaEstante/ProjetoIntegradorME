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
    public partial class frmAlterarUsuario : Form
    {
        public frmAlterarUsuario()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //deletarUsuario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            //if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim().Length < 6)
            //{
            //    MessageBox.Show("Usuario ou Senha incorretos!");
            //    txtUsuario.Focus();
            //}
            //else
            //{
            //    alterarUsuario();
            //}
        }




        //private void alterarUsuario()
        //{

        //    try
        //    {
        //        string usuario = txtUsuario.Text.Trim();
        //        string senha = txtSenha.Text.Trim();
        //        int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);

        //        Banco.Conectar();

        //        string atualizar = "UPDATE t_usuario SET login = @login, senha = @senha WHERE id = @id;";
        //        MySqlCommand cm = new MySqlCommand(atualizar, Banco.conexao);
        //        cm.Parameters.AddWithValue("@login", usuario);
        //        cm.Parameters.AddWithValue("@senha", senha);
        //        cm.Parameters.AddWithValue("@id", id);
        //        cm.ExecuteNonQuery();

        //        MessageBox.Show("Cadastro alterado com sucesso!");

        //        txtUsuario.Clear();
        //        txtSenha.Clear();

        //        btnAlterar.Enabled = false;
        //        btnDeletar.Enabled = false;
        //        btnCadastrar.Enabled = true;

               


        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show(erro.ToString());
        //    }

        //}






        //private void deletarUsuario()
        //{
        //    try
        //    {
        //        int id = Convert.ToInt32(   dgvUsuarios   .CurrentRow.Cells[0].Value);
        //        DialogResult confirma = MessageBox.Show("Deseja deletar seu usuário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (confirma == DialogResult.Yes)
        //        {
        //            Banco.Conectar();
        //            string del = "DELETE FROM Usuarios WHERE id = @idUsuarios;";
        //            MySqlCommand cm = new MySqlCommand(del, Banco.conexao);
        //            cm.Parameters.AddWithValue("@idUsuarios", id);
        //            cm.ExecuteNonQuery();

        //            MessageBox.Show("Usuário excluído!");

        //            (vai fechar tudo)
        //            
        //            Banco.Desconectar();
        //        }

        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show(erro.ToString());
        //    }
        //}
    }
}
