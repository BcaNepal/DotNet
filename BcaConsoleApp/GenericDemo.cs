using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Generics

namespace BcaConsoleApp
{
  
    public class GenericDemo
    {
        //[modifier] delegate [return_type][delegate_name] ([parameter_list]);
        public delegate void mydelegate(float a, float b);

        
        public void callDelegate() //float a, float b)
        {
            
            mydelegate objDelegate = new mydelegate(calculate);
            objDelegate(23.0f, 45.6f);
           
        }
        public void calculate(float x, float y)
        {       
            dynamic z;
            z = x + y;
            Console.WriteLine(z);
           Console.WriteLine(z.GetType());
            z = "ram";
            Console.WriteLine(z);
            Console.WriteLine(z.GetType());
        }


        public void display<T>(T x)
        {
            Console.WriteLine(x);
        }

        public void showData<K, V>(K k, V v)
        {
            Console.WriteLine($"Key:{k}, Value:{v}");
        }
        public dynamic getCalulcation(dynamic a, dynamic b)
        {
            dynamic c = a + b;
            return c;
        }

       /** public void display(int x)
        {
            Console.WriteLine(x);
        }

        public void display(string x)
        {
            Console.WriteLine(x);
        }**/

    }
}
