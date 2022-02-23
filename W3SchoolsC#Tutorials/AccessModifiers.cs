// Private Modifier
/*using System;

namespace MyApplication
{
  class Car
  {
    private string model = "Mustang";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}*/

// If you try to access it outside the class, an error will occur:

//prog.cs

/*using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}*/

//prog2.cs
/*using System;

namespace MyApplication
{
  class Car
  {
    private string model = "Mustang";
  }
}*/

// Public Modifier
//prog.cs
/*using System;
​
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}*/

//prog2.cs
/*using System;
​
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}*/
