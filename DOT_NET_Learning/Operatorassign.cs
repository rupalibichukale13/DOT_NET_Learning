using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class Operatorassign
    {
        static void Main()
        {
            Console.WriteLine("===== Arithmetic Operators =====");
            int a = 10;
            int b = 20;
            Console.WriteLine($"Addition of two numbers: {a + b}");
            Console.WriteLine($"Substraction of two numbers: {a - b}");
            Console.WriteLine($"Multiplication of two numbers: {a * b}");
            Console.WriteLine($"Division of two numbers: {a / b}");
            Console.WriteLine($"Modulus of two numbers: {a % b}");

            Console.WriteLine("===== Relational Operators ======");
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a != b: {a != b}");
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < b: {a < b}");
            Console.WriteLine($"a >= b: {a >= b}");
            Console.WriteLine($"a <= b: {a <= b}");

        }
    }
}
