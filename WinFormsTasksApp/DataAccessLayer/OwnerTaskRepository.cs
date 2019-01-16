using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public  class OwnerTaskRepository
    {
        public string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public TaskRepository tasksRepositry = new TaskRepository();
        public List<Entities.Task> _tasks = new List<Entities.Task>();
        public UserRepository userRepository = new UserRepository();



        public List<ViewModels.ViewTask> GetOwnerTasks(int ownerID)
        {
            var tasks = userRepository.GetUsers();
            var tasksOwnerWorker = _tasks.Where(x => x.nID == ownerID).Select(x => new ViewModels.ViewTask
            {

                sTitle = x.sTitle,
                sDescription = x.sDescription,
                sOwner = tasks.Where(t => t.nId == x.nOwnerId).Select(t => t.sUsername).FirstOrDefault()

            }).ToList();
            return tasksOwnerWorker;
        }

            
        public List<Entities.Task> GetTasksOwner(int idOwner)
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
    }
}
