using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcaConsoleApp
{
    public class LambdaDemo
    {
        //
        //  => Lambda operator
        public void cal()
        {
            var add = (int a, int b) => a + b;
                        /**{
                            var sum = a + b;
                            return sum;
                        };**/

            Console.WriteLine(add);
        }
    }
}
