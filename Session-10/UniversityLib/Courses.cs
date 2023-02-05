using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class Courses {
        //Properties
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        //Constructor
        public Courses() {
            ID = Guid.NewGuid();
        }
    }
}
