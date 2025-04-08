using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    class ConstantEx
    {
        //normal variable declaration
        public int a = 10;
        public string name = "test";

        //declaration of constant variable
        public const double pi = 3.15154;
        const string AppName = "XYZ";

        public void PrintConstantValues()
        {
            Console.WriteLine(name);
            Console.WriteLine($"The value of pi is:{pi}");
            Console.WriteLine($"The value of AppName is:{AppName}");

            name = "TestNew";
            Console.WriteLine(name);
            //AppName = "XYZNew"; constant variable we cannot change` or modify the value of constant

        }
    }
    internal class ConstantExample
    {
        static void Main()
        {
            ConstantEx con = new ConstantEx();  
            con.PrintConstantValues();
        }
    }
}
