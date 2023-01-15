using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ProgramFour
    {
        public static void MultiplyArrays(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length * array2.Length];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    newArray[index] = array1[i] * array2[j];
                    index++;
                }
            }

            Console.WriteLine("Array 1: ");
            Console.WriteLine(string.Join(" ", array1));

            Console.WriteLine("Array 2: ");
            Console.WriteLine(string.Join(" ", array2));

            Console.WriteLine("Result Array: ");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
