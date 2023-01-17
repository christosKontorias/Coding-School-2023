using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class MessageLogger
    {
        //Properties
        public Message[] Messages { get; set; }
        int maxMessages = 1000;
        //Methods
        public string ReadAll()
        {
            string message = string.Empty;

            for(int i= 0; i <= maxMessages; i++)
            {
                message += Messages[i].MessageValue + ", ";
            }

            return message;
            Console.WriteLine("dsadasdsa");
        }
        public void Clear()
        {
            
        }
        public void Write(string Message)
        {

        }
    }
}
