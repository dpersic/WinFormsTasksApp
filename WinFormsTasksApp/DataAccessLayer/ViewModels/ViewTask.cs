using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Entities;

namespace DataAccessLayer.ViewModels
{
     public class ViewTask
    {
       
        public string sTitle { get; set; }
        public string sDescription { get; set; }
        public string  sOwner { get; set; }
        public string sWorker { get; set; }
        public DateTime sDeadline { get; set; }
        public int nActive { get; set; }
        public List<ViewModels.ViewTask> OwnerTasks { get; set; }
    }
}
