using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
   internal class PublicExampleTest
    {
        //define property
        public int PublicProperty { get; set; }

        //Method creation
        //[access-modifier] [return-type] [method-name]{p
        public void Display()
        {
            Console.WriteLine("Public property value:" +PublicProperty);
        }
        public void show()
        {
            Console.WriteLine("Hello");
        }
    }
    public class PublicExample
    {
        static void Main()
        {
            PublicExampleTest obj = new PublicExampleTest();
            obj.PublicProperty = 5; 
            obj.Display();
            obj.show();


        }
            
    }
}
