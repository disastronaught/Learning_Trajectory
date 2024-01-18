//The prompts for a multiband channel analyzer on Arduino Uno. This gets merged out of console with a few libraries for BLE analysis and
//MRS selection. I'll have to scrape the IR functions from other repositories and solder the diode on or use an IR hat for NFC.

using System;
#include <Arduino.h>
#include "Analyzer.h"

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("band select: ");
      string genre = Console.ReadLine();

      switch (genre)
      {
        case "01":
          Console.WriteLine("VHF");
          break;
        case "02":
          Console.WriteLine("UHV");
          break;
        case "03":
          Console.WriteLine("BLE");
          break;
        case "04":
          Console.WriteLine("IR");
          break;
      }

    }
  }
}
