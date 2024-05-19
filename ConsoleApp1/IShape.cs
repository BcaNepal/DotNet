using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{    
    public interface IShape
    {
        double GetArea();
    }

    // multiple inheritance
    interface I1
    {
        void Method1(); // declaration
    }

    interface I2
    {
        void Method2(); // declared
    }

    interface IRemoteControl
    {
       public void decreaseVolume();
       public void increaseVolume();
    }

    class SamsungRemoteControl : IRemoteControl
    {
        public void decreaseVolume()
        {
            Console.WriteLine("Volume -");
        }
        

         void IRemoteControl.increaseVolume()
        {
            Console.WriteLine("Volume +");
        }

        
    }

    class MyClass : Animal, I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 is called.");
        }

        public void Method2() //defined

        {
            Console.WriteLine("Method2 is called.");
        }
    }

    class Animal
    {
    public void eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// multi-level inheritance
class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Mammal is running.");
    }
}

class Horse : Mammal
{
    public void Gallop()
    {
        Console.WriteLine("Horse is galloping.");
    }
}
}
