//Here's the program I made in codecademy's C# full suite for monitoring forestry statistics using 
//new methods and public vs private allocation of their functionality
using System;

namespace BasicClasses
{
  class Forest
  {


    public int age;
    private string biome;
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
      public int Grow()
    {
      Trees += 30; 
      Age ++;
      return Trees;
    }
    public int Burn(){
      Trees -=20;
      Age ++;
      return Trees;
    }
  }

}
