using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class ControlStatementAssign
    {
        static void Main()
        {
            Console.WriteLine("====== Basic Conditions ====== ");
            Console.Write("Enter The Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>0)
            {
                Console.WriteLine("Number is Positive");
                
            }
            else if (a < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else if( a == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            Console.WriteLine("===== Grade Calculator ======");
            Console.Write("Enter the grade (0-100): ");
            int grade = Convert.ToInt32(Console.ReadLine());
            if(grade >= 70 && grade< 80)
            {
                Console.WriteLine("Excellent, You got a grade A");
            }
            else if(grade >= 55 && grade < 70)
            {
                Console.WriteLine("Good , You got a grade B");

            }
            else if(grade >= 40 && grade< 55){
                Console.WriteLine("Satisfactory, You got a grade C");
            }
            else if(grade <= 35 && grade>=0)
            {
                Console.WriteLine("Fail,You got a grade D");
            }
           
        }
    }
}
