using System;
using System.Diagnostics;

namespace _02_donet_debuging
{
  class Program
  {
    static void Main(string[] args)
    {

      // int firstNumber = 12;
      // int secondNumber = 7;

      // string name = "Bob";
      // int someNumber = 7;

      // int result = add(firstNumber, secondNumber);
      // Console.WriteLine(result);
      // Console.WriteLine(name + " sold " + (someNumber + 7) + " beers");

      // Console.WriteLine("#### Mathematical Operators ####");
      // mathOperators();
      // castingDataType();
      // Console.WriteLine("Random number");
      // getRandomData();

      // randomGame();
      // arraysExcercise();
      // inventoryArray();
      detectFraud();

      //   Console.ReadKey(true);
    }
    static int add(int a, int b)
    {

      return a + b;

    }

    static void mathOperators()
    {

      int sum = 7 + 5;
      int difference = 7 - 5;
      int product = 7 * 5;
      int quotient = 7 / 5;
      decimal decimalQuotient = 7.0m / 5;

      Console.WriteLine("Sum:" + sum);
      Console.WriteLine("Difference:" + difference);
      Console.WriteLine("Product:" + product);
      Console.WriteLine("Quotient:" + quotient);
      Console.WriteLine("DecimalQuotient:" + decimalQuotient);
    }

    static void castingDataType()
    {
      int first = 7;
      int second = 5;
      decimal quotient = (decimal)first / (decimal)second;
      Console.WriteLine("casting data type: " + quotient);
    }

    static void getRandomData()
    {
      Random dice = new Random();

      int roll = dice.Next(100);
      Console.WriteLine(roll);
    }

    static void randomGame()
    {
      Random dice = new Random();

      int roll1 = dice.Next(1, 7);
      int roll2 = dice.Next(1, 7);
      int roll3 = dice.Next(1, 7);

      int total = roll1 + roll2 + roll3;

      Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

      if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
      {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
          Console.WriteLine("You rolled triples! +6 bonus to total!");
          total += 6;
        }
        else
        {
          Console.WriteLine("You rolled doubles! +2 bonus to total!");
          total += 2;
        }
      }




      if (total >= 16)
      {
        Console.WriteLine("You win a new car!");
      }
      else if (total >= 10)
      {
        Console.WriteLine("You win a new laptop!");
      }
      else if (total == 7)
      {
        Console.WriteLine("You win a trip for two!");
      }
      else
      {
        Console.WriteLine("You win a kitten!");
      }
    }

    static void arraysExcercise()
    {

      // define string array
      /*  string[] fraudulentOrderIds = new string[3];

       fraudulentOrderIds[0] = "A123";
       fraudulentOrderIds[1] = "B456";
       fraudulentOrderIds[2] = "C789";
       // fraudulentOrderIds[3] = "D101"; index out of range error */

      // declare and initialize variable with string array
      string[] fraudulentOrderIds = { "A123", "B456", "C789" };

      Console.WriteLine($"First: {fraudulentOrderIds[0]}");
      Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
      Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

      fraudulentOrderIds[0] = "F500";

      Console.WriteLine($"Reassign first: {fraudulentOrderIds[0]}");

      // getting size of array ->using  .Length property
      Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");


      string[] names = { "Bob", "Konrad", "Greg" };

      // looping trought array
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }

    }

    static void inventoryArray()
    {
      int[] inventory = { 200, 450, 700, 175, 250 };
      int sum = 0;
      int bin = 0;

      foreach (int items in inventory)
      {
        sum += items;
        bin++;
        Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
      }

      Console.WriteLine($"We have {sum} items in the inventory");

    }
    static void detectFraud()
    {
      string[] fraudID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

      foreach (string item in fraudID)
      {
        if (item.StartsWith('B'))
        {
          Console.WriteLine(item);
        }
      }
    }
  }

}
