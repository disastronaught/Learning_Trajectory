//The following few programs are loop statements for use with the raspberry pi pico in C++, there's some conversion
//needed but since I'm building in C# at the moment, I'll store them here.
using System;

namespace CameraButton
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      do 
      {
        Console.WriteLine("image capture");
      }while (!buttonClick);
      
      Console.WriteLine("image saved");
      }
      
    }
  }

//for loop iterating a weekly schedule
using System;

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    { 
      for (int i = 1; i < 17; i++)
      {
        CreateTemplate(i);
      }

    }
    
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
    
    
  }
}
