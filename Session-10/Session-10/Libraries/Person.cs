using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries {
    public class Person {
        //Properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }


        //Constructors
        public Person() {

        }
        public Person(Guid id) {
            ID = id;
        }
        public Person(Guid id, string name) {
            ID = id;
            Name = name;
        }
        public Person(Guid id, string name, int age) {
            ID = id;
            Name = name;
            Age = age;
        }

    }
}
