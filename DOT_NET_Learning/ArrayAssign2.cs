using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class ArrayAssign2
    {
        static void Main()
        {
            int[] array = { 1, 4, 7, 9, 12, 6, 8, 5, 15 };
            Console.Write("Given array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");

            }
            Console.WriteLine();
            Console.Write("Alternate Elements in an array are:");
            for (int i = 0; i < array.Length; i+=2)
            {
                Console.Write(array[i] + " ");

            }

            Console.WriteLine();
            int numberOfElements = array.Length;
            Console.WriteLine($"Number of elements in an array: {numberOfElements}");
            Console.WriteLine("Smallest number in an array is: " + array.Min());
            Console.WriteLine("Largest number in an array is: "  + array.Max());
        }
    }
}
