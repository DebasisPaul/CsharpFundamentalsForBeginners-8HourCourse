// C# Switch Statements
// The switch expression is evaluated once
// The Value of the expression is compared with the values of each case
// If there is a match, the associated block of code is eexecuted
// The break and default keywords will be described later in this chapter

/* switch(expression)
   {
    case x:
      // code block
      break;
     case y:
      // code block
      break;
     default:
      // code block
      break;
    } */
    
    
    
 // The example below uses the weekday number to calculate the weekday name:
 /* using System;
 namespace MyApplication
 {
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day)
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
           
        }
      }
    }
  }
  
  
  // The default Keyword
  /* using System;
  namespace MyApplication
  {
    class Program
    {
      static void Main(string[] args)
      {
        int day = 4;
        switch (day)
        {
          case 6:
            Console.WriteLine("Today is Sturday.");
            break;
          case 7:
            Console.WriteLine("Today is Sunday.");
            break;
          default:
            Console.WriteLine("Looking forward to the weekend.")
          }
        }
      }
    } */
