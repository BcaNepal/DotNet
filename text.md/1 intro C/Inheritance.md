Inheritance is a fundamental concept in object-oriented programming (OOP) that allows a new class to be based on an existing class, inheriting its properties and behaviors. The new class, called the derived class or subclass, inherits the members (fields, methods, and properties) from the existing class, called the base class or superclass.

In C#, you can create a derived class by using the `:` symbol followed by the base class name. The derived class inherits all the non-private members of the base class and can also add new members or provide new implementations for the inherited members.

Here's an example of inheritance in C#:

```csharp
// Base class
class Animal
{
    public string Name;
    public int Age;

    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class
class Dog : Animal
{
    public string Breed;

    public void Bark()
    {
        Console.WriteLine("The dog barks.");
    }

    public override void MakeSound()
    {
        Console.WriteLine("The dog barks: Woof!");
    }
}
```

In this example:

1. The `Animal` class is the base class, which has two properties (`Name` and `Age`), a method (`Eat()`), and a virtual method (`MakeSound()`).
2. The `Dog` class is the derived class, which inherits from the `Animal` class using the `: Animal` syntax.
3. The `Dog` class inherits the `Name`, `Age`, and `Eat()` members from the `Animal` class.
4. The `Dog` class has an additional property `Breed` and a new method `Bark()`.
5. The `Dog` class overrides the `MakeSound()` method from the base class using the `override` keyword, providing its own implementation.

You can create instances of the derived class and access both the inherited and new members:

```csharp
Dog myDog = new Dog();
myDog.Name = "Buddy";
myDog.Age = 3;
myDog.Breed = "Labrador";
myDog.Eat(); // Output: The animal is eating.
myDog.Bark(); // Output: The dog barks.
myDog.MakeSound(); // Output: The dog barks: Woof!
```

Inheritance provides several benefits:

1. **Code Reuse**: Derived classes can reuse the code from the base class, reducing duplication and promoting code reusability.
2. **Extensibility**: Derived classes can extend the functionality of the base class by adding new members or overriding existing ones.
3. **Polymorphism**: Derived classes can provide their own implementation of methods inherited from the base class, enabling polymorphism.
4. **Code Organization**: Inheritance helps in organizing and structuring code by creating hierarchies of classes, promoting code maintainability and readability.

It's important to note that C# supports single inheritance, meaning a class can only inherit from one base class. However, interfaces can be used to achieve multiple inheritance-like behavior in C#.