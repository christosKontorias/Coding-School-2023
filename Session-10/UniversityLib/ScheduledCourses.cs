using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class ScheduledCourses {

        //Properties
        public Guid ID { get; set; }
        public DateTime Callendar { get; set; }
        public string CourseSubject { get; set; }


        //Constructor
        public ScheduledCourses() {
            ID= Guid.NewGuid();
        }

    }
}
