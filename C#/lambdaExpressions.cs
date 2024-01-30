//This is a further implementation of expression bodied definitions, but uses a more lifelike example. 
//Between this and exprbodexamp I had a tough time understanding this '(strings) => true);' portion
//especially when it comes to implementation in another program or for using the methodology
//when using a method as a parameter, so I'll likely repeat the lesson.
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      bool makesContact = Array.Exists(spaceRocks, (string s) => true);
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
    
    static bool HitGround(string s)
    {
      return s == "meteorite";
    }
  }
}
