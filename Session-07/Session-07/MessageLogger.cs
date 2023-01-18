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
        int messageStored = 0;
        private int _messageCounter = 0;

        //Constructor
        public MessageLogger()
        {
            Messages = new Message[1000];
        }
        //Methods

        public string ReadAll()
        {
            string message = String.Empty;

            for (int i = 0; i < messageStored; i++)
            {
                message += Messages[i].MessageValue + "\n";
            }

            return message;
        }

        public void Clear()
        {
            Array.Clear(Messages);
        }
        public void Write(Message message)
        {
            Messages[_messageCounter] = message;
            _messageCounter++;

        }
    }
}
