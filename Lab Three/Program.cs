using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Three
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello. What is your name?");
      string name = Console.ReadLine();

      char doAgain;
      bool repeat1 = true;
      while (repeat1 == true)
      {
        Console.WriteLine(name + ", enter a number between 1 and 100.");
        string input = Console.ReadLine();
        // Use method for checking for a number.

        if (!IsAllDigits(input))
        {
          Console.WriteLine("Hey! That isn't a number.");
          Console.WriteLine("Would you like to try again? Y or N");
          doAgain = Convert.ToChar(Console.ReadLine());

          if (doAgain == 'y' || doAgain == 'Y')
          {
            repeat1 = true;
          }
          else
          {
            break;
          }
        }
        int userInput = int.Parse(input);
        if (userInput % 2 == 0)
        {
          if (userInput <= 25)

          {
            Console.WriteLine(name + ", your number is even and less than 25.");
            break;
          }

          else if (userInput >= 26 || userInput <= 60)

          {
            Console.WriteLine(name + ", your number is even.");
            break;
          }

          else if (userInput > 60)

          {
            Console.WriteLine(name + "," + userInput + " is an even number.");
            break;
          }
        }
        else
        {
          Console.WriteLine(name + "," + userInput + " is an odd number.");
          break;
        }

        // IsAllDigits Method
        bool IsAllDigits(string raw)
        {
          // First get rid of any benign characters at either end of string.
          // If there is nothing left, no number.
          string s = raw.Trim();
          if (s.Length == 0) return false;

          // Loop through the string.
          for (int index = 0; index < s.Length; index++)
          {
            // A nondigit indicates that the string is not a number.
            if (Char.IsDigit(s[index]) == false) return false;
          }
          // No nondigit is found; it's okay!
          return true;
        }
      }
      //Wait for user to acknowledge the results.
      Console.WriteLine("Bye!");
    }
  } 
}