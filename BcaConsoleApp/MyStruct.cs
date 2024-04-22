using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcaConsoleApp
{
    //struct 

    public struct MyPerson
    {
        private string name; // ="Person's Name";

        public string Name
        {
            get 
            { 
                return name;
            }
            set {
                name = value; 
            }
        }

        public void displayName()
        {
            Console.WriteLine("Person's Name: " + name);
        }
    }
}
