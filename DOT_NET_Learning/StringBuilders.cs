using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class StringBuilders
    {
        static void Main()
        {
            //String
            string str = "Hello World"; //creating object og string
            Console.WriteLine(str);

            str = "Test";
            Console.WriteLine(str);

            string FirstName = "Rupali";
            string LastName = "Bichukale";

            string FullName = FirstName +  LastName;   //concatenation do alwyas help of '+'  Operator
            Console.WriteLine($"My fullName is:{FullName}");

            //string Builder Implementations

            StringBuilder SB =  new StringBuilder(); //creating object of stringBuilder
            SB.Append("My Name");
            SB.Append(" is: ");
            SB.Append("Rupali");
            SB.Append("Bichukale");

            Console.WriteLine(SB.ToString());
        }
    }
}
