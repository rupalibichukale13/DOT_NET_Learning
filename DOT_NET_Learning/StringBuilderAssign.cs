using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class StringBuilderAssign
    {
        static void Main()
        {
            Console.WriteLine("-------- Assignment - 1  --------");
            Console.WriteLine(" ====== (Task-1) ======");
            StringBuilder SB = new StringBuilder();
            SB.Append("My Name");
            SB.Append(" is: ");
            SB.Append(" Rupali");
            SB.Append(" Bichukale");
            Console.WriteLine(" Append Multiple string -->" + SB.ToString());

            Console.WriteLine(" ====== (Task-2) ======");
            SB.Replace("Rupali", "Pooja");
            Console.WriteLine("After Replace String is -->" + SB.ToString());

            Console.WriteLine(" ====== (Task-3) ======");
            SB.Remove(2, 3);
            Console.WriteLine("After Remove string is -->" + SB.ToString());


            Console.WriteLine("-------- Assignment - 2  --------");
            int[] num = { 50, 30, 80, 10, 40 };
            Console.Write("Array Of integers with values are:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");



            }
            Console.WriteLine();
            Console.WriteLine("Maximum value in given array is:" + num.Max());
            Console.WriteLine("Minimum value in given array is:" + num.Min());
            Console.WriteLine("\n");
            Console.WriteLine();

            Console.WriteLine("-------- Assignment - 3  --------");
            string[] Names = { "Alice", "Bob", "Charlie", "David", "Emily" };
            Console.WriteLine("Names in the given list are:Alice, Bob, Charlie, David, Emily");
            int names = 5;
            switch (names)
            {
                case 1:
                    Console.WriteLine("Alice");
                    break;
                case 2:
                    Console.WriteLine("Bob");
                    break;
                case 3:
                    Console.WriteLine("Charlie");
                    break;
                case 4:
                    Console.WriteLine("David");
                    break;
                case 5:
                    Console.WriteLine("Emily");
                    break;
                default:
                    Console.WriteLine("john");
                    break;


            }

        }


    }



}