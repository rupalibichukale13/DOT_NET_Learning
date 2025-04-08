using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class ArrayAssign
    {
        static void Main()
        {
            int[] num = { 4, 5, 9, 10, 11, 12, 13 };


            Console.Write("Given Array is:");
            for (int i = 0; i < num.Length; i++) {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("--------- Sum of values of an array ----------");
            int sum = 0;
            for (int i = 0; i < num.Length; i++) {
                sum += num[i];
                
            }

            Console.WriteLine("Sum of Values of an array:" + sum);


            Console.WriteLine("-------- Average value of array elements --------");

            int[] Numbers = { 10, 30, 60, 40, 50 };
            int sum1 = 0;
            foreach (var num1 in Numbers)
            {
                sum1 += num1;
            }
            double average = (double)sum1 / Numbers.Length;
            Console.WriteLine("Average value of array elements:" + average);
        }
        
    }
}
