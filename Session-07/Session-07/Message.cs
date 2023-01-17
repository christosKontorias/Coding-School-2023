﻿using System;
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
        public string MessageValue { get; set; }

        public Message()
        {
            ID = Guid.NewGuid(); 
        }
    }
}
