//this is an alarm system using a Raspi Pico board, to secure my woodshop. It'll be added to the
//Physical Devices repository once the soldering and case are finished.
using System;
using Ardiuno.h;
namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      int rings = 0;
      do
      {
        Console.WriteLine("BLARRRRR");
      rings++;
      if (rings == 12)
      {
        break;
      }
        
      } while(!buttonClick);
    }
  }
}
