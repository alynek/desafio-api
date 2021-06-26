using Microsoft.Data.SqlClient;
using PeopleApi.Models;
using System;
using System.Threading.Tasks;

namespace PeopleApi.Data
{
    public class ADODb
    {
        public SqlConnection connection;
        public ADODb()
        {
            try
            {
                connection = new SqlConnection("Data Source=ALYNE\\SQLEXPRESS;Initial Catalog=PeopleDb;Integrated Security=true");
            }
            catch (Exception ex)
            {
            }
        }

        public async Task<Pessoa> ExecutaQuery<T>(string queryString)
        {
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader =  command.ExecuteReader();

                Pessoa pessoa = null;

                if (reader.Read())
                {
                        pessoa = new Pessoa
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                        Ativo = Convert.ToBoolean(reader["Ativo"])
                    };
                        
                }

                reader.Close();
                return pessoa;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
