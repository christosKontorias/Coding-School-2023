using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries {
    class Institute {
        //Properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }


        //Constructor
        public Institute() {

        }
        public Institute(Guid id) {
            ID = id;
        }
        public Institute(Guid id, string name) {
            ID = id;
            Name = name;
        }
        public Institute(Guid id, string name, int yearinservice) {
            ID = id;
            Name = name;
            YearsInService = yearinservice;
        }
    }
}
