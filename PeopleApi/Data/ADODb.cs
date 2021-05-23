using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace PeopleApi.Data
{
    public class ADODb
    {
        public SqlConnection connection;
        public ADODb()
        {
            try
            {
                connection = new SqlConnection("Data Source=DESKTOP-OE806TC\\SQLEXPRESS;Initial Catalog=PeopleDb;Integrated Security=true");
            }
            catch (Exception ex)
            {
            }
        }

        public void ExecutaQuery<T>(string queryString)
        {
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.CommandTimeout = 9600;

                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
