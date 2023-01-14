using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ProgramFive
    {
        public class Sorting
        {
            public static void SortArray(int[] arr)
            {
                Console.WriteLine("Initial Array: ");
                Console.WriteLine(string.Join(" ", arr));
                Array.Sort(arr);


                Array.Sort(arr);
                Console.WriteLine("Array sorted in ascending order: ");
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();

            }
        }
    }
}