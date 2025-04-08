using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class Operators
    {
        static void Main()
        {
            //Console.WriteLine("Test");  //first line
            //Console.WriteLine("Test1"); //second line
            //Console.Write("Test2");   //third line
            //Console.WriteLine("Test3"); //third line

            Console.WriteLine("===== Operators =====");
            //Variables Declarations
            int a = 10;
            int b = 11;

            Console.WriteLine("===== Arithmetic Operator =======");
            Console.WriteLine($"Addition:{a + b}");
            Console.WriteLine($"Substraction:{a - b}");
            Console.WriteLine($"Multiplication:{a * b}");
            Console.WriteLine($"Division:{a / b}");
            Console.WriteLine($"Mod:{a % b}");

            // Comparision operator OR Relational operator
            Console.WriteLine("===== Comparision Operator =====");

            Console.WriteLine($"a==b:{a == b}");
            Console.WriteLine($"a!=b:{a != b}");
            Console.WriteLine($"a<b:{a < b}");
            Console.WriteLine($"a>b:{a > b}");
            Console.WriteLine($"a<=b:{a <= b}");
            Console.WriteLine($"a>=b:{a >= b}");

            //Logical Operators

            bool x = true;
            bool y = true;
            Console.WriteLine("=====Logical Operators====");
            Console.WriteLine($"x && y: {x && y}");   //AND
            Console.WriteLine($"x || y: {x || y}");   //OR
            Console.WriteLine($"!x: {!x}, !y: {!y}");  //NOR



        }
    }
}
