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
            int i, n, sum = 0;

            Console.WriteLine("Enter the value of an integer n :");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum += i;
            }

            //Console.WriteLine("Total sum: " + sum);

            return sum;
        }

        public int Product()
        {
            int i, n, product = 1;

            Console.WriteLine("Enter the value of an integer n :");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                product = product * i;
            }

            //Console.WriteLine("Total product: " + product);

            return product;
        }
    }
}