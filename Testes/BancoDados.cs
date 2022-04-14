using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Testes
{
    public class BancoDados
    {
        //método para conectar o banco de dados
        public static MySqlConnection getConnection()
        {
            //acessando a string de conexão - Alterar a string de conexão no App.config
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
