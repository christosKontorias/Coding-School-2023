using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries {
    public class ScheduledCourses {
        //Properties
        public Guid ID { get; set; }
        public DateTime Callendar { get; set; }

        //Constructor
        public ScheduledCourses() {

        }
        public ScheduledCourses(Guid id) {
            ID = Guid.NewGuid();
        }

    }
}
