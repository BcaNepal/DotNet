using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace BcaConsoleApp {

    public class Student : Person // class  inheritance
    {
        /*private int age; // property  // member variable
         public int getAge()
         {
             return age;
         }

         public void setAge(int age)
         {
             this.age = age;
         }
        */
        private int age; // member variable  Encapsulation

        //Property (Attribute)
        public int Age // Abstraction
        {
            get => age;
            set => age = value;

            //get
            //{
            //    return age;
            //}


            //set
            //{
            //    age = value;
            //}
        }


        public void displayName()
        {
            Console.WriteLine("Student's Name: " + Name);
        }

        //private string name="Student's Name";
        //public string Name { 
        //    get { return name; } 
        //    set { name = value; }
        //}

        // function or method

        // example of function(method) -overloading or static polymorphism
        internal void displayAge()
        {          
            Console.WriteLine("Age is: " + 23);
           
        }

        public void displayAge(int age)
        {
            Console.WriteLine("Age is:" + age);
        }

    }// class close   
} //namespace close
