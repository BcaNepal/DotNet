using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringDemo
    {
        char letter = 'S';
        string stdName = "Surendra";
        char[] msg = { 'h', 'e', 'l', 'o' };
        string[] msg2 = { "h", "e" };
        string k1;

        string h = string.Empty; // "";

        public StringDemo()
        {
            //k1 = "jmc";
            if (String.IsNullOrEmpty(k1))
            {
                if (h.Equals("kmc"))
                {
                    // code here
                }
            }
        }

        public void showString(string colName)
        {
            Console.WriteLine(colName.Substring(3, 5));
        }
    }
}
