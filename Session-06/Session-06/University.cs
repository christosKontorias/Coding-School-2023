using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    class University : Institute
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
        public University(Guid id, string name, int yearinservice) : base (id, name, yearinservice)
        {

        }
        public University()
        {

        }

        public University(Student[] students)
        {
            Students = students;
        }
        public University(Student[] students, Course[] courses)
        {
            Students = students;
            Courses = courses;
        }
        public University(Student[] students, Course[] courses, Grade[] grade)
        {
            Students = students;
            Courses = courses;
            Grades = grade;
        }
        public University(Student[] students, Course[] courses, Grade[] grade, Schedule[] scheduledcourse)
        {
            Students = students;
            Courses = courses;
            Grades = grade;
            ScheduledCourse = scheduledcourse;
        }
    }
    
}
