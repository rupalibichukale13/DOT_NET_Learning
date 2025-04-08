using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class ArrayAssign1
    {
        static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            Console.Write("Given Array is:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Prime Numbers in given array is:" );
            foreach (int num in nums)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num + " ");
                }


            }
        }
              public  static Boolean IsPrime(int num)
               {
            if (num < 2)
                return false;
            for (int i = 2; i < num; i++)
            {


                if (num % i == 0) 
                    return false;
            }
            { 
            
                   return true;
                    }
                }
               
            }

        }
    

