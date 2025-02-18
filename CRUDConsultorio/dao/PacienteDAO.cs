using CRUDConsultorio.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsultorio
{
    internal class PacienteDAO
    {
        public void Salvar(Paciente paciente)
        {
            try
            {
                string slq = "INSERT INTO Pacientes (Nome, Cpf ,Email, Telefone, DataNascimento)" +
                "VALUES (@Nome,@Cpf, @Email, @Telefone, @DataNascimento)";

                MySqlCommand comando = new MySqlCommand(slq, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", paciente.Nome);
                comando.Parameters.AddWithValue("@email", paciente.Cpf);
                comando.Parameters.AddWithValue("@telefone", paciente.Email);
                comando.Parameters.AddWithValue("@dataNasc", paciente.Telefone);
                comando.Parameters.AddWithValue("@dataNasc", paciente.DataNascimento);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar aluno {ex.Message}");
            }

        }

        public void Deletar( Paciente paciente)
        {
            try
            {
                string sql = "DELETE FROM Pacientes WHERE IdPaciente = @IdPaciente";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@IdPaciente", paciente.IdPaciente);
                comando.ExecuteNonQuery();
                Console.WriteLine("Paciente excluido com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar excluir: {ex.Message}");
            }
        }

        public void Atualizar(Paciente paciente)
        {
            try
            {
                string sql = "UPDATE Pacientes SET Nome = @Nome, Cpf = @Cpf, Email = @Email, DataNascimento = @DataNascimento   WHERE IdPaciente" ;
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@Nome", paciente.Nome);
                comando.Parameters.AddWithValue("@Cpf", paciente.Cpf);
                comando.Parameters.AddWithValue("@Email", paciente.Email);
                comando.Parameters.AddWithValue("@Telefone", paciente.Telefone);
                comando.Parameters.AddWithValue("@DataNascimento", paciente.DataNascimento);
                comando.Parameters.AddWithValue("@IdPaciente", paciente.IdPaciente);
                comando.ExecuteNonQuery();
                Console.WriteLine("Paciente atualizado com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar atualizar: {ex.Message}");
            }
        }

        public List<Paciente> List()
        {
            List<Paciente> pacientes = new List<Paciente>();
            try
            {
                var sql = "SELECT * FROM Pacientes ORDER BY IdPaciente";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Paciente paciente = new Paciente();
                        paciente.IdPaciente = dr.GetInt32("IdPaciente");
                        paciente.Nome = dr.GetString("Nome");
                        paciente.Cpf = dr.GetString("Cpf"); 
                        paciente.Email = dr.GetString("Email");
                        paciente.Telefone = dr.GetString("Telefone");
                        paciente.DataNascimento = dr.GetString("DataNascimento");
                        pacientes.Add(paciente);
                    }
                }
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar listar: {ex.Message}");
            }
            return pacientes;
        }
    }
}
