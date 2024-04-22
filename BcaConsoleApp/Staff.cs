using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcaConsoleApp
{
    public class Staff
    {
        
        private string[] names = new string[5];
        public string this[int i]
        {
            get => names[i];
            set => names[i] = value;
        }

        //indexers
        //public string this[int index]
        //{
        //    get 
        //    {
        //        return names[index];
        //    }
        //    set 
        //    {
        //        names[index] = value;
        //    }
        //}




        // constructor
        public Staff(string name){ }
        public Staff() {}

        //finalizer
        ~Staff()
        {
        }

    }
}
