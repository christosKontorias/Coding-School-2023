using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ProgramThree
    {
        public int operationOne()
        {
            int numberA = 1;
            int numberB = 5;
            int numberC = 6;

            int resultOne = (- numberA) + (numberB * numberC);
            
            return resultOne;  
        }
        public int operationTwo()
        {
            int numberA = 38;
            int numberB = 5;
            int numberC = 7;

            int resultTwo = numberA + (numberB % numberC);

            return resultTwo;
        }
        public double operationThree()
        {
            double numberA = 3.0;
            double numberB = 6.0;
            double numberC = 7.0;
            double numberD = 14.0;

            double resultThree = numberD + ((- numberA) * (numberB)) / numberC;

            return resultThree;
        }

        public double operationFour()
        {
            double numberA = 2.0;
            double numberB = 6.0;
            double numberC = 7.0;
            double numberD = 13.0;

            double resultFour = numberA + (numberD/numberB) * numberB + Math.Sqrt(numberC);

            return resultFour;
        }
        public int operationFive()
        {
            int numberA = 4;
            int numberB = 5;
            int numberC = 6;
            int numberD = 7;
            int numberE = 9;

            int resultFive = (int)((Math.Pow(numberC, numberA)) + (Math.Pow(numberB, numberD))) / (numberE % numberA);

            return resultFive;
        }

    }
}
