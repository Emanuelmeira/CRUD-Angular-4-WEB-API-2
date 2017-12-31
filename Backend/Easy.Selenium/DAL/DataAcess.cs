using Dapper;
using Easy.Domain.Entities;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Easy.Selenium.DAL
{
    public class DataAcess
    {
        public DataAcess()
        {

        }
        
        static string ConnectionString = ConfigurationManager.ConnectionStrings["CRUD-EASY"].ConnectionString;

        public bool ExistDeveloperByName(string name)
        {
            var query = @" Select * from Developer where Name = @Name; ";

            try
            {

                using (var sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    dynamic developer = sqlConnection.Query<Developer>(query, new { Name = name });

                    sqlConnection.Close();

                    return developer != null;
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }


        }


    }
}
