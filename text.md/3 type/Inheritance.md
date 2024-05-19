In C#, unlike some other languages such as C++, direct multiple inheritance (i.e., a class inheriting from multiple base classes) is not supported. C# supports only single inheritance, meaning that a class can inherit from at most one base class. 

However, C# provides a feature called interface inheritance, which allows a class to implement multiple interfaces. Interfaces define contracts that classes must adhere to, specifying a set of members (methods, properties, events, indexers) without providing any implementation. By implementing multiple interfaces, a class can inherit behavior and structure from multiple sources.

Here's an example demonstrating interface inheritance in C#:

```csharp
// Define interfaces
public interface IWalkable
{
    void Walk();
}

public interface IFlyable
{
    void Fly();
}

// Implement interfaces
public class Bird : IWalkable, IFlyable
{
    public void Walk()
    {
        Console.WriteLine("Bird is walking.");
    }

    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird();
        bird.Walk();
        bird.Fly();
    }
}
```

In the above example, the `Bird` class implements both the `IWalkable` and `IFlyable` interfaces, allowing it to exhibit behavior defined by both interfaces. While this is not exactly multiple inheritance in the traditional sense, it achieves a similar result by allowing a class to inherit behavior from multiple sources.

It's important to note that while interface inheritance provides some flexibility and code reuse, it does not inherit implementation like traditional class inheritance. Instead, it defines a contract that classes must fulfill, allowing for polymorphic behavior and facilitating code design patterns such as dependency injection and composition over inheritance.