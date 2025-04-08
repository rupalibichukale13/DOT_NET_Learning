using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{

    public class Copyconstructors
    {
        //parameter declarations

        public string Name { get; set; }
        public int age { get; set; }

        public string NameNew { get; set; }
        public string AgeNew { get; set; }

        //parameter constructor

        public Copyconstructors(string Name, int age)
        {
            Name = Name;
            age = age;

        }

        //copy constructor
        public Copyconstructors(Copyconstructors copyex)
        {
            NameNew = copyex.NameNew;
            AgeNew = copyex.AgeNew;



        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}");
        }

        public void DisplayInfoNew()
        {
            Console.WriteLine($"Name:{NameNew} , Age:{AgeNew}");
        }
    }

        internal class CopyConstructorExample
        {
            static void Main()
            {
                //creating object with pass the value for parameterized constructor

                Copyconstructors obj = new Copyconstructors("Rupali", 21);
                obj.DisplayInfo();

            //creating another object using copy constructor

            Copyconstructors obj2 = new Copyconstructors(obj);
            obj2.DisplayInfoNew();
            }
        }
    }
    
