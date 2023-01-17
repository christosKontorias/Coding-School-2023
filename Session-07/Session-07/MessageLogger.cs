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
        int messageStored = 0;

        public MessageLogger() { Messages = new Message[maxMessages]; }
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
        public void Write(string message)
        {
           if(messageStored >= maxMessages)
            {
                messageStored = 0;
            }else
            {
                Message[] messages = Messages;
                messageStored++;
            }
        }
    }
}
