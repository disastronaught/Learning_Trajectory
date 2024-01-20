//there's a dev suite in Duke Nukem for DOSBOX where you can build your own levels to the game
//A lot of it is polygonal architecture and rendering, but building out the story for an entirely
//new game in C# is a good note taking format before drafting out the scene and building the gameplay
using System;

namespace GenericDevPlot
{
  class Program
  {
      static void Main(string[] args)
    {


      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
     
     Console.Write("Type YES or NO: ");
     string noiseChoice = Console.ReadLine();



     if (noiseChoice = "NO"):
     {
      Console.WriteLine("Not much of an adventure if we don't leave our room!");
      Console.WriteLine("THE END.");
    
     }
      else if (noiseChoice = YES):
     {
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
      Console.WriteLine("You walk towards it. Do you open it or knock?");
     }
     
     Console.Write("Type OPEN or Knock: ");
     string openOrKnock = Console.ReadLine();
     if (openOrKnock = Knock);
     {
      Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: ");
      Console.Write("Type your answer: ");
      string riddleAnswer = Console.ReadLine();
      Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?");
     }
     else if (openOrKnock = "OPEN");
     {
      Console.WriteLine("The door is locked! See if one of your three keys will open it.");
      Console.Write("Enter a number(1-3)");
      string keyChoice = Console.ReadLine();
     }
      switch (keyChoice)
      {
        case "1":
        Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...THE END.");
        break;
        case "2":
        Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
        break;
        case "3":
        Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
        break;
      }
     }
     Console.Write("The door opwns and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
     else:
     Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
     
    }
  }
}
