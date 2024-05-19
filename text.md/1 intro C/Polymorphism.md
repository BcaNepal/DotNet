Polymorphism is a principle of object-oriented programming that allows objects of different classes to be treated as objects of a common superclass. It provides a way to perform a single action in different ways based on the object's type. There are two types of polymorphism in C#: method overloading and method overriding.

**Method Overloading**:
Method overloading is a form of polymorphism that allows a class to have multiple methods with the same name but different parameter lists (different number of parameters, different types of parameters, or both). The compiler determines which method to call based on the number and types of arguments provided during the method call.

Example:

```csharp
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}
```

In the example above, the `Calculator` class has three `Add` methods with different parameter lists. The compiler determines which method to call based on the number and types of arguments provided during the method call.

**Method Overriding**:
Method overriding is a form of polymorphism that allows a derived class to provide its own implementation of a method that is already defined in its base class. The overridden method in the derived class must have the same signature (method name, return type, and parameter list) as the method in the base class.

Example:

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}
```

In the example above, the `Animal` class has a virtual `MakeSound` method. The `Dog` and `Cat` classes override this method with their own implementations. When you create an object of the `Dog` or `Cat` class and call the `MakeSound` method, the overridden method in the respective class is invoked, producing different outputs.

Polymorphism provides several benefits:

1. **Code Reusability**: Common operations can be defined in the base class, and derived classes can override or extend the behavior as needed.
2. **Extensibility**: New derived classes can be created without modifying the existing code, allowing for easy extension of the program's functionality.
3. **Flexibility**: Objects of different classes can be treated as objects of a common superclass, allowing for more flexible and dynamic programming.
4. **Abstraction**: Polymorphism helps in achieving abstraction by allowing objects to be treated as instances of their base class, without worrying about the specific implementation details.

Polymorphism is an essential concept in object-oriented programming, enabling code reuse, extensibility, and flexibility in software development.