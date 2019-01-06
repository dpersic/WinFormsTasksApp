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


        public List<Entities.Task> GetTasks()
        {
            var tasks = new List<Entities.Task>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Tasks_Tasks";
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


        public void DeleteTask(Entities.Task task)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Tasks_Tasks WHERE ID = " + task.nID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void EditTask(Entities.Task task)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Tasks_Tasks SET DESCRIPTION = '" + task.sDescription + "', TITLE = '" + task.sTitle + "', DEADLINE = '" + task.sDeadline + "' WHERE USER_ID = " + task.nID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }


    }
}