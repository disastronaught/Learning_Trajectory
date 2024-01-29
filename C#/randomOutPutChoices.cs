//This turned out to be super convoluted once I got to translating method assignments from strings to integers
//it's based on a codecademy lesson, where there's some input? to choose a randomized selection of numbers
//which correspond to body/head/feet selections and create ascii art. I blew through this because it doesn't take user input and 
//doesn't necessarily have a use outside of being completely overhauled.
using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      RandomMode();

    }
    static string BuildACreature()
    {
      int ghostNum = TranslateToNumber("1");
      int bugNum = TranslateToNumber("2");
      int monsterNum = TranslateToNumber("3");
      
      switch (head)
      {
        case "bug":
        BugHead();
        break;
        case "monster":
        MonsterHead();
        break;
        case "ghost":
        GhostHead();
        break;
      }
      switch (body)
      {
        case "bug":
        BugBody();
        break;
        case "monster":
        MonsterBody();
        break;
        case "ghost":
        GhostBody();
        break;
      }
      switch (feet)
      {
        case "bug":
        BugFeet();
        break;
        case "monster":
        MonsterFeet();
        break;
        case "ghost":
        GhostFeet();
        break;
      }
    }
static void RandomMode()
{
  Random randomNumber = new Random();
  int head = randomNumber.Next(1, 4);
}
static void SwitchCase()
{
  switch(1)
  {
    case "1":
    GhostHead();
    GhostBody();
    GhostFeet();
    break;
    case "2":
    BugHead();
    BugBody();
    BugFeet();
    break;
    case "3":
    MonsterHead();
    MonsterBody();
    MonsterFeet();
    break;
  }
}

static int TranslateToNumber(string creature)
{
  switch (creature)
  {
    case "ghost":
      return 1;
    case "bug":
      return 2;
    case "monster":
      return 3;
  }

}
    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("   (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
