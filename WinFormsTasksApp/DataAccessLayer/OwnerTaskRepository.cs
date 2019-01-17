using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using DataAccessLayer.ViewModels;

namespace DataAccessLayer
{
    public  class OwnerTaskRepository
    {
        public string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public TaskRepository tasksRepositry = new TaskRepository();
        public List<Entities.ViewTask> _tasks = new List<Entities.ViewTask>();
        public UserRepository userRepository = new UserRepository();

        public OwnerTaskRepository()
        {
            
        }

        public List<ViewTask> GetAll()
        {
            var tasks= userRepository.GetUsers();
            var zadaci = _tasks.Select(o => new ViewTask
            {
                sTitle = o.sTitle,
                sDescription = o.sDescription,
                sDeadline = o.sDeadline,
                sOwner = tasks.Where(c => c.nId == o.nOwnerId).Select(c => c.sName + " " + c.sSurname).FirstOrDefault(),
                
            }).ToList();
            return zadaci;          
        }

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

            
        public List<Entities.ViewTask> GetTasksOwner(int idOwner)
        {
            var tasks = new List<Entities.ViewTask>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Tasks_Tasks";
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
    }
}
