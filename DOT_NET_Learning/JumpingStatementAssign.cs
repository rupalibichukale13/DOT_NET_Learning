using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class JumpingStatementAssign
    {
        static void Main()
        {
            Console.WriteLine("====== Using For Each loop ======");
            string[] MobileBrand={"Apple", "Samsung", "Xiaomi", "Oppo", "Vivo", "OnePlus", "Realme", "Motorola", "Google Pixel", "Nokia" };
            foreach ( string mobilebrand in MobileBrand)
            {
                Console.WriteLine(" Mobile Brand is:" + mobilebrand);
                
            }
            Console.WriteLine("====== Using Break statement ======");
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number:");
                int number =Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                
                    break;
                    sum += number;
                
                }
                Console.WriteLine("Sum of Positive number is:" +sum);

            Console.WriteLine("===== Using Continue Statement =====");
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 20; i++)
            {
                if( i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine($"Number is:{i}");
            }
            Console.WriteLine("===== Using GO-TO statement ======");
            int age;
            Repeat:
            Console.Write("Enter the valid age between 0-120:");
            age = Convert.ToInt32(Console.ReadLine());
           
            if(age >120 )
            {
                //Console.WriteLine("Enter the valid age between 0-120:");
                Console.WriteLine("Invalid Age..");

                goto Repeat;

            }
            
            Console.WriteLine($"Your age is:{age}");
                
            }
           
        
        }
    }

