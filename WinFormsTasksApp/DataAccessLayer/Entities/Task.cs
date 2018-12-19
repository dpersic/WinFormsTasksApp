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
        public int nOwnerId { get; set; } // Prepraviti, kasnije u STRING jer mora pisati ime ( objekt klase )
        public int nWorkerId { get; set; } // Prepraviti, kasnije u STRING jer mora pisati ime ( ojekt klase )
       
        public string sDeadline { get; set; }
        public bool bActive { get; set; }
    }
}
