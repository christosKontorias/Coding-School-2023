using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    class Student : Person
    {
        //Properties
        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; }

        //Methods
        public void Attend(string course, DateTime datetime)
        {

        }

        public void WriteExam(string course, DateTime datetime)
        {

        }

        //Constructor
        public Student()
        {

        }
        public Student(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }
        public Student(int registrationNumber, Course[] courses)
        {
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }
    }
}
