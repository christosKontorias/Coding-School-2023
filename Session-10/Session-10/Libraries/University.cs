using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries {
    class University : Institute {
        public List<Students> Student { get; set; }
        public List<Grades> Grade { get; set; }
        public List<Courses> Course { get; set; }
        public List<ScheduledCourses> ScheduledCourse { get; set; }

        public University() {
            Student = new List<Students>();
            Grade = new List<Grades>();
            Course = new List<Courses>();
            ScheduledCourse = new List<ScheduledCourses>();
        }
    }
}
