// C# Conditions & if Statement

// Use if to specify a block of code to be executed, if a specified condition is true
// Use Else to specify a block of code to be executed, if the same condition is false
// Use Else If to specify a new condition to test, if the first condition is false
// Use switch to specify many alternative blocks of code to be executed

/* using System
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      if(20 > 18)
      {
        Console.WriteLine("20 is greater than 18");
      }
     }
   }
 } */
 
 /* using System;
 namespace MyApplication
 {
  class Program
  {
    static void Main(string[] args)
    {
      int x = 20;
      int y = 18;
      if (x > y)
      {
        Console.WriteLine("x is greater than y");
      }
    }
  } */
  
  /* using System;
  
 namespace MyApplication
 {
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      if (time < 18)
      {
        Console.WriteLine("Good day.");
      }
      else
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
} */

// The else if statement

/* using System;
namespace MyApplication
{
  class Program
  {
    int time = 22;
    if (time < 20)
    {
      Console.WriteLine("Good Morning.");
    }
    else if (time < 20)
    {
      Console.WriteLine("Good day.");
    }
    else
    {
      Console.WriteLine("Good evening");
     }
    }
  }
} */

// Short hand if else (Ternary Operator)
// variabe = (condition) ? expressionTrue : ewxpressionFalse;
/* using System;
namespace MyApplication
{
  class Progarm
  {
   static void Main(string[] args)
   {
    int time = 20;
    if (time < 18)
    {
      Console.WriteLine("Good day.");
    }
    else
    {
      Console.WriteLine("Good evening.");
     }
    }
   }
 } */
 
 /* using System;
 namespace MyApplication
 {
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      string result = (time < 18) ? "Good day." : "Good evening.";
      Console.WriteLine(result);
     }
   }
 } */
