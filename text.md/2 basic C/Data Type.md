```csharp
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String
```
system define type


#### user defined data types
In C#, you can create custom data types using several mechanisms. Here are some common ways to define custom data types:

1. **Classes**: Classes are the most common way to create custom data types in C#. A class encapsulates data (fields) and behaviors (methods) into a single unit. You can define properties, constructors, methods, and other members within a class to represent your custom data type. For example:

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
```

2. **Structs**: Structs are similar to classes but are value types and are typically used for lightweight objects that contain small amounts of data. Structs are suitable for representing simple data structures. For example:

```csharp
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
```

3. **Enums**: Enums allow you to define a set of named constants representing integral values. Enums are useful for defining a distinct set of values for a particular property or field. For example:

```csharp
public enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
```

4. **Delegates**: Delegates are used to define method signatures, allowing you to pass methods as parameters or store them in variables. Delegates are useful for defining callback methods or implementing event handling. For example:

```csharp
public delegate int MathOperation(int a, int b);
```

5. **Interfaces**: Interfaces define a contract that classes can implement, specifying a set of properties, methods, and events. Interfaces are useful for defining common behavior that multiple classes can share. For example:

```csharp
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
```

These are some of the primary mechanisms for creating custom data types in C#. Depending on your requirements, you can choose the appropriate approach to define custom types that suit your application's needs.