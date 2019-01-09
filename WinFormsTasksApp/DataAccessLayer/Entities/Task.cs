using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Task
    {
        public int nID { get; set; }
        public string sTitle { get; set; }
        public int nOwnerId { get; set; }
        public int nWorkerId { get; set; }
        public string sDescription { get; set; }
        public DateTime sDeadline { get; set; }
        public int nActive { get; set; }
    }
}
