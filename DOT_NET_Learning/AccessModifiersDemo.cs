using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET_Learning
{
    class person
    {
        protected string EmployeeName;
        protected int EmployeeId;
        protected string EmployeeAddress;

        protected void Details()
        {
            Console.WriteLine("-------- Protected Access Modifier --------");
            Console.Write("Employee Details: Name:" +EmployeeName+ " Id:"+EmployeeId+ " Address:"+EmployeeAddress);
        }
    }
    class Employee : person
    {
        public Employee()
        {
            EmployeeName = "Rupali";
            EmployeeId = 1;
            EmployeeAddress = "Pune";
        }
        public void DisplayDetails()
        {
            Details();
        }
    }
     class AccessModifiersDemo
    {
        static void Main()
        {
            Employee person = new Employee();
            person.DisplayDetails();
        }

    }
}



