using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    internal class PrivateClass
    {
       
            private string firstname;
            private string lastname;
        
        private void FullName()
        {
            Console.WriteLine("--------- Private Access Modifier ---------");
            Console.WriteLine(" Full Name is: " + firstname + " " + lastname);
        }

            static void Main()
            {
                PrivateClass name = new PrivateClass();
                name.firstname = "Rupali";
               name.lastname = "Bichukale";
                name.FullName();
            }
        }
    }

