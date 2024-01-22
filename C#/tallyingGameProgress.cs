//for level progress on DOS game devs, we're gonna build a tracker that uses planetary visitations
//I'm making optional parameters within the main method so we can tally the total points
//travelled during gameplay

using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets(numberOfPlanets:2);
      VisitPlanets(numberOfPlanets: 2, name:"Odin");
    }
    
    static void VisitPlanets(
      string adjective = "Cadet",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
      
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}
