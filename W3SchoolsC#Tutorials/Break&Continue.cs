// You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.
// The break statement also used to jump out of a loop.

/* using system;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0, i < 10; i++)
      {
        if (i == 4)
        {
          break;
        }
        Console.WriteLine(i);
       }
     }
   }
 } */
 
 // C# Contitnue
 // The Continue statement breaks one iteration (in the loop), is a specified condition occurs, and continues with the next iteration in the loop.
 
 /* using System;
 namespace MyApplication
 {
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0, i < 10; i++)
      {
        if ( i == 4)
        {
          continue;
        }
        Console.WriteLine(i);
       }
      }
     }
   } */
   
   // Break & Continue in while Loop
   /* using System;
   namespace MyApplication
   {
    class Program
    {
      static void Main(string[] args)
      {
        int i = 0;
        while (i < 10)
        {
          Console.WriteLine(i);
          i++;
          if (i == 4)
          {
            break;
           }
          }
        }
      }
    } */
     
 // Break & Continue in while Loop
 /* using System;
 namespace MyApplication
 {
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 10)
      {
        Console.WriteLine(i);
        i++;
        if (i == 4)
        {
          break;
         }
       }
     }
   }
 } */
 
 // C# Continue in while Loop
 /* using System;
 namespace MyApplication
 {
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 10)
      {
        if (i == 4)
        {
          i++;
          continue;
        }
        Console.WriteLine(i);
        i++;
       }
     }
   }
 } */
      
