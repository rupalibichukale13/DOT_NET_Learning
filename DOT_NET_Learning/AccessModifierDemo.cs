using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    public class AccessModifierDemo
    {
       
        public class Person
        {
            public string firstName = "Rupali";
            
            public string lastName = "Bichukale";
        }
        public void DisplayfullName(Person person)
        {
            Console.WriteLine("My Full Name is:" + person.firstName + " " + person.lastName);
        }
        static void Main()
        {
            AccessModifierDemo name = new AccessModifierDemo();
            Person person = new Person();
            name.DisplayfullName(person);

        }

    }
}
