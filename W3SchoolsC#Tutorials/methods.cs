// A method is a block of code which only run when it is called.
// You can pass data, Known as parameters into a method.
// Methods are used to perform certain actions, and they are also known as functions.

/*
class Program
{
  static void MyMethod()
  {
    // Code to be executed
  }
}
*/

// MyMethod is the name of the method.
// static means that the method belongs to the program class.
// void means that this method does not have a return value.
/*
using System;
namespace MyApplication
{
  class Program
  {
    static void MyMethod()
    {
      Console.WriteLine("I just got executed!");
    }
    static void Main(string[] args)
    {
      MyMethod();
    }
  }
}
*/

// A method can be called multiple times

/*
using System;
namespace MyApplication
{
  class Program
  {
    static void MyMethod()
    {
      Console.WriteLine("I just got executed!");
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
