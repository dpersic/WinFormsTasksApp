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
    public class TaskRepository
    {
        public string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";


        public List<Entities.Task> GetUsers()
        {
            var tasks = new List<Entities.Task>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Tasks_Users";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tasks.Add(new Entities.Task()
                        {
                            nID=(int)reader["ID"],
                            nOwnerId=(int)reader["OWNER_ID"],
                            nWorkerId=(int)reader["WORKSER_ID"],
                            sTitle=(string)reader["TITLE"],
                            sDeadline=(string)reader["DEADLINE"],
                            sDescription=(string)reader["DESCRIPTION"],
                            bActive=(int)reader["ACTIVE"]
                        });
                    }
                }
            }
            return tasks;
        }
    }
}