using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class LoopingStatementAssign
    {
        static void Main()
        {
            Console.WriteLine("======= Switch Statements =======");
            Console.WriteLine("Enter a number corresponding to their Choice:");
            Console.WriteLine("1.Burger - RS.80");
            Console.WriteLine("2.Pizza - RS.70");
            Console.WriteLine("3.Salad - RS.90");
            Console.WriteLine("Noodles - RS.60");
            Console.WriteLine("Paratha - RS.50");
            Console.Write("Enter Your Choice food items No.:");
            
            string input = Console.ReadLine();
            switch(input){
                case "1":
                    Console.WriteLine("Selected Burger price is RS. 80");
                    break;
                    case "2":
                    Console.WriteLine("Selected Pizza price is RS.70");
                    break;
                    case "3":
                    Console.WriteLine("Selected Salad price is RS.90");
                    break;
                    case "4":
                    Console.WriteLine("Selected Noodles price is RS.60");
                    break;
                    case "5":
                    Console.WriteLine("Selected Paratha price is RS.50");
                    break;
                    default:
                    Console.WriteLine("Invalid Selected food items");
                    break;

            }
            Console.WriteLine("==== Looping Statement - For loop/while loop/do while loop =====");
            Console.WriteLine("**** Using for loop *****");
            for (int i = 1; i<10; i++)
            {
                Console.WriteLine($"Check the student: {i}");
            }
            Console.WriteLine("**** Using while loop ****");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine($"check the student: {j}");
                j++;
            }
            Console.WriteLine("**** Using do while loop ****");
            int k = 1;
            do
            {
                Console.WriteLine($"Check the student: {k}");
                k++;
            }while(k <= 10);

          
            

        }
    }
}
