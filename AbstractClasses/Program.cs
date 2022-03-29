using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
          Employee Employee = new Employee
            {
                FirstName = "Student",
                LastName = "Sample"
            };

            Employee.SayName();
            {
                Console.ReadLine();
            }
        }
    }
}