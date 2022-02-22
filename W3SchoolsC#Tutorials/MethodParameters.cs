// Parameters & Arguments

/*
using System;
namespace MyApplicaion
{
  class Program
  {
    static void MyMethod(string fname)
    {
      Console.WriteLine(fname + " Refsnes");
    }
    {
      static void Main(string[] args)
    }
    {
      MyMethod();
      MyMethod();
      MyMethod();
    }
  }
}
*/

// Default parameter value

/*
using System;
namespace MyApplication
{
  class Program
  {
    static void MyMethod(string country = "Norway" ) // Norway is the default value.
    {
      Console.WriteLine(country); // country Optional Parameter
    }
    static void Main(string[] args)
    {
      MyMethod("Sweden");
      MyMethod("India");
      MyMethod();
      MyMethod("USA");
    }
  }
}
*/

// Multiple Parameters
/*
using System;
namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname, int age)
  }
  {
    Console.WriteLine(fname+ " is " + age)
  }
  static void Main(string[] args)
  {
    MyMethod("Liam", 5);
    MyMethod("Jenny" , 8);
    MyMethod("Anja", 31)
  }
  } 
}
*/

// Return Value

/*
using System;
namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x)
    {
      return 5 + x;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(3));
    }
  }
}
*/

// This Example returns the sum of a method's two parameters:
/*
using System;
namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x, int y)
    {
      return x + y;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(5,3));
    }
  }
}
*/

// Store Result in a Variable

/*
using System;
namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x, int y)
    {
      return x+y;
    }
    static void Main(string[] args)
    {
      int z = MyMethod(5,3);
      Console.WriteLine(MyMethod(z));
    }
  }
}
*/

// Named Arguments
/*
using System;
namespace MyApplication
{
  class Program
  {
    static void MyMethod(string child1, string child2, string child3)
    {
      Console. WriteLine("The youngest Child is: " + child3)
    }
    static void Main(string[] args)
    {
       MyMethod(child3: "John" , child1: "Liam" , child2: "Liam");
    }
    
  }
}
*/

// Multiple parameters with default values

/*
using System;
namespace MyApplication
{
  class Program
  {
  static void MyMethod(string child1, string child2, string child3)
  {
    Console.WriteLine("The youngest child is: " + child3);
  }
  static void Main(string[] args)
  {
    MyMethod(child3: "John", child1: "Liam" , child2: "Liam");
  }
  }
}
*/
