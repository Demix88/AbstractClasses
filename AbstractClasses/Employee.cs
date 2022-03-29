using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
     class Employee:Person,IQuittable
    {
        public override void SayName()
        {
          

            Console.WriteLine("Name:" + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("I " + FirstName + " " + LastName+" Would Like to hand in my resignition.");
        }
    }
}

