using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsultorio.data
{
    internal class Conexao
    {
        static MySqlConnection conexao;
        static string strconexao ="server=localhost;Port=3307;uid=root;pwd=root;database=CadastrarPacientes";

        public static MySqlConnection Conectar()
        {
            try
            {
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                Console.WriteLine("conexão criada com sucesso!");
                return conexao;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar a conexão com a base de dados!");
            }
        }
        
        public static void FecharConexao()
        {
            conexao.Close();
        }
                    
    }
}
