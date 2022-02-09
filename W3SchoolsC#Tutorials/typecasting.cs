// Implicit Casting. Converting a smaller type to a larger type size. char>int>long>float>double


/* using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 9;
      double myDouble = myInt; //Automatic casting: int to double
    
     Console.WriteLine(myInt);
     Console.WriteLine(myDouble);
    }
  }
} */

// Explicit Casting. Converting a larger type to a smaller size type. double>float>long>int>char
/* using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double myDouble = 9.78;
      int myInt = (int) myDouble; //Manual Casting: double to int
      
      Console.writeLine(myDouble);
      Console.WriteLine(myInt);
     }
   }
 } */

// Type Conversion Method

/* using System;

namespace MyApplication
{
  class Program
  {
  static void Main(string[] args)
  {
    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;
    
    Console.WriteLine(Convert.ToString(myInt));   // Convert int to string
    Console.WriteLine(Convert.ToDouble(myInt));   // Convert int to double
    Console.WriteLine(Convert.ToInt32(myDouble)); // Convert double to int
    Console.WriteLien(Convert.ToString(myBool));  // Convert bool to string
   }
  }
 } */
 
 
