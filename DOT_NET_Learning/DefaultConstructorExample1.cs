using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{

    public class DefaultConstexample
    {
        public int value;

        //default Constructor //constructor name and class name should be same

        public DefaultConstexample()
        {
            value = 1;
        }
        //normal method
        public void Display()
        {
            Console.WriteLine("test" +value);
        }


    }
    internal class DefaultConstructorExample1
    {
        static void Main()
        {
            //instance creation

            DefaultConstexample example = new DefaultConstexample();//instance creation
            example.Display();


        }

        
        
    }
}
