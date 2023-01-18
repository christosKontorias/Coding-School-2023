using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResponse : ActionEntity
    {
        //Properties
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        //Constructor
        public ActionResponse()
        {
            RequestID = Guid.NewGuid();
        }
    }
}
