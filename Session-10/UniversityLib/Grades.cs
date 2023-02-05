using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class Grades {
        //Properties
        public Guid ID { get; set; }
        public int GradeValue { get; set; }
        public string StudentName { get; set; }

        //Constructor
        public Grades() {
            ID = Guid.NewGuid();
        }
    }
}
