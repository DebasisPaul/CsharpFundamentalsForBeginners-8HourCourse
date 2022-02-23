// Fields and methods inside classes are often referred to as "Class Members":

/*
// The class
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 200;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
}
*/

//Fields

/*using System;

namespace MyApplication
{
  class Car 
  {
    string color = "red";
    int maxSpeed = 200;

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
    }
  }
}*/

/*//filename: Car.cs
using System;

namespace MyApplication
{
  class Car 
  {
    string color;
    int maxSpeed;

    static void Main(string[] args)
    {
      Car myObj = new Car();
      myObj.color = "red";
      myObj.maxSpeed = 200;
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
    }
  }
}*/

//Creating multiple objects of one class
/*//filename: Car.cs
using System;

namespace MyApplication
{
  class Car 
  {
    string model;
    string color;
    int year;

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

//Object Methods
/*using System;

namespace MyApplication
{
  class Car
  {
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
      Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
      Car myObj = new Car();
      myObj.fullThrottle();  // Call the method
    }
  }
}*/

// Use Multiple Classes

/*
//prog2.cs
class Car 
{
  public string model;
  public string color;
  public int year;
  public void fullThrottle()
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }
}*/

/* // prog2.cs
using System;
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
