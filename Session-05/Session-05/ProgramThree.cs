using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ProgramThree
    {

        static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) 
                    return false;
            }
            return true;
        }

        public void AllPrimeNumbers()
        {
            Console.WriteLine("Enter the value of an integer n :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The Prime numbers are: ");
            for (int i = 1; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
