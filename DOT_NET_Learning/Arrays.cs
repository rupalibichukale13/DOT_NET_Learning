using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    class Arrays
    {
        static void Main()
        {
            //Declare the arrays
            string[] Mobiles = new string[6];

            //assigning values in arrays
            //first approach
            Mobiles[0] = "Apple";
            Mobiles[1] = "Samsung";
            Mobiles[2] = "OnePlus";
            Mobiles[3] = "Vivo";
            Mobiles[4] = "RealMe";
            Mobiles[5] = "Redmi";

            //
            //string[] Mobile = ["Apple", "Samsung", "onePlus"];

            //Accessing values from array
            for (int i = 0; i < Mobiles.Length; i++)
            {

                Console.WriteLine("Mobiles Names:" + Mobiles[i]);
            }
            //initialize multidimensional array
            int[,] Matrix = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9, }
            };

            //accessing values from multidimensional array
            Console.WriteLine("Element at(0,0):"  + Matrix[0, 1]);
            Console.WriteLine("Element at(1,2):"  + Matrix[1, 2]);


            //print all the elements form the multidimensional array

            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(Matrix[i, j] +" ");
                }
                Console.WriteLine();

            }

            //reverse string 
            string rev = "Welcome";

            char[] chArray = rev.ToCharArray();
            char[] revArray =new char[chArray.Length];
            for (int i = 0; i < chArray.Length; i++)
            {
                revArray[i] = chArray[chArray.Length - 1-i];  
            }
            string Originalstr = new string(chArray);
            string revstr = new string (revArray);
            Console.WriteLine("Original String:" + Originalstr);
            Console.WriteLine("Reverse String:" +revstr);
    

        }
            
    }
}
