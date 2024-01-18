//not sure if this will go on the Arduino Uno first and then be modified to run on a pico with a band pass filter 
//but it definitely needs loaded into VS and debugged. 
//the purpose for customizing the channel hopping was specifically to lower the step size 
//because fengbros step is limitted to 2.5k where activity on HF channels can be seen in cubic between these ranges
using System;
using Analyzer.h;
using System.Numerics;
namespace channelHopper
{
  class Program
  {
    static void Main(string[] args)
    {
      double freq = 190.000;

      for i in {190..164} do 
      
      (i+=0.250 from freq && delay 5000);
      {
        Console.WriteLine(i);
      }
      else
      {
        Console.WriteLine("EOR");
      }
    }
  }
}
