using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class Students : Person{
        //Properties
        public int RegistrationNumber { get; set; }
        public List<Courses> Courses { get; set; }

        //Constructor
        public Students() {
            ID = Guid.NewGuid();
        }
        public Students(String name, int age, int registrationNumber) {

        }
    }
}
