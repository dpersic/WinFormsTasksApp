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
        public Task  nOwnerId { get; set; } 
        public Task nWorkerId { get; set; }
        public string sDeadline { get; set; }
        public bool bActive { get; set; }
    }
}
