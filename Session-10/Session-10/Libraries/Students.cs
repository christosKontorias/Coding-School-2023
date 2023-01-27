using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries {
    public class Students : Person {
        //Properties
        public int RegistrationNumber { get; set; }

        //Constructor
        public Students() {
            ID = Guid.NewGuid();
        }
    }
}
