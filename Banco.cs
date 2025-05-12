using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorME
{
    public static class Banco
    {
        public static string db = "Server=u5a2o.h.filess.io;Port=3307;Database=minhaestante_towardalso;Uid=minhaestante_towardalso;Pwd=SenhaMinhaEstante;";
        public static MySqlConnection conexao; // Alterado para public para corrigir o erro CS0122  

        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();

                //var builder = new MySqlConnectionStringBuilder
                //{
                //    Server = "127.0.0.1",
                //    UserID = "root",
                //    Password = "senacJBQ",
                //    Database = "sys",
                //};

                //using var connection = new MySqlConnection(builder.ConnectionString);
                //await connection.OpenAsync();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao acessar o BANCO DE DADOS");
                MessageBox.Show(ex.ToString());
            }
        }
        //Método para fechar a conexão com o banco
        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao desconectar o BANCO DE DADOS");
            }
        }
    }
}

