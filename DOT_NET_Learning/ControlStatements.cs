using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class ControlStatements
    {
        static void Main()
        {
            //if Statement
            Console.WriteLine("===== if Statement =====");
            int Number = 10;
            if(Number == 10)
            {
                Console.WriteLine("This Number is Positive");

            }
            // if else statement
            Console.WriteLine("==== If else statement =====");
            string UserName = "Pooja";
            if (UserName == "Pooja")
            {
                Console.WriteLine("This is Active User");      
            }
            else
            {
                Console.WriteLine("This is Invalid user");
            }

            //if else if statement
             Console.WriteLine("===== if else if statement ===== ");
            int num = 59;
            if (num > 0)
            {
                Console.WriteLine("The number is positive");

                
            }
            else if (num < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else if(num > 100 && num < 200)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number below 100");
            }

            //Switch
            Console.WriteLine("======== Switch Case ==========");
            int Day = 5;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("WeekEnd");
                    break;
            }

            //Looping Statement

            //1.for loop
            //Console.WriteLine("====== For Loop =======");
            //int n = 5;  //variable Declaration
            //for (n=0; n<5; n++)    //1.variable initialization 2.iteration condition 3.increament
            //{
            //    Console.WriteLine("Iteration:" + n);
            //}

            //2.While loop- entry control loop
            Console.WriteLine("====== While loop ======");

            int i = 0;
            while (i > 5)
            {
                //core logic
                Console.WriteLine("Iteration in while loop" +i);
                i++;
            }
            //3.do while loop - exit control loop
            Console.WriteLine("===== Do While loop =====");
            int j = 0;
            do
            {
                Console.WriteLine("Iteration in do while loop:" + j);
                j++;
            } while (j<5);


            //for each statement

            string[] Fruits ={"Apple","Mango", "Banana", "Orange", "Watermelon", "Grapes" };
            foreach (string fruit in Fruits)
            {
                Console.WriteLine("The fruits is:" + fruit);
            }

            //3.jumping statement 
            Console.WriteLine("======== Jumping Statement ========");

            //1.continue

            for (i=0; i<5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine("Iterations:"+i);
            }

            //2.Go To Statement

            int count = 0;
            startloop:   
            if (count < 5)
            {
                Console.WriteLine($"Count is:{count}");
                count++;
                goto startloop;
                Console.WriteLine($"count after goto {count}"); 


            }
            Console.WriteLine($"Loop with goto is finished");


        }
    }
} 
