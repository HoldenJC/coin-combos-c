using System;
using System.Collections.Generic;

namespace Coins
{

  public class Program
  {

    public static void Main()
    {
      int quarters = 0;
      int dimes = 0;
      int nickles = 0;
      int pennies = 0;
      Console.WriteLine("Enter cents to see coin breakdown of:");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("( no decimals; for example, enter '$0.75' as 75 )");
      Console.ResetColor();
      double change = Double.Parse(Console.ReadLine());
      while(change % 1 != 0)
      {
        Console.WriteLine("Please enter a valid input (no decimals):");
        change = Double.Parse(Console.ReadLine());
      }

      while(change / 25 >= 1)
      {
        quarters++;
        change -= 25.0;
      }
      while(change / 10 >= 1)
      {
        dimes++;
        change -= 10.0;
      }
      while(change / 5 >= 1)
      {
        nickles++;
        change -= 5.0;
      }
      while(change / 1 >= 1)
      {
        pennies++;
        change -= 1.0;
      }

      Console.WriteLine("The smallest number of coins you would need to make that change is:");
      Console.WriteLine(quarters + " quarters");
      Console.WriteLine(dimes + " dimes");
      Console.WriteLine(nickles + " nickles");
      Console.WriteLine(pennies + " pennies");

    }

  }
}

//                                                     PLAIN ENGLISH SPECS
//---------------------------------------------------------------------------------------------------------------------------
//user enters in amount of change as whole number -------------> program only accepts input if input is whole number
//program checks if change is divisible by quarter ------------> increments quarters by 1, subtracts 25 from change, repeats until it fails
//program checks if change is divisible by dime ---------------> increments dime by 1, subtracts 10 from change, repeats until it fails
//program checks if change is divisible by nickle -------------> increments nickles by 1, subtracts 5 from change, repeats until it fails
//program checks if change is divisible by penny --------------> increments pennies by 1, subtracts 1 from change, repeats until it fails
//program outputs results to user