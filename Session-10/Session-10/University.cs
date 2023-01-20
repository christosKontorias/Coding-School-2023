using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10
{
    public class Institute
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        //public int YearsInService { get; set; }

        public Institute()
        {
            ID = Guid.NewGuid();
        }
    }

    class University : Institute
    {
        public List<Student> Students { get; set; }
        public List<Grade> Grades { get; set; }

        public List<Course> Courses { get; set; }

        public List<ScheduledCourse> ScheduledCourses { get; set; }


        public University()
        {
            Students = new List<Student>();
            Grades = new List<Grade>();
            Courses = new List<Course>();
            ScheduledCourses = new List<ScheduledCourse>();
        }
    }

    class Person
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            ID = Guid.NewGuid();
        }
    }
    class Course
    {
        public Course()
        {
            ID = Guid.NewGuid();
        }
        //Properties
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }
    }
    class Grade
    {
        public Grade()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }
    }


    class ScheduledCourse
    {
        //Properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }
    }
    class Student : Person
    {
        public Student()
        {
            ID = Guid.NewGuid();
        }

        public enum GenderEnum { Male, Female, Other }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }
    }
}