//here we're going to take a simple data/progress/iteration tracking program that's extremely light weight and cause a
//stackoverflow condition by doubly placing a user argument inside of a method we created for output.


 

using System;

namespace ANoteOnParameters
{
  class Program
  {
    static void Main(string[] args)//taking one of the arguments from here in the main method we'll copy it below
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      VisitPlanets(5);//when it shows up here it overflows as there's a collision for the function call with what we can only presume is
    }                 //a doubled reference during the function call. 
  }
}
