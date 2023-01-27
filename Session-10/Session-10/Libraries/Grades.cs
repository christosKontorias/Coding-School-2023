using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries {
    public class Grades {
        //Properties
        public Guid ID { get; set; }
        public int GradeValue { get; set; }

        //Constructor
        public Grades() {

        }
        public Grades(Guid id) {
            ID = Guid.NewGuid();
        }

    }
}