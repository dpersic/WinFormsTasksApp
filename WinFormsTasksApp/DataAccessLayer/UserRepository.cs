using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository
    {
        public string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";


        public List<User> GetAll()
        {
            var users = new List<User>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Tasks_Users";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User()
                        {
                            nId = (int)reader["ID"],
                            sPassword = (string)reader["PASSWORD"],
                            sUsername = (string)reader["USERNAME"],
                            sName = (string)reader["NAME"]
                        });
                    }
                }
            }
            return users;
        }
        public void CreateUser(User user)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO users (USERNAME, PASSWORD, NAME) VALUES ('" + user.sUsername + "','" + user.sPassword + "','" + user.sName + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void UpdateUser(User user)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE USERS SET NAME = '" + user.sName + "', USERNAME = '" + user.sUsername + "', PASSWORD = '" + user.sPassword + "' WHERE USER_ID = " + user.nId;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteUser(User user)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM users WHERE USER_ID = " + user.nId;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
}
