//this is a standard divisory program, I might use it on test runs for 16x2 screens and an arduino to adjust aspect ratios.

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("Enter an amount you'd like to convert: ");
      double amount = Convert.ToDouble(Console.ReadLine());

      int gold = 10;
      int silver = 5;
      int copper = 1;

      double goldCalc = Math.Floor(amount/gold);
      double silverCalc = Math.Floor(goldCalc/silver);
      double copperCalc = Math.Floor(silverCalc/copper);
      
      Console.WriteLine($"{amount} is equal to {goldCalc}, {silverCalc}, {copperCalc}");
    }
  }
}
