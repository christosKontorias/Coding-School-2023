using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ProgramOne
    {
        public string ReverseName()
        {
            String name, reverseName;
            name = "Christos";
            reverseName = "";

            Console.WriteLine("Name is {0}.", name);

            // Find Name Length
            int length;
            length = name.Length - 1;
            while (length >= 0)
            {
                reverseName = reverseName + name[length];
                length--;
            }

            return "The Reverse name is: " + reverseName + ".";
        }

    }
}
