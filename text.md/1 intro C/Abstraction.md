Abstraction is a fundamental concept in object-oriented programming (OOP) that allows you to hide complex implementation details and provide a simplified interface to the user. In C#, abstraction is achieved through abstract classes and interfaces.

**Abstract Class:**
An abstract class is a class that cannot be instantiated directly. It serves as a base class for other classes and provides a blueprint for its derived classes. Abstract classes can contain abstract methods, which are methods without implementation, as well as concrete methods with implementation.

Here's an example of an abstract class in C#:

```csharp
abstract class Animal
{
    public abstract void MakeSound(); // Abstract method

    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    } // Concrete method
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}
```

In this example, the `Animal` class is an abstract class that defines an abstract method `MakeSound()` and a concrete method `Sleep()`. The `Dog` and `Cat` classes inherit from the `Animal` class and provide their own implementation of the `MakeSound()` method.

**Interface:**
An interface is a contract that defines a set of methods, properties, and events that a class must implement. It specifies what the class should do but not how it should be done. Interfaces are used to achieve abstraction and enable multiple inheritance in C#.

Here's an example of an interface in C#:

```csharp
interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
class Circle : IShape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
```

In this example, the `IShape` interface defines two methods: `CalculateArea()` and `CalculatePerimeter()`. The `Circle` class implements the `IShape` interface by providing the implementation for these methods based on the circle's radius.

Abstraction helps in achieving encapsulation, code reusability, and maintainability. It allows you to create a high-level representation of an object or system, hiding the unnecessary details from the user and focusing on the essential features and behaviors.