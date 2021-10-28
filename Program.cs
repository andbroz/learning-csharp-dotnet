using System;
using System.Diagnostics;

namespace _02_donet_debuging
{
  class Program
  {
    static void Main(string[] args)
    {

      int firstNumber = 12;
      int secondNumber = 7;

      string name = "Bob";
      int someNumber = 7;

      int result = add(firstNumber, secondNumber);
      Console.WriteLine(result);
      Console.WriteLine(name + " sold " + (someNumber + 7) + " beers");

      Console.WriteLine("#### Mathematical Operators ####");
      mathOperators();
      castingDataType();
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
  }
}
