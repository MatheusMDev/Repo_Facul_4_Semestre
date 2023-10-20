using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecommerce.Models.Data
{
    public class Data
    {
        // conexão usando a autenticaçã do Windows
        // private static string stringConexao = @"Data source = localhost;
        // Initial Catalog = VendaLanchesBD;
        // Integrated Security = true;";


        // conexao usando autentificação do SQL SERVER
        private static string stringConexao = @"DataSource = localhost; Initial Catalog = VendaLanchesBD; 
                                                User ID = computacao; Password = aa11++--;";

        // declarando o objeto conexaoBD e inicializando com null
        private static SqlConnection conexaoBD = null;

        // implementando um metodo para fazer a conexao com o banco de dados
        private static SqlConnection ConectarBancoDados()
        {
            //instanciando o objeto conexaoBD e passando para o construtor da classe SqlConnection como parametro a stringSQL
            //para fazer a conexão com o banco de dados
            conexaoBD = new SqlConnection(stringConexao);

            try
            {
                //abrir o banco de dados
                conexaoBD.Open();
                Console.WriteLine("Conexão OK");
            }
            catch(SqlException erro)
            {
                // ocorreu erro na conexão com o Banco de Dados 
                conexaoBD = null;
                Console.WriteLine("Conexão Error :" + erro);
            }

            // retorna a con~exão com Banco de Dados se deu certo ou retorna null se não foi possível conectar com o Banco de Dados
            return conexaoBD;
        }
        public static void fecharConexaoBancoDados()
        {
            if (conexaoBD != null)
            {
                conexaoBD.Close();
            }
        }

    }
}