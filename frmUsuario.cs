using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
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

        private void dadosUsuario(string usuario)
        {
            try
            {

                string xUser = usuario;

                Banco.Conectar();
                string selecionarUsuarios = "SELECT Nome, Email FROM Usuarios WHERE Nome = @usuario;";
                MySqlCommand cmd = new MySqlCommand(selecionarUsuarios, Banco.conexao);
                cmd.Parameters.AddWithValue("@usuario", xUser);

                MySqlDataReader dr =  cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtEmailUsuario.Text = dr["Email"].ToString();
                    txtNomeUsuario.Text = dr["Nome"].ToString();

                }


                Banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }





     

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarUsuario formsAlterar = new frmAlterarUsuario();
            formsAlterar.ShowDialog();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dadosUsuario("teste");
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
