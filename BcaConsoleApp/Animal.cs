using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcaConsoleApp
{
    public abstract class Animal
    {

        public abstract string Sound { get; }

        public virtual void move()
        {
            Console.WriteLine("Animal is moving...");
        }
    }

    public class Cat : Animal
    {
        private string sound;
        //public override string Sound 
        //{ 
        //    get
        //    {
        //        return sound;
        //    }
        //}

        public override string Sound => sound + " Sound of an animal";
       
        public Cat()
        {
            this.sound = "Meow";
        }
        public override void move()
        {
            Console.WriteLine("Cat is moving....");
            base.move();
        }

        //public override string Sound => "Meow";

        //public override void move()
        //{
        //    Console.WriteLine("Walking like a cat...");
        //}
    }
}
