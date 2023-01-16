using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    class University
    {
        //Properties
        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }
        public Grade[]? Grades { get; set; }
        public Schedule[]? ScheduledCourse { get; set; }

        //Methods
        public void GetStudents()
        {

        }

        public void GetCourses()
        {

        }

        public void GetGrades()
        {

        }
        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime datetime)
        {

        }

        //Constructor
    }
}
