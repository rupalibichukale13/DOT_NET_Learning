using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{

    class ReadonlyEx
    {
        //property declaration
        public readonly int Initialvalue;
        public static readonly double pi;
        public static string test = "Test";

        public ReadonlyEx(int initialval)
        {
            Initialvalue = initialval;
            Initialvalue = 20;

        }
        static ReadonlyEx()
        {
            pi = 3.15454;
        }
        public void PrintValues()
        {
            Console.WriteLine($"Initial values:{Initialvalue}");
            Console.WriteLine($"Value of pi is:{pi}");
        }
    }
    internal class ReadOnlyExample
    {
        static void Main()
        {
            ReadonlyEx re = new ReadonlyEx(5);
            re.PrintValues();
        }
    }
}
