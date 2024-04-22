using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   // private string[] students;

    internal class MyCls
    {
        // Array
        //private string[] students = { "Ram", "Hari", "Shyam"};
        private string[] students = new string[4];

        internal MyCls() // special method (Constructor)
        {
           // students = new string[4];
            students[0] = "Seeta";
            students[1] = "Reeta";
            students[2] = "Geeta";
            students[3] = "Neeta";
        }
        internal MyCls(string[] students) // special method (Constructor)
        {
            /** students = new string[3];
             students[0] = "Seeta";
             students[1] = "Reeta";
             students[2] = "Geeta";
            */
            this.students = students;
        }
        internal void showLoop()
        { 
            try
            {
                for(int i =0; i<students.Length; i++)
                {
                    Console.WriteLine(students[i]);
                }
                Console.WriteLine("*******/n*******");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void displayLoop()
        {
            try
            {
                for (int i = 0; i < students.Length; i++)
                {                    

                    if (students[i].Equals("Reeta"))
                    {
                        // 
                        //break; ; // breaks the loop
                        //continue;
                        return;
                    }
                    Console.WriteLine(students[i]);

                } // loop close
                Console.WriteLine("Loop Ends");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void foreachLoop()
        {
            foreach(string student in students )
            {
                Console.WriteLine(student);
            }
        }

        

    }
}
