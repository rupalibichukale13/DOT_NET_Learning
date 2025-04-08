using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    //protected acccess moifier

    //base class/parent class / super class
    class Animal
    {
        //protected Member
        protected string Sound;

        //protected Method 

        protected void Makesound()
        {
            Console.WriteLine($"Animal makes sound:{Sound}");
        }
    }
    // derived class/ child class/ sub class

    class Dog : Animal
    {
        public Dog()
        {
            Sound = "Barks";
        }
        public void DisplaySound()
        {
            Makesound();
        }
    }
    class Cat : Animal
    {
        public Cat()
        {
            Sound = "Mewos";
        }
        public void DisplaySound()
        {
            Makesound();
            //Console.WriteLine("test");
        }
    }
    class Protected
    {
        static void Main()
        {
            Cat c = new Cat();
            c.DisplaySound();

        }
    }
}
