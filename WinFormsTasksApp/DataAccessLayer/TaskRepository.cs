using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataAccessLayer
{
    public class TaskRepository
    {
        public string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
      

        //  public List<Entities.ViewTask> _tasks = new List<Entities.ViewTask>();




        public TaskRepository()
        {
         
        }
     
        public List<Entities.ViewTask> GetTasks(int userId)
        {
            var tasks = new List<Entities.ViewTask>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Tasks_Tasks where OWNER_ID ="+ userId + "";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tasks.Add(new Entities.ViewTask()
                        {
                            nID = (int)reader["ID"],
                            nOwnerId = (int)reader["OWNER_ID"],
                            nWorkerId = (int)reader["WORKER_ID"],
                            sTitle = (string)reader["TITLE"],
                            sDeadline = (DateTime)reader["DEADLINE"],
                            sDescription = (string)reader["DESCRIPTION"],
                            nActive = (int)reader["ACTIVE"]
                        });
                    }
                }
            }
            return tasks;
        }

        public List<ViewModels.ViewTask> GetAllName()
        {
            var users = userRepository.GetUsers();
            var tasks = _tasks.Select(o => new ViewModels.ViewTask
            {
                sTitle = o.sTitle,
                sDescription = o.sDescription,
                sDeadline = o.sDeadline,
                sOwner = users.Where(u => u.nId == o.nOwnerId).Select(u => u.sName + " " + u.sSurname).FirstOrDefault().ToString(),
            }).ToList();
            return tasks;
        }

        public void DeleteTask(Entities.ViewTask task)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Tasks_Tasks  ID = " + task.nID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void EditTask(Entities.ViewTask task)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Tasks_Tasks SET DESCRIPTION = '" + task.sDescription + "', TITLE = '" + task.sTitle + "', DEADLINE = '" + task.sDeadline + "' WHERE ID = " + task.nID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }


    }
}