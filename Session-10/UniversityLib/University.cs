using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLib;

namespace Session_10 {
    public class University {
        public List<Students> Students { get; set; }
        public List<Grades> Grades { get; set; }
        public List<Courses> Courses { get; set; }
        public List<ScheduledCourses> ScheduledCourses { get; set; }


        public University() {
            Students = new List<Students>();
            Grades = new List<Grades>();
            Courses = new List<Courses>();
            ScheduledCourses = new List<ScheduledCourses>();
        }
    }
}
