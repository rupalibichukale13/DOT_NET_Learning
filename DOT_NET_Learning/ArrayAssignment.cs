using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class ArrayAssignment
    {
        static void Main()
        {
            int[] array = { 2, 4, 5, 8, 7, 10, 24, 45, 34, 55, 40 };
            Console.Write("Given Array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");



            }
            Console.WriteLine();
            Console.WriteLine("Even Numbers in a given array is: ");
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            //Console.WriteLine();
            Console.WriteLine("Odd Numbers in a given array is: ");
            foreach (int i in array)
            {
                if (i % 2! == 0)
                {
                    Console.WriteLine(i);
                }


                {

                }

            }
        }
    }
}
