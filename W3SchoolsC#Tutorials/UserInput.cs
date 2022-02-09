using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Type your username and press enter
      Console.WriteLine("Enter username:");
      
      // Create a string variable and get user input from the keyboard and store it in the variable
      string username = Console.ReadLine();
      
      // Print the Value of the variale (userName), which will display the input value
      Console.WriteLine("Username is: " + userName);
      }
    }
  }
