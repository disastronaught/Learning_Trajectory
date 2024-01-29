//Well isn't this just a game changer...
//This is probably to most excited I've been about coding since learning to assign outputs from DIP switches 
//on the Arduino.
//This'll come in handy on the Proxmark3 too, because it has such a small flashable memory size.
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome("Earth");
      double days = 500;
      double rotations = DaysToRotations(days);
      Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
    } 
    
    static double DaysToRotations(double days) => days/365;
    
    
    static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");

  }
}
