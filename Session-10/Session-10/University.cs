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
        //public Course[]? Courses { get; set; }
        //public Grade[]? Grades { get; set; }
        //public Schedule[]? ScheduledCourse { get; set; }

        public University()
        {
            Students = new List<Student>();
        }
    }

    class Person
    {
        public Guid ID { get; set; }
        //public string? Name { get; set; }
        //public int Age { get; set; }

        public Person()
        {
            ID = Guid.NewGuid();
        }
    }
    class Student : Person
    {
        //public int RegistrationNumber { get; set; }
        //public Course[]? Courses { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}