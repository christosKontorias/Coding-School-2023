using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10
{
    internal class Student
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
        public bool Undergraduate { get; set; }
        public GenderEnum Gender { get; set; }
    }
}
