
using System;

// Using System means that we can use classes from the system namespace.

namespace HelloWorld

  // Namespace is use to organise your code and it is a container for classes & other namespaces.
  // The Curly braces {} marks the begining and the end of a block of code.
{
  class Program
    
    // Class is a container for data & methods, which brings funtionality to your program. Every lines of code that runs in c# must be inside in a class.
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");   
      // Console is a class of the System namespace, which has a WriteLine() method that is output/print text. In our example it will output "Hello World!",
      // if u omit the using System, you would have to write System.Console.WriteLine() to print/output text. 
    }
  }
}

