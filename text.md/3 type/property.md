In C#, properties provide a way to encapsulate fields within a class, allowing controlled access to the data stored in those fields. They consist of a get accessor (to retrieve the value of the property) and optionally a set accessor (to modify the value of the property). Here's an example to illustrate how properties work:

```csharp
using System;

class Person
{
    // Private field
    private string name;
    // Property with both get and set accessors
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            // Perform validation if needed
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            name = value;
        }
    }
    // Auto-implemented property
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Person class
        Person person = new Person();
        // Set the Name property
        person.Name = "John Doe";
        // Set the Age property
        person.Age = 30;
        // Display the values using properties
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}
```

In this example:

- The `Person` class has two properties: `Name` and `Age`.
- The `Name` property has both a get and set accessor. It encapsulates the private field `name`, allowing controlled access to it. In the set accessor, validation is performed to ensure that the name is not null or empty.
- The `Age` property is an auto-implemented property, which automatically creates a private field behind the scenes and provides both get and set accessors.
- In the `Main` method, we create an instance of the `Person` class, set the `Name` and `Age` properties, and then display their values.

Properties provide a way to achieve encapsulation, data hiding, and controlled access to class members, enhancing the security and maintainability of the code. They also allow developers to implement custom logic such as validation or computation when accessing or modifying data.