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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //voltar para o menu principal

            this.Close();
            this.Dispose();
        }

        //private void listarUsuarios()
        //{
        //    try
        //    {
        //        Banco.Conectar();
        //        string selecionarUsuarios = "SELECT Usuario, Email FROM Usuarios WHERE Usuario = @usuario AND Email = @email";
        //        MySqlCommand cmd = new MySqlCommand(selecionarUsuarios, Banco.conexao);

        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);


        //        txtNomeUsuario.Text = "@usuario";
        //        txtEmailUsuario.Text = "@email";


        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show(erro.ToString());
        //    }
        //}





        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //deletarUsuario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarUsuario formsAlterar = new frmAlterarUsuario();
            formsAlterar.ShowDialog();
        }

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

        //        }

        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show(erro.ToString());
        //    }
        //}


    }
}
