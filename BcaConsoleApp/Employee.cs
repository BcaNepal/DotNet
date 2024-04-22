using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcaConsoleApp
{
    // abstract , virtual;, this, base
    public class Employee
    {
      


        // example of function(method) -overloading or static polymorphism
        // when method name is same and signature is different, then it is called function-overloading
        internal void displayAge()
        {
            Console.WriteLine("Age is: " + 23);
        }
        public void displayAge(int age)
        {
            Console.WriteLine("Age is:" + age);
        }

    }
}
