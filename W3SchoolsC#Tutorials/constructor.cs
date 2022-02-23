// A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields:

/*using System;

namespace MyApplication
{
  // Create a Car class
  class Car
  {
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
      model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
      Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
      Console.WriteLine(Ford.model);  // Print the value of model
    }
  }
}*/

/*Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
Also note that the constructor is called when the object is created.
All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.
Constructors save time! Take a look at the last example on this page to really understand why.*/

//Constructor Parameters
/*//filename: Car.cs
using System;

namespace MyApplication
{
  class Car
  {
    public string model;

    // Create a class constructor with a parameter
    public Car(string modelName)
    {
      model = modelName;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang");
      Console.WriteLine(Ford.model);
    }
  }
}*/

// You can have as many parameters as you want

/*using System;

namespace MyApplication
{
  class Car
  {
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
      model = modelName;
      color = modelColor;
      year = modelYear;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "Red", 1969);
      Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
  }
}*/

//Tip: Just like other methods, constructors can be overloaded by using different numbers of parameters.

// Constructors Save Time

//Without Consitructor

/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}*/

// With Constructor
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "Red", 1969);
      Car Opel = new Car("Astra", "White", 2005);

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}*/
