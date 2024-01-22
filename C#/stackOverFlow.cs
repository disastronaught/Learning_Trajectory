//here we're going to take a simple data/progress/iteration tracking program that's extremely light weight and cause a
//stackoverflow condition by calling 




using System;

namespace ANoteOnParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      VisitPlanets(5);
    }
  }
}
