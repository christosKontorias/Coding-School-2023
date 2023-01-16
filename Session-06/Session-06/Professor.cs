using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    class Professor : Person
    {
        //Properties
        public string? Rank { get; set; }
        public Course[]? Courses { get; set; }


        //Methods
        public void Teach(Course[] course, DateTime datetime)
        {

        }
        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {

        }
        public void GetName()
        {

        }

        //Constructor
    }
}
