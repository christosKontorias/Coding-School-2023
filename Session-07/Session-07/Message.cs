using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class Message
    {
        //Properties
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }

        //Change from class diagram: Message Cannot be the same as the class name
        public string MessageValue { get; set; }
        //Constructor
        public Message()
        {
            ID = Guid.NewGuid(); 
        }

        public Message(string messageValue)
        {
            ID = Guid.NewGuid();
            MessageValue = messageValue;
            TimeStamp = DateTime.Now;  

        }
    }
}
