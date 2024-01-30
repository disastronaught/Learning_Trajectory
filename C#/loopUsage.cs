//The following few programs are loop statements for use with the raspberry pi pico in C++, there's some conversion
//needed but since I'm building in C# at the moment, I'll store them here.
      /*while loop: while(){..} 
      do...while loop: do{...}while();
      for loop: for(int i=0; i<x; i++){}
      foreach loop: foreach(int item in list){}
      jump statements: break, continue, return*/

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

//The foreach loop here is used to print out tasks in a list to the terminal. I don't yet have a use for this one
//but I'm thinking of ways to use it on a pico board with one sensor and a .98" screen

//A foreach loop that iterates over websites:
using System;

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] websites = { "twitter", "facebook", "gmail" };
      
      
      foreach (string website in websites)
      { 
        Console.WriteLine(website); 
        
      }
    }
  }
}
