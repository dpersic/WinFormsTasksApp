using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataAccessLayer.ViewModels
{
     public class ViewTask
    {
       
        public string sTitle { get; set; }
        public string sDescription { get; set; }
        public int  nOwnerID { get; set; } // jel je potrebno staviti string sOwnerName
        public int nWorkerID { get; set; }
        public DateTime sDeadline { get; set; }
        public int nActive { get; set; }
    }
}
