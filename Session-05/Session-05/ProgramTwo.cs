using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_05
{
    internal class ProgramTwo
    {
        public int Sum()
        {
            int sum = 0;

            Console.WriteLine("Enter the value of an integer n :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int Product()
        {
            int product = 1;

            Console.WriteLine("Enter the value of an integer n :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}