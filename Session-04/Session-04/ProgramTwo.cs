using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_04
{
    internal class ProgramTwo
    {
        double numberA = 8.5;
        double numberB = 1.5;


        public double Sum()
        {
            double sum = numberA + numberB;
            return sum;
        }

        public double Division()
        {
            double division = numberA / numberB;
            return division;
        }
    }
}
