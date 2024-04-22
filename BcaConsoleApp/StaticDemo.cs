using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcaConsoleApp
{
    public class StaticDemo
    {

        // static
        public static string empName;
        public string empId;
        public static int count;

        // destructor or finalizers

        ~StaticDemo() 
        {
            // clean the resources
            count--;
            empName = null;
            empId = null;
        }

        public StaticDemo()
        {
            count++;
            empId = "";
            empName = "";
        }
        public void displayName()
        {
            Console.WriteLine(empName);
           // Console.WriteLine(empId);
        }
        public void setName(string name)
        {
            empName = name;
        }
        public static void showName()
        {
            Console.WriteLine(empName);
        }
        public static void displayCount()
        {
            Console.WriteLine(count);
        }
    }
}
