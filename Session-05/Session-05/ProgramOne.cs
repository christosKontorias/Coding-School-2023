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
   
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseName += name[i];
            }
            return "The Reverse name is: " + reverseName + ".";
        }
    }
}
